namespace B16_VMHieu_NDHung
{
    partial class FormBackroundWorker
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
            this.button_Start = new System.Windows.Forms.Button();
            this.button_ReadFile = new System.Windows.Forms.Button();
            this.textBox_Matrix = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPause = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnRow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnThread = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Restart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerTotal = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxFileName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_Start);
            this.panel1.Controls.Add(this.button_ReadFile);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 60);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxFileName
            // 
            this.comboBoxFileName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFileName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFileName.FormattingEnabled = true;
            this.comboBoxFileName.Items.AddRange(new object[] {
            "data3.txt",
            "data4.txt",
            "data2.txt"});
            this.comboBoxFileName.Location = new System.Drawing.Point(118, 17);
            this.comboBoxFileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxFileName.Name = "comboBoxFileName";
            this.comboBoxFileName.Size = new System.Drawing.Size(377, 28);
            this.comboBoxFileName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "File name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.LightBlue;
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.Location = new System.Drawing.Point(662, 14);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(133, 33);
            this.button_Start.TabIndex = 3;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_ReadFile
            // 
            this.button_ReadFile.BackColor = System.Drawing.Color.LightBlue;
            this.button_ReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ReadFile.Location = new System.Drawing.Point(514, 14);
            this.button_ReadFile.Name = "button_ReadFile";
            this.button_ReadFile.Size = new System.Drawing.Size(133, 33);
            this.button_ReadFile.TabIndex = 2;
            this.button_ReadFile.Text = "Read file";
            this.button_ReadFile.UseVisualStyleBackColor = false;
            this.button_ReadFile.Click += new System.EventHandler(this.button_ReadFile_Click);
            // 
            // textBox_Matrix
            // 
            this.textBox_Matrix.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Matrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Matrix.Location = new System.Drawing.Point(16, 39);
            this.textBox_Matrix.Multiline = true;
            this.textBox_Matrix.Name = "textBox_Matrix";
            this.textBox_Matrix.ReadOnly = true;
            this.textBox_Matrix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_Matrix.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Matrix.Size = new System.Drawing.Size(478, 395);
            this.textBox_Matrix.TabIndex = 3;
            this.textBox_Matrix.WordWrap = false;
            this.textBox_Matrix.TextChanged += new System.EventHandler(this.textBox_Matrix_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonPause);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.button_Restart);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_Matrix);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 489);
            this.panel2.TabIndex = 4;
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.LightBlue;
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPause.Location = new System.Drawing.Point(662, 440);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(133, 33);
            this.buttonPause.TabIndex = 14;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(169, 448);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(325, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnRow,
            this.columnSum,
            this.columnThread});
            this.listView1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(514, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(281, 395);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnRow
            // 
            this.columnRow.Text = "Row";
            this.columnRow.Width = 78;
            // 
            // columnSum
            // 
            this.columnSum.Text = "Sum";
            this.columnSum.Width = 93;
            // 
            // columnThread
            // 
            this.columnThread.Text = "Thread";
            this.columnThread.Width = 95;
            // 
            // button_Restart
            // 
            this.button_Restart.BackColor = System.Drawing.Color.LightBlue;
            this.button_Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Restart.Location = new System.Drawing.Point(16, 438);
            this.button_Restart.Name = "button_Restart";
            this.button_Restart.Size = new System.Drawing.Size(133, 33);
            this.button_Restart.TabIndex = 11;
            this.button_Restart.Text = "Restart";
            this.button_Restart.UseVisualStyleBackColor = false;
            this.button_Restart.Click += new System.EventHandler(this.button_Restart_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total rows";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.Firebrick;
            this.textBoxTotal.Location = new System.Drawing.Point(575, 444);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(80, 27);
            this.textBoxTotal.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(510, 4);
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
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matrix read from file";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // backgroundWorkerTotal
            // 
            this.backgroundWorkerTotal.WorkerReportsProgress = true;
            this.backgroundWorkerTotal.WorkerSupportsCancellation = true;
            this.backgroundWorkerTotal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTotal_DoWork);
            this.backgroundWorkerTotal.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerTotal_ProgressChanged);
            // 
            // FormBackroundWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 567);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormBackroundWorker";
            this.Text = "version 1: Counting Matrix Rows ( use BackgroundWorker )";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_ReadFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Matrix;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button button_Restart;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnRow;
        private System.Windows.Forms.ColumnHeader columnSum;
        private System.Windows.Forms.ColumnHeader columnThread;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTotal;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBoxFileName;
    }
}