using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;
namespace BLL物流管理系统.出车登记
{
    [ServiceContract]
    public class FRM_DaoDaDengJi
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region   车辆ID查询发货单ID
        [OperationContract]
        public int btnDaoDa_Click_ChaXunFaCheDian(string 车辆ID, string 到达网点ID)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                                new SqlParameter("@车辆ID", SqlDbType.Char),
                                        };
            SQlCMDpas[0].Value = "btnDaoDa_Click_ChaXunFaCheDian";
            SQlCMDpas[1].Value = 车辆ID;
            DataTable dt = myDALMethod.QueryDataTable("出车登记_FRM_DaoDaDengJi", SQlCMDpas);
            int j = 0;
            for(int i=0;i<dt.Rows.Count;i++ )
            {
             j= btnDaoDa_Click_ChaRuGenZongBiao(到达网点ID, dt.Rows[i]["配载发车单ID"].ToString());
            }
   
            return j;
        }
        #endregion
        #region   添加跟踪记录
        [OperationContract]
        public int btnDaoDa_Click_ChaRuGenZongBiao(string 到达网点ID, string 配载发车单ID)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                                new SqlParameter("@到达网点ID", SqlDbType.Char),
                                                 new SqlParameter("@配载发车单ID", SqlDbType.Char),
                                        };
            SQlCMDpas[0].Value = "btnDaoDa_Click_ChaRuGenZongBiao";
            SQlCMDpas[1].Value = 到达网点ID;
            SQlCMDpas[2].Value = 配载发车单ID;
            return myDALMethod.UpdateData("出车登记_FRM_DaoDaDengJi", SQlCMDpas);

        }
        #endregion


        #region   查询未发送邮件的跟踪记录
        [OperationContract]
        public DataTable ShiJianDuanFaSongYouJian( )
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),   
                                        };
            SQlCMDpas[0].Value = "ShiJianDuanFaSongYouJian"; 
            return myDALMethod.QueryDataTable("出车登记_FRM_DaoDaDengJi", SQlCMDpas);

        }
        #endregion
        #region   添加跟踪记录
        [OperationContract]
        public int FaYouJianHouGengXinWuLiuGenZong(string  物流跟踪ID)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                                new SqlParameter("@物流跟踪ID", SqlDbType.Char),
                                                 
                                        };
            SQlCMDpas[0].Value = "FaYouJianHouGengXinWuLiuGenZong";
            SQlCMDpas[1].Value = 物流跟踪ID; 
            return myDALMethod.UpdateData("出车登记_FRM_DaoDaDengJi", SQlCMDpas);

        }
        #endregion
        #region    
        [OperationContract]
        public DataSet FRM_DaoDaDengJi_IDChaXunCheLiangZhuangTai(int 车辆ID)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                                new SqlParameter("@车辆ID", SqlDbType.Int),

                                        };
            SQlCMDpas[0].Value = "FRM_DaoDaDengJi_IDChaXunCheLiangZhuangTai";
            SQlCMDpas[1].Value = 车辆ID;
            DataTable dt = myDALMethod.QueryDataTable("出车登记_FRM_DaoDaDengJi", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
        #region   查询全部车辆
        [OperationContract]
        public DataSet FRM_DaoDaDengJi_Load_ChaXunQuanBuCheLiang()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),

                                        };
            SQlCMDpas[0].Value = "FRM_DaoDaDengJi_Load_ChaXunQuanBuCheLiang";

            DataTable dt = myDALMethod.QueryDataTable("出车登记_FRM_DaoDaDengJi", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion    
        #region    
        [OperationContract]
        public DataSet FRM_DaoDaDengJi_Load_ChaXunWangDian()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),

                                        };
            SQlCMDpas[0].Value = "FRM_DaoDaDengJi_Load_ChaXunWangDian";

            DataTable dt = myDALMethod.QueryDataTable("出车登记_FRM_DaoDaDengJi", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion 
        #region    
        [OperationContract]
        public DataSet FRM_DaoDaDengJi_Load_ChaXunZhuangTai()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),

                                        };
            SQlCMDpas[0].Value = "FRM_DaoDaDengJi_Load_ChaXunZhuangTai";

            DataTable dt = myDALMethod.QueryDataTable("出车登记_FRM_DaoDaDengJi", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
        #region   查询配载发车单明细
        [OperationContract]
        public DataSet pb_MouseClick_ChaXunMingXi(int 配载发车单ID)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                             new SqlParameter("@配载发车单ID", SqlDbType.Int),

                                        };
            SQlCMDpas[0].Value = "pb_MouseClick_ChaXunMingXi";
            SQlCMDpas[1].Value = 配载发车单ID;

            DataTable dt = myDALMethod.QueryDataTable("出车登记_FRM_DaoDaDengJi", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
    }
}
