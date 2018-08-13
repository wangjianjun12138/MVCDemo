using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemo.ViewModels
{
    public class SysUser
    {
        public Int32 ID { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
       
        public virtual ICollection<SysUserRole> SysUserRoles{get;set;}
    }

    public class SysRole
    {
        public Int32 ID { get; set; }
        public String RoleName { get; set; }
        public String RoleDesc { get; set; }
        public virtual ICollection<SysUserRole> SysUserRoles{get;set;}
    }

    public class SysUserRole
    {
        public Int32 ID { get; set; }
        public Int32 SysUserID { get; set; }
        public Int32 SysRoleID { get; set; }
        public virtual SysUser SysUser { get; set; }
        public virtual SysRole SysRole { set;set; }
    }
}