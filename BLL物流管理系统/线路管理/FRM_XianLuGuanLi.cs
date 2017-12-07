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
    public class FRM_XianLuGuanLi
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        
        [OperationContract]
        #region  根据线路名称查询线路信息
        public DataSet FRM_XianLuGuanLi_Load_ChaXunXianLuXinXi(string 线路名称)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                         new SqlParameter("@线路名称", SqlDbType.NChar) };
            SQLCMDpas[0].Value = "FRM_XianLuGuanLi_Load_ChaXunXianLuXinXi";
            SQLCMDpas[1].Value = 线路名称.ToString().Trim();
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion  
        [OperationContract]
        #region  根据线路ID查询线路信息
        public DataSet dgvXianLuXinXi_CellClick_ChaXunXianLuXiangXiXinXi(string  线路ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                         new SqlParameter("@线路ID", SqlDbType.Char) };
            SQLCMDpas[0].Value = "dgvXianLuXinXi_CellClick_ChaXunXianLuXiangXiXinXi";
            SQLCMDpas[1].Value = 线路ID;
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion  
          [OperationContract]
        #region 查询全部线路
        public DataSet FRM_XianLuGuanLi_Load_ChaXunQuanBuXianLu()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),  };
            SQLCMDpas[0].Value = "FRM_XianLuGuanLi_Load_ChaXunQuanBuXianLu"; 
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion  
             [OperationContract]
        #region 删除线路
          public int tsbShangChu_Delete_Click_ShanChuXianLu(string 线路ID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char), 
                                       new SqlParameter("@线路ID", SqlDbType.Char),};
            SQLCMDpas[0].Value = "tsbShangChu_Delete_Click_ShanChuXianLu";
            SQLCMDpas[1].Value = 线路ID.Trim();
            return myDALMethod.UpdateData("线路管理_FRM_XianLuGuanLi", SQLCMDpas);
            
        }
        #endregion  

              [OperationContract]
        #region 多条件查询
             public DataSet FRM_XianLuGuanLi_Load_DuoTiaoJianChaXunXianLu(string 线路名称, string 助记码)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char), 
                                       new SqlParameter("@线路名称", SqlDbType.Char),
                                        new SqlParameter("@助记码", SqlDbType.Char),};
            SQLCMDpas[0].Value = "FRM_XianLuGuanLi_Load_DuoTiaoJianChaXunXianLu";
            SQLCMDpas[1].Value = 线路名称;
            SQLCMDpas[2].Value = 助记码;
            DataTable myDataTable = myDALMethod.QueryDataTable("线路管理_FRM_XianLuGuanLi", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
            
        }
        #endregion  
        
    }
}
