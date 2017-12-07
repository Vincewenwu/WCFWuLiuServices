using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;
using System.IO;
namespace BLL物流管理系统.车辆状态
{
    [ServiceContract]
    public class FRM_CheLiangZhuangTai
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region  删除车辆
        [OperationContract]
        public int tsbShanChu_Delete_Click_ShanChuCheLiang(string strCheLiangID)
        {
            FRM_CheLiangZhuangTai_Update myFRM_CheLiangZhuangTai_Update = new FRM_CheLiangZhuangTai_Update();
            #region 删除原来的照片
            string strTuPian =myFRM_CheLiangZhuangTai_Update. FRM_CheLiangZhuangTai_Update_Load_IDChaXunCheLiang(strCheLiangID).Tables[0].Rows[0]["车辆照片"].ToString().Trim();
            string[] stWenJianZu = strTuPian.Split(';');
            for (int i = 0; i < stWenJianZu.Length; i++)
            {
                if (File.Exists(stWenJianZu[i]))
                {
                    //如果存在则删除
                    File.Delete(stWenJianZu[i]);
                }
            }
            #endregion
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                          new SqlParameter("@车辆ID", SqlDbType.Int),
                                        };
            SQlCMDpas[0].Value = "tsbShanChu_Delete_Click_ShanChuCheLiang";
            SQlCMDpas[1].Value =Convert.ToInt32( strCheLiangID);

            return myDALMethod.UpdateData("车辆状态_FRM_CheLiangZhuangTai", SQlCMDpas);
            
        }
        #endregion
        #region  多条件查询车辆
        [OperationContract]
        public DataSet btnChaXun_Select_Click_DuoTiaoJianChaXunCheLiang(string strFaCheWangDianID,string strMuDiWangDianID,string strZhuangTaiID,string strSiJiMingCheng)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@状态ID", SqlDbType.Char),
                                                new SqlParameter("@司机名称", SqlDbType.Char),
                                                 new SqlParameter("@发车网点ID", SqlDbType.Char),
                                                  new SqlParameter("@目的网点ID", SqlDbType.Char),
	 
                                        };
            SQlCMDpas[0].Value = "btnChaXun_Select_Click_DuoTiaoJianChaXun";
            SQlCMDpas[1].Value = strZhuangTaiID;
            SQlCMDpas[2].Value =  strSiJiMingCheng;
            SQlCMDpas[3].Value = strFaCheWangDianID;
            SQlCMDpas[4].Value = strMuDiWangDianID;
            DataTable dt = myDALMethod.QueryDataTable("车辆状态_FRM_CheLiangZhuangTai", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
        #region   查询全部车辆
        [OperationContract]
                public DataSet FRM_CheLiangZhuangTai_Load_ChaXunQuanBuCheLiang()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                              
                                        };
            SQlCMDpas[0].Value = "FRM_CheLiangZhuangTai_Load_ChaXunQuanBuCheLiang";

            DataTable dt = myDALMethod.QueryDataTable("车辆状态_FRM_CheLiangZhuangTai", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region   查询网点
        [OperationContract]
        public DataSet FRM_CheLiangZhuangTai_Load_ChaXunWangDian()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                              
                                        };
            SQlCMDpas[0].Value = "FRM_CheLiangZhuangTai_Load_ChaXunWangDian";

            DataTable dt = myDALMethod.QueryDataTable("车辆状态_FRM_CheLiangZhuangTai", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region   查询状态
        [OperationContract]
        public DataSet FRM_CheLiangZhuangTai_Load_ChaXunZhuangTai()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                              
                                        };
            SQlCMDpas[0].Value = "FRM_CheLiangZhuangTai_Load_ChaXunZhuangTai";

            DataTable dt = myDALMethod.QueryDataTable("车辆状态_FRM_CheLiangZhuangTai", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
        #region   更新状态
        [OperationContract]
        public int ToolStripMenuItem_Click_XiuGaiZhuangTai(string 状态ID,string 车辆ID)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@状态ID", SqlDbType.Char),
                                                new SqlParameter("@车辆ID", SqlDbType.Char),
                                        };
            SQlCMDpas[0].Value = "ToolStripMenuItem_Click_XiuGaiZhuangTai";
            SQlCMDpas[1].Value = 状态ID;
            SQlCMDpas[2].Value =车辆ID;
            return myDALMethod.UpdateData("车辆状态_FRM_CheLiangZhuangTai", SQlCMDpas);
           
        }
        #endregion
       
    }
}
