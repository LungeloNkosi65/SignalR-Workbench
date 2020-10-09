using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor_WorkBench.Shared
{
   public class Developer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal Experience { get; set; }

        public Developer() { }
       public Developer(int id,string firstName,string secondName,string email,decimal experience)
        {
            Id = id;
            FirstName = firstName;
            LastName = secondName;
            Email = email;
            Experience = experience;
        }
    }
}
