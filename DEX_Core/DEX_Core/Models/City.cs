using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEX_Core_WebAPI.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Company> Companies { get; set; }
    }
}
