using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace building_react_and_asp_dot_net_core_applications.Data.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime? DateCompleted { get; set; }
    }
}
