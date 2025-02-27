﻿using System.ComponentModel.DataAnnotations;

namespace BloodBank.ViewModels.BloodGroups
{
    public class BloodGroupAddViewModel
    {
        [MaxLength(50, ErrorMessage = "{0} can have a max of {1} characters")]
        [Required(ErrorMessage = "{0} is required")]
        public string Name { get; set; }
        [MaxLength(100, ErrorMessage = "{0} can have a max of {1} characters")]
        [Required(ErrorMessage = "{0} is required")]
        public string Description { get; set; }
    }
}
