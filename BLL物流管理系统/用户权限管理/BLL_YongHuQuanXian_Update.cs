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
    class BLL_YongHuQuanXian_Update
    {
        DALPublic.DALMethod DAL = new DALPublic.DALMethod();

        [OperationContract]
        public DataSet FRM_YongHuQuanXian_Update_ChaXunQuanXianZu()          //查询权限组
        {
            SqlParameter[] pas = new SqlParameter[] { new SqlParameter("@Type", SqlDbType.Char) };
            pas[0].Value = "FRM_YongHuQuanXian_Insert_Load_ChaXunQuanXianZu";
            DataTable dt = DAL.QueryDataTable("用户权限管理_FRM_YongHuQuanXian_Insert", pas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet FRM_YongHuQuanXian_Update_Load_ChaXunYuanGong()                 //查询员工
        {
            SqlParameter[] pas = new SqlParameter[] { new SqlParameter("@Type", SqlDbType.Char)
                                                    };
            pas[0].Value = "FRM_YongHuQuanXian_Insert_Load_ChaXunYuanGong";
            DataTable dt = DAL.QueryDataTable("用户权限管理_FRM_YongHuQuanXian_Insert", pas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //btnQueDing_Click
        [OperationContract]
        public int FRM_YongHuQuanXian_Update_btnQueDing_Click(string 账号, string 密码, int 权限组ID, int 员工ID,int 用户ID)
        {
            SqlParameter[] pas = new SqlParameter[] { new SqlParameter("@Type",SqlDbType.Char),
                                                        new SqlParameter("@账号",SqlDbType.Char),
                                                        new SqlParameter("@密码",SqlDbType.Char),
                                                        new SqlParameter("@权限组ID",SqlDbType.Int),
                                                        new SqlParameter("@员工ID",SqlDbType.Int),
                                                        new SqlParameter("@用户ID",SqlDbType.Int)};
            pas[0].Value = "FRM_YongHuQuanXian_Update_btnQueDing_Click";
            pas[1].Value = 账号;
            pas[2].Value = 密码;
            pas[3].Value = 权限组ID;
            pas[4].Value = 员工ID;
            pas[5].Value = 用户ID;
            int count = DAL.UpdateData("用户权限管理_FRM_YongHuQuanXian_Update", pas);
            return count;
        }
    }
}
