using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.Entity.Concrete
{
    public class CustomIdentityUser : IdentityUser
    {
        public virtual Customer Customer { get; set; }
    }
}
