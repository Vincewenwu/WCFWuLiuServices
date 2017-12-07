using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;

namespace BLL物流管理系统.配载发货
{
     [ServiceContract]
 public   class PeiZaiFaHuoPeiZai_Insert
    {
    
     DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
         [OperationContract]
     #region 查询配置编号
     public DataSet frmPeiZaiFaHuoPeiZai_Insert_SelectHuodanhao()
     {
         SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char), };
         SQLCMDpas[0].Value = "frmPeiZaiFaHuoPeiZai_Insert_SelectHuodanhao";
         DataTable myDataTable = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai_Insert_DangRiPeiZaiDanShu", SQLCMDpas);
         DataSet myDataSet = new DataSet();
         myDataSet.Tables.Add(myDataTable);
         return myDataSet;
     } 
     #endregion
         [OperationContract]
     #region 查询下拉框网点
     
     public DataSet frmPeiZaiFaHuo_Insert_SelectcboWiangDian()
     {
         SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char), };
         SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Insert_SelectcboWiangDian";
         DataTable myDataTable = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuo_insert", SQLCMDpas);
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
         SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Insert_SelectcboXianLu";
         DataTable myDataTable = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuo_insert", SQLCMDpas);
         DataSet myDataSet = new DataSet();
         myDataSet.Tables.Add(myDataTable);
         return myDataSet;
     } 
     #endregion
         [OperationContract]
     #region 查询下拉框车辆
         public DataSet frmPeiZaiFaHuo_Insert_SelectcboCheLiang()
         {
             SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char), };
             SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Insert_SelectcboCheLiang";
             DataTable myDataTable = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuo_insert", SQLCMDpas);
             DataSet myDataSet = new DataSet();
             myDataSet.Tables.Add(myDataTable);
             return myDataSet;
         } 
         #endregion
         [OperationContract]
         #region 查询下司机
         public DataSet frmPeiZaiFaHuo_Insert_SelectSiJi()
         {
             SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char), };
             SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Insert_SelectSiJi";
             DataTable myDataTable = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuo_insert", SQLCMDpas);
             DataSet myDataSet = new DataSet();
             myDataSet.Tables.Add(myDataTable);
             return myDataSet;
         }
         #endregion  
         [OperationContract]
         public int frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(int 分包ID)
         {
             SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char),
                                        new SqlParameter("@分包ID",SqlDbType.Int),};
             SQLCMDpas[0].Value="frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing";
             SQLCMDpas[1].Value = 分包ID;
             int count = myDALMethod.UpdateData("配载发货_FRM_PeiZaiFaHuo_insert", SQLCMDpas);
             return count;
         }
         
     

          #region 根据开始与结束网点查询可选择路线
          [OperationContract]
          public DataSet cboFaHuoWangDian_SelectedIndexChanged_ChaXunLuXianLinJu(int 开始网点ID, int 结束网点ID)
          {
              SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char),
                                       };
              SQLCMDpas[0].Value = "cboFaHuoWangDian_SelectedIndexChanged_ChaXunLuXianLinJu";

              DataTable 线路邻居表_线路明细 = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuoPeiZai_Update", SQLCMDpas);
              //DataView dv = new DataView(dtLinJu);
              DataView 线路邻居表_线路明细_过滤视图 = 线路邻居表_线路明细.DefaultView;

              DataTable 线路表 = frmPeiZaiFaHuo_Insert_SelectcboXianLu().Tables[0];

            
              DataTable 最终线路表 = 线路表.Clone();
              for (int i = 0; i < 线路表.Rows.Count; i++)
              {
                  string XianLuID = 线路表.Rows[i]["线路ID"].ToString();
                  线路邻居表_线路明细_过滤视图.RowFilter = "线路ID=" + XianLuID ;
                  DataTable 临时线路邻居表 = 线路邻居表_线路明细_过滤视图.ToTable();
                  int 开始网点ID出现索引 = -1;
                  int 结束网点ID出现索引 = -1;
                  for (int j = 0; j < 临时线路邻居表.Rows.Count; j++)
                  {
                      if (开始网点ID == Convert.ToInt32(临时线路邻居表.Rows[j]["网点ID"]))
                      {
                          开始网点ID出现索引 = j;
                      }
                      if (结束网点ID == Convert.ToInt32(临时线路邻居表.Rows[j]["网点ID"]))
                      {
                          结束网点ID出现索引 = j;
                      }
                  }

                  if (开始网点ID出现索引 != -1 && 结束网点ID出现索引 != -1 && 结束网点ID出现索引 >= 开始网点ID出现索引)
                  {

                      DataRow dr = 最终线路表.NewRow();
                      dr["线路ID"] = 线路表.Rows[i]["线路ID"];
                      dr["线路名称"] = 线路表.Rows[i]["线路名称"];
                     
                      最终线路表.Rows.Add(dr);

                  }

              }
              DataSet ds = new DataSet();
              ds.Tables.Add(最终线路表);

              return ds;

          }
          #endregion

          [OperationContract]
          public int frmPeiZaiFaHuo_Insert_LockFenBaoSuoDing(int 分包ID)
          {
              SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char),
                                        new SqlParameter("@分包ID",SqlDbType.Int),};
              SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Insert_LockFenBaoSuoDing";
              SQLCMDpas[1].Value = 分包ID;
              int count = myDALMethod.UpdateData("配载发货_FRM_PeiZaiFaHuo_insert", SQLCMDpas);
              return count;
          }



          [OperationContract]
          public int frmPeiZaiFaHuo_Insert_InsertPeiZaiFaChe(string 配载发车单号, int 车辆ID, int 司机ID
             , int 发车网点ID, int 线路ID, int 目的网点ID, DateTime 接单时间)
          {
              SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char),
                                          new SqlParameter("@配载发车单号",SqlDbType.Char),
                                          new SqlParameter("@车辆ID ",SqlDbType.Int),
                                          new SqlParameter("@司机ID ",SqlDbType.Int),
                                          new SqlParameter("@发车网点ID",SqlDbType.Int),
                                          new SqlParameter("@线路ID",SqlDbType.Int),
                                          new SqlParameter("@目的网点ID",SqlDbType.Int),
                                          new SqlParameter("@接单时间",SqlDbType.DateTime)};
              SQLCMDpas[0].Value = "frmPeiZaiFaHuo_Insert_InsertPeiZaiFaChe";
              SQLCMDpas[1].Value = 配载发车单号;
              SQLCMDpas[2].Value = 车辆ID;
              SQLCMDpas[3].Value = 司机ID;
              SQLCMDpas[4].Value = 发车网点ID;
              SQLCMDpas[5].Value = 线路ID;
              SQLCMDpas[6].Value = 目的网点ID;
              SQLCMDpas[7].Value = 接单时间;
              try
              {
                  return Convert.ToInt32(myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuo_insert", SQLCMDpas).Rows[0][0]);
              }
              catch
              {
                  return -2;
              }
          }

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
     }
}
