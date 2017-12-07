using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data.SqlClient;
using System.Data;

namespace BLL物流管理系统.用户权限管理
{
     [ServiceContract]
    class BLL_XuanZheQuanXianZu
    {
        DALPublic.DALMethod DAL = new DALPublic.DALMethod();

        [OperationContract]
        public DataSet FRM_XuanZheQuanXianZu_Load_ChaXunQuanXianZu()          //查询权限组
        {
            SqlParameter[] pas = new SqlParameter[] { new SqlParameter("@Type", SqlDbType.Char) };
            pas[0].Value = "FRM_YongHuQuanXian_Insert_Load_ChaXunQuanXianZu";
            DataTable dt = DAL.QueryDataTable("用户权限管理_FRM_YongHuQuanXian_Insert", pas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public int FRM_XuanZheQuanXianZu_btnQueDing_Click(int 用户ID,int 权限组ID)          //修改权限组
        {
            SqlParameter[] pas = new SqlParameter[] { new SqlParameter("@用户ID", SqlDbType.Int),new SqlParameter("@权限组ID",SqlDbType.Int) };
            pas[0].Value = 用户ID;
            pas[1].Value = 权限组ID;
            int count = DAL.UpdateData("用户权限管理_FRM_XuanZheQuanXianZu", pas);
            return count;
        }
    }
}
