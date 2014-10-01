namespace Comparison_Program
{
    partial class Form1
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
            this.dataFile1 = new System.Windows.Forms.DataGridView();
            this.dataFile2 = new System.Windows.Forms.DataGridView();
            this.btnRow1 = new System.Windows.Forms.Button();
            this.btnColumn1 = new System.Windows.Forms.Button();
            this.numRow1 = new System.Windows.Forms.NumericUpDown();
            this.numColumn1 = new System.Windows.Forms.NumericUpDown();
            this.numColumn2 = new System.Windows.Forms.NumericUpDown();
            this.numRow2 = new System.Windows.Forms.NumericUpDown();
            this.btnColumn2 = new System.Windows.Forms.Button();
            this.btnRow2 = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFile2 = new System.Windows.Forms.Button();
            this.txtFile2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFile1 = new System.Windows.Forms.Button();
            this.txtFile1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rtb2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataFile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRow2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataFile1
            // 
            this.dataFile1.AllowUserToAddRows = false;
            this.dataFile1.AllowUserToDeleteRows = false;
            this.dataFile1.AllowUserToOrderColumns = true;
            this.dataFile1.AllowUserToResizeColumns = false;
            this.dataFile1.AllowUserToResizeRows = false;
            this.dataFile1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFile1.Location = new System.Drawing.Point(12, 221);
            this.dataFile1.Name = "dataFile1";
            this.dataFile1.ReadOnly = true;
            this.dataFile1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataFile1.RowTemplate.Height = 21;
            this.dataFile1.Size = new System.Drawing.Size(321, 225);
            this.dataFile1.TabIndex = 0;
            // 
            // dataFile2
            // 
            this.dataFile2.AllowUserToAddRows = false;
            this.dataFile2.AllowUserToDeleteRows = false;
            this.dataFile2.AllowUserToOrderColumns = true;
            this.dataFile2.AllowUserToResizeColumns = false;
            this.dataFile2.AllowUserToResizeRows = false;
            this.dataFile2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFile2.Location = new System.Drawing.Point(405, 221);
            this.dataFile2.Name = "dataFile2";
            this.dataFile2.ReadOnly = true;
            this.dataFile2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataFile2.RowTemplate.Height = 21;
            this.dataFile2.Size = new System.Drawing.Size(315, 225);
            this.dataFile2.TabIndex = 1;
            // 
            // btnRow1
            // 
            this.btnRow1.Location = new System.Drawing.Point(244, 163);
            this.btnRow1.Name = "btnRow1";
            this.btnRow1.Size = new System.Drawing.Size(90, 23);
            this.btnRow1.TabIndex = 2;
            this.btnRow1.Text = "Skip Row";
            this.btnRow1.UseVisualStyleBackColor = true;
            this.btnRow1.Click += new System.EventHandler(this.btnRow1_Click);
            // 
            // btnColumn1
            // 
            this.btnColumn1.Location = new System.Drawing.Point(244, 192);
            this.btnColumn1.Name = "btnColumn1";
            this.btnColumn1.Size = new System.Drawing.Size(90, 23);
            this.btnColumn1.TabIndex = 3;
            this.btnColumn1.Text = "Skip Column";
            this.btnColumn1.UseVisualStyleBackColor = true;
            this.btnColumn1.Click += new System.EventHandler(this.btnColumn1_Click);
            // 
            // numRow1
            // 
            this.numRow1.Location = new System.Drawing.Point(202, 167);
            this.numRow1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRow1.Name = "numRow1";
            this.numRow1.ReadOnly = true;
            this.numRow1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numRow1.Size = new System.Drawing.Size(36, 19);
            this.numRow1.TabIndex = 6;
            this.numRow1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numRow1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numColumn1
            // 
            this.numColumn1.Location = new System.Drawing.Point(202, 192);
            this.numColumn1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColumn1.Name = "numColumn1";
            this.numColumn1.ReadOnly = true;
            this.numColumn1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numColumn1.Size = new System.Drawing.Size(36, 19);
            this.numColumn1.TabIndex = 7;
            this.numColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numColumn1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numColumn2
            // 
            this.numColumn2.Location = new System.Drawing.Point(587, 192);
            this.numColumn2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColumn2.Name = "numColumn2";
            this.numColumn2.ReadOnly = true;
            this.numColumn2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numColumn2.Size = new System.Drawing.Size(36, 19);
            this.numColumn2.TabIndex = 11;
            this.numColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numColumn2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numRow2
            // 
            this.numRow2.Location = new System.Drawing.Point(587, 167);
            this.numRow2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRow2.Name = "numRow2";
            this.numRow2.ReadOnly = true;
            this.numRow2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numRow2.Size = new System.Drawing.Size(36, 19);
            this.numRow2.TabIndex = 10;
            this.numRow2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numRow2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnColumn2
            // 
            this.btnColumn2.Location = new System.Drawing.Point(629, 192);
            this.btnColumn2.Name = "btnColumn2";
            this.btnColumn2.Size = new System.Drawing.Size(90, 23);
            this.btnColumn2.TabIndex = 9;
            this.btnColumn2.Text = "Skip Column";
            this.btnColumn2.UseVisualStyleBackColor = true;
            this.btnColumn2.Click += new System.EventHandler(this.btnColumn2_Click);
            // 
            // btnRow2
            // 
            this.btnRow2.Location = new System.Drawing.Point(629, 163);
            this.btnRow2.Name = "btnRow2";
            this.btnRow2.Size = new System.Drawing.Size(90, 23);
            this.btnRow2.TabIndex = 8;
            this.btnRow2.Text = "Skip Row";
            this.btnRow2.UseVisualStyleBackColor = true;
            this.btnRow2.Click += new System.EventHandler(this.btnRow2_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(329, 452);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 12;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Result:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(371, 514);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 33);
            this.lblResult.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "File Comparison Program";
            // 
            // btnFile2
            // 
            this.btnFile2.Location = new System.Drawing.Point(551, 102);
            this.btnFile2.Name = "btnFile2";
            this.btnFile2.Size = new System.Drawing.Size(75, 23);
            this.btnFile2.TabIndex = 26;
            this.btnFile2.Text = "Choose File";
            this.btnFile2.UseVisualStyleBackColor = true;
            this.btnFile2.Click += new System.EventHandler(this.btnFile2_Click);
            // 
            // txtFile2
            // 
            this.txtFile2.BackColor = System.Drawing.Color.White;
            this.txtFile2.Location = new System.Drawing.Point(173, 106);
            this.txtFile2.Name = "txtFile2";
            this.txtFile2.ReadOnly = true;
            this.txtFile2.Size = new System.Drawing.Size(363, 19);
            this.txtFile2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "File 2:";
            // 
            // btnFile1
            // 
            this.btnFile1.Location = new System.Drawing.Point(551, 76);
            this.btnFile1.Name = "btnFile1";
            this.btnFile1.Size = new System.Drawing.Size(75, 23);
            this.btnFile1.TabIndex = 21;
            this.btnFile1.Text = "Choose File";
            this.btnFile1.UseVisualStyleBackColor = true;
            this.btnFile1.Click += new System.EventHandler(this.btnFile1_Click);
            // 
            // txtFile1
            // 
            this.txtFile1.BackColor = System.Drawing.Color.White;
            this.txtFile1.Location = new System.Drawing.Point(173, 80);
            this.txtFile1.Name = "txtFile1";
            this.txtFile1.ReadOnly = true;
            this.txtFile1.Size = new System.Drawing.Size(363, 19);
            this.txtFile1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "File 1:";
            // 
            // rtb1
            // 
            this.rtb1.Location = new System.Drawing.Point(12, 476);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(136, 33);
            this.rtb1.TabIndex = 27;
            this.rtb1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "Removed Column or Row";
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(12, 513);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(70, 22);
            this.btnSave1.TabIndex = 29;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(650, 513);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(70, 22);
            this.btnSave2.TabIndex = 32;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "Removed Column or Row";
            // 
            // rtb2
            // 
            this.rtb2.Location = new System.Drawing.Point(584, 476);
            this.rtb2.Name = "rtb2";
            this.rtb2.Size = new System.Drawing.Size(136, 33);
            this.rtb2.TabIndex = 30;
            this.rtb2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 549);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtb2);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.btnFile2);
            this.Controls.Add(this.txtFile2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFile1);
            this.Controls.Add(this.txtFile1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.numColumn2);
            this.Controls.Add(this.numRow2);
            this.Controls.Add(this.btnColumn2);
            this.Controls.Add(this.btnRow2);
            this.Controls.Add(this.numColumn1);
            this.Controls.Add(this.numRow1);
            this.Controls.Add(this.btnColumn1);
            this.Controls.Add(this.btnRow1);
            this.Controls.Add(this.dataFile2);
            this.Controls.Add(this.dataFile1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Comparison Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRow2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataFile1;
        private System.Windows.Forms.DataGridView dataFile2;
        private System.Windows.Forms.Button btnRow1;
        private System.Windows.Forms.Button btnColumn1;
        private System.Windows.Forms.NumericUpDown numRow1;
        private System.Windows.Forms.NumericUpDown numColumn1;
        private System.Windows.Forms.NumericUpDown numColumn2;
        private System.Windows.Forms.NumericUpDown numRow2;
        private System.Windows.Forms.Button btnColumn2;
        private System.Windows.Forms.Button btnRow2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFile2;
        private System.Windows.Forms.TextBox txtFile2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFile1;
        private System.Windows.Forms.TextBox txtFile1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtb2;
    }
}

