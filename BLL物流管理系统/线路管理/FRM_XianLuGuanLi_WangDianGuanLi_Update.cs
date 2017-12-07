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
    public class FRM_XianLuGuanLi_WangDianGuanLi_Update
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
     
        [OperationContract]
        #region  网点ID查询网点信息
        public DataSet FRM_XianLuGuanLi_WangDianGuanLi_Update_Load_ChaXunWangDianXinXi(int 网点ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                       new SqlParameter("@网点ID", SqlDbType.Int) };
            SQLCMDpas[0].Value = "FRM_XianLuGuanLi_WangDianGuanLi_Update_Load_ChaXunWangDianXinXi";
            SQLCMDpas[1].Value = 网点ID.ToString().Trim();
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_WangDianGuanLi_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion  
        [OperationContract]
        #region  ID查询网点信息
        public DataSet FRM_XianLuGuanLi_WangDianGuanLi_Update_Load_ChaXunWangDianXinXi_JvLi(int 网点ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                       new SqlParameter("@网点ID", SqlDbType.Int) };
            SQLCMDpas[0].Value = "FRM_XianLuGuanLi_WangDianGuanLi_Update_Load_ChaXunWangDianXinXi_JvLi";
            SQLCMDpas[1].Value = 网点ID.ToString().Trim();
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_WangDianGuanLi_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion  
          
        [OperationContract]
        #region 删除相邻网点
        public int btnBaoCun_Update_Click_ShanChuXiangLinWangDian(string 网点ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                       new SqlParameter("@网点ID", SqlDbType.Int) };
            SQLCMDpas[0].Value = "btnBaoCun_Update_Click_ShanChuXiangLinWangDian";
            SQLCMDpas[1].Value = 网点ID.ToString().Trim();
           return   myDALMethod.UpdateData("线路管理_FRM_XianLuGuanLi_WangDianGuanLi_Update", SQLCMDpas);
        
        }
        #endregion  

        
        [OperationContract]
        #region  修改网点
        public int btnBaoCun_Update_Click_XiuGaiWangDian( string  网点名称,string 停用否,  string 网点ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@网点名称", SqlDbType.Char),   
                                                new SqlParameter("@停用否", SqlDbType.Char), 
                                       new SqlParameter("@网点ID", SqlDbType.Int) };
            SQLCMDpas[0].Value = "btnBaoCun_Update_Click_XiuGaiWangDian";
            SQLCMDpas[1].Value = 网点名称.ToString().Trim();
            SQLCMDpas[2].Value = 停用否.ToString().Trim();
            SQLCMDpas[3].Value = 网点ID.ToString().Trim();
            return myDALMethod.UpdateData("线路管理_FRM_XianLuGuanLi_WangDianGuanLi_Update", SQLCMDpas);
            
        }
        #endregion  
    }
}
