using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreData.Model
{
   public class User:IdentityUser
    {

        public IEnumerable<User> GetUsers() 
        {

            return new List<User>() { new User() { UserName="张三",PasswordHash="123" } };
        }
    }
}
