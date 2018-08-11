using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MvcLogin.Models
{
    /// <summary>
    /// 管理员数据访问类
    /// </summary>
    public class SysAdminService
    {
        /// <summary>
        /// 根据账号和密码登录
        /// </summary>
        /// <param name="sysAdmin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin sysAdmin)
        {
            String sql = "select AdminName From Admins where LoginId={0} and LoginPwd='{1}'";
            sql = String.Format(sql,sysAdmin.LoginId,sysAdmin.LoginPwd);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            if (objReader.Read())
            {
                sysAdmin.AdminName = objReader["AdminName"].ToString();
            }
            else
            {
                sysAdmin = null;
            }
            objReader.Close();
            return sysAdmin;
        }
    }
}