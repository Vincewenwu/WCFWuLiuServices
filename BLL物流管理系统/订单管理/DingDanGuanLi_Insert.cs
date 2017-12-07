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
    public class DingDanGuanLi_Insert
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        [OperationContract]
        #region 在保存订单数据时候保存单据编码
        public DataSet frmDingDanGuanLi_Insert_SelectHuodanhao()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Insert_SelectHuodanhao";
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Insert_DangRiHuoDanShu", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        #endregion
        [OperationContract]
        public DataSet frmDingDanGuanLi_Insert_SelectWangDian()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Insert_SelectWangDian";
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Insert", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        [OperationContract]
        public DataSet frmDingDanGuanLi_Insert_SelectYuanGong()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Insert_SelectYuanGong";
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Insert", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        [OperationContract]
        public DataSet frmDingDanGuanLi_Insert_SelectKeHu(string 客户全称)
        {
            SqlParameter[] SQLCMDpas = {
                                           new SqlParameter("@Type", SqlDbType.Char),
                                           new SqlParameter("@客户全称", SqlDbType.Char),
                                       };
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Insert_SelectKeHu";
            SQLCMDpas[1].Value = 客户全称;
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Insert", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        [OperationContract]
        public DataSet frmDingDanGuanLi_Insert_SelectJiFeiGongShi()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Insert_SelectJiFeiGongShi";
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Insert", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        [OperationContract]
        public DataSet frmDingDanGuanLi_Insert_SelectJieSuanFangShi()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Insert_SelectJieSuanFangShi";
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Insert", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }
        [OperationContract]
        public DataSet frmDingDanGuanLi_Insert_SelectCboLanShouZhuangTai()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Insert_SelectCboLanShouZhuangTai";
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Insert", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }

        [OperationContract]
        public DataSet frmDingDanGuanLi_Insert_SelectHuoWu()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "frmDingDanGuanLi_Insert_SelectHuoWu";
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Insert", SQLCMDpas);
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(myDataTable);
            return myDataSet;
        }

        [OperationContract]
        public int btnBaoCun_Click_InsertDanJu(string 单据编号,DateTime 接单时间,
            int 业务员_员工ID,DateTime 要求送达时间,
          int 托运方ID,string 提单号,int 收货方ID,string 寄件地址,string 收货地址, 
          int 结算方式ID,decimal 运费总价,string 备注,int  制单人_员工ID, 
          int 修单人_员工ID,int  寄件网点ID,int  收货网点ID,int 货物揽收状态ID)
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
                                       };
            SQLCMDpas[0].Value = "btnBaoCun_Click_InsertDanJu";
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
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Insert", SQLCMDpas);
            return Convert.ToInt32(myDataTable.Rows[0][0]);
        }

        [OperationContract]
        public int btnBaoCun_Click_InsertMingXi(int 货物ID,decimal 数量,int 计费公式ID,decimal 运费单价,bool 揽收否,int 货运单ID)
        {
            int result = 0;
            SqlParameter[] SQLCMDpas = { 
                                           new SqlParameter("@Type", SqlDbType.Char), 
                                           new SqlParameter("@货物ID", SqlDbType.Int),
                                           new SqlParameter("@数量", SqlDbType.Decimal),
                                           new SqlParameter("@计费公式ID", SqlDbType.Int),
                                           new SqlParameter("@运费单价", SqlDbType.Decimal),
                                           new SqlParameter("@揽收否", SqlDbType.Bit),
                                           new SqlParameter("@货运单ID", SqlDbType.Int),
                                       };
            SQLCMDpas[0].Value = "btnBaoCun_Click_InsertMingXi";
            SQLCMDpas[1].Value = 货物ID;
            SQLCMDpas[2].Value = 数量;
            SQLCMDpas[3].Value = 计费公式ID;
            SQLCMDpas[4].Value = 运费单价;
            SQLCMDpas[5].Value = 揽收否;
            SQLCMDpas[6].Value = 货运单ID;
            int i=  myDALMethod.UpdateData("订单管理_FRM_DingDanGuanLi_Insert", SQLCMDpas);
            if(i!=0)
            {
              result=  btnBaoCun_Click_UpdateZuiDaDanHao();
            }
            return result;
        }

        [OperationContract]
        public int btnBaoCun_Click_SelectZuiDaDanHao()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "btnBaoCun_Click_SelectZuiDaDanHao";
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Insert", SQLCMDpas);
            return Convert.ToInt32(myDataTable.Rows[0][0]);
        } 
        public int btnBaoCun_Click_UpdateZuiDaDanHao()
        {
            SqlParameter[] SQLCMDpas = { new SqlParameter("@Type", SqlDbType.Char) };
            SQLCMDpas[0].Value = "btnBaoCun_Click_UpdateZuiDaDanHao";
            DataTable myDataTable = myDALMethod.QueryDataTable("订单管理_FRM_DingDanGuanLi_Insert", SQLCMDpas);
            return Convert.ToInt32(myDataTable.Rows[0][0]);
        }
    }
}  
