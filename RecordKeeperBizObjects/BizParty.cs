using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecordKeeperBizObjects
{
    public class bizParty : bizObject<bizParty>
    {
        string partynameval = "";
        string colorval = "";
        int yearstartedval = 0;
        int presidentcountval= 0;
        List<bizPresident> lstpresident = new List<bizPresident>();
        public bizParty() 
        {

        }
        //public void Load(int id)
        //{
        //    DataTable dt = base.Load(id);

        //    if (dt.Rows.Count > 0)
        //    {
        //        this.PartyName = dt.Rows[0]["PartyName"].ToString();
        //    }
        //}
       
        public int PartyId
        {
            get => this.PrimaryKeyValue;
            set => this.PrimaryKeyValue = value;
        }

        [Required]
        [Display(Name = "Party Name")]
        public string PartyName
        {
            get
            {
                return partynameval;

            }
            set
            {
                partynameval = value;
                InvokePropertyChanged();
            }
        }

        [Required]
        [Display(Name = "Color")]
        public string Color
        {
            get
            {
                return colorval;

            }
            set
            {
                colorval = value;
                InvokePropertyChanged();
            }
        }

        [Required]
        [Display(Name = "Year Started")]
        public int YearStarted
        {
            get { return yearstartedval; }
            set {
                yearstartedval = value;
                InvokePropertyChanged();

            }
        }
        public int PresidentCount
        {
            get { return presidentcountval; }
            set
            {
                presidentcountval = value;
                InvokePropertyChanged();

            }
        }
        public List<bizPresident> PresidentList (bool refresh)
        {
            if (refresh == true || lstpresident == null)
            {
                lstpresident = bizPresident.GetList("PartyName", this.PartyName);
            }
            return lstpresident;
        }
    }
}