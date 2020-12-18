namespace test1
{
    partial class formsearchcustomer
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
            this.entercustomername = new System.Windows.Forms.Label();
            this.customername = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // entercustomername
            // 
            this.entercustomername.AutoSize = true;
            this.entercustomername.Location = new System.Drawing.Point(60, 58);
            this.entercustomername.Name = "entercustomername";
            this.entercustomername.Size = new System.Drawing.Size(138, 17);
            this.entercustomername.TabIndex = 0;
            this.entercustomername.Text = "entercustomername:";
            // 
            // customername
            // 
            this.customername.Location = new System.Drawing.Point(395, 58);
            this.customername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customername.Name = "customername";
            this.customername.Size = new System.Drawing.Size(89, 22);
            this.customername.TabIndex = 1;
            this.customername.TextChanged += new System.EventHandler(this.customername_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(568, 37);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(142, 62);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(24, 104);
            this.datagrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowTemplate.Height = 28;
            this.datagrid.Size = new System.Drawing.Size(643, 198);
            this.datagrid.TabIndex = 3;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // formsearchcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.customername);
            this.Controls.Add(this.entercustomername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formsearchcustomer";
            this.Text = "formsearchcustomer";
            this.Load += new System.EventHandler(this.formsearchcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label entercustomername;
        private System.Windows.Forms.TextBox customername;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView datagrid;
    }
}