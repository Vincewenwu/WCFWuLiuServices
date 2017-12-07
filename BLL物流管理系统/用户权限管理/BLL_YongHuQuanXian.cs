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
    class BLL_YongHuQuanXian
    {
        DALPublic.DALMethod DAL = new DALPublic.DALMethod();
        [OperationContract]
        public DataSet FRM_YongHuQuanXian_Load_ChaXunYongHu()          //加载用户权限时查询用户
        {
            SqlParameter[] pas = new SqlParameter[] {new SqlParameter("@Type",SqlDbType.Char) };
            pas[0].Value = "FRM_YongHuQuanXian_Load_ChaXunQueXian";
            DataTable dt = DAL.QueryDataTable("用户权限管理_FRM_YongHuQuanXian",pas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]
        public int FRM_YongHuQuanXian_btnYongHu_Del_Click(int 用户ID)
        {
            SqlParameter[] pas = new SqlParameter[] { new SqlParameter("@Type", SqlDbType.Char),
                                                      new SqlParameter("@用户ID", SqlDbType.Int)
                                                    };
            pas[0].Value = "FRM_YongHuQuanXian_btnYongHu_Del_Click";
            pas[1].Value = 用户ID;
            int i = DAL.UpdateData("用户权限管理_FRM_YongHuQuanXian", pas);
            return i;
        }
    }
}
