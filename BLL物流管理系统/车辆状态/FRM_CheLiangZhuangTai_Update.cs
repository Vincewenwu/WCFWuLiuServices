using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient; 
using System.IO;
namespace BLL物流管理系统.车辆状态
{
    [ServiceContract]
    public class FRM_CheLiangZhuangTai_Update
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region  查询车队
        [OperationContract]
        public DataSet FRM_CheLiangZhuangTai_Update_Load_ChaXunCheDui()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                          
                                        };
            SQlCMDpas[0].Value = "FRM_CheLiangZhuangTai_Update_Load_ChaXunCheDui";

            DataTable dt = myDALMethod.QueryDataTable("车辆状态_FRM_CheLiangZhuangTai_Update", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
        #region  查询司机
        [OperationContract]
        public DataSet FRM_CheLiangZhuangTai_Update_Load_ChaXunSiJi()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                              
                                        };
            SQlCMDpas[0].Value = "FRM_CheLiangZhuangTai_Update_Load_ChaXunSiJi";

            DataTable dt = myDALMethod.QueryDataTable("车辆状态_FRM_CheLiangZhuangTai_Update", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region  ID查询车辆
        [OperationContract]
        public DataSet FRM_CheLiangZhuangTai_Update_Load_IDChaXunCheLiang(string strCheLiangID)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@车辆ID", SqlDbType.Int),
                                        };
            SQlCMDpas[0].Value = "FRM_CheLiangZhuangTai_Update_Load_IDChaXunCheLiang";
            SQlCMDpas[1].Value =Convert.ToInt32(strCheLiangID);
            DataTable dt = myDALMethod.QueryDataTable("车辆状态_FRM_CheLiangZhuangTai_Update", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region  修改车辆

        [OperationContract]
        public int btnBaoCun_Update_Click_XiuGaiCheLiang(string 车队ID, string 车牌号,
            string 行驶证号, string 保险证号, string 状态ID,
            string 发动机号, string 车架号,
            string 负责人_司机ID, string 紧急联系人_司机ID, byte[][] byteTuPian,string 车辆ID)
        {

          #region 删除原来的照片
            string strTuPian = FRM_CheLiangZhuangTai_Update_Load_IDChaXunCheLiang(车辆ID).Tables[0].Rows[0]["车辆照片"].ToString().Trim(); 
            string[] stWenJianZu = strTuPian.Split(';');
            for (int i = 0; i < stWenJianZu.Length; i++)
            {
                string strBaoCunLuJing = System.AppDomain.CurrentDomain.BaseDirectory;//获取项目路径
                stWenJianZu[i] = strBaoCunLuJing + "image\\" + stWenJianZu[i];//获取项目路径stWenJianZu[i]
              
                if (File.Exists(stWenJianZu[i]))
                {
                    //如果存在则删除
                    File.Delete(stWenJianZu[i]);
                }
            }
            #endregion
            string strWenJianName = WenJianLiuZhuanHuanLuJing(byteTuPian); 
            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@车队ID", SqlDbType.Int),
                                        new SqlParameter("@车牌号", SqlDbType.Char),
                                        new SqlParameter("@行驶证号", SqlDbType.Char),
                                        new SqlParameter("@保险证号", SqlDbType.Char),
                                        new SqlParameter("@车辆照片", SqlDbType.Char),
                                        new SqlParameter("@状态ID", SqlDbType.Int),
                                        new SqlParameter("@发动机号", SqlDbType.Char),
                                        new SqlParameter("@车架号", SqlDbType.Char),
                                        new SqlParameter("@负责人_司机ID", SqlDbType.Int),
                                        new SqlParameter("@紧急联系人_司机ID", SqlDbType.Int),  
                                          new SqlParameter("@车辆ID", SqlDbType.Int),  
                                       };
            SQlCMDpas[0].Value = "btnBaoCun_Update_Click_XiuGaiCheLiang";
            SQlCMDpas[1].Value = Convert.ToInt32(车队ID);
            SQlCMDpas[2].Value = 车牌号;
            SQlCMDpas[3].Value = 行驶证号;
            SQlCMDpas[4].Value = 保险证号;
            SQlCMDpas[5].Value = strWenJianName;
            SQlCMDpas[6].Value = Convert.ToInt32(状态ID);
            SQlCMDpas[7].Value = 发动机号;
            SQlCMDpas[8].Value = 车架号;
            SQlCMDpas[9].Value = Convert.ToInt32(负责人_司机ID);
            SQlCMDpas[10].Value = Convert.ToInt32(紧急联系人_司机ID);
            SQlCMDpas[11].Value =Convert.ToInt32( 车辆ID);
            int j = myDALMethod.UpdateData("车辆状态_FRM_CheLiangZhuangTai_Update", SQlCMDpas);

            return j;
        }
        #endregion
        #region  文件流转换路径
        private string WenJianLiuZhuanHuanLuJing(byte[][] byteTuPian)
        {
            string strWenJianQianZui = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() +
                        DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();

            string strWenJianName = "";

            for (int i = 0; i < byteTuPian.Length; i++)
            {
                string strRiQiWenJian = strWenJianQianZui + i.ToString()+ ".png";//生成图片文件名;
                string strBaoCunLuJing = System.AppDomain.CurrentDomain.BaseDirectory;//获取项目路径
               strBaoCunLuJing = strBaoCunLuJing + "image\\" + strRiQiWenJian;  
                //创建地址
                FileInfo fi = new System.IO.FileInfo(strBaoCunLuJing);
                //文件流对象
                FileStream fs;
                //文件流写入
                fs = fi.OpenWrite();
                //文件流插入数据
                fs.Write(byteTuPian[i], 0, byteTuPian[i].Length);
                //关闭文件流
                fs.Close();

                strWenJianName += strRiQiWenJian + ";";//把所有文件的路径累加到文件字符串。两个路径间用“；”隔开

            }
            return strWenJianName;
        }
        #endregion

        #region  查询图片
        [OperationContract]
        public byte[][] FRM_CheLiangZhuangTai_Update_Load_ChaXunTuPian(string strLuJing)
        {
            return WenJianLiuZhuanHuanLuJing(strLuJing);
        }
        #endregion
        #region  路径转换文件流
        private byte[][] WenJianLiuZhuanHuanLuJing(string strLuJing)
        { 
          try{
            string[] strLuJingZu = strLuJing.Trim().Split(';');//根据“;”分割字符串得到路径组
            byte[][] lstBytes = new byte[strLuJingZu.Length-1][];//以路径组的长度实例化byte数组
           
                for (int i = 0; i < strLuJingZu.Length; i++)//遍历路径组
                {
                    if (strLuJingZu[i] != "")
                    {
                        string strBaoCunLuJing = System.AppDomain.CurrentDomain.BaseDirectory;//获取项目路径
                        strLuJingZu[i] = strBaoCunLuJing + "image\\" + strLuJingZu[i];
                        using (Stream sm = new FileStream(strLuJingZu[i], FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                        {
                            //二进制文件长度
                            int length = (int)sm.Length;
                            //二进制文件存放的二进制数组
                            byte[] bytes = new byte[length];
                            //内存流读取
                            sm.Read(bytes, 0, length);
                            //关闭内存流
                            sm.Close();
                            ////将数据保存到数据库中
                            lstBytes[i] = bytes;
                        }
                    }
                }
            return lstBytes;
          }
          catch { return null; }
        }
        #endregion
    }
}
