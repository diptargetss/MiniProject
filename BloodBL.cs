using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLayer
{
    public class BloodBL
    {
        BloodBankDA bbda = null;
        public BloodBL()
        {
            bbda = new BloodBankDA();
        }
        public bool LoginCheck(admin)
        {
            return bbda.Logincheck(admin);
        }
        public bool ModifyCampDetails(BloodCamp camp,out string checkmsg)
        {
            //bool checkDate=false;
            if(camp.Date.CompareTo(DateTime.Now)>0)
            return bbda.ModifyCampDetails();
            else
            {
                //Console.WriteLine("Cannot Change details as date already passed");
                checkmsg="Cannot Change details as date already passed";
                return false;
            }
        }
        public bool registerBank(BloodBank b,out string checkmsg)
        {
            BloodBank bnk=bbda.BankSearch(b.userid);
            if(bnk!=null)
            {
                checkmsg="Username already exists";
                return false;
            }
            else
                bbda.registerBank(b);

        }
        public bool DonorAdd(donor d){ return bbda.DonorAdd(d);}
        public bool AddCamp(BloodCamp bc){return bbda.AddCamp(bc);}



    }
}
