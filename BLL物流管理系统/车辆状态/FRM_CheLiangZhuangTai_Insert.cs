using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;
using System.IO;
 
 
namespace BLL物流管理系统.车辆状态
{
    [ServiceContract]
    public class FRM_CheLiangZhuangTai_Insert
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region  查询车队
        [OperationContract]
        public DataSet FRM_CheLiangZhuangTai_Insert_Load_ChaXunCheDui( )
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                          
                                        };
            SQlCMDpas[0].Value = "FRM_CheLiangZhuangTai_Insert_Load_ChaXunCheDui";
            
            DataTable dt = myDALMethod.QueryDataTable("车辆状态_FRM_CheLiangZhuangTai_Insert", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
        #region  查询司机
        [OperationContract]
        public DataSet FRM_CheLiangZhuangTai_Insert_Load_ChaXunSiJi()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                              
                                        };
            SQlCMDpas[0].Value = "FRM_CheLiangZhuangTai_Insert_Load_ChaXunSiJi";
        
            DataTable dt = myDALMethod.QueryDataTable("车辆状态_FRM_CheLiangZhuangTai_Insert", SQlCMDpas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
        #region  插入车辆
        [OperationContract] 
        public int btnBaoCun_Insert_Click_ChaRuCheLiang(string 车队ID, string 车牌号,
            string 行驶证号, string 保险证号, string 状态ID,  
            string 发动机号, string 车架号,
            string 负责人_司机ID, string 紧急联系人_司机ID, byte[][] byteTuPian)
        {

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
                                       };
            SQlCMDpas[0].Value = "btnBaoCun_Insert_Click_ChaRuCheLiang";
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

            int j = myDALMethod.UpdateData("车辆状态_FRM_CheLiangZhuangTai_Insert", SQlCMDpas);

            return j;
        }
        #endregion
        #region  文件流转换路径
        private string WenJianLiuZhuanHuanLuJing(byte[][] byteTuPian)
        {
            try
            {
                string strWenJianQianZui = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() 
                                           + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() 
                                           + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() 
                                           + DateTime.Now.Millisecond.ToString();

                string strWenJianName = "";
                for (int i = 0; i < byteTuPian.Length; i++)
                {
                    string strRiQiWenJian = strWenJianQianZui + i.ToString() + ".png";//生成图片的文件名 ;
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
                    strWenJianName += strRiQiWenJian + ";";//把所有文件的路径累加到文件字符串。两个路径间用“;”隔开

                }
                return strWenJianName;
            }
            catch { return null; }
        }
        #endregion

        


    }
}
