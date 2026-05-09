using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WindowCalculator.Models
{
    public class Order
    {
        public int Id { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int Sections { get; set; }
        public int OpeningSections { get; set; }
        public double TotalPrice { get; set; }
    }
}
