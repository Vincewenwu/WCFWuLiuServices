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
   public  class DingDanGuanLi_Update
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        [OperationContract]
        public DataSet frmDingDanGuanLi_Update_SelectWangDian()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Update_SelectWangDian";
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        [OperationContract]
        public DataSet frmDingDanGuanLi_Update_SelectYuanGong()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Update_SelectYuanGong";
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        [OperationContract]
        public DataSet frmDingDanGuanLi_Update_SelectKeHu(string 客户名称)
        {
            SqlParameter[] SQLCMDpas = {
                                           new SqlParameter("@Type", SqlDbType.Char),
                                           new SqlParameter("@客户全称", SqlDbType.Char),
                                       };
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Update_SelectKeHu";
            SQLCMDpas[1].Value = 客户名称;
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        [OperationContract]
        public DataSet frmDingDanGuanLi_Update_SelectJiFeiGongShi()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Update_SelectJiFeiGongShi";
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        [OperationContract]
        public DataSet frmDingDanGuanLi_Update_SelectJieSuanFangShi()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Update_SelectJieSuanFangShi";
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        [OperationContract]
        public DataSet frmDingDanGuanLi_Update_SelectCboLanShouZhuangTai()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Update_Load_SelectCboLanShouZhuangTai";
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }

        [OperationContract]
        public DataSet frmDingDanGuanLi_Update_SelectHuoWu()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Update_SelectHuoWu";
            DataTable myDataTable = 
                myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }

        [OperationContract]
        public DataSet frmDingDanGuanLi_Update_Load_SelectHuoYunDan(int huoYunDanID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                       new SqlParameter("@货运单ID", SqlDbType.Int)};
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Update_Load_SelectHuoYunDan";
            SQLCMDpas[1].Value = huoYunDanID;
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        [OperationContract]
        public DataSet frmDingDanGuanLi_Update_SelectHuoYunDanMingXiByHuoYunDanID(int huoYunDanID)
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char),
                                       new SqlParameter("@货运单ID", SqlDbType.Int)};
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Update_SelectHuoYunDanMingXiByHuoYunDanID";
            SQLCMDpas[1].Value = huoYunDanID;
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Update", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }

        [OperationContract]
        public int btnBaoCun_Click_UpdateDanJu(string 单据编号, DateTime 接单时间,
            int 业务员_员工ID, DateTime 要求送达时间,
          int 托运方ID, string 提单号, int 收货方ID, string 寄件地址, string 收货地址,
          int 结算方式ID, decimal 运费总价, string 备注, int 制单人_员工ID,
          int 修单人_员工ID, int 寄件网点ID, int 收货网点ID, int 货物揽收状态ID,int 货运单ID)
        {
            SqlParameter[] SQLCMDpas = { 
                                           new SqlParameter("@Type", SqlDbType.Char), 
                                           new SqlParameter("@单据编号", SqlDbType.NChar),
                                           new SqlParameter("@接单时间", SqlDbType.DateTime),
                                           new SqlParameter("@业务员_员工ID", SqlDbType.Int),
                                           new SqlParameter("@要求送达时间", SqlDbType.Date),
                                           new SqlParameter("@托运方ID", SqlDbType.Int),
                                           new SqlParameter("@提单号", SqlDbType.NChar),
                                           new SqlParameter("@收货方ID", SqlDbType.Int),
                                           new SqlParameter("@寄件地址", SqlDbType.NChar),
                                           new SqlParameter("@收货地址", SqlDbType.NChar),
                                           new SqlParameter("@结算方式ID", SqlDbType.Int),
                                           new SqlParameter("@运费总价", SqlDbType.Decimal),
                                           new SqlParameter("@备注", SqlDbType.NChar),
                                           new SqlParameter("@制单人_员工ID", SqlDbType.Int),
                                           new SqlParameter("@修单人_员工ID", SqlDbType.Int),
                                           new SqlParameter("@寄件网点ID", SqlDbType.Int),
                                           new SqlParameter("@收货网点ID", SqlDbType.Int),
                                           new SqlParameter("@货物揽收状态ID", SqlDbType.Int),
                                           new SqlParameter("@货运单ID", SqlDbType.Int),
                                       };
            SQLCMDpas[0].Value = "btnBaoCun_Click_UpdateDanJu";
            SQLCMDpas[1].Value = 单据编号;
            SQLCMDpas[2].Value = 接单时间;
            SQLCMDpas[3].Value = 业务员_员工ID;
            SQLCMDpas[4].Value = 要求送达时间;
            SQLCMDpas[5].Value = 托运方ID;
            SQLCMDpas[6].Value = 提单号;
            SQLCMDpas[7].Value = 收货方ID;
            SQLCMDpas[8].Value = 寄件地址;
            SQLCMDpas[9].Value = 收货地址;
            SQLCMDpas[10].Value = 结算方式ID;
            SQLCMDpas[11].Value = 运费总价;
            SQLCMDpas[12].Value = 备注;
            SQLCMDpas[13].Value = 制单人_员工ID;
            SQLCMDpas[14].Value = 修单人_员工ID;
            SQLCMDpas[15].Value = 寄件网点ID;
            SQLCMDpas[16].Value = 收货网点ID;
            SQLCMDpas[17].Value = 货物揽收状态ID;
            SQLCMDpas[18].Value = 货运单ID;
            return myDALMethod.UpdateData("订单管理_FRM_DingDanGuanLi_Update", SQLCMDpas);
           
        }

        [OperationContract]
        public int btnBaoCun_Click_UpdateMingXi(
            int 货物ID, decimal 数量, int 计费公式ID, 
            decimal 运费单价, bool 揽收否, int 货运单ID,int 货运单明细ID)
        {
            /*货物ID, 数量, 计费公式ID, 运费单价, 揽收否, 货运单ID*/
            SqlParameter[] SQLCMDpas = { 
                                           new SqlParameter("@Type", SqlDbType.Char), 
                                           new SqlParameter("@货物ID", SqlDbType.Int),
                                           new SqlParameter("@数量", SqlDbType.Decimal),
                                           new SqlParameter("@计费公式ID", SqlDbType.Int),
                                           new SqlParameter("@运费单价", SqlDbType.Decimal),
                                           new SqlParameter("@揽收否", SqlDbType.Bit),
                                           new SqlParameter("@货运单ID", SqlDbType.Int),
                                           new SqlParameter("@货运单明细ID", SqlDbType.Int),
                                       };
            SQLCMDpas[0].Value = "btnBaoCun_Click_UpdateDanJuMingXi";
            SQLCMDpas[1].Value = 货物ID;
            SQLCMDpas[2].Value = 数量;
            SQLCMDpas[3].Value = 计费公式ID;
            SQLCMDpas[4].Value = 运费单价;
            SQLCMDpas[5].Value = 揽收否;
            SQLCMDpas[6].Value = 货运单ID;
            SQLCMDpas[7].Value = 货运单明细ID;
            return myDALMethod.UpdateData("订单管理_FRM_DingDanGuanLi_Update", SQLCMDpas);
        }

        [OperationContract]
        public int btnBaoCun_Click_InsertDanJuMingXi(
            int 货物ID, decimal 数量, int 计费公式ID, 
            decimal 运费单价, bool 揽收否, int 货运单ID)
        {
            /*货物ID, 数量, 计费公式ID, 运费单价, 揽收否, 货运单ID*/
            SqlParameter[] SQLCMDpas = { 
                                           new SqlParameter("@Type", SqlDbType.Char), 
                                           new SqlParameter("@货物ID", SqlDbType.Int),
                                           new SqlParameter("@数量", SqlDbType.Decimal),
                                           new SqlParameter("@计费公式ID", SqlDbType.Int),
                                           new SqlParameter("@运费单价", SqlDbType.Decimal),
                                           new SqlParameter("@揽收否", SqlDbType.Bit),
                                           new SqlParameter("@货运单ID", SqlDbType.Int),
                                       };
            SQLCMDpas[0].Value = "btnBaoCun_Click_InsertDanJuMingXi";
            SQLCMDpas[1].Value = 货物ID;
            SQLCMDpas[2].Value = 数量;
            SQLCMDpas[3].Value = 计费公式ID;
            SQLCMDpas[4].Value = 运费单价;
            SQLCMDpas[5].Value = 揽收否;
            SQLCMDpas[6].Value = 货运单ID;
            return myDALMethod.UpdateData("订单管理_FRM_DingDanGuanLi_Update", SQLCMDpas);
        }


        [OperationContract]
        public int btnBaoCun_Click_DeleteDanJuMingXi(int 货运单明细ID)
        {
            /*货物ID, 数量, 计费公式ID, 运费单价, 揽收否, 货运单ID*/
            SqlParameter[] SQLCMDpas = { 
                                           new SqlParameter("@Type", SqlDbType.Char),
                                           new SqlParameter("@货运单明细ID", SqlDbType.Int),
                                       };
            SQLCMDpas[0].Value = "btnBaoCun_Click_DeleteDanJuMingXi";
            SQLCMDpas[1].Value = 货运单明细ID;
            return myDALMethod.UpdateData("订单管理_FRM_DingDanGuanLi_Update", SQLCMDpas);
        }
    }
    
} 
