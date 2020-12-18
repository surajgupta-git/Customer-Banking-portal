namespace test1
{
    partial class customerpreview
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
            this.customerdata = new System.Windows.Forms.Label();
            this.countrydata = new System.Windows.Forms.Label();
            this.genderdata = new System.Windows.Forms.Label();
            this.hobbiesdata = new System.Windows.Forms.Label();
            this.statusdata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "customername";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "gender";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "hobbies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "status";
            // 
            // customerdata
            // 
            this.customerdata.AccessibleDescription = "customerdata";
            this.customerdata.AccessibleName = "customerdata";
            this.customerdata.AutoSize = true;
            this.customerdata.Location = new System.Drawing.Point(342, 44);
            this.customerdata.Name = "customerdata";
            this.customerdata.Size = new System.Drawing.Size(51, 20);
            this.customerdata.TabIndex = 5;
            this.customerdata.Text = "label6";
            // 
            // countrydata
            // 
            this.countrydata.AccessibleName = "countrydata";
            this.countrydata.AutoSize = true;
            this.countrydata.Location = new System.Drawing.Point(342, 85);
            this.countrydata.Name = "countrydata";
            this.countrydata.Size = new System.Drawing.Size(51, 20);
            this.countrydata.TabIndex = 6;
            this.countrydata.Text = "label7";
            // 
            // genderdata
            // 
            this.genderdata.AccessibleName = "genderdata";
            this.genderdata.AutoSize = true;
            this.genderdata.Location = new System.Drawing.Point(342, 122);
            this.genderdata.Name = "genderdata";
            this.genderdata.Size = new System.Drawing.Size(51, 20);
            this.genderdata.TabIndex = 7;
            this.genderdata.Text = "label8";
            this.genderdata.Click += new System.EventHandler(this.label8_Click);
            // 
            // hobbiesdata
            // 
            this.hobbiesdata.AccessibleName = "hobbiesdata";
            this.hobbiesdata.Location = new System.Drawing.Point(342, 207);
            this.hobbiesdata.Name = "hobbiesdata";
            this.hobbiesdata.Size = new System.Drawing.Size(224, 42);
            this.hobbiesdata.TabIndex = 8;
            this.hobbiesdata.Text = "label9jjksdjfkikgigoh";
            this.hobbiesdata.Click += new System.EventHandler(this.hobbiesdata_Click);
            // 
            // statusdata
            // 
            this.statusdata.AccessibleName = "statusdata";
            this.statusdata.AutoSize = true;
            this.statusdata.Location = new System.Drawing.Point(342, 266);
            this.statusdata.Name = "statusdata";
            this.statusdata.Size = new System.Drawing.Size(60, 20);
            this.statusdata.TabIndex = 9;
            this.statusdata.Text = "label10";
            this.statusdata.Click += new System.EventHandler(this.label10_Click);
            // 
            // customerpreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusdata);
            this.Controls.Add(this.hobbiesdata);
            this.Controls.Add(this.genderdata);
            this.Controls.Add(this.countrydata);
            this.Controls.Add(this.customerdata);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "customerpreview";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.customerpreview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label customerdata;
        private System.Windows.Forms.Label countrydata;
        private System.Windows.Forms.Label genderdata;
        private System.Windows.Forms.Label hobbiesdata;
        private System.Windows.Forms.Label statusdata;
    }
}