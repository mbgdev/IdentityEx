using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityEx.Models
{
    public class AppUser: IdentityUser<int>
    {
        [StringLength(11)]
        public string? TCNO { get; set; }
    }
}
