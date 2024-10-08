using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using WebApplication4.DSConn;
using WebApplication4.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeApi : ControllerBase
    {
        public readonly DBContext _Con;

        public EmployeeApi(DBContext con)
        {
            _Con = con;
        }

        [HttpGet]
        [Route("AddEmp/{Name}/{Img}/{spec}/{email}/{phone}/{address}/{HDate}/{DepRef}/{UserName}/{password}")]
        public string AddEmployee(string Name, string Img, string spec, string email, string phone,
            string address, string HDate, string DepRef, string UserName, string password)
        {
            Employee ObjEmp = new Employee();
            ObjEmp.Name = Name;
            ObjEmp.Image = Img;
            ObjEmp.Specialty = spec;
            ObjEmp.Email = email;
            ObjEmp.Phone = phone;
            ObjEmp.Address = address;
            ObjEmp.HireDate = DateTime.Parse(HDate);
            ObjEmp.DepRef = int.Parse(DepRef);
            ObjEmp.UserName = UserName;
            ObjEmp.Password = password;
            _Con.Employees.Add(ObjEmp);
            _Con.SaveChanges();
            return "Employee Added";
        }

        [HttpGet]
        [Route("GetEmployees")]
        public string GetEmployees()
        {
            var getData = from em in _Con.Employees
                          join dep in _Con.Departments on em.DepRef equals dep.ID
                          select new {
                              em.Name,
                              dep.DepartmentName,
                              em.Image,
                              em.Specialty,
                              em.Address,
                              em.Email,
                              em.Phone,
                              em.HireDate
                          };

            JavaScriptSerializer jsData = new JavaScriptSerializer();
            jsData.MaxJsonLength = int.MaxValue;
            string Val = jsData.Serialize(getData);
            return Val;
        }

        [HttpGet]
        [Route("EditEmp/{EmpNo}/{Name}/{Img}/{spec}/{email}/{phone}/{address}/{HDate}/{DepRef}")]
        public string EditEmployee(string EmpNo, string Name, string Img, string spec, string email, string phone,
            string address, string HDate, string DepRef, string ProRef)
        {
            int Num = int.Parse(EmpNo);
            Employee ObjEmp = new Employee();
            ObjEmp = _Con.Employees.Single(e => e.Id == Num);
            ObjEmp.Name = Name;
            ObjEmp.Image = Img;
            ObjEmp.Specialty = spec;
            ObjEmp.Email = email;
            ObjEmp.Phone = phone;
            ObjEmp.Address = address;
            ObjEmp.HireDate = DateTime.Parse(HDate);
            ObjEmp.DepRef = int.Parse(DepRef);

            _Con.Employees.Update(ObjEmp);
            _Con.SaveChanges();
            return "Employee updated";
        }

        [HttpDelete]
        [Route("DeleteEmployee/{id}")]
        public string DeleteEmployee(string id)
        {
            int Num = int.Parse(id);
            Employee ObjEmp = new Employee();
            ObjEmp = _Con.Employees.Single(e => e.Id == Num);
            _Con.Employees.Remove(ObjEmp);
            _Con.SaveChanges();
            return "Employee deleted";
        }
        
        [HttpGet]
        [Route("GetAuth/{userName}/{password}")]
        public string Login(string userName, string password)
        {
            var getLog = (from log in _Con.Employees
                          where log.UserName == userName && log.Password == password
                          select new { log.Id ,log.Name, log.Email, log.Specialty}).ToList();
            int count = getLog.Count();
            if(count != 0)
            {

                JavaScriptSerializer jsData = new JavaScriptSerializer();
                jsData.MaxJsonLength = int.MaxValue;
                string Val = jsData.Serialize(getLog);
                return Val;
            }
            else
            {
                return count.ToString();
            }
            
        }
    }
}
