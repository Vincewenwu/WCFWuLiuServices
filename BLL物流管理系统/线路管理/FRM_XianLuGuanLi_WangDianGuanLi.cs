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
    public class FRM_XianLuGuanLi_WangDianGuanLi
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
         
        [OperationContract]
        #region 查询网点通过状态
        public DataSet btnChaXunWangDianXinXi_Click_ChaXunWangDianXinXiONZhuangTai(string 停用否)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                       new SqlParameter("@停用否", SqlDbType.Bit) };
            SQLCMDpas[0].Value = "btnChaXunWangDianXinXi_Click_ChaXunWangDianXinXiONZhuangTai";
            SQLCMDpas[1].Value = Convert.ToBoolean(停用否.ToString().Trim());
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_WangDianGuanLi", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion
        [OperationContract]
        #region 查询网点名称
        public DataSet btnChaXunWangDianXinXi_Click_ChaXunWangDianXinXi(string 网点名称)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                       new SqlParameter("@网点名称", SqlDbType.NChar) };
            SQLCMDpas[0].Value = "btnChaXunWangDianXinXi_Click_ChaXunWangDianXinXi";
            SQLCMDpas[1].Value = 网点名称.ToString().Trim();
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_WangDianGuanLi", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion  
        [OperationContract]
        #region 查询相邻网点名称
        public DataSet dgvWangDianXinXi_CellClick_ChaXunXiangLinWangDianXinXi(string 网点ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                       new SqlParameter("@网点ID", SqlDbType.Int) };
            SQLCMDpas[0].Value = "dgvWangDianXinXi_CellClick_ChaXunXiangLinWangDianXinXi";
            SQLCMDpas[1].Value = Convert.ToInt32(网点ID.ToString().Trim());
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_WangDianGuanLi", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion

        [OperationContract]
        #region 删除网点
        public int tsbShanChu_Delete_Click_ShanChuWangDian(string 网点ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                       new SqlParameter("@网点ID", SqlDbType.Int) };
            SQLCMDpas[0].Value = "tsbShanChu_Delete_Click_ShanChuWangDian";
            SQLCMDpas[1].Value = Convert.ToInt32(网点ID.ToString().Trim());
            return myDALMethod.UpdateData("线路管理_FRM_XianLuGuanLi_WangDianGuanLi", SQLCMDpas);
           
        }
        #endregion
        
    }
}
