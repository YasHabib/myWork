namespace YasinHabib_CPRG200_lab2
{
    partial class frmCustomerData
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
            this.lstCustData = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomerCount = new System.Windows.Forms.TextBox();
            this.txtI = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtTotCharge = new System.Windows.Forms.TextBox();
            this.grpCustData = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChargeAmount = new System.Windows.Forms.TextBox();
            this.txtTotKW = new System.Windows.Forms.TextBox();
            this.lblKWused = new System.Windows.Forms.Label();
            this.txtOffPeak = new System.Windows.Forms.TextBox();
            this.lblOffpeak = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpCustData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCustData
            // 
            this.lstCustData.FormattingEnabled = true;
            this.lstCustData.Location = new System.Drawing.Point(310, 42);
            this.lstCustData.Name = "lstCustData";
            this.lstCustData.Size = new System.Drawing.Size(210, 290);
            this.lstCustData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Type";
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new System.Drawing.Point(134, 27);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(100, 20);
            this.txtAccNo.TabIndex = 4;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(134, 64);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(100, 20);
            this.txtCustName.TabIndex = 5;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "",
            "R",
            "C",
            "I"});
            this.cboType.Location = new System.Drawing.Point(134, 93);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(100, 21);
            this.cboType.TabIndex = 6;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total customers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total charge per type of customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "R";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "I";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(560, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(560, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total overall charge";
            // 
            // txtCustomerCount
            // 
            this.txtCustomerCount.Enabled = false;
            this.txtCustomerCount.Location = new System.Drawing.Point(581, 70);
            this.txtCustomerCount.Name = "txtCustomerCount";
            this.txtCustomerCount.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerCount.TabIndex = 13;
            // 
            // txtI
            // 
            this.txtI.Enabled = false;
            this.txtI.Location = new System.Drawing.Point(581, 202);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(100, 20);
            this.txtI.TabIndex = 14;
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Location = new System.Drawing.Point(581, 179);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 15;
            // 
            // txtR
            // 
            this.txtR.Enabled = false;
            this.txtR.Location = new System.Drawing.Point(581, 153);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 16;
            // 
            // txtTotCharge
            // 
            this.txtTotCharge.Enabled = false;
            this.txtTotCharge.Location = new System.Drawing.Point(581, 268);
            this.txtTotCharge.Name = "txtTotCharge";
            this.txtTotCharge.Size = new System.Drawing.Size(100, 20);
            this.txtTotCharge.TabIndex = 17;
            // 
            // grpCustData
            // 
            this.grpCustData.Controls.Add(this.label10);
            this.grpCustData.Controls.Add(this.txtChargeAmount);
            this.grpCustData.Controls.Add(this.txtAccNo);
            this.grpCustData.Controls.Add(this.txtCustName);
            this.grpCustData.Controls.Add(this.cboType);
            this.grpCustData.Controls.Add(this.label1);
            this.grpCustData.Controls.Add(this.label2);
            this.grpCustData.Controls.Add(this.label3);
            this.grpCustData.Location = new System.Drawing.Point(24, 43);
            this.grpCustData.Name = "grpCustData";
            this.grpCustData.Size = new System.Drawing.Size(252, 156);
            this.grpCustData.TabIndex = 18;
            this.grpCustData.TabStop = false;
            this.grpCustData.Text = "Customer Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Charge Amount";
            // 
            // txtChargeAmount
            // 
            this.txtChargeAmount.Enabled = false;
            this.txtChargeAmount.Location = new System.Drawing.Point(134, 129);
            this.txtChargeAmount.Name = "txtChargeAmount";
            this.txtChargeAmount.Size = new System.Drawing.Size(100, 20);
            this.txtChargeAmount.TabIndex = 7;
            // 
            // txtTotKW
            // 
            this.txtTotKW.Location = new System.Drawing.Point(158, 205);
            this.txtTotKW.Name = "txtTotKW";
            this.txtTotKW.Size = new System.Drawing.Size(100, 20);
            this.txtTotKW.TabIndex = 19;
            this.txtTotKW.Visible = false;
            // 
            // lblKWused
            // 
            this.lblKWused.AutoSize = true;
            this.lblKWused.Location = new System.Drawing.Point(28, 209);
            this.lblKWused.Name = "lblKWused";
            this.lblKWused.Size = new System.Drawing.Size(84, 13);
            this.lblKWused.TabIndex = 20;
            this.lblKWused.Text = "Total KW usage";
            this.lblKWused.Visible = false;
            // 
            // txtOffPeak
            // 
            this.txtOffPeak.Location = new System.Drawing.Point(156, 240);
            this.txtOffPeak.Name = "txtOffPeak";
            this.txtOffPeak.Size = new System.Drawing.Size(100, 20);
            this.txtOffPeak.TabIndex = 21;
            this.txtOffPeak.Visible = false;
            this.txtOffPeak.WordWrap = false;
            // 
            // lblOffpeak
            // 
            this.lblOffpeak.AutoSize = true;
            this.lblOffpeak.Location = new System.Drawing.Point(21, 240);
            this.lblOffpeak.Name = "lblOffpeak";
            this.lblOffpeak.Size = new System.Drawing.Size(129, 13);
            this.lblOffpeak.TabIndex = 22;
            this.lblOffpeak.Text = "Total off peak KW usage ";
            this.lblOffpeak.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(24, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(105, 309);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(187, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(156, 267);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 23);
            this.btnCalculate.TabIndex = 25;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Visible = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmCustomerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 355);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblOffpeak);
            this.Controls.Add(this.txtOffPeak);
            this.Controls.Add(this.lblKWused);
            this.Controls.Add(this.txtTotKW);
            this.Controls.Add(this.grpCustData);
            this.Controls.Add(this.txtTotCharge);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtI);
            this.Controls.Add(this.txtCustomerCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstCustData);
            this.Name = "frmCustomerData";
            this.Text = "Customer data";
            this.Load += new System.EventHandler(this.frmCustomerData_Load);
            this.grpCustData.ResumeLayout(false);
            this.grpCustData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustomerCount;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtTotCharge;
        private System.Windows.Forms.GroupBox grpCustData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChargeAmount;
        private System.Windows.Forms.TextBox txtTotKW;
        private System.Windows.Forms.Label lblKWused;
        private System.Windows.Forms.TextBox txtOffPeak;
        private System.Windows.Forms.Label lblOffpeak;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
    }
}

