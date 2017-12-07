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
    public class FRM_PeiZaiFaHuoFenBao_Update
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();

        [OperationContract]
        public DataSet FRM_PeiZaiFaHuoFenBao_Update_Load_SelectDingDanMingXi(int int货运单ID)
        {
            SqlParameter[] sqlpams = {
                                new SqlParameter("@Type",SqlDbType.NChar),
                                new SqlParameter("@货运单ID",SqlDbType.Int)
                                    };
            sqlpams[0].Value = "FRM_PeiZaiFaHuoFenBao_Update_Load_SelectDingDanMingXi";
            sqlpams[1].Value = int货运单ID;
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("配载发货_FRM_PeiZaiFaHuoFenBao_Update", sqlpams));
            return myDS;
        }

        [OperationContract]
        public DataSet dgvMingXi_SelectionChanged_SelectFenBao(int 货运单明细ID)
        {
            SqlParameter[] sqlpams = {
                                new SqlParameter("@Type",SqlDbType.NChar),
                                new SqlParameter("@货运单明细ID",SqlDbType.Int)
                                    };
            sqlpams[0].Value = "dgvMingXi_SelectionChanged_SelectFenBao";
            sqlpams[1].Value = 货运单明细ID;
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("配载发货_FRM_PeiZaiFaHuoFenBao_Update", sqlpams));
            return myDS;
        }

        [OperationContract]
        public int btnBaoCun_Update_Click_DeleteOldFenBao(int 货运单明细ID)
        {
            SqlParameter[] sqlpams = {
                                new SqlParameter("@Type",SqlDbType.NChar),
                                new SqlParameter("@货运单明细ID",SqlDbType.Int)
                                    };
            sqlpams[0].Value = "btnBaoCun_Update_Click_DeleteOldFenBao";
            sqlpams[1].Value = 货运单明细ID;

            return myDAL.UpdateData("配载发货_FRM_PeiZaiFaHuoFenBao_Update", sqlpams);
        }

        [OperationContract]
        public int btnBaoCun_Update_Click_InsertNewFenBao(int 货运单明细ID,decimal 分包数量)
        {
            SqlParameter[] sqlpams = {
                                new SqlParameter("@Type",SqlDbType.NChar),
                                new SqlParameter("@货运单明细ID",SqlDbType.Int),
                                new SqlParameter("@分包数量",SqlDbType.Decimal)
                                    };
            sqlpams[0].Value = "btnBaoCun_Update_Click_InsertNewFenBao";
            sqlpams[1].Value = 货运单明细ID;
            sqlpams[2].Value = 分包数量;

            return myDAL.UpdateData("配载发货_FRM_PeiZaiFaHuoFenBao_Update", sqlpams);
        }
    }
}
