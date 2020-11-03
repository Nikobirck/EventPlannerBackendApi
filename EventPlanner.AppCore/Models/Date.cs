using System;
using System.Collections.Generic;

namespace EventPlanner.AppCore.Models
{
    public class Date
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Eligible { get; set; }
        public List<Candidate> Candidates { get; set; }

    }
}
