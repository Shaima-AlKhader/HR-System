﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using WebApplication4.DSConn;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractApi : ControllerBase
    {
        public readonly DBContext _Con;
        public ContractApi(DBContext con)
        {
            _Con = con;
        }

        [HttpGet]
        [Route("AddCont/{EmpRef}/{CoType}/{pos}/{salary}/{stDate}/{eDate}")]
        public string AddContract(string EmpRef, string CoType, 
            string pos, string salary, string stDate, string eDate)
        {
            Contract ObjCont= new Contract();
            ObjCont.EmpRef = int.Parse(EmpRef);
            ObjCont.ContractType = CoType;
            ObjCont.position = pos;
            ObjCont.salary = decimal.Parse(salary);
            ObjCont.StartDate = DateTime.Parse(stDate);
            ObjCont.EndDate = DateTime.Parse(eDate);
            
            _Con.Contracts.Add(ObjCont);
            _Con.SaveChanges();
            return "Contract Added";
        }


        [HttpGet]
        [Route("GetCont")]
        public string GetContract()
        {
            var getData = from co in _Con.Contracts
                          join em in _Con.Employees on co.EmpRef equals em.Id
                          select new {em.Name, co.ContractType, co.position, 
                                      co.StartDate, co.EndDate, co.salary};

            JavaScriptSerializer jsData = new JavaScriptSerializer();
            jsData.MaxJsonLength = int.MaxValue;
            string Val = jsData.Serialize(getData);
            return Val;
        }

        [HttpDelete]
        [Route("DelCont/{ContNo}")]
        public string DeleteCont(string ContNo)
        {
            int Num = int.Parse(ContNo);
            Contract ObjCont = new Contract();
            ObjCont = _Con.Contracts.Single(c => c.ID == Num);
            _Con.Contracts.Remove(ObjCont);
            _Con.SaveChanges();
            return "deleted Contract";
        }

        [HttpGet]
        [Route("EditCont/{ContNo}/{EmpRef}/{CoType}/{pos}/{salary}/{stDate}/{eDate}")]
        public string EditCont(string ContNo,string EmpRef, string CoType,
            string pos, string salary, string stDate, string eDate)
        {
            int Num = int.Parse(ContNo);
            Contract ObjCont = new Contract();
            ObjCont = _Con.Contracts.Single(c => c.ID == Num);
            ObjCont.EmpRef = int.Parse(EmpRef);
            ObjCont.ContractType = CoType;
            ObjCont.position = pos;
            ObjCont.salary = decimal.Parse(salary);
            ObjCont.StartDate = DateTime.Parse(stDate);
            ObjCont.EndDate = DateTime.Parse(eDate);
            _Con.Contracts.Update(ObjCont);
            _Con.SaveChanges();
            return "updated Contract";
        }
    }
}
