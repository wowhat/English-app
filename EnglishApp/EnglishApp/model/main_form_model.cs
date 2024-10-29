using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OfficeOpenXml;
using EnglishApp.view;
using OfficeOpenXml.ConditionalFormatting.Contracts;
using EnglishApp.view;

namespace EnglishApp.model
{
    class main_form_model
    {

        static Random random = new Random();
        int random_numb;
        public void reading_words()
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new System.IO.FileInfo(all_values.File_path)))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                ExcelWorkbook workbook = excelPackage.Workbook;
                ExcelWorksheet worksheet = workbook.Worksheets[all_values.choosed_list];

                for (int i = 1; i <= worksheet.Dimension.Rows; i++)
                {
                    KeyValuePair<string, string> pair = new KeyValuePair<string, string>(Convert.ToString(worksheet.Cells[i, 1].Value), Convert.ToString(worksheet.Cells[i, 2].Value));
                    all_values.all_words.Add(pair);
                }

            }
        }

        public void check_if_english()
        {

            random_numb = random.Next(all_values.all_words.Count);
            if (all_values.all_words.Count > 0)
            {
                all_values.the_word = all_values.all_words[random_numb];

                if (all_values.isEnglish)
                {
                    all_values.label_word = all_values.the_word.Key;
                    all_values.input_word = all_values.the_word.Value;
                }
                else
                {
                    all_values.label_word = all_values.the_word.Value;
                    all_values.input_word = all_values.the_word.Key;
                }
            } else { all_values.label_word = "the end"; }
        }
        public void btn_next()
        {
            all_values.all_words.RemoveAt(random_numb);

            check_if_english();
        }

    }
}
