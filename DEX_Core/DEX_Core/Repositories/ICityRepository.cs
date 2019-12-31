using DEX_Core_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEX_Core_WebAPI.Repositories
{
    public interface ICityRepository
    {

        Task<City> GetCity();
        Task<City> CreateCity();
        Task<City> DeleteCity();
    }
}
