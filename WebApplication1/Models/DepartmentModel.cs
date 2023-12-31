﻿using System.ComponentModel.DataAnnotations;

namespace WEXAMMVC.Models
{
    public class DepartmentModel
    {
        [Key]
        public int DepartmentCode { get; set; }
        [Required]
        public string? DepartmentName { get; set; }
        [Required]
        public string? Location { get; set; }
        [Required]
        public int NumberOfPersonals { get; set; }
    }
}
