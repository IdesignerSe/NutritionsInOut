using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionsInOut.Models
{
    public class ProgramHabit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DietType { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
    }
}
