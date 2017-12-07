using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;
namespace BLL物流管理系统.报表统计
{
    [ServiceContract]
   public class FRM_DingDanBaoBiao
    {
       DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
       #region ID查询订单信息
        [OperationContract]
       public DataSet FRM_DingDanBaoBiao_Load_ChaXunDingDan(string 货运单ID)
       {
           SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@货运单ID", SqlDbType.Int)
                                        };
           SQlCMDpas[0].Value = "FRM_DingDanBaoBiao_Load_ChaXunDingDan";
           SQlCMDpas[1].Value = Convert.ToInt32(货运单ID);
           DataTable dt = myDALMethod.QueryDataTable("报表统计_FRM_DingDanBaoBiao", SQlCMDpas);
           DataSet ds = new DataSet();
           ds.Tables.Add(dt); 
           return ds;
       }
       #endregion
        #region  查询订单明细
        [OperationContract]
        public DataSet FRM_DingDanBaoBiao_Load_ChaXunMingXi(string 货运单ID)
        {
             SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@货运单ID", SqlDbType.Int)
                                        };
             SQlCMDpas[0].Value = "FRM_DingDanBaoBiao_Load_ChaXunMingXi";
           SQlCMDpas[1].Value = Convert.ToInt32(货运单ID);

            
            DataTable dt = myDALMethod.QueryDataTable("报表统计_FRM_DingDanBaoBiao", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
    }
}
