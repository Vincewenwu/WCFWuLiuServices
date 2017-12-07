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
  public    class PeiZaiFaHuoPeiZai_Update
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        [OperationContract]
        #region 查询发车单

        public DataSet FRM_PeiZaiFaHuoPeiZai_SelectPeiZaiFaHuoDanBYPeiZaiFaHuoDanID(int 配载发车单ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char),
                                          new SqlParameter("@配载发车单ID",SqlDbType.Int),};
            SQLCMDpas[0].Value = "FRM_PeiZaiFaHuoPeiZai_SelectPeiZaiFaHuoDanBYPeiZaiFaHuoDanID";
            SQLCMDpas[1].Value = 配载发车单ID;
            DataTable MyDataTable = 
                myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(MyDataTable);
            return myDataSet;
        } 
        #endregion
        [OperationContract]
        #region 查询发车单明细通过配载发车单ID
         public DataSet FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMingXiByFaHuoDanID(int 配载发车单ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char),
                                          new SqlParameter("@配载发车单ID",SqlDbType.Int),};
            SQLCMDpas[0].Value = "FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMingXiByFaHuoDanID";
            SQLCMDpas[1].Value = 配载发车单ID;
            DataTable MyDataTable = 
                myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(MyDataTable);
            return myDataSet;
        } 
        #endregion
        [OperationContract]
        #region 查询下拉框网点

        public DataSet frmPeiZaiFaHuo_Insert_SelectcboWiangDian()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char), };
            SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Update_SelectcboWiangDian";
            DataTable myDataTable = 
                myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion
        [OperationContract]
        #region 查询下拉框线路
        public DataSet frmPeiZaiFaHuo_Insert_SelectcboXianLu()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char), };
            SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Update_SelectcboXianLu";
            DataTable myDataTable = 
                myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion
       
        [OperationContract]
        #region 查询下司机（这里跟新增时候有点不同，还要显示已选择的那个司机）
        public DataSet frmPeiZaiFaHuo_Update_SelectSiJiBySiJiID(int 司机ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char),
                                         new SqlParameter("@司机ID", SqlDbType.Int),};
            SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Update_SelectSiJiBySiJiID";
            SQLCMDpas[1].Value = 司机ID;
            DataTable myDataTable = 
                myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion  
        
        [OperationContract]
        #region 查询车辆，锁定状态的车辆也查出来（跟新增有点不同，已选择的那趟车也要显示出来）
        public DataSet frmPeiZaiFaHuo_Update_SelectcboCheLiang(int 车辆ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char),
                                          new SqlParameter("@车辆ID",SqlDbType.Int),};
            SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Update_SelectcboCheLiang";
            SQLCMDpas[1].Value = 车辆ID;
            DataTable MyDataTable = 
                myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai_Update", SQLCMDpas);
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
         #region 如果修改时选择新的司机，那旧司机状态变为无任务状态
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

        #region 新司机就状态变为有任务状态
        [OperationContract]
        public int frmPeiZaiFaHuo_Insert_UpdateSiJiZhuangTai(int 司机ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char)
                                          ,new SqlParameter("@司机ID",SqlDbType.Int),};
            SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Insert_UpdateSiJiZhuangTai";
            SQLCMDpas[1].Value = 司机ID;
            int count = myDALMethod.UpdateData("配载发货_FRM_PeiZaiFaHuo_insert", SQLCMDpas);
            return count;
        } 
        #endregion
         #region 如果发车状态为4，待装货，那么此时用户还可以改变车辆，对原来的车辆状态改为空闲
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

        #region 新选择得到车辆状态改为4配载中
        [OperationContract]
        public int frmPeiZaiFaHuo_Insert_UpdateCheLiangZhuangTai(int 车辆ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char)
                                          ,new SqlParameter("@车辆ID",SqlDbType.Int),};
            SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Insert_UpdateCheLiangZhuangTai";
            SQLCMDpas[1].Value = 车辆ID;
            int count = myDALMethod.UpdateData("配载发货_FRM_PeiZaiFaHuo_insert", SQLCMDpas);
            return count;
        } 
        #endregion
        #region 修改配载发车单通过发车单ID
        [OperationContract]
        public int frmPeiZaiFaHuo_Update_UpdatePeiZaiFaCheDanByFaCheDanID(int 车辆ID, int 司机ID, int 发车网点ID, int 线路ID, int 目的网点ID, DateTime 接单时间, int 配载发车单ID)
        {  
            SqlParameter[] SQLCMDpas = {  new SqlParameter("@type",SqlDbType.Char),
                                          new SqlParameter("@车辆ID",SqlDbType.Int),
                                          new SqlParameter("@司机ID",SqlDbType.Int),
                                          new SqlParameter("@发车网点ID",SqlDbType.Int),
                                          new SqlParameter("@线路ID",SqlDbType.Int),
                                          new SqlParameter("@目的网点ID",SqlDbType.Int),
                                          new SqlParameter("@接单时间",SqlDbType.DateTime),
                                           new SqlParameter("@配载发车单ID",SqlDbType.Int),
                                        };
            SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Update_UpdatePeiZaiFaCheDanByFaCheDanID";
            SQLCMDpas[1].Value = 车辆ID;
            SQLCMDpas[2].Value = 司机ID;
            SQLCMDpas[3].Value = 发车网点ID;
            SQLCMDpas[4].Value = 线路ID;
            SQLCMDpas[5].Value = 目的网点ID;
            SQLCMDpas[6].Value = 接单时间;
            SQLCMDpas[7].Value = 配载发车单ID;
            int count = myDALMethod.UpdateData("配载发货_FRM_PeiZaiFaHuoPeiZai_Update", SQLCMDpas);
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
        #region 插入明细表
        [OperationContract]
        public int frmPeiZaiFaHuo_Insert_InsertPeiZaiFaCheMingXi(int 配载发车单ID, int 分包ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char),
                                          new SqlParameter("@配载发车单ID",SqlDbType.Int),
                                          new SqlParameter("@分包ID",SqlDbType.Int),};
            SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Insert_InsertPeiZaiFaCheMingXi";
            SQLCMDpas[1].Value = 配载发车单ID;
            SQLCMDpas[2].Value = 分包ID;
            int count = myDALMethod.UpdateData("配载发货_FRM_PeiZaiFaHuo_insert", SQLCMDpas);
            return count;
        }   
        #endregion

        #region 根据开始与结束网点查询可选择路线
        [OperationContract]
        public DataSet cboFaHuoWangDian_SelectedIndexChanged_ChaXunLuXianLinJu(int 开始网点ID, int 结束网点ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char),
                                       };
            SQLCMDpas[0].Value = "cboFaHuoWangDian_SelectedIndexChanged_ChaXunLuXianLinJu";

            DataTable dtLinJu = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai_Update", SQLCMDpas);
            DataView dv = new DataView(dtLinJu);


            DataTable dtXianLu = frmPeiZaiFaHuo_Insert_SelectcboXianLu().Tables[0];


            DataTable dtXianLuZuiZhong = dtXianLu.Clone();
            for (int i = 0; i < dtXianLu.Rows.Count; i++)
            {
                string XianLuID = dtXianLu.Rows[i]["线路ID"].ToString();
                dv.RowFilter = "线路ID=" + XianLuID;
                DataTable dtLinShiXianLuLiJu = dv.ToTable();
                int KaiShiWangID = -1;
                int JieShuWangID = -1;
                for (int j = 0; j < dtLinShiXianLuLiJu.Rows.Count; j++)
                {
                    if (开始网点ID == Convert.ToInt32(dtLinShiXianLuLiJu.Rows[j]["网点ID"]))
                    {
                        KaiShiWangID = j;
                    }
                    if (结束网点ID == Convert.ToInt32(dtLinShiXianLuLiJu.Rows[j]["网点ID"]))
                    {
                        JieShuWangID = j;
                    }
                }

                if (KaiShiWangID != -1 && JieShuWangID != -1 && JieShuWangID >= KaiShiWangID)
                {

                    DataRow dr = dtXianLuZuiZhong.NewRow();
                    dr["线路ID"] = dtXianLu.Rows[i]["线路ID"];
                    dr["线路名称"] = dtXianLu.Rows[i]["线路名称"];

                    dtXianLuZuiZhong.Rows.Add(dr);

                }

            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dtXianLuZuiZhong);

            return ds;

        }
        #endregion
       
    }
}
