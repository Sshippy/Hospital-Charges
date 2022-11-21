using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExtraDiscussion4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // These methods accept the number of days at the hospital

        // and medical charges as arguments and return the

        // equivalent total of charges.

        private double CalcStayCharges(double days)

        {

            return days * 350.0;

        }

        private double CalcMiscCharges(double medical, double surgical, double lab, double rehab)

        {

            return (medical + surgical + lab + rehab);

        }

        private double CalcTotalCharges(double days, double medical, double surgical, double lab, double rehab)

        {

            return CalcStayCharges(days) + CalcMiscCharges(medical, surgical, lab, rehab);
        }

            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblDays_Click(object sender, EventArgs e)
        {

        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMedicine_Click(object sender, EventArgs e)
        {

        }

        private void txtMedicine_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSurgury_Click(object sender, EventArgs e)
        {

        }

        private void txtSurgury_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLab_Click(object sender, EventArgs e)
        {

        }

        private void txtLab_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRehab_Click(object sender, EventArgs e)
        {

        }

        private void txtRehab_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Variables to hold the number of days spent at the hospital, amount of medication, surgical, lab and rehab charges.

            double days, medical, surgical, lab, rehab, totalCharges;

            // Get the number of days.

            if (!double.TryParse(txtDays.Text, out days) || days <= 0.0)

            {

                MessageBox.Show("Length of stay (days) is invalid. Please amend");

                txtDays.Focus();

                return;

            }

            // Get the medication charges

            if (!double.TryParse(txtMedicine.Text, out medical) || medical < 0.0)

            {

                MessageBox.Show("Medication charges are invalid. Please amend");

                txtMedicine.Focus();

                return;

            }

            // Get the surgical charges

            if (!double.TryParse(txtSurgury.Text, out surgical) || surgical < 0.0)

            {

                MessageBox.Show("Surgical charges are invalid. Please amend");

                txtSurgury.Focus();

                return;

            }

            // Get the lab fees

            if (!double.TryParse(txtLab.Text, out lab) || lab < 0.0)

            {

                MessageBox.Show("Lab fees are invalid. Please amend");

                txtLab.Focus();

                return;

            }

            // Get the physical rehabilitation charges

            if (!double.TryParse(txtRehab.Text, out rehab) || rehab < 0.0)

            {

                MessageBox.Show("Phycial rehabilitation charges are invalid. Please amend");

                txtRehab.Focus();

                return;

            }

            // Calculate the total charges.

            totalCharges = CalcTotalCharges(days, medical, surgical, lab, rehab);

            // Display the total charges.

            txtTotal.Text = totalCharges.ToString("n2");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDays.Text = String.Empty;
            txtMedicine.Text = String.Empty;
            txtSurgury.Text = String.Empty;
            txtLab.Text = String.Empty;
            txtRehab.Text = String.Empty;
            txtTotal.Text = String.Empty;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
