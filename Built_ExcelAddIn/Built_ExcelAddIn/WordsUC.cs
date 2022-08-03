using System;
using System.Linq;
using System.Windows.Forms;

namespace Built_ExcelAddIn
{
    public partial class WordsUC : UserControl
    {
        public WordsUC()
        {
            InitializeComponent();
            lbResults.Text = string.Empty;
            lbResults.Items.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbResults.Items.Clear();
            object[] results;
            if (rbDefinitions.Checked)
            {
                lbResults.Items.Add("*Definitions*");
                results = WordsUDF.GetWordDefinitions(txtWord.Text)?.Split('|') ?? new string[0];
            }
            else if (rbSynonyms.Checked)
            {
                lbResults.Items.Add("*Synonymns*");
                results = WordsUDF.GetWordSynonyms(txtWord.Text)?.Split('|') ?? new string[0];
            }
            else if (rbExamples.Checked)
            {
                lbResults.Items.Add("*Examples*");
                results = WordsUDF.GetWordExamples(txtWord.Text)?.Split('|') ?? new string[0];
            }
            else if (rbRhymes.Checked)
            {
                lbResults.Items.Add("*Rhymes*");
                results = WordsUDF.GetWordRhymes(txtWord.Text)?.Split('|') ?? new string[0];
            }
            else if (rbAntonyms.Checked)
            {
                lbResults.Items.Add("*Antonyms*");
                results = WordsUDF.GetWordAntonyms(txtWord.Text)?.Split('|') ?? new string[0];
            }
            else
            {
                results = new object[0];
            }

            if (results.Length == 0 
                || (results.Length == 1 && (string)results[0] == string.Empty))
            {
                results = new string[] { "--none found" };
            }
            lbResults.Items.AddRange(results);
        }

        private void lbResults_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                string s = lbResults.SelectedItem.ToString();
                Clipboard.SetData(DataFormats.StringFormat, s);
            }
        }
    }
}