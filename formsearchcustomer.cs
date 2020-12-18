using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Dataaccess;

namespace test1
{
    public partial class formsearchcustomer : Form
    {
        public formsearchcustomer()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string custname = customername.Text;
            Class1 obj1 = new Class1();
            if (obj1.Customervalidation(customername.Text) == false)
            {
                MessageBox.Show("customer name is cumplosury");
                return;
            }

            //string Connectionstring = ConfigurationManager.ConnectionStrings["dbconn"].ToString(); 
            SqlClass objsql = new SqlClass();
            DataSet objdataset = objsql.Getcustomer(custname);
            datagrid.DataSource = objdataset.Tables[0];

            

        }

        private void formsearchcustomer_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
