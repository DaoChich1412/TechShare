﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechShare.Models
{
    public class AppUser:IdentityUser
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Gender { get; set; }
        public string Job { get; set; }
    }
}
