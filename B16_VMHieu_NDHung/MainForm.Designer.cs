﻿namespace B16_VMHieu_NDHung
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelThreads = new System.Windows.Forms.LinkLabel();
            this.linkLabelBackgroundWorker = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(136, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÀI TẬP LỚN LÝ THUYẾT HỆ ĐIỀU HÀNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(230, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 82);
            this.label2.TabIndex = 1;
            this.label2.Text = "Multithread";
            // 
            // linkLabelThreads
            // 
            this.linkLabelThreads.AutoSize = true;
            this.linkLabelThreads.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelThreads.Location = new System.Drawing.Point(88, 501);
            this.linkLabelThreads.Name = "linkLabelThreads";
            this.linkLabelThreads.Size = new System.Drawing.Size(594, 33);
            this.linkLabelThreads.TabIndex = 2;
            this.linkLabelThreads.TabStop = true;
            this.linkLabelThreads.Text = "version 2: Counting Matrix Rows ( use Multithread )";
            this.linkLabelThreads.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelThreads_LinkClicked);
            // 
            // linkLabelBackgroundWorker
            // 
            this.linkLabelBackgroundWorker.AutoSize = true;
            this.linkLabelBackgroundWorker.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBackgroundWorker.Location = new System.Drawing.Point(88, 468);
            this.linkLabelBackgroundWorker.Name = "linkLabelBackgroundWorker";
            this.linkLabelBackgroundWorker.Size = new System.Drawing.Size(675, 33);
            this.linkLabelBackgroundWorker.TabIndex = 3;
            this.linkLabelBackgroundWorker.TabStop = true;
            this.linkLabelBackgroundWorker.Text = "version 1: Counting Matrix Rows ( use BackgroundWorker )";
            this.linkLabelBackgroundWorker.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBackgroundWorker_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(246, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vũ Minh Hiếu ( CNTT16A )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(225, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nguyễn Đức Hưng ( CNTT16B )";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(339, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thực hiện";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(829, 567);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabelBackgroundWorker);
            this.Controls.Add(this.linkLabelThreads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelThreads;
        private System.Windows.Forms.LinkLabel linkLabelBackgroundWorker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}