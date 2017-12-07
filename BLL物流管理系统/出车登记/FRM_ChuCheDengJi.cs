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
    public class FRM_ChuCheDengJi
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region   ID查询分包信息
        [OperationContract]
        public DataSet myPictureBox_Click_ChaXunFenBao(string strChuCheID)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                                new SqlParameter("@车辆ID", SqlDbType.Char),
                                        };
            SQlCMDpas[0].Value = "myPictureBox_Click_ChaXunFenBao";
            SQlCMDpas[1].Value = strChuCheID;
            DataTable dt = myDALMethod.QueryDataTable("出车登记_FRM_ChuCheDengJi", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
           #region   出车修改车辆状态
       
        #endregion 
        #region   查询全部车辆
        [OperationContract]
        public DataSet FRM_ChuCheDengJi_Load_ChaXunQuanBuCheLiang()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                              
                                        };
            SQlCMDpas[0].Value = "FRM_ChuCheDengJi_Load_ChaXunQuanBuCheLiang";

            DataTable dt = myDALMethod.QueryDataTable("出车登记_FRM_ChuCheDengJi", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion


        #region   查询全部车辆
        [OperationContract]
        public DataSet FRM_ChuCheDengJi_Load_ChaXunCheLiang()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                              
                                        };
            SQlCMDpas[0].Value = "FRM_ChuCheDengJi_Load_ChaXunCheLiang";

            DataTable dt = myDALMethod.QueryDataTable("出车登记_FRM_ChuCheDengJi", SQlCMDpas);
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

            DataTable dt = myDALMethod.QueryDataTable("出车登记_FRM_ChuCheDengJi", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
        #region   查询网点
        [OperationContract]
        public DataSet FRM_ChuCheDengJi_Load_ChaXunWangDian()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),

                                        };
            SQlCMDpas[0].Value = "FRM_ChuCheDengJi_Load_ChaXunWangDian";

            DataTable dt = myDALMethod.QueryDataTable("出车登记_FRM_ChuCheDengJi", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region   查询状态
        [OperationContract]
        public DataSet FRM_ChuCheDengJi_Load_ChaXunZhuangTai()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),

                                        };
            SQlCMDpas[0].Value = "FRM_ChuCheDengJi_Load_ChaXunZhuangTai";

            DataTable dt = myDALMethod.QueryDataTable("出车登记_FRM_ChuCheDengJi", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
        [OperationContract]
        public int FRM_ChuCheDengJi_tsbChuChe_Click_UpdateChuChe(int 车辆ID)
        {
            SqlParameter[] sqlPas = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                new SqlParameter("@车辆ID",SqlDbType.Int),
                                    };
            sqlPas[0].Value = "FRM_ChuCheDengJi_tsbChuChe_Click_UpdateChuChe";
            sqlPas[1].Value = 车辆ID;
            return myDALMethod.UpdateData("出车登记_FRM_ChuCheDengJi", sqlPas);
        }
        #region  ID查询车辆
        [OperationContract]
        public DataSet FRM_ChuCheDengJi_IDChaXunCheLiangZhuangTai(string strCheLiangID)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@车辆ID", SqlDbType.Int),
                                        };
            SQlCMDpas[0].Value = "FRM_ChuCheDengJi_IDChaXunCheLiangZhuangTai";
            SQlCMDpas[1].Value = Convert.ToInt32(strCheLiangID);
            DataTable dt = myDALMethod.QueryDataTable("出车登记_FRM_ChuCheDengJi", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
    }
}
