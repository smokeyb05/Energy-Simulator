using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy_Simulation
{
    class InformationGate
    {

       // Creates Data Struct Holding Supplier Information
        public struct SupplierInfo
        {
            public float ElectricityUsageRate;
            public float ElectricityStandingCharge;
            public float GasUsageRate;
            public float GasStandingCharge;
        }
        public SupplierInfo SI = new SupplierInfo();
        public void Init() // Sets the values of the struct. Could be loaded from a file etc.
        {
            SI.ElectricityUsageRate = 24.76f;
            SI.ElectricityStandingCharge = 14f;
            SI.GasUsageRate = 13.56f;
            SI.GasStandingCharge = 27f;
    }
        //House Info Holds All Data About the current house
        public HouseInfo HI = new HouseInfo();
        public struct HouseInfo
        {
            //Rolls Back Each Day
           public float CurrentElecUsageToday;
           public float CurrentGasUsageToday;
            //Rolls Back Each Month
           public float CurrentElecUsageThisMonth;
           public float CurrentGasUsageThisMonth;
            //Rolls back Every Year
           public float CurrentElecUsageThisYear;
           public float CurrentGasUsageThisYear;
        }

        //Show The Monitor + Creates The Mon Referance of the class so can be accessed whenever 
        Monitor Mon = new Monitor();
        public void ShowMonitor(DateTime Date)
        {
            Mon.Show();
            Mon.SetDate(Date);
            Init();

        }

        public DateTime LastDate = DateTime.Now;
        //Calculates Spendings and send it to the monitor
        public void Calculate(float Multiplyer,float Energy,float Gas,DateTime Date)
        {
            //At the End of the Day Calculate + StandingCharge 
            if (LastDate.Day < Date.Day)
            {
                HI.CurrentElecUsageToday += (((Energy * SI.ElectricityUsageRate * Multiplyer) + SI.ElectricityStandingCharge) / 100);
                HI.CurrentGasUsageToday += (((Gas * SI.GasUsageRate * Multiplyer) + SI.GasStandingCharge) / 100);
                HI.CurrentGasUsageThisMonth += HI.CurrentGasUsageToday;
                HI.CurrentElecUsageThisMonth += HI.CurrentElecUsageToday;
                Mon.SetDaily(HI.CurrentElecUsageToday, HI.CurrentGasUsageToday);
                HI.CurrentElecUsageToday = 0;
                HI.CurrentGasUsageToday = 0;
                Mon.SetMonthly(HI.CurrentElecUsageThisMonth, HI.CurrentGasUsageThisMonth);
            }
            else
            {
                HI.CurrentElecUsageToday += ((Energy * SI.ElectricityUsageRate) / 100) * Multiplyer;
                HI.CurrentGasUsageToday += ((Gas * SI.GasUsageRate) / 100) * Multiplyer;
            }
            if (LastDate.Month < Date.Month)
            {
                HI.CurrentGasUsageThisYear += HI.CurrentGasUsageThisMonth;
                HI.CurrentElecUsageThisYear += HI.CurrentElecUsageThisMonth;
                HI.CurrentElecUsageThisMonth = 0;
                HI.CurrentGasUsageThisMonth = 0;
                Mon.SetYear(HI.CurrentElecUsageThisYear, HI.CurrentGasUsageThisYear);
            }
            if (LastDate.Year < Date.Year)
            {
                HI.CurrentGasUsageThisYear = 0;
                HI.CurrentElecUsageThisYear = 0;
                Mon.SetYear(HI.CurrentElecUsageThisYear, HI.CurrentGasUsageThisYear);
            }
            Mon.SetDaily(HI.CurrentElecUsageToday, HI.CurrentGasUsageToday);
            Mon.SetDate(Date);
            LastDate = Date;
        }


    }
}
