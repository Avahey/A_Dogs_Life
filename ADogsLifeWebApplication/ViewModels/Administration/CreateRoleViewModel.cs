﻿using System.ComponentModel.DataAnnotations;

 namespace ADogsLifeWebApplication.ViewModels.Administration
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}