using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Data.ApplicationModels
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string racxa { get; set; }
    }
}
