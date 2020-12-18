using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class customerpreview : Form
    {
        public customerpreview()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void customerpreview_Load(object sender, EventArgs e)
        {

        }
        public void setvalues(string customername, 
            string countryname, 
            string gender, 
            string hobbies, string status)
        {

            customerdata.Text=customername;
            countrydata.Text = countryname;
            genderdata.Text = gender;
            hobbiesdata.Text = hobbies;
            statusdata.Text = status;


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void hobbiesdata_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
