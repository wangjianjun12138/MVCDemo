using MvcDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcDemo.DAL
{
    public class AccountContext:DbContext
    {
        public AccountContext()
            : base("AccountContext")
        { 
        
        }

        public DbSet<SysUser> SysUsers { get; set; }
        public DbSet<SysRole> SysUsers { get; set; }
        public DbSet<SysUserRole> SysUsers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }
    }
}