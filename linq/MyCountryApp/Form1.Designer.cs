namespace MyCountryApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.grdDistrict = new System.Windows.Forms.DataGridView();
            this.btnGetDistrict = new System.Windows.Forms.Button();
            this.txtSearchDistrict = new System.Windows.Forms.TextBox();
            this.txtMaxDistrict = new System.Windows.Forms.TextBox();
            this.btnGetDistrict1 = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDistrict)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdDistrict
            // 
            this.grdDistrict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDistrict.Location = new System.Drawing.Point(394, 12);
            this.grdDistrict.Name = "grdDistrict";
            this.grdDistrict.Size = new System.Drawing.Size(341, 405);
            this.grdDistrict.TabIndex = 2;
            // 
            // btnGetDistrict
            // 
            this.btnGetDistrict.Location = new System.Drawing.Point(481, 480);
            this.btnGetDistrict.Name = "btnGetDistrict";
            this.btnGetDistrict.Size = new System.Drawing.Size(151, 53);
            this.btnGetDistrict.TabIndex = 3;
            this.btnGetDistrict.Text = "Get Districts";
            this.btnGetDistrict.UseVisualStyleBackColor = true;
            this.btnGetDistrict.Click += new System.EventHandler(this.btnGetDistrict_Click);
            // 
            // txtSearchDistrict
            // 
            this.txtSearchDistrict.Location = new System.Drawing.Point(426, 440);
            this.txtSearchDistrict.Name = "txtSearchDistrict";
            this.txtSearchDistrict.Size = new System.Drawing.Size(266, 20);
            this.txtSearchDistrict.TabIndex = 4;
            // 
            // txtMaxDistrict
            // 
            this.txtMaxDistrict.Location = new System.Drawing.Point(61, 440);
            this.txtMaxDistrict.Name = "txtMaxDistrict";
            this.txtMaxDistrict.Size = new System.Drawing.Size(246, 20);
            this.txtMaxDistrict.TabIndex = 5;
            // 
            // btnGetDistrict1
            // 
            this.btnGetDistrict1.Location = new System.Drawing.Point(481, 558);
            this.btnGetDistrict1.Name = "btnGetDistrict1";
            this.btnGetDistrict1.Size = new System.Drawing.Size(151, 53);
            this.btnGetDistrict1.TabIndex = 6;
            this.btnGetDistrict1.Text = "Get Districts CityCode";
            this.btnGetDistrict1.UseVisualStyleBackColor = true;
            this.btnGetDistrict1.Click += new System.EventHandler(this.btnGetDistrict1_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(93, 558);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(172, 53);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "ShowDisAndCityOrdByCityName";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(865, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1121, 100);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(187, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 642);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnGetDistrict1);
            this.Controls.Add(this.txtMaxDistrict);
            this.Controls.Add(this.txtSearchDistrict);
            this.Controls.Add(this.btnGetDistrict);
            this.Controls.Add(this.grdDistrict);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDistrict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdDistrict;
        private System.Windows.Forms.Button btnGetDistrict;
        private System.Windows.Forms.TextBox txtSearchDistrict;
        private System.Windows.Forms.TextBox txtMaxDistrict;
        private System.Windows.Forms.Button btnGetDistrict1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

