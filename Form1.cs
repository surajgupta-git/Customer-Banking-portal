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
using Dataaccess;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
        public void loadcustomer()
        {
           

            SqlClass objsql = new SqlClass();
            DataSet objdataset = objsql.Getcustomer();
            formgrid.DataSource = objdataset.Tables[0];

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            loadcustomer();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 obj1 = new Class1();
            if(obj1.Customervalidation(txtcustomername.Text)==false)
            {
                MessageBox.Show("customer name is cumplosury");
                return;
            }
                        customerpreview obj = new customerpreview();
            string hobbies1, status, gender;
            string strcustomername = txtcustomername.Text;
            string strcountry = cmbcountry.Text;
            if(radioButton1.Checked)
            {
                gender = "male";

            }
            else
            {
                gender = "female";
            }
            if (checkBox2.Checked && checkBox1.Checked)
            {
                hobbies1 = "reading"+"painting";

            }
            else
            if(checkBox1.Checked)
                {
                hobbies1 = "painting";
            }
            else
            if(checkBox2.Checked)
            {
                hobbies1 = "reading";
            }
            else
            {
                hobbies1 = "none";
            }
            if (radioButton3.Checked)
            {
                status = "1";

            }
            else
            {
                status = "0";
            }
            SqlClass sqlinsert = new SqlClass();
            sqlinsert.Insertcustomer(txtcustomername.Text, cmbcountry.Text, gender, hobbies1, status);
            loadcustomer();
        }

        private void txtcustomername_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void displaycustomer(string customercode)
        {
            SqlClass objsql = new SqlClass();
            DataSet objdataset = objsql.Getcustomer(customercode);
            String strcustomername = objdataset.Tables[0].Rows[0][0].ToString();
            String strcountryname = objdataset.Tables[0].Rows[0][1].ToString();
            String strgender = objdataset.Tables[0].Rows[0][2].ToString();
            String strhobbies = objdataset.Tables[0].Rows[0][3].ToString();
            bool married = Convert.ToBoolean(objdataset.Tables[0].Rows[0][4]);
            txtcustomername.Text = strcustomername;
            cmbcountry.Text = strcountryname;
            if(strgender=="male")
            {
                radioButton1.Checked = true; 
            }
            else
            {
                radioButton2.Checked = true;
            }
            if(married==true)
            {
                radioButton3.Checked = true;
            }
            else
            {
                radioButton4.Checked = true;
            }
            if(strhobbies=="reading")
            {
                checkBox1.Checked = true;

            }
            else
            {
                checkBox2.Checked = true;

            }
        }
        
        

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlClass sqlinsert = new SqlClass();
            sqlinsert.Deletecustomer(txtcustomername.Text);
            loadcustomer();
        }

        private void formgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strselectedcustomer = formgrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            displaycustomer(strselectedcustomer);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Class1 obj1 = new Class1();
            if (obj1.Customervalidation(txtcustomername.Text) == false)
            {
                MessageBox.Show("customer name is cumplosury");
                return;
            }

            customerpreview obj = new customerpreview();
            string hobbies1, status, gender;
            if (radioButton1.Checked)
            {
                gender = "male";

            }
            else
            {
                gender = "female";
            }
            if (checkBox2.Checked && checkBox1.Checked)
            {
                hobbies1 = "reading" + "painting";

            }
            else
            if (checkBox1.Checked)
            {
                hobbies1 = "painting";
            }
            else
            if (checkBox2.Checked)
            {
                hobbies1 = "reading";
            }
            else
            {
                hobbies1 = "none";
            }
            if (radioButton3.Checked)
            {
                status = "1";

            }
            else
            {
                status = "0";
            }
            SqlClass sqlinsert = new SqlClass();
            sqlinsert.Updatecustomer(txtcustomername.Text, cmbcountry.Text, gender, hobbies1, status);
            loadcustomer();
        }
    }
}
