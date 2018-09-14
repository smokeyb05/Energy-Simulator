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
    public partial class Form1 : Form
    {

        List<Image> FloorPlans = new List<Image>();
        public string FileLocation = (@"C:\Users\l-bosier\energy-monitor-simulator\resources\");
        InformationGate IG = new InformationGate();
        public DateTime Date = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
            SpawnLocation.Text = null;
            FloorPlans.Add(Image.FromFile(FileLocation+"large_blanked.jpg"));
            FloorPlans.Add(Image.FromFile(FileLocation+"loft_blanked.jpg"));
            FloorPlans.Add(Image.FromFile(FileLocation+"many_rooms_blanked.jpg"));
            FloorPlans.Add(Image.FromFile(FileLocation+"medium_blanked.jpg"));
            FloorPlans.Add(Image.FromFile(FileLocation + "simple_blanked.jpg"));
        }//Could Change to be able to select plan to load rather than having fixed Images


        //Floor Selection
        private string prefix = "Selected Floor: ";
        public int FloorIndex = -1;
        private void Floor1btn_Click(object sender, EventArgs e)
        {
            SelFloorText.Text = prefix + "1";
            SetFloorPlan(0);
        }

        private void Floor2btn_Click(object sender, EventArgs e)
        {
            SelFloorText.Text = prefix + "2";
            SetFloorPlan(1);
        }

        private void Floor3btn_Click(object sender, EventArgs e)
        {
            SelFloorText.Text = prefix + "3";
            SetFloorPlan(2);
        }

        private void Floor4btn_Click(object sender, EventArgs e)
        {
            SelFloorText.Text = prefix + "4";
            SetFloorPlan(3);
        }

        private void Floor5btn_Click(object sender, EventArgs e)
        {
            SelFloorText.Text = prefix + "5";
            SetFloorPlan(4);
        }

        public void SetFloorPlan(int index)
        {
            FloorPlanImage.Image = FloorPlans[index];
            FloorIndex = index;
            foreach (Appliance Apl in ApplianceList)
            {
                if (Apl.FloorIndex != index)
                {
                    Apl.Hide();
                }
                else
                {
                    Apl.Show();
                    Apl.BringToFront();
                }
            }
        }
        //^ Could be  more simple but for now it will do



        //Open New Form (Interfaces with Information Gate Then Opens New Window There)
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            IG.ShowMonitor(Date);
        }

     

        //Time Controller
        private void button1_Click(object sender, EventArgs e)
        {
            if (Tick.Enabled == true)
            {
                button1.Text = "Start";
                Tick.Enabled = false;
            }
            else{
                button1.Text = "Pause";
                Tick.Enabled = true;
            }

        }

        //This is The Timer Object That does the ticking
        private void Tick_Tick(object sender, EventArgs e)
        {
            //Send Current appliances to the IG for calcualtion and display
            float GasUsage = 0;
            float ElecUsage = 0;
            foreach (Appliance apl in ApplianceList)
            {
                GasUsage += apl.GasUsageRate;
                ElecUsage += apl.ElecUsageRate;
            }
            IG.Calculate(1,ElecUsage,GasUsage, Date = Date.AddHours(1));
            
        }
        //Get Value Of Slider
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TimeLabel.Text = trackBar1.Value.ToString() + " H/Sec";
            //Multiplyer = trackBar1.Value;
            Tick.Interval = 1000 / trackBar1.Value;
        }

        //List Of Existing Appliances
        List<Appliance> ApplianceList = new List<Appliance>();
                     
        //Floor Check
        public bool FloorCheck()
        {
            if (FloorIndex != -1)
            {
                return true;
            }
            else return false;
        }

        //Creation Buttons \/

        //Create Light Bulb
        private void button2_Click(object sender, EventArgs e)
        {
            if (FloorCheck() == true)
            {
                CreateApplicance("Light", Properties.Resources.Light_Bulb_On, Properties.Resources.Light_Bulb_Off, 0.06f, 0, FloorIndex);
            }
        }
        //Create TV
        private void button3_Click(object sender, EventArgs e)
        {
            if (FloorCheck() == true)
            {
                CreateApplicance("TV", Properties.Resources.TV_Image_On,Properties.Resources.TV_Image, 0.25f, 0, FloorIndex);
            }
        }
        //Create Oven
        private void button4_Click(object sender, EventArgs e)
        {
            if (FloorCheck() == true)
            {
                CreateApplicance("Oven", Properties.Resources.Oven_On, Properties.Resources.Oven_Off, 0, 1f, FloorIndex);
            }
        }
        //Create Shower
        private void button7_Click(object sender, EventArgs e)
        {
            if (FloorCheck() == true)
            {
                CreateApplicance("Shower", Properties.Resources.Shower_On, Properties.Resources.Shower_Off, 8, 0f, FloorIndex);
            }
        }
        //Create Heator
        private void button6_Click(object sender, EventArgs e)
        {
            if (FloorCheck() == true)
            {
                CreateApplicance("Heater", Properties.Resources.Rad_On, Properties.Resources.Rad_Off, 2, 0f, FloorIndex);
            }
        }
        //Create Boiler
        private void button5_Click(object sender, EventArgs e)
        {
            if (FloorCheck() == true)
            {
                CreateApplicance("Boiler", Properties.Resources.Boiler_On, Properties.Resources.Boiler_Off, 0, 1f, FloorIndex);
            }
        }



        //Appliance Pressed
        public void Toggle(object sender, EventArgs e)
        {
            Appliance btn=sender as Appliance;
            if (btn.Toggled == true)
            {
                btn.Toggled = false;
                btn.Image = btn.OffPNG;
                btn.ElecUsageRate = 0;
                btn.GasUsageRate = 0;
            }
            else
            {
                btn.Toggled = true;
                btn.Image = btn.OnPNG;
                btn.ElecUsageRate = btn.ElecUntouch;
                btn.GasUsageRate = btn.GasUntouch;
            }
        }


        public void CreateApplicance(string ApplianceName,Image OnPNG,Image OffPNG, float ElecUsage,float GasUsage, int FloorIndex)
        {
            Appliance APL = new Appliance();
            // Set Applicance properties
            APL.Toggled = false;
            APL.FloorIndex = FloorIndex;
            APL.OnPNG = OnPNG;
            APL.OffPNG = OffPNG;
            APL.ElecUsageRate = 0;
            APL.GasUsageRate = 0;
            APL.ElecUntouch = ElecUsage;
            APL.GasUntouch = GasUsage;
            APL.Height = 35;
            APL.Width = 35;
            APL.SizeMode = PictureBoxSizeMode.StretchImage;
            APL.Image = APL.OffPNG;
            APL.Location = SpawnLocation.Location;
            APL.Name = ApplianceName;
            Controls.Add(APL);
            ApplianceList.Add(APL);
            APL.BringToFront();
            APL.Click += new EventHandler(Toggle);
            ControlExtension.Draggable(APL, true);
        }

        class Appliance : PictureBox
        {
            public float ElecUsageRate;
            public float GasUsageRate;
            public bool Toggled;
            public Image OnPNG;
            public Image OffPNG;
            public int FloorIndex;
            //Untouch values are always the same so they don't get nulled out
            public float ElecUntouch;
            public float GasUntouch;
        }

        
    }
}
