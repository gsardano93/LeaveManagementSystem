﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeEditVM: BaseLeaveTypeVM
    {
       
        [Required]
        [Length(4, 100, ErrorMessage = "Lenght requirement violated")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(1, 90)]
        [Display(Name = "Maximum allocation of days")]

        public int NumberOfDays { get; set; }
    }
}
