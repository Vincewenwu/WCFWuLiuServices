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
    class BLL_QuanXianZu_Insert
    {
        DALPublic.DALMethod DAL = new DALPublic.DALMethod();
        [OperationContract]
        public DataSet FRM_QuanXianZu_Insert_Load_ChaXunMoKuai()
        {
            SqlParameter[] pas = new SqlParameter[] { new SqlParameter("@Type", SqlDbType.Char) };
            pas[0].Value = "FRM_QuanXianZu_Insert_Load_ChaXunMoKuai";
            DataTable dt = DAL.QueryDataTable("用户权限管理_FRM_QuanXianZu_Insert", pas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]
        public int FRM_QuanXianZu_Insert_btnQueDing_Click_TianJiaQuanXianZu(int[] 模块ID,string 权限组名称)
        {
            SqlParameter[] pas = new SqlParameter[] {new SqlParameter("@Type",SqlDbType.Char),
                                                      new SqlParameter("@权限组名称",SqlDbType.Char)};
            pas[0].Value = "FRM_QuanXianZu_Insert_btnQueDing_Click_TianJiaQuanXianZu";
            pas[1].Value = 权限组名称;
            DataTable dt = DAL.QueryDataTable("用户权限管理_FRM_QuanXianZu_Insert",pas);

            int 权限组ID=Convert.ToInt32(dt.Rows[0][0]);


            int count = 0;
            for (int i = 0; i < 模块ID.Length; i++)
            {
                SqlParameter[] pasMoKuai = new SqlParameter[]{new SqlParameter("@Type",SqlDbType.Char),new SqlParameter("@权限组ID",SqlDbType.Int),
                                                       new SqlParameter("@模块ID",SqlDbType.Int)};
                pasMoKuai[0].Value="FRM_QuanXianZu_Insert_btnQueDing_Click_TianJiaQuanXianZu_TianJiaMoKuai";
                pasMoKuai[1].Value = 权限组ID;
                pasMoKuai[2].Value = 模块ID[i];
                DAL.UpdateData("用户权限管理_FRM_QuanXianZu_Insert", pasMoKuai);
                count++;
            }

            if ((count) == 模块ID.Length)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
