using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicPersonalInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnDisplayClick_Click(object sender, EventArgs e)
        {

            string det = "Firstname: " + txtFirstname.Text +
                "\nMiddlename: " + txtMiddlename.Text +
                "\nLastname: " + txtLastname.Text +
                "\nBirthdate: " + dtBdate.Text +
                "\nCivil Status: " + civilStatus.SelectedItem;


            if (rbtMale.Checked)
                det = det + "\nGender: Male";
            else
                det = det + "\nGender: Female";

            det = det + "\n\nSports: ";

            if (cbBasketball.Checked)
                det = det + "\nBasketball";
            if (cbBadminton.Checked)
                det = det + "\nBadminton";
            if (cbVolleyball.Checked)
                det = det + "\nVolleyball";



            MessageBox.Show(det, "Personal Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
