namespace RaviTestApplication
{
    partial class PaymentDetail
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbSummary = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpPostingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpClearedDate = new System.Windows.Forms.DateTimePicker();
            this.chkIsCleared = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Is Cleared";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Posting Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cleared Date";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.cmbType.Location = new System.Drawing.Point(157, 78);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 28);
            this.cmbType.TabIndex = 6;
            this.cmbType.Text = "-Select-";
            // 
            // cmbSummary
            // 
            this.cmbSummary.FormattingEnabled = true;
            this.cmbSummary.Items.AddRange(new object[] {
            "Payment",
            "Refund"});
            this.cmbSummary.Location = new System.Drawing.Point(157, 121);
            this.cmbSummary.Name = "cmbSummary";
            this.cmbSummary.Size = new System.Drawing.Size(200, 28);
            this.cmbSummary.TabIndex = 7;
            this.cmbSummary.Text = "-Select-";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(157, 169);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 26);
            this.txtAmount.TabIndex = 8;
            // 
            // dtpPostingDate
            // 
            this.dtpPostingDate.Location = new System.Drawing.Point(157, 220);
            this.dtpPostingDate.Name = "dtpPostingDate";
            this.dtpPostingDate.Size = new System.Drawing.Size(200, 26);
            this.dtpPostingDate.TabIndex = 9;
            // 
            // dtpClearedDate
            // 
            this.dtpClearedDate.Location = new System.Drawing.Point(157, 326);
            this.dtpClearedDate.Name = "dtpClearedDate";
            this.dtpClearedDate.Size = new System.Drawing.Size(200, 26);
            this.dtpClearedDate.TabIndex = 10;
            // 
            // chkIsCleared
            // 
            this.chkIsCleared.AutoSize = true;
            this.chkIsCleared.Location = new System.Drawing.Point(157, 267);
            this.chkIsCleared.Name = "chkIsCleared";
            this.chkIsCleared.Size = new System.Drawing.Size(22, 21);
            this.chkIsCleared.TabIndex = 11;
            this.chkIsCleared.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(201, 388);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(110, 31);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // PaymentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 467);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkIsCleared);
            this.Controls.Add(this.dtpClearedDate);
            this.Controls.Add(this.dtpPostingDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cmbSummary);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PaymentDetail";
            this.Text = "PaymentDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbSummary;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpPostingDate;
        private System.Windows.Forms.DateTimePicker dtpClearedDate;
        private System.Windows.Forms.CheckBox chkIsCleared;
        private System.Windows.Forms.Button btnSubmit;
    }
}