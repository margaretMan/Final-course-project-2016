﻿namespace DoctorsHandBook.View
{
    partial class DiseaseOptionAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rTBoxDiseaseSympt = new System.Windows.Forms.RichTextBox();
            this.tBoxDiseaseTitle = new System.Windows.Forms.TextBox();
            this.rTBoxDiseaseProced = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMedCancel = new System.Windows.Forms.Button();
            this.btnMedSave = new System.Windows.Forms.Button();
            this.tBoxDiseaseMeds = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lBoxDiseaseMed = new System.Windows.Forms.ListBox();
            this.btnPlusMed = new System.Windows.Forms.Button();
            this.btnMinusMed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Symptoms";
            // 
            // rTBoxDiseaseSympt
            // 
            this.rTBoxDiseaseSympt.Location = new System.Drawing.Point(136, 57);
            this.rTBoxDiseaseSympt.Name = "rTBoxDiseaseSympt";
            this.rTBoxDiseaseSympt.Size = new System.Drawing.Size(296, 64);
            this.rTBoxDiseaseSympt.TabIndex = 31;
            this.rTBoxDiseaseSympt.Text = "";
            // 
            // tBoxDiseaseTitle
            // 
            this.tBoxDiseaseTitle.Location = new System.Drawing.Point(136, 29);
            this.tBoxDiseaseTitle.Name = "tBoxDiseaseTitle";
            this.tBoxDiseaseTitle.Size = new System.Drawing.Size(296, 22);
            this.tBoxDiseaseTitle.TabIndex = 29;
            // 
            // rTBoxDiseaseProced
            // 
            this.rTBoxDiseaseProced.Location = new System.Drawing.Point(136, 127);
            this.rTBoxDiseaseProced.Name = "rTBoxDiseaseProced";
            this.rTBoxDiseaseProced.Size = new System.Drawing.Size(296, 64);
            this.rTBoxDiseaseProced.TabIndex = 33;
            this.rTBoxDiseaseProced.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Procedures";
            // 
            // btnMedCancel
            // 
            this.btnMedCancel.Location = new System.Drawing.Point(15, 451);
            this.btnMedCancel.Name = "btnMedCancel";
            this.btnMedCancel.Size = new System.Drawing.Size(97, 39);
            this.btnMedCancel.TabIndex = 39;
            this.btnMedCancel.Text = "Cancel";
            this.btnMedCancel.UseVisualStyleBackColor = true;
            this.btnMedCancel.Click += new System.EventHandler(this.btnMedCancel_Click);
            // 
            // btnMedSave
            // 
            this.btnMedSave.Location = new System.Drawing.Point(420, 451);
            this.btnMedSave.Name = "btnMedSave";
            this.btnMedSave.Size = new System.Drawing.Size(97, 39);
            this.btnMedSave.TabIndex = 38;
            this.btnMedSave.Text = "Save";
            this.btnMedSave.UseVisualStyleBackColor = true;
            this.btnMedSave.Click += new System.EventHandler(this.btnMedSave_Click);
            // 
            // tBoxDiseaseMeds
            // 
            this.tBoxDiseaseMeds.Location = new System.Drawing.Point(136, 201);
            this.tBoxDiseaseMeds.Name = "tBoxDiseaseMeds";
            this.tBoxDiseaseMeds.Size = new System.Drawing.Size(207, 22);
            this.tBoxDiseaseMeds.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Medications:";
            // 
            // lBoxDiseaseMed
            // 
            this.lBoxDiseaseMed.FormattingEnabled = true;
            this.lBoxDiseaseMed.ItemHeight = 16;
            this.lBoxDiseaseMed.Location = new System.Drawing.Point(136, 233);
            this.lBoxDiseaseMed.Name = "lBoxDiseaseMed";
            this.lBoxDiseaseMed.Size = new System.Drawing.Size(294, 180);
            this.lBoxDiseaseMed.TabIndex = 42;
            // 
            // btnPlusMed
            // 
            this.btnPlusMed.Location = new System.Drawing.Point(366, 197);
            this.btnPlusMed.Name = "btnPlusMed";
            this.btnPlusMed.Size = new System.Drawing.Size(30, 30);
            this.btnPlusMed.TabIndex = 43;
            this.btnPlusMed.Text = "+";
            this.btnPlusMed.UseVisualStyleBackColor = true;
            this.btnPlusMed.Click += new System.EventHandler(this.btnPlusMed_Click);
            // 
            // btnMinusMed
            // 
            this.btnMinusMed.Location = new System.Drawing.Point(402, 197);
            this.btnMinusMed.Name = "btnMinusMed";
            this.btnMinusMed.Size = new System.Drawing.Size(30, 30);
            this.btnMinusMed.TabIndex = 44;
            this.btnMinusMed.Text = "-";
            this.btnMinusMed.UseVisualStyleBackColor = true;
            this.btnMinusMed.Click += new System.EventHandler(this.btnMinusMed_Click);
            // 
            // DiseaseOptionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 502);
            this.Controls.Add(this.btnMinusMed);
            this.Controls.Add(this.btnPlusMed);
            this.Controls.Add(this.lBoxDiseaseMed);
            this.Controls.Add(this.tBoxDiseaseMeds);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMedCancel);
            this.Controls.Add(this.btnMedSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rTBoxDiseaseSympt);
            this.Controls.Add(this.tBoxDiseaseTitle);
            this.Controls.Add(this.rTBoxDiseaseProced);
            this.Controls.Add(this.label2);
            this.Name = "DiseaseOptionAdd";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Disease_OptionAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rTBoxDiseaseSympt;
        private System.Windows.Forms.TextBox tBoxDiseaseTitle;
        private System.Windows.Forms.RichTextBox rTBoxDiseaseProced;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMedCancel;
        private System.Windows.Forms.Button btnMedSave;
        private System.Windows.Forms.TextBox tBoxDiseaseMeds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lBoxDiseaseMed;
        private System.Windows.Forms.Button btnPlusMed;
        private System.Windows.Forms.Button btnMinusMed;
    }
}