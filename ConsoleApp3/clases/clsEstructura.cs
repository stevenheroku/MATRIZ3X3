using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace ConsoleApp3.clases
{
    class clsEstructura
    {
        public int matric1 { get; set; }
        public int matric2 { get; set; }
        public int matric3 { get; set; }

        public List<clsEstructura> cargaDatosXLS()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            int rCnt;
            int rw = 0;
            int cl = 0;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\Jefferson Rueda\Desktop\5TO SEMESTRE\PROGRAMACION 3\matriz1.xlsx");
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;

            List<clsEstructura> todos = new List<clsEstructura>();
            clsEstructura individual = new clsEstructura();

            for (rCnt = 1; rCnt <= rw; rCnt++)
            {

                individual.matric1 = (int)(range.Cells[rCnt, 1] as Excel.Range).Value2;
                individual.matric2 = (int)(range.Cells[rCnt, 2] as Excel.Range).Value2;
                individual.matric3 = (int)(range.Cells[rCnt, 3] as Excel.Range).Value2;



                todos.Add(individual);
                individual = new clsEstructura();
                
            }
            
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            return todos;

        }
        



    }



}