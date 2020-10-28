using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BasicQueuingSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private int _ticks;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _ticks++;
               
                if (_ticks == 5)
                {
                    timer1.Stop();
                    _ticks = 0;
                    NowServing now = new NowServing();
                    now.ShowDialog();
                    DisplayCashierQueue(CashierClass.CashierQueue.Dequeue());
                    DisplayCashierQueue(CashierClass.CashierQueue);
                }
            }
            catch (System.InvalidOperationException ex)
            {
                timer1.Stop();
                _ticks = 0;
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
            timer1.Stop();
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach(Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

       

        private void btnNext_Click(object sender, EventArgs e)
        {

            timer1.Start();
            

        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
            timer1.Stop();
        }
    }
}
