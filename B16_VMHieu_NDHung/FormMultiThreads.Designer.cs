namespace B16_VMHieu_NDHung
{
    partial class FormMultiThreads
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxFileName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.textBoxMatrix = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewCounting = new System.Windows.Forms.ListView();
            this.columnRow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnThread = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxFileName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.buttonReadFile);
            this.panel1.Location = new System.Drawing.Point(16, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 62);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxFileName
            // 
            this.comboBoxFileName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFileName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFileName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFileName.ForeColor = System.Drawing.Color.Firebrick;
            this.comboBoxFileName.FormattingEnabled = true;
            this.comboBoxFileName.Items.AddRange(new object[] {
            "data.txt",
            "data2.txt",
            "data3.txt",
            "data4.txt"});
            this.comboBoxFileName.Location = new System.Drawing.Point(135, 13);
            this.comboBoxFileName.Name = "comboBoxFileName";
            this.comboBoxFileName.Size = new System.Drawing.Size(359, 32);
            this.comboBoxFileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 999;
            this.label1.Text = "File name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LightBlue;
            this.buttonStart.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(662, 13);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(133, 32);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.BackColor = System.Drawing.Color.LightBlue;
            this.buttonReadFile.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadFile.Location = new System.Drawing.Point(514, 13);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(133, 32);
            this.buttonReadFile.TabIndex = 2;
            this.buttonReadFile.Text = "Read file";
            this.buttonReadFile.UseVisualStyleBackColor = false;
            this.buttonReadFile.Click += new System.EventHandler(this.button_ReadFile_Click);
            // 
            // textBoxMatrix
            // 
            this.textBoxMatrix.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMatrix.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatrix.Location = new System.Drawing.Point(16, 38);
            this.textBoxMatrix.Multiline = true;
            this.textBoxMatrix.Name = "textBoxMatrix";
            this.textBoxMatrix.ReadOnly = true;
            this.textBoxMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMatrix.Size = new System.Drawing.Size(478, 458);
            this.textBoxMatrix.TabIndex = 999;
            this.textBoxMatrix.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewCounting);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonReset);
            this.panel2.Controls.Add(this.textBoxTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxMatrix);
            this.panel2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(16, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 517);
            this.panel2.TabIndex = 4;
            // 
            // listViewCounting
            // 
            this.listViewCounting.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnRow,
            this.columnSum,
            this.columnThread,
            this.columnStatus});
            this.listViewCounting.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCounting.FullRowSelect = true;
            this.listViewCounting.GridLines = true;
            this.listViewCounting.Location = new System.Drawing.Point(514, 38);
            this.listViewCounting.Name = "listViewCounting";
            this.listViewCounting.Size = new System.Drawing.Size(281, 414);
            this.listViewCounting.TabIndex = 999;
            this.listViewCounting.UseCompatibleStateImageBehavior = false;
            this.listViewCounting.View = System.Windows.Forms.View.Details;
            // 
            // columnRow
            // 
            this.columnRow.Text = "Row";
            this.columnRow.Width = 66;
            // 
            // columnSum
            // 
            this.columnSum.Text = "Sum";
            this.columnSum.Width = 70;
            // 
            // columnThread
            // 
            this.columnThread.Text = "Thread";
            this.columnThread.Width = 70;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            this.columnStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnStatus.Width = 68;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 32);
            this.label4.TabIndex = 999;
            this.label4.Text = "Total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.LightBlue;
            this.buttonReset.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(662, 464);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(133, 33);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.Firebrick;
            this.textBoxTotal.Location = new System.Drawing.Point(576, 464);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(80, 32);
            this.textBoxTotal.TabIndex = 8;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(510, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Counting matrix rows";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matrix read from file";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMultiThreads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMultiThreads";
            this.Text = "version 2: Counting Matrix Rows ( use Multithread )";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMatrix;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewCounting;
        private System.Windows.Forms.ColumnHeader columnRow;
        private System.Windows.Forms.ColumnHeader columnSum;
        private System.Windows.Forms.ColumnHeader columnThread;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.ComboBox comboBoxFileName;
    }
}