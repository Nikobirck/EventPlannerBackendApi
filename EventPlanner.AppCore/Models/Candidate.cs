using System;
using System.Collections.Generic;

namespace EventPlanner.AppCore.Models
{
    public class Candidate :  User
    {
        public List<Role> Roles { get; set; }
        public Role SelectedRole { get; set; }
    }
}
