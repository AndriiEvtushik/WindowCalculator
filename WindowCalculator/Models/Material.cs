using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowCalculator.Models
{
    public partial class Material
    {
        public int Id { get; set; }
        public string? Category { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        public double PricePerM2 { get; set; }
        public string? Description { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Category}) - {PricePerM2} грн/м²";
        }

    }
}
