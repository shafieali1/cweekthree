using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Of_Week_FOUR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            lblDecision.Text = string.Empty;
        }

        private void BtnCheckQuali_Click(object sender, EventArgs e)
        {
            double salary, yearsExperience;
            const double YEARS_EXP = 2;

            if (double.TryParse(TxtSalary.Text, out salary) &&
                double.TryParse(TxtYearsExp.Text, out yearsExperience))
            {
                if (salary > 0 && yearsExperience > 0)
                {
                    if (salary >= 200)
                    {
                        if (yearsExperience >= YEARS_EXP)
                        {
                            lblDecision.Text = "You qualify for a loan";
                        }
                        else
                        {
                            lblDecision.Text =
                                "Your experience must be at least 2 years";
                        }
                    }
                    else
                    {
                        lblDecision.Text = "Your salary is less than 200";
                    }
                }
                else
                {
                    lblDecision.Text =
                        "Salary and experience must be positive";
                }
            }
            else
            {
                lblDecision.Text = "Please enter valid numbers";
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnChangeClr_Click(object sender, EventArgs e)
        {
           
            BtnCheckQuali.BackColor = Color.LimeGreen;
            BtnCheckQuali.ForeColor = Color.White;

            BtnChangeClr.BackColor = Color.ForestGreen;
            BtnChangeClr.ForeColor = Color.White;
        }

        private void TxtSalary_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

