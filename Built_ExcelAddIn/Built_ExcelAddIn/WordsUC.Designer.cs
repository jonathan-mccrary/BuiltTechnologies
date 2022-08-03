namespace Built_ExcelAddIn
{
    partial class WordsUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.rbDefinitions = new System.Windows.Forms.RadioButton();
            this.rbSynonyms = new System.Windows.Forms.RadioButton();
            this.rbExamples = new System.Windows.Forms.RadioButton();
            this.rbRhymes = new System.Windows.Forms.RadioButton();
            this.rbAntonyms = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(22, 44);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(127, 20);
            this.txtWord.TabIndex = 0;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(22, 25);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(33, 13);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "Word";
            // 
            // rbDefinitions
            // 
            this.rbDefinitions.AutoSize = true;
            this.rbDefinitions.Checked = true;
            this.rbDefinitions.Location = new System.Drawing.Point(22, 71);
            this.rbDefinitions.Name = "rbDefinitions";
            this.rbDefinitions.Size = new System.Drawing.Size(74, 17);
            this.rbDefinitions.TabIndex = 2;
            this.rbDefinitions.TabStop = true;
            this.rbDefinitions.Text = "Definitions";
            this.rbDefinitions.UseVisualStyleBackColor = true;
            // 
            // rbSynonyms
            // 
            this.rbSynonyms.AutoSize = true;
            this.rbSynonyms.Location = new System.Drawing.Point(22, 94);
            this.rbSynonyms.Name = "rbSynonyms";
            this.rbSynonyms.Size = new System.Drawing.Size(73, 17);
            this.rbSynonyms.TabIndex = 3;
            this.rbSynonyms.TabStop = true;
            this.rbSynonyms.Text = "Synonyms";
            this.rbSynonyms.UseVisualStyleBackColor = true;
            // 
            // rbExamples
            // 
            this.rbExamples.AutoSize = true;
            this.rbExamples.Location = new System.Drawing.Point(22, 117);
            this.rbExamples.Name = "rbExamples";
            this.rbExamples.Size = new System.Drawing.Size(70, 17);
            this.rbExamples.TabIndex = 4;
            this.rbExamples.TabStop = true;
            this.rbExamples.Text = "Examples";
            this.rbExamples.UseVisualStyleBackColor = true;
            // 
            // rbRhymes
            // 
            this.rbRhymes.AutoSize = true;
            this.rbRhymes.Location = new System.Drawing.Point(22, 140);
            this.rbRhymes.Name = "rbRhymes";
            this.rbRhymes.Size = new System.Drawing.Size(63, 17);
            this.rbRhymes.TabIndex = 5;
            this.rbRhymes.TabStop = true;
            this.rbRhymes.Text = "Rhymes";
            this.rbRhymes.UseVisualStyleBackColor = true;
            // 
            // rbAntonyms
            // 
            this.rbAntonyms.AutoSize = true;
            this.rbAntonyms.Location = new System.Drawing.Point(22, 164);
            this.rbAntonyms.Name = "rbAntonyms";
            this.rbAntonyms.Size = new System.Drawing.Size(71, 17);
            this.rbAntonyms.TabIndex = 6;
            this.rbAntonyms.TabStop = true;
            this.rbAntonyms.Text = "Antonyms";
            this.rbAntonyms.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Navy;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(22, 188);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(22, 227);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(42, 13);
            this.lblResults.TabIndex = 8;
            this.lblResults.Text = "Results";
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.HorizontalScrollbar = true;
            this.lbResults.Location = new System.Drawing.Point(22, 243);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(127, 264);
            this.lbResults.TabIndex = 9;
            this.lbResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbResults_KeyDown);
            // 
            // WordsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rbAntonyms);
            this.Controls.Add(this.rbRhymes);
            this.Controls.Add(this.rbExamples);
            this.Controls.Add(this.rbSynonyms);
            this.Controls.Add(this.rbDefinitions);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.txtWord);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "WordsUC";
            this.Size = new System.Drawing.Size(172, 527);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.RadioButton rbDefinitions;
        private System.Windows.Forms.RadioButton rbSynonyms;
        private System.Windows.Forms.RadioButton rbExamples;
        private System.Windows.Forms.RadioButton rbRhymes;
        private System.Windows.Forms.RadioButton rbAntonyms;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ListBox lbResults;
    }
}
