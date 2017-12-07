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
    class BLL_QuanXianZu
    {
        DALPublic.DALMethod DAL = new DALPublic.DALMethod();
        [OperationContract]
        public DataSet FRM_QuanXianZu_Load_ChaXunQuanXianZu()
        {
            SqlParameter[] pas = new SqlParameter[] { new SqlParameter("@Type", SqlDbType.Char) };
            pas[0].Value = "FRM_QuanXianZu_Load_ChaXunQuanXianZu";
            DataTable dt = DAL.QueryDataTable("用户权限管理_FRM_QuanXianZu", pas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet FRM_QuanXianZu_dgvAuthGroup_CellClick_ChaXunMoKuai(int 权限组ID)
        {
            SqlParameter[] pas = new SqlParameter[] { new SqlParameter("@Type", SqlDbType.Char),
                                                       new SqlParameter("@权限组ID",SqlDbType.Int) };
            pas[0].Value = "FRM_QuanXianZu_dgvAuthGroup_CellClick_ChaXunMoKuai";
            pas[1].Value = 权限组ID;
            DataTable dt = DAL.QueryDataTable("用户权限管理_FRM_QuanXianZu", pas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public int FRM_QuanXianZu_btnDelQuanXianZu_Click(int 权限组ID)
        {
            SqlParameter[] pas = new SqlParameter[] { new SqlParameter("@Type", SqlDbType.Char),
                                                       new SqlParameter("@权限组ID",SqlDbType.Int) };
            pas[0].Value = "FRM_QuanXianZu_btnDelQuanXianZu_Click";
            pas[1].Value = 权限组ID;
            int flag = DAL.UpdateData("用户权限管理_FRM_QuanXianZu", pas);

            return flag;
        }
    }
}
