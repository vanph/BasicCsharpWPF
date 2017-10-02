namespace MyCountry.App.View
{
    partial class DistrictDetailForm
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
            this.txtDistrictType = new System.Windows.Forms.TextBox();
            this.txtDistrictName = new System.Windows.Forms.TextBox();
            this.txtDistictCode = new System.Windows.Forms.TextBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblDistrictType = new System.Windows.Forms.Label();
            this.lblDistrictName = new System.Windows.Forms.Label();
            this.lblDistrictCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDistrictType);
            this.panel1.Controls.Add(this.txtDistrictName);
            this.panel1.Controls.Add(this.txtDistictCode);
            this.panel1.Controls.Add(this.cmbCity);
            this.panel1.Controls.Add(this.lblDistrictType);
            this.panel1.Controls.Add(this.lblDistrictName);
            this.panel1.Controls.Add(this.lblDistrictCode);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 265);
            this.panel1.TabIndex = 0;
            // 
            // txtDistrictType
            // 
            this.txtDistrictType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDistrictType.Location = new System.Drawing.Point(152, 167);
            this.txtDistrictType.Name = "txtDistrictType";
            this.txtDistrictType.Size = new System.Drawing.Size(168, 22);
            this.txtDistrictType.TabIndex = 7;
            // 
            // txtDistrictName
            // 
            this.txtDistrictName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDistrictName.Location = new System.Drawing.Point(152, 132);
            this.txtDistrictName.Name = "txtDistrictName";
            this.txtDistrictName.Size = new System.Drawing.Size(168, 22);
            this.txtDistrictName.TabIndex = 6;
            // 
            // txtDistictCode
            // 
            this.txtDistictCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDistictCode.Location = new System.Drawing.Point(152, 97);
            this.txtDistictCode.Name = "txtDistictCode";
            this.txtDistictCode.Size = new System.Drawing.Size(168, 22);
            this.txtDistictCode.TabIndex = 5;
            // 
            // cmbCity
            // 
            this.cmbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(152, 60);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(168, 24);
            this.cmbCity.TabIndex = 4;
            // 
            // lblDistrictType
            // 
            this.lblDistrictType.AutoSize = true;
            this.lblDistrictType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDistrictType.Location = new System.Drawing.Point(23, 173);
            this.lblDistrictType.Name = "lblDistrictType";
            this.lblDistrictType.Size = new System.Drawing.Size(83, 16);
            this.lblDistrictType.TabIndex = 3;
            this.lblDistrictType.Text = "District Type";
            // 
            // lblDistrictName
            // 
            this.lblDistrictName.AutoSize = true;
            this.lblDistrictName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDistrictName.Location = new System.Drawing.Point(23, 138);
            this.lblDistrictName.Name = "lblDistrictName";
            this.lblDistrictName.Size = new System.Drawing.Size(88, 16);
            this.lblDistrictName.TabIndex = 2;
            this.lblDistrictName.Text = "District Name";
            // 
            // lblDistrictCode
            // 
            this.lblDistrictCode.AutoSize = true;
            this.lblDistrictCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDistrictCode.Location = new System.Drawing.Point(23, 103);
            this.lblDistrictCode.Name = "lblDistrictCode";
            this.lblDistrictCode.Size = new System.Drawing.Size(84, 16);
            this.lblDistrictCode.TabIndex = 1;
            this.lblDistrictCode.Text = "District Code";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.Location = new System.Drawing.Point(23, 68);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 16);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(201, 34);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(71, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 24);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DistrictDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 442);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DistrictDetailForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DistrictDetailForm";
            this.Load += new System.EventHandler(this.DistrictDetailForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDistrictType;
        private System.Windows.Forms.Label lblDistrictName;
        private System.Windows.Forms.Label lblDistrictCode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDistrictType;
        private System.Windows.Forms.TextBox txtDistrictName;
        private System.Windows.Forms.TextBox txtDistictCode;
        private System.Windows.Forms.ComboBox cmbCity;
    }
}