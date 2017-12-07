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
    class BLL_YongHuQuanXian_Insert
    {
        DALPublic.DALMethod DAL = new DALPublic.DALMethod();
        [OperationContract]
        public DataSet FRM_YongHuQuanXian_Insert_Load_ChaXunQuanXianZu()          //加载用户权限时查询用户
        {
            SqlParameter[] pas = new SqlParameter[] { new SqlParameter("@Type", SqlDbType.Char) };
            pas[0].Value = "FRM_YongHuQuanXian_Insert_Load_ChaXunQuanXianZu";
            DataTable dt = DAL.QueryDataTable("用户权限管理_FRM_YongHuQuanXian_Insert", pas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]
        public DataSet FRM_YongHuQuanXian_Insert_Load_ChaXunYuanGong()
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
        public int FRM_YongHuQuanXian_Insert_btnQueDing_Click(string 账号,string 密码,int 权限组ID,int 员工ID)
        {
            SqlParameter[] pas = new SqlParameter[] { new SqlParameter("@Type",SqlDbType.Char),
                                                        new SqlParameter("@账号",SqlDbType.Char),
                                                        new SqlParameter("@密码",SqlDbType.Char),
                                                        new SqlParameter("@权限组ID",SqlDbType.Int),
                                                        new SqlParameter("@员工ID",SqlDbType.Int)};
            pas[0].Value = "FRM_YongHuQuanXian_Insert_btnQueDing_Click";
            pas[1].Value = 账号;
            pas[2].Value = 密码;
            pas[3].Value = 权限组ID;
            pas[4].Value = 员工ID;
            int count = DAL.UpdateData("用户权限管理_FRM_YongHuQuanXian_Insert",pas);
            return count;
        }
    }
}
