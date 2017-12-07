using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;

namespace BLL物流管理系统.用户权限管理
{
    [ServiceContract]
    class BLL_authCheck
    {
        DALPublic.DALMethod DAL = new DALPublic.DALMethod();
        [OperationContract]
        public bool BLL_authCheck_checkAuthByType(string 窗体名称, int 权限组ID)
        {
            SqlParameter[] pas = {
                                     new SqlParameter("@Type",SqlDbType.Char),
                                     new SqlParameter("@窗体名称",SqlDbType.Char),
                                     new SqlParameter("@权限组ID",SqlDbType.Int),
                                 };
            pas[0].Value = "BLL_authCheck_checkAuthByType";
            pas[1].Value = 窗体名称;
            pas[2].Value = 权限组ID;

            DataTable dt = DAL.QueryDataTable("用户权限管理_authCheck", pas);

            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
