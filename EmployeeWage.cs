namespace Day10Employee
{
    public class EmplyeeWage{
        public const int Part_time=1;
        public const int Full_time=2;

        private string Company_name;
        private int wagePerhour;
        private int Max_working_hour;
        private int TotalWages;
        private int WorkingDays;

        public EmplyeeWage(string Company_name,int wagePerhour,int Max_working_hour,int WorkingDays){
            this.Company_name = Company_name;
            this.wagePerhour = wagePerhour ;
            this.Max_working_hour=Max_working_hour;
            this.WorkingDays=WorkingDays;
        }

        public void computewage(){

            int empHours = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while(totalEmpHrs <= this.Max_working_hour && totalWorkingDays < this.WorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int employeecheck = random.Next(0, 3);
                switch(employeecheck)
                {
                    case Part_time:
                        empHours = 4;
                        break;
                    case Full_time:
                        empHours = 8; 
                        break;
                    default:
                        empHours = 0; 
                        break;
                }
                totalEmpHrs += empHours;
            }
            Console.WriteLine("Total working Hour is {0} and Working Days is {1}",totalEmpHrs,totalWorkingDays);
            TotalWages = totalEmpHrs * this.wagePerhour;
        
        }
        public String toString(){
            return "Wages for " + Company_name + " is " +TotalWages;
        }
    }
}