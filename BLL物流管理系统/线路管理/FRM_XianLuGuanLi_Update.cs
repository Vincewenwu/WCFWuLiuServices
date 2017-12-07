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
    public class FRM_XianLuGuanLi_Update
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        [OperationContract]
        #region 查询线路
        public DataSet FRM_XianLuGuanLi_Update_Load_ChaXunXianLuXinXi(string 线路ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                         new SqlParameter("@线路ID", SqlDbType.Int) };
            SQLCMDpas[0].Value = "FRM_XianLuGuanLi_Update_Load_ChaXunXianLuXinXi";
            SQLCMDpas[1].Value = 线路ID.ToString().Trim();
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion  

          [OperationContract]
        #region 查询线路明细
        public DataSet FRM_XianLuGuanLi_Update_Load_ChaXunXianLuMingXiXinXi(string 线路ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                         new SqlParameter("@线路ID", SqlDbType.Int) };
            SQLCMDpas[0].Value = "FRM_XianLuGuanLi_Update_Load_ChaXunXianLuMingXiXinXi";
            SQLCMDpas[1].Value = 线路ID.ToString().Trim();
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion  
        
        [OperationContract]
        #region 删除线路明细
        public int btnBaoCunXianLu_Update_Click_ShanChuXianLuMingXi(string 线路ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                         new SqlParameter("@线路ID", SqlDbType.Int) };
            SQLCMDpas[0].Value = "btnBaoCunXianLu_Update_Click_ShanChuXianLuMingXi";
            SQLCMDpas[1].Value = 线路ID.ToString().Trim();
            return myDALMethod.UpdateData("线路管理_FRM_XianLuGuanLi_Update", SQLCMDpas);
            
        }
        #endregion  
        [OperationContract]
        #region 修改线路
        public int btnBaoCunXianLu_Update_Click_XiuGaiXianLu(string 线路名称, string 助记码, string 线路ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                         new SqlParameter("@线路名称", SqlDbType.Char),
                                         new SqlParameter("@助记码", SqlDbType.Char),
                                         new SqlParameter("@线路ID", SqlDbType.Char),
                                       };
            SQLCMDpas[0].Value = "btnBaoCunXianLu_Update_Click_XiuGaiXianLu";
            SQLCMDpas[1].Value = 线路名称.ToString().Trim();
            SQLCMDpas[2].Value = 助记码.ToString().Trim();
            SQLCMDpas[3].Value = 线路ID.ToString().Trim();
            return  myDALMethod.UpdateData("线路管理_FRM_XianLuGuanLi_Update", SQLCMDpas);
            
            
        }
        #endregion  
    }
}
