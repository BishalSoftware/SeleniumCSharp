using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using ExcelDataReader;


namespace SeleniumCSharp
{
    public class ExcelLib
    {

        // This is older version because it uses new ExcelDataReader v3.6.0 which doesn't have older Excel v1.0.0 
        // so Excel v1.0.0 is separately downloaded in NuGet Packages. However, ICSharpCode.SharpZipLib does not load though with Excel v1.0.0

        /*
        private static DataTable ExcelToDataTable(string fileName)
        {

            //open file and returns as Stream
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);

            //CreateOpenXmlReader via ExcelReaderFactory to read .xlsx excel file
            Excel.IExcelDataReader excelReader = Excel.ExcelReaderFactory.CreateOpenXmlReader(stream); //.xlsx

            //Set the First Row as Column Name
            excelReader.IsFirstRowAsColumnNames = true;

            //Return as DataSet
            DataSet result = excelReader.AsDataSet();

            //Get all the Tables
            DataTableCollection table = result.Tables;

            //Store it in DataTable
            DataTable resultTable = table["Sheet1"];

            //return
            return resultTable;
        }
        */

        
        public static DataTable ExcelToDataTable(string fileName)
        {
            using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()  //Return as DataSet //DataSet result = excelReader.AsDataSet();
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()   //Set the First Row as Column Name //excelReader.IsFirstRowAsColumnNames = true;
                        {
                            UseHeaderRow = true
                        }
                    });

                    //Get all the Tables
                    DataTableCollection table = result.Tables;

                    //Store it in DataTable
                    DataTable resultTable = table["Sheet1"];

                    //return
                    return resultTable;
                }
            }
        }
        

        //Storing Data in C# Collections

        public class Datacollection
        {
            public int rowNumber { get; set; }
            public string colName { get; set; }
            public string colValue { get; set; }
        }


        public static List<Datacollection> dataCol = new List<Datacollection>();

        public static void PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);

            //iterate through the rows and columns of the Table

            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    dataCol.Add(dtTable);
                }
            }
        }

     

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in dataCol
                               where colData.rowNumber == rowNumber && colData.colName == columnName
                               select colData.colValue).SingleOrDefault();

                //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
