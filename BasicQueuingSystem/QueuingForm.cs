using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingSystem

   
{
   
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();

           
        }


        private CashierClass cashier = new CashierClass();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {

            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

