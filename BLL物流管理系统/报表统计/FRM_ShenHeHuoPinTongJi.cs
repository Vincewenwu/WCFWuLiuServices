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
  public  class FRM_ShenHeHuoPinTongJi
  {
      DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
      #region 时间段查询订单信息
      [OperationContract]

      public DataSet FRM_ShenHeHuoPinTongJi_Load_ChaXunHuiZong()
      {
          SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char), 
                                        };
          SQlCMDpas[0].Value = "FRM_ShenHeHuoPinTongJi_Load_ChaXunHuiZong";
          DataTable dt = myDALMethod.QueryDataTable("报表统计_FRM_ShenHeHuoPinTongJi", SQlCMDpas);
          DataSet ds = new DataSet();
          ds.Tables.Add(dt);
          return ds;
      }
      #endregion
    }
}
