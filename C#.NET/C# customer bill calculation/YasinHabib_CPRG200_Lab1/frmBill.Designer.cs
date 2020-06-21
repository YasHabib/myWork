namespace YasinHabib_CPRG200_Lab1
{
    partial class frmBill
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.radIndust = new System.Windows.Forms.RadioButton();
            this.radComm = new System.Windows.Forms.RadioButton();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsage = new System.Windows.Forms.Label();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.lblOffPeak = new System.Windows.Forms.Label();
            this.txtOffPeak = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.grpCalculation = new System.Windows.Forms.GroupBox();
            this.grpCustomer.SuspendLayout();
            this.grpCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(209, 204);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(336, 204);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(486, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radIndust
            // 
            this.radIndust.AutoSize = true;
            this.radIndust.Location = new System.Drawing.Point(6, 106);
            this.radIndust.Name = "radIndust";
            this.radIndust.Size = new System.Drawing.Size(67, 17);
            this.radIndust.TabIndex = 2;
            this.radIndust.TabStop = true;
            this.radIndust.Text = "Industrial";
            this.radIndust.UseVisualStyleBackColor = true;
            this.radIndust.CheckedChanged += new System.EventHandler(this.radIndust_CheckedChanged);
            // 
            // radComm
            // 
            this.radComm.AutoSize = true;
            this.radComm.Location = new System.Drawing.Point(6, 68);
            this.radComm.Name = "radComm";
            this.radComm.Size = new System.Drawing.Size(79, 17);
            this.radComm.TabIndex = 1;
            this.radComm.TabStop = true;
            this.radComm.Text = "Commercial";
            this.radComm.UseVisualStyleBackColor = true;
            this.radComm.CheckedChanged += new System.EventHandler(this.radComm_CheckedChanged);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Checked = true;
            this.radResidential.Location = new System.Drawing.Point(7, 30);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(77, 17);
            this.radResidential.TabIndex = 0;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(140, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 13);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "This program will calculate the total electricity usage";
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.Location = new System.Drawing.Point(21, 30);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(136, 13);
            this.lblUsage.TabIndex = 0;
            this.lblUsage.Text = "Total electricity used (kWh)";
            // 
            // txtUsage
            // 
            this.txtUsage.BackColor = System.Drawing.Color.White;
            this.txtUsage.Location = new System.Drawing.Point(163, 30);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(100, 20);
            this.txtUsage.TabIndex = 1;
            // 
            // lblOffPeak
            // 
            this.lblOffPeak.AutoSize = true;
            this.lblOffPeak.Location = new System.Drawing.Point(21, 68);
            this.lblOffPeak.Name = "lblOffPeak";
            this.lblOffPeak.Size = new System.Drawing.Size(112, 13);
            this.lblOffPeak.TabIndex = 2;
            this.lblOffPeak.Text = "Off peak usage (kWh)";
            this.lblOffPeak.Visible = false;
            // 
            // txtOffPeak
            // 
            this.txtOffPeak.Location = new System.Drawing.Point(163, 68);
            this.txtOffPeak.Name = "txtOffPeak";
            this.txtOffPeak.Size = new System.Drawing.Size(100, 20);
            this.txtOffPeak.TabIndex = 3;
            this.txtOffPeak.Visible = false;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(21, 106);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(68, 13);
            this.lblTotalCost.TabIndex = 4;
            this.lblTotalCost.Text = "Total Charge";
            this.lblTotalCost.Visible = false;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Enabled = false;
            this.txtTotalCost.Location = new System.Drawing.Point(163, 106);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCost.TabIndex = 5;
            this.txtTotalCost.Visible = false;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.radIndust);
            this.grpCustomer.Controls.Add(this.radComm);
            this.grpCustomer.Controls.Add(this.radResidential);
            this.grpCustomer.Location = new System.Drawing.Point(31, 43);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(140, 155);
            this.grpCustomer.TabIndex = 3;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Type";
            // 
            // grpCalculation
            // 
            this.grpCalculation.Controls.Add(this.txtTotalCost);
            this.grpCalculation.Controls.Add(this.lblTotalCost);
            this.grpCalculation.Controls.Add(this.txtOffPeak);
            this.grpCalculation.Controls.Add(this.lblOffPeak);
            this.grpCalculation.Controls.Add(this.txtUsage);
            this.grpCalculation.Controls.Add(this.lblUsage);
            this.grpCalculation.Location = new System.Drawing.Point(209, 43);
            this.grpCalculation.Name = "grpCalculation";
            this.grpCalculation.Size = new System.Drawing.Size(352, 155);
            this.grpCalculation.TabIndex = 4;
            this.grpCalculation.TabStop = false;
            this.grpCalculation.Text = "Input";
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(590, 254);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpCalculation);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalc);
            this.Name = "frmBill";
            this.Text = "Bill Calculation";
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpCalculation.ResumeLayout(false);
            this.grpCalculation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radIndust;
        private System.Windows.Forms.RadioButton radComm;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.Label lblOffPeak;
        private System.Windows.Forms.TextBox txtOffPeak;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.GroupBox grpCalculation;
    }
}

