using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityEx.Models
{
    public class AppRole:IdentityRole<int>
    {

        public string Description { get; set; }
    }
}
