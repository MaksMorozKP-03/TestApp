using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models
{
    class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Rank { get; set; }
        public string SymbolUrl { get; set; }
        public double TotalSupply { get; set; }
        public double  MaxSupply { get; set; }
        public double DailyPriceChange { get; set; }
        public DateTime LastUpdated { get; set; }   

    }
}
