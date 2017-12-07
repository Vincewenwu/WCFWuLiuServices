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
    public class FRM_XianLuGuanLi_WangDianGuanLi_Insert
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
         
        [OperationContract]
        #region 网点名称查询网点信息
        public DataSet btnBaoCun_Click_ChaRuWangDianXinXi(string 网点名称, string 停用否)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                       new SqlParameter("@网点名称", SqlDbType.NChar),
                                       new SqlParameter("@停用否", SqlDbType.Bit)  };
            SQLCMDpas[0].Value = "btnBaoCun_Click_ChaRuWangDianXinXi";
            SQLCMDpas[1].Value = 网点名称.ToString().Trim();
            SQLCMDpas[2].Value = Convert.ToBoolean(停用否.ToString().Trim());
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_WangDianGuanLi_Insert", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion  
        [OperationContract]
        #region  查询网点信息
        public DataSet FRM_XianLuGuanLi_WangDianGuanLi_Insert_Load_ChaXunWangDianXinXi( )
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "FRM_XianLuGuanLi_WangDianGuanLi_Insert_Load_ChaXunWangDianXinXi";
             DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_WangDianGuanLi_Insert", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion
        [OperationContract]
        #region   插入邻居网点
        public DataSet btnBaoCun_Click_ChaRuWangDianXinXi_ChaRuXiangLinWangDian(int 网点ID, int 邻居网点ID, decimal 距离)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@网点ID", SqlDbType.Int),
                                        new SqlParameter("@邻居网点ID", SqlDbType.Int),
                                        new SqlParameter("@距离", SqlDbType.Decimal)};
            SQLCMDpas[0].Value = "btnBaoCun_Click_ChaRuWangDianXinXi_ChaRuXiangLinWangDian";
            SQLCMDpas[1].Value = 网点ID;
            SQLCMDpas[2].Value = 邻居网点ID;
            SQLCMDpas[3].Value =  距离;
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_WangDianGuanLi_Insert", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion
    }
}
