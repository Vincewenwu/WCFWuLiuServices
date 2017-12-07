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
 public    class PeiZaiFaHuo_ShiShiPeiZai
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
      [OperationContract]
        public DataSet frmPeiZaiFaHuo_ShiShiPeiZai_SelectcboLanShouZhuangTai()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@type",SqlDbType.Char)};
            SQLCMDpas[0].Value = "frmPeiZaiFaHuo_ShiShiPeiZai_SelectcboLanShouZhuangTai";
            DataTable MyDataTable = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuo_ShiShiPeiZai", SQLCMDpas);
            DataSet MyDataSet = new DataSet();
            MyDataSet.Tables.Add(MyDataTable);
            return MyDataSet;
        }
        [OperationContract]
      #region 查询下拉框网点
      public DataSet frmPeiZaiFaHuo_ShiShiPeiZai_SelectcboWiangDian()
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
        public DataSet frmPeiZaiFaHuo_ShiShiPeiZai_LoadFenBao()
        {
           SqlParameter[] SQLCMDpas={new SqlParameter("@type",SqlDbType.Char),};
           SQLCMDpas[0].Value = "frmPeiZaiFaHuo_ShiShiPeiZai_LoadFenBao";
           DataTable myDataTable = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuo_ShiShiPeiZai",SQLCMDpas);
           DataSet myDataSet=new DataSet();
           myDataSet.Tables.Add(myDataTable);
           return myDataSet;
        }
      [OperationContract]
      #region 查询分包
        public DataSet frmPeiZaiFaHuo_ShiShiPeiZai_SelectPeiZaiFenBao(string 单据编号, int 寄件网点ID, int 收货网点ID, int 货物揽收状态ID, DateTime 起始时间, DateTime 结束时间)
      {

          SqlParameter[] SQLCMDpas = { new SqlParameter("@type", SqlDbType.Char),
                                      new SqlParameter("@单据编号",SqlDbType.Char),
                                      new SqlParameter("@寄件网点ID",SqlDbType.Int),
                                      new SqlParameter("@收货网点ID",SqlDbType.Int),
                                      new SqlParameter("@货物揽收状态ID",SqlDbType.Int),
                                      new SqlParameter("@起始时间",SqlDbType.DateTime),
                                      new SqlParameter("@结束时间",SqlDbType.DateTime),};
          SQLCMDpas[0].Value = "frmPeiZaiFaHuo_ShiShiPeiZai_SelectPeiZaiFenBao";
          SQLCMDpas[1].Value = 单据编号;
          SQLCMDpas[2].Value = 寄件网点ID;
          SQLCMDpas[3].Value = 收货网点ID;
          SQLCMDpas[4].Value = 货物揽收状态ID;
          SQLCMDpas[5].Value = 起始时间;
          SQLCMDpas[6].Value = 结束时间;
          DataTable myDataTable = myDALMethod.QueryDataTable("配载发货_FRM_PeiZaiFaHuo_ShiShiPeiZai", SQLCMDpas);
          DataSet myDataSet = new DataSet();
          myDataSet.Tables.Add(myDataTable);
          return myDataSet;
      }
      #endregion 
     
        
    }
}
