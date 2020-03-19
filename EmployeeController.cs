using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Models;

namespace Controllers
{

   [Produces("application/json")] //it will give response only in JSON format
    [Route("api/Employee")]  //it routes an incoming HTTP requst to a particular action method on a web api
    public class EmployeeController
    {
       List<Employee> employeList = new List<Employee>()
       { 
                new Employee(){Employee_id = 1,Employe_name="Lavanya", NoOfWorkedDays= 0, Description="Not filled" },
                new Employee(){Employee_id = 2,Employe_name="Tereena", NoOfWorkedDays =0, Description="not filled"},
                new Employee(){Employee_id = 3,Employe_name="karan", NoOfWorkedDays =0, Description="not filled"},
                new Employee(){Employee_id = 4,Employe_name="Raju", NoOfWorkedDays =0, Description="not filled"},
                new Employee(){Employee_id = 5,Employe_name="Shashank", NoOfWorkedDays =0, Description="not filled"},
    };
    
    [HttpGet]  //it is an attribute that handles the http get request(optional)
    public IEnumerable<Employee> GetAll() // it retrives all the employees data
        {
            return employeList;
        }

    [HttpGet("employeid/{empid}")] //in order to retrive the specific employee details
        public IEnumerable<Employee> ListEmployeeById(int empid)
        {
             IEnumerable<Employee> returnValue =
                from emp in employeList
                where emp.Employee_id.Equals(empid) 
                select emp;

            return returnValue;

        }
    }

}