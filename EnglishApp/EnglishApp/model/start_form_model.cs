using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.ConditionalFormatting.Contracts;
using EnglishApp.view;
namespace EnglishApp.model
{
    class start_form_model
    {
        public void set_file_path(string file_path)
        {
            all_values.File_path = file_path;
        }

        public void Reading_names()
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new System.IO.FileInfo(all_values.File_path)))
            {
               
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                ExcelWorkbook workbook = excelPackage.Workbook;

                foreach (var worksheet in workbook.Worksheets)
                {
                    all_values.sheet_names.Add(worksheet.Name);
                }
                
            }
        }
    }
}
