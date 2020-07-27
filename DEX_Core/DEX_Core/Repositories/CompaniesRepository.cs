﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DEX_Core_WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using DEX_Core_WebAPI.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace DEX_Core_WebAPI.Repositories
{
    public class CompaniesRepository : ICompaniesRepository
    {
        private Dex_CoreDbContext _db = new Dex_CoreDbContext();

        public Task<Company[]> GetAllCompaniesAsync(int CityID)
        {
            return _db.Companies.Where(c => c.CityId == CityID).ToArrayAsync();
        }

        //public void Add<T>(T entity) where T : class
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<Company> CreateCompany(Company company)
        {
            _db.Companies.Add(company);
            if (await _db.SaveChangesAsync())
            {
                return OK();
            }
            
            
        }

        public Task<Company[]> GetAllCompaniesAsync()
        {
            throw new NotImplementedException();
        }

        //public void Delete<T>(T entity) where T : class
        //{
        //    throw new NotImplementedException();
        //}


    }
}
