using System;
using System.Collections.Generic;

namespace EventPlanner.AppCore
{
    public class User
    {
        public string Name { get; set; }
        public List<User> Friends { get; set; }
    }
}
