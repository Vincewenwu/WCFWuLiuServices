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
   public class FRM_YuanGongGongZuoZheng
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region 更新员工图片
        [OperationContract]

        public int btnShangChuan_Click_UpdateYuanGong(byte[] 照片)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char), 
                                              new SqlParameter("@照片", SqlDbType.Image), 

                                        };
            SQlCMDpas[0].Value = "btnShangChuan_Click_UpdateYuanGong";
            SQlCMDpas[1].Value = 照片;

         int i = myDALMethod.UpdateData("报表统计_FRM_YuanGongGongZuoZheng", SQlCMDpas);

         return i;
        }
        #endregion


        #region 查询员工信息
        [OperationContract]

        public DataSet FRM_YuanGongGongZuoZhengDaYin_Load_ChaXunYuanGong()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char), 
                                        };
            SQlCMDpas[0].Value = "FRM_YuanGongGongZuoZhengDaYin_Load_ChaXunYuanGong";
            DataTable dt = myDALMethod.QueryDataTable("报表统计_FRM_YuanGongGongZuoZheng", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
    }
}
