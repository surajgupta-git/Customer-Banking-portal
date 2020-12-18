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

namespace test1
{
    public partial class uservalidation : Form
    {
        public uservalidation()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                  Close();
            }
            else
            {
                MessageBox.Show("invalid credentials");
            }
            
        }



        public DataSet Getuser(string strusername, string strpassword)
        {
            string Connectionstring = @"Data Source=WINSG185310-74Z\SQLEXPRESS;Initial Catalog=mycustdb;Integrated Security=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            SqlCommand objcommand = new SqlCommand("SELECT  *  FROM users WHERE username='" + strusername + "' and password='" + strpassword + "'  ", objConnection);
            DataSet objdataset = new DataSet();
            SqlDataAdapter objdataadapter = new SqlDataAdapter(objcommand);
            //objdataadapter.SelectCommand = objcommand;
            objdataadapter.Fill(objdataset);
            objConnection.Close();
            return objdataset;
        }

        public bool Isvalid()
        {
            DataSet obj = Getuser(txtusername.Text,txtpassword.Text);
            if (obj.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
                return true;
        }

        private void uservalidation_Load(object sender, EventArgs e)
        {
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
