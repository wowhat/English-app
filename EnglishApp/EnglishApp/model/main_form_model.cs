using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OfficeOpenXml;

namespace EnglishApp.model
{
    class main_form_model
    {
        Random random = new Random();
        public void reading_words()
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new System.IO.FileInfo(all_values.File_path)))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                ExcelWorkbook workbook = excelPackage.Workbook;
                ExcelWorksheet worksheet = workbook.Worksheets[all_values.choosed_list];

                for (int i = 0; i < worksheet.Dimension.Rows; i++)
                {
                    KeyValuePair<string, string> pair = new KeyValuePair<string, string>(Convert.ToString(worksheet.Cells[i, 1]), Convert.ToString(worksheet.Cells[i, 2]));
                    all_values.all_words.Add(pair);
                }

            }
        }

        public void check_if_english(bool isEnglish)
        {
            if (isEnglish)
            {
                all_values.label_word = all_values.the_word.Key;
            }
            else
            {
                all_values.label_word = all_values.the_word.Value;
            }
        }

        public void btn_next()
        {
            int rand_numb =  random.Next(all_values.all_words.Count);

            all_values.input_word = all_values.the_word.Value;
        }
        
    }
}
