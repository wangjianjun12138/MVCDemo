using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLogin.Models
{
    /// <summary>
    /// 管理员实体类
    /// </summary>
    [Serializable]
    public class SysAdmin
    {
        public Int32 LoginId { get; set; }
        public String LoginPwd { get; set; }
        public String AdminName { get; set; }
    }
}