namespace Day10Employee
{
    public class EmplyeeWage : IComputeWage{
        public const int Part_time=1;
        public const int Full_time=2;
        private int numOfCompany = 0;

        private CompanyEmpWage[] companyEmpWages;

     
        public EmplyeeWage(){
            this.companyEmpWages = new CompanyEmpWage[5];

        }

        public void Add(String name , int wage,int maxday,int maxhours){
            companyEmpWages[numOfCompany]= new CompanyEmpWage(name,wage,maxhours,maxday);
            numOfCompany++;
        }
        public void Computewage(){
            for(int i =0 ;i < numOfCompany;i++){
                companyEmpWages[i].setwage(this.computewage(companyEmpWages[i]));
                Console.WriteLine(companyEmpWages[i].toString());
            }
        }

        private int computewage(CompanyEmpWage companyEmpWage){

            int empHours = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while(totalEmpHrs <= companyEmpWage.Max_working_hour && totalWorkingDays < companyEmpWage.WorkingDays)
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
            return totalEmpHrs * companyEmpWage.wagePerhour;       
        
        }
       
    }
}