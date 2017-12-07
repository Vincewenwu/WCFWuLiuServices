using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL物流管理系统.订单管理
{
    [ServiceContract]
    public class DingDanGuanLi
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();

        [OperationContract]
        public DataSet FRM_DingDanGuanLi_Load_SelectZhuangTai()
        {
            SqlParameter[] sqlPas = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                    };
            sqlPas[0].Value = "FRM_DingDanGuanLi_Load_SelectZhuangTai";
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("订单管理_FRM_DingDanGuanLi",sqlPas));
            return myDS;
        }


        [OperationContract]
        public DataSet FRM_DingDanGuanLi_Load_SelectHuoMing()
        {
            SqlParameter[] sqlPas = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                    };
            sqlPas[0].Value = "FRM_DingDanGuanLi_Load_SelectHuoMing";
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("订单管理_FRM_DingDanGuanLi", sqlPas));
            return myDS;
        }


        [OperationContract]
        public DataSet FRM_DingDanGuanLi_Load_SelectKeHu()
        {
            SqlParameter[] sqlPas = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                    };
            sqlPas[0].Value = "FRM_DingDanGuanLi_Load_SelectKeHu";
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("订单管理_FRM_DingDanGuanLi", sqlPas));
            return myDS;
        }

        [OperationContract]
        public DataSet FRM_DingDanGuanLi_Load_SelectAllDingDan()
        {
            SqlParameter[] sqlPas = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                    };
            sqlPas[0].Value = "FRM_DingDanGuanLi_Load_SelectAllDingDan";
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("订单管理_FRM_DingDanGuanLi", sqlPas));
            return myDS;
        }

        [OperationContract]
        public DataSet FRM_DingDanGuanLi_Load_SelectDingDanByRiQi(DateTime kaishi,DateTime jieshu,bool shenhefou)
        {
            SqlParameter[] sqlPas = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                new SqlParameter("@开始时间",SqlDbType.DateTime),
                                new SqlParameter("@结束时间",SqlDbType.DateTime),
                                new SqlParameter("@审核否",SqlDbType.Bit),
                                    };
            sqlPas[0].Value = "FRM_DingDanGuanLi_Load_SelectDingDanByRiQi";
            sqlPas[1].Value = kaishi;
            sqlPas[2].Value = jieshu;
            sqlPas[3].Value = shenhefou;
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("订单管理_FRM_DingDanGuanLi", sqlPas));
            return myDS;
        }
        [OperationContract]
        public DataSet FRM_DingDanGuanLi_Load_SelectDingDanByHuoWuID(int huowuid,bool shenhefou)
        {
            SqlParameter[] sqlPas = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                new SqlParameter("@货物ID",SqlDbType.Int),
                                new SqlParameter("@审核否",SqlDbType.Bit),
                                    };
            sqlPas[0].Value = "FRM_DingDanGuanLi_Load_SelectDingDanByHuoWuID";
            sqlPas[1].Value = huowuid;
            sqlPas[2].Value = shenhefou;
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("订单管理_FRM_DingDanGuanLi", sqlPas));
            return myDS;
        }

        [OperationContract]
        public DataSet dgvHuoYunDan_SelectionChanged_SelectHuoYunDanMingXi(int HuoYunDanID)
        {
            SqlParameter[] sqlPas = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                new SqlParameter("@货运单ID",SqlDbType.Int),
                                    };
            sqlPas[0].Value = "dgvHuoYunDan_SelectionChanged_SelectHuoYunDanMingXi";
            sqlPas[1].Value = HuoYunDanID;
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("订单管理_FRM_DingDanGuanLi", sqlPas));
            return myDS;
        }

        [OperationContract]
        public int FRM_DingDanGuanLi_Load_SelectHuoYunDanCount()
        {
            SqlParameter[] sqlPas = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                    };
            sqlPas[0].Value = "FRM_DingDanGuanLi_Load_SelectHuoYunDanCount";
            DataTable dt = myDAL.QueryDataTable("订单管理_FRM_DingDanGuanLi", sqlPas);
            int rowCount = Convert.ToInt32(dt.Rows[0][0]);
            return rowCount;
        }

        [OperationContract]
        public DataSet FRM_DingDanGuanLi_Load_SelectHuoYunDanByFenYe(int pageSize,int pageNum)
        {
            SqlParameter[] sqlPas = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                new SqlParameter("@PageSize",SqlDbType.Int),
                                new SqlParameter("@PageNum",SqlDbType.Int),
                                    };
            sqlPas[0].Value = "FRM_DingDanGuanLi_Load_SelectHuoYunDanByFenYe";
            sqlPas[1].Value = pageSize;
            sqlPas[2].Value = pageNum;
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("订单管理_FRM_DingDanGuanLi", sqlPas));
            return myDS;
        }

        [OperationContract]
        public int tspBtnShanChuDingDan_Click_DeleteHuoYunDan(int 货运单ID)
        {
            SqlParameter[] sqlPas = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                new SqlParameter("@货运单ID",SqlDbType.Int),
                                    };
            sqlPas[0].Value = "tspBtnShanChuDingDan_Click_DeleteHuoYunDan";
            sqlPas[1].Value = 货运单ID;
            return myDAL.UpdateData("订单管理_FRM_DingDanGuanLi", sqlPas);
        }
        [OperationContract]
        public int tspBtnShanChuDingDan_Click_DeleteHuoYunDanMingXi(int 货运单ID)
        {
            SqlParameter[] sqlPas = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                new SqlParameter("@货运单ID",SqlDbType.Int),
                                    };
            sqlPas[0].Value = "tspBtnShanChuDingDan_Click_DeleteHuoYunDanMingXi";
            sqlPas[1].Value = 货运单ID;
            return myDAL.UpdateData("订单管理_FRM_DingDanGuanLi", sqlPas);
        }

        [OperationContract]
        public int dgvHuoYunDan_CellClick_UpdateShenHe(int 货运单ID)
        {
            SqlParameter[] sqlPas = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                new SqlParameter("@货运单ID",SqlDbType.Int),
                                    };
            sqlPas[0].Value = "dgvHuoYunDan_CellClick_UpdateShenHe";
            sqlPas[1].Value = 货运单ID;
            return myDAL.UpdateData("订单管理_FRM_DingDanGuanLi", sqlPas);
        }


        [OperationContract]
        public int dgvHuoYunDan_CellClick_InsertFenBao(int 货运单明细ID,decimal 分包数量)
        {
            SqlParameter[] sqlPas = {
                                new SqlParameter("@type",SqlDbType.NChar),
                                new SqlParameter("@货运单明细ID",SqlDbType.Int),
                                new SqlParameter("@分包数量",SqlDbType.Decimal),
                                    };
            sqlPas[0].Value = "dgvHuoYunDan_CellClick_InsertFenBao";
            sqlPas[1].Value = 货运单明细ID;
            sqlPas[2].Value = 分包数量;
            return myDAL.UpdateData("订单管理_FRM_DingDanGuanLi", sqlPas);
        }

        [OperationContract]
        #region 物流信息查询
        public DataSet Search_WuLiuGenZhongXinXi(string 订单流水号)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                       new SqlParameter("@订单流水号", SqlDbType.NChar),
                                       };
            SQLCMDpas[0].Value = "Search_WuLiuGenZhongXinXi";
            SQLCMDpas[1].Value = 订单流水号.ToString().Trim();
            DataSet myDS = new DataSet();
            myDS.Tables.Add(myDAL.QueryDataTable("物流管理_二维码扫描", SQLCMDpas));
            return myDS;
        }
        #endregion
    }
}
