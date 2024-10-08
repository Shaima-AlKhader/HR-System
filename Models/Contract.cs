﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Contract
    {
        [Key]
        [Display(Name = "Code")]
        [Column(TypeName = "int")]
        public int ID { get; set; }

        [Display(Name = "Contract Type")]
        [Column(TypeName = "nvarchar(MAX)")]
        public string? ContractType { get; set; }

        [Display(Name = "position")]
        [Column(TypeName = "nvarchar(MAX)")]
        public string? position { get; set; }

        [Display(Name = "salary")]
        [Column(TypeName = "decimal (18, 0)")]
        public decimal? salary { get; set; }

        [Display(Name = "StartDate")]
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }


        [Display(Name = "End Date")]
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        
        [ForeignKey("EmpRef")]
        public int EmpRef { get; set; }
        public Employee? emps { get; set; }
        
    }
}