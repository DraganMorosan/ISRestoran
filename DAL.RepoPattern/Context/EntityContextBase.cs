using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL.RepoPattern.Context
{
    public class EntityContextBase<TContext> : DbContext, IEntityContext where TContext : DbContext
    {
        public EntityContextBase()
        {
                
        }

        public EntityContextBase(DbContextOptions<TContext> options ) : base (options)
        {
            
        }
    }
}
