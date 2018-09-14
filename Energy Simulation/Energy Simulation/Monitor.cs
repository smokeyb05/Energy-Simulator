using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Energy_Simulation
{
    public partial class Monitor : Form
    {
        
        public Monitor()
        {
            InitializeComponent();
            
        }

        public void SetDaily(float Energy,float Gas)
        {

            Daily_Energy.Text = Energy.ToString("0.00");
            Daily_Gas.Text = Gas.ToString("0.00");
        }


        public void SetMonthly(float Energy,float Gas)
        {
            MonthlyEnergy.Text = Energy.ToString("0.00");
            MonthyGas.Text = Gas.ToString("0.00");
        }

        public void SetYear(float Energy, float Gas)
        {
            ElecYear.Text = Energy.ToString("0.00");
            GasYear.Text = Gas.ToString("0.00");
        }


        public void SetDate(DateTime Date)
        {
            DateLabel.Text = Date.ToString();
        }

       
    }
}
