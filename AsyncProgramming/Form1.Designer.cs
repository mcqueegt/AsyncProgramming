namespace AsyncProgramming
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            txtFile1 = new TextBox();
            label1 = new Label();
            browse1 = new Button();
            lstReport1 = new ListBox();
            Submit = new Button();
            Close = new Button();
            txtFile2 = new TextBox();
            label2 = new Label();
            browse2 = new Button();
            lstReport2 = new ListBox();
            openFileDialog2 = new OpenFileDialog();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFile1
            // 
            txtFile1.Location = new Point(93, 39);
            txtFile1.Name = "txtFile1";
            txtFile1.Size = new Size(238, 27);
            txtFile1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 42);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 1;
            label1.Text = "File";
            // 
            // browse1
            // 
            browse1.Location = new Point(298, 82);
            browse1.Name = "browse1";
            browse1.Size = new Size(94, 29);
            browse1.TabIndex = 2;
            browse1.Text = "Browse";
            browse1.UseVisualStyleBackColor = true;
            browse1.Click += browse1_Click;
            // 
            // lstReport1
            // 
            lstReport1.FormattingEnabled = true;
            lstReport1.Location = new Point(12, 126);
            lstReport1.Name = "lstReport1";
            lstReport1.Size = new Size(363, 244);
            lstReport1.TabIndex = 3;
            // 
            // Submit
            // 
            Submit.Location = new Point(298, 388);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 4;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Close
            // 
            Close.Location = new Point(442, 388);
            Close.Name = "Close";
            Close.Size = new Size(94, 29);
            Close.TabIndex = 5;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // txtFile2
            // 
            txtFile2.Location = new Point(420, 39);
            txtFile2.Name = "txtFile2";
            txtFile2.Size = new Size(259, 27);
            txtFile2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 45);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 7;
            label2.Text = "File";
            // 
            // browse2
            // 
            browse2.Location = new Point(672, 89);
            browse2.Name = "browse2";
            browse2.Size = new Size(94, 29);
            browse2.TabIndex = 8;
            browse2.Text = "Browse";
            browse2.UseVisualStyleBackColor = true;
            browse2.Click += browse2_Click;
            // 
            // lstReport2
            // 
            lstReport2.FormattingEnabled = true;
            lstReport2.Location = new Point(415, 129);
            lstReport2.Name = "lstReport2";
            lstReport2.Size = new Size(329, 244);
            lstReport2.TabIndex = 9;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstReport2);
            Controls.Add(browse2);
            Controls.Add(label2);
            Controls.Add(txtFile2);
            Controls.Add(Close);
            Controls.Add(Submit);
            Controls.Add(lstReport1);
            Controls.Add(browse1);
            Controls.Add(label1);
            Controls.Add(txtFile1);
            Name = "Form1";
            Text = "Gavin McQueen Word Sort";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox txtFile1;
        private Label label1;
        private Button browse1;
        private ListBox lstReport1;
        private Button Submit;
        private Button Close;
        private TextBox txtFile2;
        private Label label2;
        private Button browse2;
        private ListBox lstReport2;
        private OpenFileDialog openFileDialog2;
    }
}
