using System;
using System.Collections.Generic;
using System.Text;
using DAL.RepoPattern.Context;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class RestoranDbContext : EntityContextBase<RestoranDbContext>
    {
        public RestoranDbContext(DbContextOptions<RestoranDbContext> options) : base (options)
        {
            
        }
    }
}
