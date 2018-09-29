namespace BankCodeFirst.Forms
{
    partial class TekrarForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDateCredit = new System.Windows.Forms.DateTimePicker();
            this.TxbAmount = new System.Windows.Forms.TextBox();
            this.TxbPassportNumber = new System.Windows.Forms.TextBox();
            this.Btn_Go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "PassportNumber";
            // 
            // dateTimePickerDateCredit
            // 
            this.dateTimePickerDateCredit.Location = new System.Drawing.Point(137, 224);
            this.dateTimePickerDateCredit.Name = "dateTimePickerDateCredit";
            this.dateTimePickerDateCredit.Size = new System.Drawing.Size(149, 22);
            this.dateTimePickerDateCredit.TabIndex = 11;
            // 
            // TxbAmount
            // 
            this.TxbAmount.Location = new System.Drawing.Point(131, 148);
            this.TxbAmount.Name = "TxbAmount";
            this.TxbAmount.Size = new System.Drawing.Size(149, 22);
            this.TxbAmount.TabIndex = 10;
            // 
            // TxbPassportNumber
            // 
            this.TxbPassportNumber.Location = new System.Drawing.Point(131, 80);
            this.TxbPassportNumber.Name = "TxbPassportNumber";
            this.TxbPassportNumber.Size = new System.Drawing.Size(149, 22);
            this.TxbPassportNumber.TabIndex = 9;
            // 
            // Btn_Go
            // 
            this.Btn_Go.Location = new System.Drawing.Point(131, 279);
            this.Btn_Go.Name = "Btn_Go";
            this.Btn_Go.Size = new System.Drawing.Size(75, 23);
            this.Btn_Go.TabIndex = 8;
            this.Btn_Go.Text = "Go";
            this.Btn_Go.UseVisualStyleBackColor = true;
            this.Btn_Go.Click += new System.EventHandler(this.Btn_Go_Click);
            // 
            // TekrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDateCredit);
            this.Controls.Add(this.TxbAmount);
            this.Controls.Add(this.TxbPassportNumber);
            this.Controls.Add(this.Btn_Go);
            this.Name = "TekrarForm";
            this.Text = "TekrarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateCredit;
        private System.Windows.Forms.TextBox TxbAmount;
        private System.Windows.Forms.TextBox TxbPassportNumber;
        private System.Windows.Forms.Button Btn_Go;
    }
}