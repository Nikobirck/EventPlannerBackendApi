using System;
using System.Collections.Generic;

namespace EventPlanner.AppCore.Models
{
    public class Event
    {
        public string Name { get; set; }
        public List<Date> SuggestedDates { get; set; }
        public List<Date> PickedDates { get; set; }
        public User Owner { get; set; }
        public List<User> InvitedUsers { get; set; }
        public List<Role> RoleSetup { get; set; }
    }
}
