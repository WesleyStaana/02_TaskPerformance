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
    public partial class NowServing : Form
    {
        public NowServing()
        {
            InitializeComponent();
        }

        private void NowServing_Load(object sender, EventArgs e)
        {
            try
            {
                lblServing.Text = CashierClass.CashierQueue.Peek();
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("Nothing in Queue");
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
