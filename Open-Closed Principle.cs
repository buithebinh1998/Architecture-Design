namespace  OCP
{
    public class FullTimeWorker{  
        public double wagePerHour {get;set;}  
        public int hour {get;set;}  
        public double bonus {get; set;}
    }  
    public class PartTimeWorker{  
        public double wagePerHour {get;set;}  
        public int hour {get;set;}    
    }

    public class TotalSalary  
    {  
        public double TotalSalary(object[] arr)  
        {  
            double salary = 0;  
            FullTimeWorker objFullTime;  
            PartTimeWorker objPartTime;  
            foreach(var obj in arr)  
            {  
                if(obj is FullTimeWorker)  
                {    
                    salary += objFullTime.wagePerHour * objFullTime.hour + objFullTime.bonus;  
                }  
                else  
                {  
                    salary += objPartTime.wagePerHour * objPartTime.hour;  
                }  
            }  
            return salary;  
        }  
    }  
}
//violation because everytime we introduce a new type of worker, we have to alter the TotalSalary method. So it doesn't open for extension.

//fix violation
namespace  SRP
{
    public abstract class Worker  
    {  
        public abstract double Salary();  
    }  

    public class FullTimeWorker{  
        public double wagePerHour {get;set;}  
        public int hour {get;set;}  
        public double bonus {get; set;}
        public override double Salary()
        {
            return wagePerHour * hour + bonus;
        }
    }  
    public class PartTimeWorker{  
        public double wagePerHour {get;set;}  
        public int hour {get;set;}    

        public override double Salary()
        {
            return wagePerHour * hour;
        }
    }

    public class TotalSalary  
    {  
        public double TotalSalary(Worker[] arrWorker)  
        {  
            double salary = 0;  
            foreach(var objWorker in arrWorker)  
            {  
                salary += objWorker.Salary();         
            }  
            return salary;  
        }  
    }  

}

    
 