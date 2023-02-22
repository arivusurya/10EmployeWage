using System;

namespace Day10Employee{

    public class CompanyEmpWage{

         public string Companyname;
        public int wagePerhour;
        public int Max_working_hour;
        public int TotalWages;
        public int WorkingDays;

        public CompanyEmpWage(string Company_name,int wagePerhour,int Max_working_hour,int WorkingDays){
            this.Companyname = Company_name;
            this.wagePerhour=wagePerhour;
            this.Max_working_hour=Max_working_hour;
            this.WorkingDays = WorkingDays;
        }
        public void  setwage(int toatalwage){
            this.TotalWages = toatalwage;
        }
        public string toString(){
            return "Tatal wage for "+this.Companyname+" is "+ this.TotalWages+ ".";
        }
    }


}