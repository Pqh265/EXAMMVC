﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WEXAMMVC.Models;


namespace EXAMMVC.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeCode { get; set; }


        [Required]
        public string? EmployeeName { get; set; }


        [Required]
        public int DepartmentCode { get; set; }
        [ForeignKey("DepartmentCode")]  // Chỉ định khóa ngoại
        public DepartmentModel? Department { get; set; }


        [Required]
        public int Rank { get; set;}
    }
}
