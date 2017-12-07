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
    public class FRM_PeiZaiFaHuoFenBao
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();

        [OperationContract]
        public DataSet FRM_PeiZaiFaHuo_Load_SelectKeHu()
        {
            SqlParameter[] sqlpams = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                    };
            sqlpams[0].Value = "FRM_PeiZaiFaHuo_Load_SelectKeHu";
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("配载发货_FRM_PeiZaiFaHuoFenBao", sqlpams));
            return myDS;
        }

        [OperationContract]
        public DataSet btnChaXun_Select_Click_SelectDingDanXinXi()
        {
            SqlParameter[] sqlpams = {
                                new SqlParameter("@type",SqlDbType.NChar)
                                    };
            sqlpams[0].Value = "btnChaXun_Select_Click_SelectDingDanXinXi";
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("配载发货_FRM_PeiZaiFaHuoFenBao", sqlpams));
            return myDS;
        }

        [OperationContract]
        public DataSet dgvHuoYunDan_SelectionChanged_SelectDingDanMingXi(int int货运单ID)
        {
            SqlParameter[] sqlpams = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                new SqlParameter("@货运单ID",SqlDbType.Int)
                                    };
            sqlpams[0].Value = "dgvHuoYunDan_SelectionChanged_SelectDingDanMingXi";
            sqlpams[1].Value = int货运单ID;
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("配载发货_FRM_PeiZaiFaHuoFenBao", sqlpams));
            return myDS;
        }

        [OperationContract]
        public DataSet dgvMingXi_SelectionChanged_SelectFenBao(int int货运单明细ID)
        {
            SqlParameter[] sqlpams = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                new SqlParameter("@货运单明细ID",SqlDbType.Int)
                                    };
            sqlpams[0].Value = "dgvMingXi_SelectionChanged_SelectFenBao";
            sqlpams[1].Value = int货运单明细ID;
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("配载发货_FRM_PeiZaiFaHuoFenBao", sqlpams));
            return myDS;
        }


        [OperationContract]
        public DataSet btnChaXun_Select_Click_SelectDingDanXinXi_DongTai(string 动态条件)
        {
            SqlParameter[] sqlpams = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                new SqlParameter("@动态条件",SqlDbType.NChar)
                                    };
            sqlpams[0].Value = "btnChaXun_Select_Click_SelectDingDanXinXi_DongTai";
            sqlpams[1].Value = 动态条件;
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("配载发货_FRM_PeiZaiFaHuoFenBao", sqlpams));
            return myDS;
        }

    }
}
