using ExcelDna.Integration;
using ExcelDna.Integration.CustomUI;
using Microsoft.Office.Interop.Excel;
using System;
using System.Runtime.InteropServices;

namespace Built_ExcelAddIn
{
    [ComVisible(true)]
    public class RibbonController : ExcelRibbon, IDisposable
    {
        private Microsoft.Office.Core.IRibbonUI _ribbonUi;

        private Application App
        {
            get => (Application)ExcelDnaUtil.Application;
        }

        public override string GetCustomUI(string ribbonID) =>
            @"<customUI xmlns='http://schemas.microsoft.com/office/2009/07/customui'>
          <ribbon>
             <tabs>
              <tab id='sample_tab' label='GoTask'>
                <group id='sample_group' label='Operations'>
                  <button id='do_reverse_range' label='Reverse' size='large' getImage='OnDoReverseGetImage' onAction='OnDoReverse'/>
                </group>
              </tab>
            </tabs>
          </ribbon>
        </customUI>";

        public void OnLoad(Microsoft.Office.Core.IRibbonUI ribbonUI)
        {
            _ribbonUi = ribbonUI;
        }

        public void Dispose()
        {
        }
    }
}