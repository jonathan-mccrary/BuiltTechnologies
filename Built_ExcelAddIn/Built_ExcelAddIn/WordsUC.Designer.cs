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
            this.rbAntonymns = new System.Windows.Forms.RadioButton();
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
            this.lblWord.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbDefinitions
            // 
            this.rbDefinitions.AutoSize = true;
            this.rbDefinitions.Location = new System.Drawing.Point(22, 71);
            this.rbDefinitions.Name = "rbDefinitions";
            this.rbDefinitions.Size = new System.Drawing.Size(74, 17);
            this.rbDefinitions.TabIndex = 2;
            this.rbDefinitions.TabStop = true;
            this.rbDefinitions.Text = "Definitions";
            this.rbDefinitions.UseVisualStyleBackColor = true;
            this.rbDefinitions.CheckedChanged += new System.EventHandler(this.rbDefinitions_CheckedChanged);
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
            this.rbSynonyms.CheckedChanged += new System.EventHandler(this.rbSynonyms_CheckedChanged);
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
            this.rbExamples.CheckedChanged += new System.EventHandler(this.rbExamples_CheckedChanged);
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
            this.rbRhymes.CheckedChanged += new System.EventHandler(this.rbRhymes_CheckedChanged);
            // 
            // rbAntonymns
            // 
            this.rbAntonymns.AutoSize = true;
            this.rbAntonymns.Location = new System.Drawing.Point(22, 164);
            this.rbAntonymns.Name = "rbAntonymns";
            this.rbAntonymns.Size = new System.Drawing.Size(77, 17);
            this.rbAntonymns.TabIndex = 6;
            this.rbAntonymns.TabStop = true;
            this.rbAntonymns.Text = "Antonymns";
            this.rbAntonymns.UseVisualStyleBackColor = true;
            this.rbAntonymns.CheckedChanged += new System.EventHandler(this.rbAntonymns_CheckedChanged);
            // 
            // WordsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbAntonymns);
            this.Controls.Add(this.rbRhymes);
            this.Controls.Add(this.rbExamples);
            this.Controls.Add(this.rbSynonyms);
            this.Controls.Add(this.rbDefinitions);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.txtWord);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "WordsUC";
            this.Size = new System.Drawing.Size(647, 404);
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
        private System.Windows.Forms.RadioButton rbAntonymns;
    }
}
