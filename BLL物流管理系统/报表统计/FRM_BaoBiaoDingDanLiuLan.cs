using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;
namespace BLL物流管理系统.报表统计
{
    [ServiceContract]
 public   class FRM_BaoBiaoDingDanLiuLan
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region 时间段查询订单信息
        [OperationContract]
        public DataSet btnChaXun_Select_Click_ChaXunDingDan(string 开始时间, string 结束时间)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@开始时间", SqlDbType.DateTime),
                                                  new SqlParameter("@结束时间", SqlDbType.DateTime)
                                        };
            SQlCMDpas[0].Value = "btnChaXun_Select_Click_ChaXunDingDan";
            SQlCMDpas[1].Value = Convert.ToDateTime(开始时间);
            SQlCMDpas[2].Value = Convert.ToDateTime(结束时间);  
            DataTable dt = myDALMethod.QueryDataTable("报表统计_FRM_BaoBiaoDingDanLiuLan", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
        #region  查询订单明细
        [OperationContract]
        public DataSet dgvDingDan_CellClick_ChaXunDingDanMingXi(string 货运单ID)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@货运单ID", SqlDbType.Int),
                                        };
            SQlCMDpas[0].Value = "dgvDingDan_CellClick_ChaXunDingDanMingXi";
            SQlCMDpas[1].Value = Convert.ToInt32(货运单ID);
            DataTable dt = myDALMethod.QueryDataTable("报表统计_FRM_BaoBiaoDingDanLiuLan", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
    }
}
