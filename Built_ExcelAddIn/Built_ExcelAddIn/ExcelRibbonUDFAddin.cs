using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Built_ExcelAddIn
{
    public class ExcelRibbonUDFAddin : IExcelAddIn
    {
        public void AutoOpen()
        {
            // startup code
        }

        public void AutoClose()
        {
            // clean up
        }
    }
}
