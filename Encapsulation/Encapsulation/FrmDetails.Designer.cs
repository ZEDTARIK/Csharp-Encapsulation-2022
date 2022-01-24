namespace Encapsulation
{
    partial class FrmDetails
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
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeAge = new System.Windows.Forms.Label();
            this.lblEmployeePostion = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeName.Location = new System.Drawing.Point(26, 36);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(178, 31);
            this.lblEmployeeName.TabIndex = 12;
            this.lblEmployeeName.Text = "EmployeeName";
            // 
            // lblEmployeeAge
            // 
            this.lblEmployeeAge.AutoSize = true;
            this.lblEmployeeAge.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEmployeeAge.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeAge.Location = new System.Drawing.Point(26, 85);
            this.lblEmployeeAge.Name = "lblEmployeeAge";
            this.lblEmployeeAge.Size = new System.Drawing.Size(163, 31);
            this.lblEmployeeAge.TabIndex = 11;
            this.lblEmployeeAge.Text = "Employee Age";
            // 
            // lblEmployeePostion
            // 
            this.lblEmployeePostion.AutoSize = true;
            this.lblEmployeePostion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEmployeePostion.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeePostion.Location = new System.Drawing.Point(26, 135);
            this.lblEmployeePostion.Name = "lblEmployeePostion";
            this.lblEmployeePostion.Size = new System.Drawing.Size(205, 31);
            this.lblEmployeePostion.TabIndex = 10;
            this.lblEmployeePostion.Text = "Employee Position";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(60, 213);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(229, 33);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 258);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblEmployeeAge);
            this.Controls.Add(this.lblEmployeePostion);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmDetails";
            this.Text = "FrmDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label lblEmployeeName;
        public Label lblEmployeeAge;
        public Label lblEmployeePostion;
        private Button btnClose;
    }
}