﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment06
{
    public partial class SalesBonusForm : Form
    {
        public SalesBonusForm()
        {
            InitializeComponent();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string x = hoursWorkedTextBox.Text;
            Console.WriteLine(x);


          //  hoursWorkedTextBox.Text
        }

    
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
              {
             RadioEnglish.Checked = false;
             RadioFrench.Checked = false;
             employeeNameTextBox.Text = ""; 
             employeeIdTextBox.Text= "";
             hoursWorkedTextBox.Text = "";
             TotalMonthlySales.Text = ""; 
             SalesBonusTextBox.Text = ""; 
         } 
  

        }

        private void TotalSalesLabel_Click(object sender, EventArgs e)
        {

        }

        private void HoursWorkedLabel_Click(object sender, EventArgs e)
        {

        }

        private void SalesBonusTextBox_TextChanged(object sender, EventArgs e)
        {
          
        //    double hoursWorked = Convert.ToDouble(hoursWorkedTextBox.Text);
//double percentageOfHoursWorked=hoursWorked / 160;

           double TotalMonthlySales = Convert.ToDouble(TotalMonthlySales.Text);

       //   double totalBonusAmount = TotalMonthlySales * 0.02;

        }
    }
}