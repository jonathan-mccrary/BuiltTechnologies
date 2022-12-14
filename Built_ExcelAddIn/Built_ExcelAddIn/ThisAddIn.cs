using Excel = Microsoft.Office.Interop.Excel;

namespace Built_ExcelAddIn
{
    public partial class ThisAddIn
    {
        private WordsUC wordsUc;
        private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;
        private int synonymsLastEditedRow = 0;
        private int definitionsLastEditedRow = 0;

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
            Excel.Range a1 = activeWorksheet.get_Range($"A{index}");
            if (string.IsNullOrWhiteSpace((string)a1.Value2))
            {
                a1.Value2 = "Test";
            }
            index++;

            PopulateSynonyms(activeWorksheet, (string)a1.Value2, index);
            PopulateDefinitions(activeWorksheet, (string)a1.Value2, index);
        }

        private void PopulateSynonyms(Excel.Worksheet activeWorksheet, string word, int index)
        {
            //clear previous results
            for (int i = index; i <= synonymsLastEditedRow; i++)
            {
                var nextRow = activeWorksheet.get_Range($"A{i}");
                nextRow.Value2 = string.Empty;
            }

            var synonymns = WordsUDF.GetWordSynonyms(word)?.Split('|') ?? new string[0];
            for (int i = 0; i < synonymns.Length; i++)
            {
                var nextRow = activeWorksheet.get_Range($"A{i + index}");
                nextRow.Value2 = synonymns[i];
                synonymsLastEditedRow = i + index;
            }
        }

        private void PopulateDefinitions(Excel.Worksheet activeWorksheet, string word, int index)
        {
            //clear previous results
            for (int i = index; i <= definitionsLastEditedRow; i++)
            {
                var nextRow = activeWorksheet.get_Range($"B{i}");
                nextRow.Value2 = string.Empty;
            }

            var synonymns = WordsUDF.GetWordDefinitions(word)?.Split('|') ?? new string[0];
            for (int i = 0; i < synonymns.Length; i++)
            {
                var nextRow = activeWorksheet.get_Range($"B{i + index}");
                nextRow.Value2 = synonymns[i];
                definitionsLastEditedRow = i + index;
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