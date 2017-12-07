using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;

namespace BLL物流管理系统.线路管理
{
    [ServiceContract]
    public class FRM_XianLuGuanLi_Insert
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        [OperationContract]
        #region
        public DataSet FRM_XianLuGuanLi_Insert_Load_ChaXunWangDianXinXi( )
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char)  };
            SQLCMDpas[0].Value = "FRM_XianLuGuanLi_Insert_Load_ChaXunWangDianXinXi";
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_Insert", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion  
        [OperationContract]
        #region
        public DataSet btnShengChengLuXian_Click_ChaXunXiangLinWangDianXinXi()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "btnShengChengLuXian_Click_ChaXunXiangLinWangDianXinXi";
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_Insert", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion 
         [OperationContract]
        #region
        public DataSet btnBaoCunXianLu_Click_BaoCunXianLu(string 线路名称,string 助记码)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                         new SqlParameter("@线路名称", SqlDbType.Char),
                                         new SqlParameter("@助记码", SqlDbType.Char)};
            SQLCMDpas[0].Value = "btnBaoCunXianLu_Click_BaoCunXianLu";
            SQLCMDpas[1].Value = 线路名称.ToString().Trim();
            SQLCMDpas[2].Value = 助记码.ToString().Trim();
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_Insert", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion 
         [OperationContract]
         #region
         public DataSet btnBaoCunXianLu_Click_BaoCunXianLuMingXi(int 线路ID, int 网点ID, int 上级网点ID)
         {
             SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                         new SqlParameter("@线路ID", SqlDbType.Int),
                                         new SqlParameter("@网点ID", SqlDbType.Int),
                                         new SqlParameter("@上级网点ID", SqlDbType.Int)
                                          };
             SQLCMDpas[0].Value = "btnBaoCunXianLu_Click_BaoCunXianLuMingXi";
             SQLCMDpas[1].Value = 线路ID;
             SQLCMDpas[2].Value = 网点ID;
             SQLCMDpas[3].Value = 上级网点ID;
             DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_Insert", SQLCMDpas);
             DataSet myDataSet = new DataSet();
             myDataSet.Tables.Add(myDataTable);
             return myDataSet;
         }
         #endregion 


          [OperationContract]
         #region 查询所有邻居网点
         public DataSet btnShengChengLuXian_Click_ChaXunLinJu()
         {
             SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char),
                                         
                                          };
             SQLCMDpas[0].Value = "btnShengChengLuXian_Click_ChaXunLinJu"; 
             DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_Insert", SQLCMDpas);
             DataSet myDataSet = new DataSet();
             myDataSet.Tables.Add(myDataTable);
             return myDataSet;
         }
         #endregion 

          [OperationContract]
          #region ID查询邻居网点
          public DataSet btnShengChengLuXian_Click_IDChaXunLinJu()
          {
              SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                         
                                          };
              SQLCMDpas[0].Value = "btnShengChengLuXian_Click_IDChaXunLinJu";
              DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_Insert", SQLCMDpas);
              DataSet myDataSet = new DataSet();
              myDataSet.Tables.Add(myDataTable);
              return myDataSet;
          }
          #endregion 

         //[OperationContract]
         //#region 生成线路
         //public DataSet btnShengChengLuXian_Click_ShengChengXianLu(string strKaiShiWangDianID, string strJieShuWangDianID)
         //{
         //    SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                         
         //                                 };
         //    SQLCMDpas[0].Value = "btnShengChengLuXian_Click_ChaXunLinJu"; 
         //    DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_Insert", SQLCMDpas);
         //    DataSet myDataSet = new DataSet();
         //    myDataSet.Tables.Add(myDataTable);
         //    return myDataSet;
         //}
         //#endregion 


        
    }
}
