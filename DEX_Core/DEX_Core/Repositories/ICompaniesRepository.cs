using DEX_Core_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEX_Core_WebAPI.Repositories
{
    public interface ICompaniesRepository
    {
        //General

        void Add(Company company);
        void SaveAllChangesAsync();
        //void Delete<T>(T entity) where T : class;

        //Companies
        Task<Company[]> GetAllCompaniesAsync(int ID);


    }
}
