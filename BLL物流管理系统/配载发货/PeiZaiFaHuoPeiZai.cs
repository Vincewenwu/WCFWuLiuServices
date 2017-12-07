using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;

namespace BLL物流管理系统.配载发货
{
    [ServiceContract]
   public  class PeiZaiFaHuoPeiZai
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        [OperationContract]
        #region 查询配载发车单
        public DataSet FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDan()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char), };
            SQLCMDpas[0].Value = "FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDan";
            DataTable MyDataTable = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(MyDataTable);
            return myDataSet;
        } 
        #endregion
        [OperationContract]
        #region 查询配载发车明细单
        public DataSet FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMingXiByFaCheID(int 配载发车单ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char),
                                          new SqlParameter("@配载发车单ID",SqlDbType.Char),};
            SQLCMDpas[0].Value = "FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMingXiByFaCheID";
            SQLCMDpas[1].Value = 配载发车单ID;
            DataTable MyDataTable = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(MyDataTable);
            return myDataSet;
        } 
        #endregion
        [OperationContract]
         #region 查询配载发车状态
        public DataSet FRM_PeiZaiFaHuoPeiZai_SelectFaCheZhuangTaiByPeiZaiFaCheID(int 配载发车单ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char),
                                          new SqlParameter("@配载发车单ID",SqlDbType.Char),};
            SQLCMDpas[0].Value = "FRM_PeiZaiFaHuoPeiZai_SelectFaCheZhuangTaiByPeiZaiFaCheID";
            SQLCMDpas[1].Value = 配载发车单ID;
            DataTable MyDataTable = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(MyDataTable);
            return myDataSet;
        } 
        #endregion
        #region 取消锁定
        [OperationContract]
        public int frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(int 分包ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char),
                                        new SqlParameter("@分包ID",SqlDbType.Int),};
            SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing";
            SQLCMDpas[1].Value = 分包ID;
            int count = myDALMethod.UpdateData("配载发货_FRM_PeiZaiFaHuo_insert", SQLCMDpas);
            return count;
        }
        #endregion
        #region 删除配载明细表
        [OperationContract]
        public int frmPeiZaiFaHuo_Update_DeletePeiZaiMingXiByFenBaoID(int 分包ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char)
                                          ,new SqlParameter("@分包ID",SqlDbType.Int),};
            SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Update_DeletePeiZaiMingXiByFenBaoID";
            SQLCMDpas[1].Value = 分包ID;
            int count = myDALMethod.UpdateData("配载发货_FRM_PeiZaiFaHuoPeiZai_Update", SQLCMDpas);
            return count;
        }
        #endregion
        #region 删除配载表
        [OperationContract]
        public int FRM_PeiZaiFaHuoPeiZai_DeletePeiZaiDanByID(int 配载发车单ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char)
                                          ,new SqlParameter("@配载发车单ID",SqlDbType.Int),};
            SQLCMDpas[0].Value = "FRM_PeiZaiFaHuoPeiZai_DeletePeiZaiDanByID";
            SQLCMDpas[1].Value = 配载发车单ID;
            int count = myDALMethod.UpdateData("配载发货_FRM_PeiZaiFaHuoPeiZai", SQLCMDpas);
            return count;
        }
        #endregion
        #region 删除配载明细表
        [OperationContract]
        public int FRM_PeiZaiFaHuoPeiZai_DeletePeiZaiDanMingXiByID(int 配载发车单ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char)
                                          ,new SqlParameter("@配载发车单ID",SqlDbType.Int),};
            SQLCMDpas[0].Value = "FRM_PeiZaiFaHuoPeiZai_DeletePeiZaiDanMingXiByID";
            SQLCMDpas[1].Value = 配载发车单ID;
            int count = myDALMethod.UpdateData("配载发货_FRM_PeiZaiFaHuoPeiZai", SQLCMDpas);
            return count;
        }
        #endregion
        #region  如果发车状态为4，待装货，删除配载单时司机状态变为无任务状态
        [OperationContract]
        public int frmPeiZaiFaHuo_Update_UpdateSiJiZhuangTaiBySiJiID(int 司机ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char),
                                        new SqlParameter("@司机ID",SqlDbType.Int),};
            SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Update_UpdateSiJiZhuangTaiBySiJiID";
            SQLCMDpas[1].Value = 司机ID;
            int count = myDALMethod.UpdateData("配载发货_FRM_PeiZaiFaHuoPeiZai_Update", SQLCMDpas);
            return count;
        }
        #endregion  
        #region 如果发车状态为4，待装货，删除配载单时此车辆变为空闲
        [OperationContract]
        public int frmPeiZaiFaHuo_Update_UpdateCheLiangZhuangTaiByID(int 车辆ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char)
                                          ,new SqlParameter("@车辆ID",SqlDbType.Int),};
            SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Update_UpdateCheLiangZhuangTaiByID";
            SQLCMDpas[1].Value = 车辆ID;
            int count = myDALMethod.UpdateData("配载发货_FRM_PeiZaiFaHuoPeiZai_Update", SQLCMDpas);
            return count;
        }
        #endregion
       
        [OperationContract]
        #region 查询下拉框发车状态
        public DataSet FRM_PeiZaiFaHuoPeiZai_SelectCboFaCheZhaungTai()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char),
                                          };
            SQLCMDpas[0].Value = "FRM_PeiZaiFaHuoPeiZai_SelectCboFaCheZhaungTai";
            DataTable MyDataTable = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(MyDataTable);
            return myDataSet;
        }
        #endregion
        [OperationContract]
        #region 查询配载发车状态
        public DataSet FRM_PeiZaiFaHuoPeiZai_MoHuSelectPeiZaiFaCheDan(
            DateTime 起始时间,DateTime 结束时间,int 发车状态ID,string 配载发车单号)
        {
            SqlParameter[] SQLCMDpas = {  new SqlParameter("@type", SqlDbType.Char),
                                          new SqlParameter("@起始时间",SqlDbType.DateTime),
                                          new SqlParameter("@结束时间",SqlDbType.DateTime),
                                          new SqlParameter("@发车状态ID",SqlDbType.Int),
                                          new SqlParameter("@配载发车单号",SqlDbType.Char),};
            SQLCMDpas[0].Value = "FRM_PeiZaiFaHuoPeiZai_MoHuSelectPeiZaiFaCheDan";
            SQLCMDpas[1].Value = 起始时间;
            SQLCMDpas[2].Value = 结束时间;
            SQLCMDpas[3].Value = 发车状态ID;
            SQLCMDpas[4].Value = 配载发车单号;
            DataTable MyDataTable = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(MyDataTable);
            return myDataSet;
        }
        #endregion
        [OperationContract]
        #region 查询网点通过线路Id 
        public DataSet FRM_PeiZaiFaHuoPeiZai_SelectWangDianByByXianLu(int 线路ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char),
                                         new SqlParameter("@线路ID", SqlDbType.Int),
                                          };
            SQLCMDpas[0].Value = "FRM_PeiZaiFaHuoPeiZai_SelectWangDianByByXianLu";
            SQLCMDpas[1].Value = 线路ID;
            DataTable MyDataTable = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(MyDataTable);
            return myDataSet;
        }
        #endregion

        [OperationContract]
        public DataSet FRM_PeiZaiFaHuoPeiZai_Load_SelectFaCheZhuangTai()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char),
                                          };
            SQLCMDpas[0].Value = "FRM_PeiZaiFaHuoPeiZai_Load_SelectFaCheZhuangTai";
            DataTable MyDataTable = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(MyDataTable);
            return myDataSet;
        }


        [OperationContract]
        public int FRM_PeiZaiFaHuoPeiZai_btnChuCheShenQing_Click_UpdateCheLiangZhuangTai(int 配载发车单ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char)
                                          ,new SqlParameter("@配载发车单ID",SqlDbType.Int),};
            SQLCMDpas[0].Value = "FRM_PeiZaiFaHuoPeiZai_btnChuCheShenQing_Click_UpdateCheLiangZhuangTai";
            SQLCMDpas[1].Value = 配载发车单ID;
            int count = myDALMethod.UpdateData("配载发货_FRM_PeiZaiFaHuoPeiZai", SQLCMDpas);
            return count;
        }
    }
}
