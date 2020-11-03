using System;
namespace EventPlanner.AppCore.Models
{
    public class Role
    {
        public string Name { get; set; }
        public bool Required { get; set; }
        public int Priority { get; set; }
        public int Amount { get; set; }
    }
}
