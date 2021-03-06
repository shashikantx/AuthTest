using AspNetCore.Identity.MongoDbCore.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthTest.Server.Models
{
    public class ApplicationUser : MongoIdentityUser<Guid>
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}
