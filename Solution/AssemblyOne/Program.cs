using System;
using AssemblyTwo;

namespace AssemblyOne
{
    class Program
    {   
        static void Main(string[] args)
        {  
            Employee employee = new Employee();            
            float a = Employee.numberPpublic; 
            //float a = Employee.numberPprivate;// Данная константа недоступна в данном классе.
            
            string str = employee.nameInternal;

            employee.SumPublic();
            //employee.sumPrivate();// Данный метод недостопен в данном классе.

            Developer developer = new Developer();            
            developer.numberProtectedInternal();
            //developer.numberProtected();// Данный метод недостопен в данном классе.
            //developer.numberPrivateProtected();// Данный метод недостопен в данном классе.

                      
            AssemblyTwo.User user = new AssemblyTwo.User();
            user.DisplayPublic();
            //user.DisplayInteral()// Данный метод недостопен в данном классе.
        }
    }
}
