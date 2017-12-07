using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;

namespace BLL物流管理系统.司机管理
{
    [ServiceContract]
    class BLL_FRM_SiJiGuanLi
    {
        DALPublic.DALMethod DAL = new DALPublic.DALMethod();
        [OperationContract]
        public DataSet FRM_SiJiGuanLi_Load_ChaXunSiJiXinXi()
        {
            SqlParameter[] pas = new SqlParameter[] { new SqlParameter("@Type", SqlDbType.Char) };
            pas[0].Value = "FRM_SiJiGuanLi_Load_ChaXunSiJiXinXi";
            DataTable dt = DAL.QueryDataTable("司机管理_FRM_SiJiGuanLi", pas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public bool tsbShanChu_Delete_Click_ShanChu(int 司机ID)
        {
            SqlParameter[] pas = new SqlParameter[] { new SqlParameter("@Type", SqlDbType.Char),new SqlParameter("@司机ID",SqlDbType.Int) };
            pas[0].Value = "tsbShanChu_Delete_Click_ShanChu";
            pas[1].Value = 司机ID;
            if (DAL.UpdateData("司机管理_FRM_SiJiGuanLi", pas) > 0)
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
