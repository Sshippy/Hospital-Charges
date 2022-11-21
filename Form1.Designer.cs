namespace ExtraDiscussion4
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.lblSurgury = new System.Windows.Forms.Label();
            this.lblLab = new System.Windows.Forms.Label();
            this.lblRehab = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.txtSurgury = new System.Windows.Forms.TextBox();
            this.txtLab = new System.Windows.Forms.TextBox();
            this.txtRehab = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(46, 409);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(168, 81);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(59, 33);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(155, 25);
            this.lblDays.TabIndex = 1;
            this.lblDays.Text = "Days in hospital:";
            this.lblDays.Click += new System.EventHandler(this.lblDays_Click);
            // 
            // txtDays
            // 
            this.txtDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.Location = new System.Drawing.Point(257, 28);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(180, 30);
            this.txtDays.TabIndex = 2;
            this.txtDays.TextChanged += new System.EventHandler(this.txtDays_TextChanged);
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicine.Location = new System.Drawing.Point(59, 93);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(152, 25);
            this.lblMedicine.TabIndex = 1;
            this.lblMedicine.Text = "Medication Fee:";
            this.lblMedicine.Click += new System.EventHandler(this.lblMedicine_Click);
            // 
            // lblSurgury
            // 
            this.lblSurgury.AutoSize = true;
            this.lblSurgury.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurgury.Location = new System.Drawing.Point(59, 151);
            this.lblSurgury.Name = "lblSurgury";
            this.lblSurgury.Size = new System.Drawing.Size(128, 25);
            this.lblSurgury.TabIndex = 1;
            this.lblSurgury.Text = "Surgical Fee:";
            this.lblSurgury.Click += new System.EventHandler(this.lblSurgury_Click);
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLab.Location = new System.Drawing.Point(59, 202);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(90, 25);
            this.lblLab.TabIndex = 1;
            this.lblLab.Text = "Lab Fee:";
            this.lblLab.Click += new System.EventHandler(this.lblLab_Click);
            // 
            // lblRehab
            // 
            this.lblRehab.AutoSize = true;
            this.lblRehab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRehab.Location = new System.Drawing.Point(49, 261);
            this.lblRehab.Name = "lblRehab";
            this.lblRehab.Size = new System.Drawing.Size(192, 25);
            this.lblRehab.TabIndex = 1;
            this.lblRehab.Text = "Physical Rehab Fee:";
            this.lblRehab.Click += new System.EventHandler(this.lblRehab_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(49, 335);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(142, 25);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total Charges:";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // txtMedicine
            // 
            this.txtMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicine.Location = new System.Drawing.Point(257, 90);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(180, 30);
            this.txtMedicine.TabIndex = 2;
            this.txtMedicine.TextChanged += new System.EventHandler(this.txtMedicine_TextChanged);
            // 
            // txtSurgury
            // 
            this.txtSurgury.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurgury.Location = new System.Drawing.Point(257, 146);
            this.txtSurgury.Name = "txtSurgury";
            this.txtSurgury.Size = new System.Drawing.Size(180, 30);
            this.txtSurgury.TabIndex = 2;
            this.txtSurgury.TextChanged += new System.EventHandler(this.txtSurgury_TextChanged);
            // 
            // txtLab
            // 
            this.txtLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLab.Location = new System.Drawing.Point(257, 199);
            this.txtLab.Name = "txtLab";
            this.txtLab.Size = new System.Drawing.Size(180, 30);
            this.txtLab.TabIndex = 2;
            this.txtLab.TextChanged += new System.EventHandler(this.txtLab_TextChanged);
            // 
            // txtRehab
            // 
            this.txtRehab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRehab.Location = new System.Drawing.Point(257, 261);
            this.txtRehab.Name = "txtRehab";
            this.txtRehab.Size = new System.Drawing.Size(180, 30);
            this.txtRehab.TabIndex = 2;
            this.txtRehab.TextChanged += new System.EventHandler(this.txtRehab_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(257, 330);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(180, 30);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(269, 409);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(168, 81);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(470, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 81);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(697, 550);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtRehab);
            this.Controls.Add(this.txtLab);
            this.Controls.Add(this.txtSurgury);
            this.Controls.Add(this.txtMedicine);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRehab);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.lblSurgury);
            this.Controls.Add(this.lblMedicine);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Hospital Charges";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.Label lblSurgury;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Label lblRehab;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.TextBox txtSurgury;
        private System.Windows.Forms.TextBox txtLab;
        private System.Windows.Forms.TextBox txtRehab;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}
