using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data.SqlClient;
using System.Data;

namespace BLL物流管理系统.司机管理
{
     [ServiceContract]
    class BLL_FRM_XuanZheJiGou
    {
        DALPublic.DALMethod DAL = new DALPublic.DALMethod();
        [OperationContract]
        public DataSet FRM_XuanZheJiGou_Load_ChaXunJiGouZuZhi(int 机构组织ID)
        {
            SqlParameter[] pas = new SqlParameter[] { 
                new SqlParameter("@Type", SqlDbType.Char), 
                new SqlParameter("@机构组织ID",SqlDbType.Int) 
            };
            pas[0].Value = "FRM_XuanZheJiGou_Load_ChaXunJiGouZuZhi";
            pas[1].Value = 机构组织ID;
            DataTable dt = DAL.QueryDataTable("司机管理_FRM_XuanZheJiGou", pas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
