﻿using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.ComponentModel.DataAnnotations;

namespace RecordKeeperBizObjects
{
    public class bizPresident : bizObject<bizPresident>
    {
        int partyidval = 0;
        string lastnameval = "";
        string firstnameval = "";
        int numval;
        int termstartval;
        int termendval;
        DateTime datebornval;
        DateTime? datediedval;
        string codeval = "";

        public bizPresident()
        {
            this.DynamParamForUpdate.Output(this, x => x.Num);
            this.DynamParamForUpdate.Output(this, x => x.Code);
            //for output parameter hat comes in as null and need put in data lenght size, here put example for datedies. can have this issue in recipe for archived, string..
            //this.DynamParamForUpdate.Output(this, x => x.DateDied, size: 20);
        }
        public static List<bizPresident> Search(string criteria)
        {
            DynamicParameters dp = new DynamicParameters();
            dp.Add("SearchCriteria", criteria);
            return GetAllFromSproc("PresidentSearch", dp);
        }
       
     
        public int PresidentId { get => this.PrimaryKeyValue; set => this.PrimaryKeyValue = value; }
        [Required]
        [Display(Name = "Party")]
        public int PartyId
        {
            get
            {
                return partyidval;
            }
            set
            {
                partyidval = value;
                InvokePropertyChanged();
            }
        }
        [Display(Name ="Last Name")]
        public string LastName
        {
            get
            {
                return lastnameval;
            }
            set
            {
                lastnameval = value;
                InvokePropertyChanged();
            }
        }

        [Display(Name = "First Name")]
        public string FirstName
        {
            get
            {
                return firstnameval;
            }
            set
            {
                firstnameval = value;
                InvokePropertyChanged();
            }
        }
        public int Num
        {
            get
            {
                return numval;
            }
            set
            {
                numval = value;
                InvokePropertyChanged();
            }

        }
        public int TermStart
        {
            get
            {
                return termstartval;
            }
            set
            {
                termstartval = value;
                InvokePropertyChanged();
            }
        }

        public int TermEnd
        {
            get
            {
                return termendval;
            }
            set
            {
                termendval = value;
                InvokePropertyChanged();
            }
        }


        public DateTime DateBorn
        {
            get
            {
                return datebornval;
            }
            set
            {
                datebornval = value;
                InvokePropertyChanged();
            }
        }

        public DateTime? DateDied
        {
            get
            {
                return datediedval;
            }
            set
            {
                datediedval = value;
                InvokePropertyChanged();
            }
        }
        public string Code
        {
            get
            {
                return codeval;
            }
            set
            {
                codeval = value;
                InvokePropertyChanged();
            }
        }
        public string FullDescription() { return this.Num + " " + this.LastName + " " + this.FirstName; }

        //public List
        public List<bizParty> PartyList()
        {
            return bizParty.GetAll();
        }
    }
}
