using DEX_Core_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEX_Core_WebAPI.ViewModels
{
    public class CompanyViewModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string CityName { get; set; }
        public IList<Contact> Contacts { get; set; }
    }
}
