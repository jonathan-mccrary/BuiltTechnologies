using Excel = Microsoft.Office.Interop.Excel;

namespace Built_ExcelAddIn
{
    public partial class ThisAddIn
    {
        private WordsUC wordsUc;
        private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;
        private int lastEditedRow = 0;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            wordsUc = new WordsUC();
            myCustomTaskPane = this.CustomTaskPanes.Add(wordsUc, "Words Search");
            myCustomTaskPane.Visible = true;
            this.Application.WorkbookBeforeSave += new Excel.AppEvents_WorkbookBeforeSaveEventHandler(Application_WorkbookBeforeSave);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void Application_WorkbookBeforeSave(Excel.Workbook Wb,
            bool SaveAsUI,
            ref bool Cancel)
        {
            int index = 1;
            Excel.Worksheet activeWorksheet = ((Excel.Worksheet)Application.ActiveSheet);
            Excel.Range firstRow = activeWorksheet.get_Range($"A{index}");
            if (string.IsNullOrWhiteSpace((string)firstRow.Value2))
            {
                firstRow.Value2 = "Test";
            }

            index++;
            //clear previous results
            for (int i = index; i <= lastEditedRow; i++)
            {
                var nextRow = activeWorksheet.get_Range($"A{i}");
                nextRow.Value2 = string.Empty;
            }

            var synonymns = WordsUDF.GetWordSynonymsUDF((string)firstRow.Value2)?.Split(',') ?? new string[0];
            for (int i = 0; i < synonymns.Length; i++)
            {
                var nextRow = activeWorksheet.get_Range($"A{i + index}");
                nextRow.Value2 = synonymns[i];
                lastEditedRow = i + index;
            }
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion VSTO generated code
    }
}