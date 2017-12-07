using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;
using System.IO; 
using System.Drawing;

namespace BLL物流管理系统.报表统计
{
    [ServiceContract]
  public  class FRM_ErWeiMaDanHao
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region  查询车队
        [OperationContract]
        public DataSet FRM_CheLiangZhuangTai_Insert_Load_ChaXunCheDui()
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
        public int btnShengCheng_Click_ChaRuDingDan(string 单据编号, string 提单号,
            byte[] 二维码图片 )
        {

            
            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@单据编号", SqlDbType.Char),
                                        new SqlParameter("@提单号", SqlDbType.Char),
                                        new SqlParameter("@二维码图片", SqlDbType.Image),
                                     
                                       };
            SQlCMDpas[0].Value = "btnShengCheng_Click_ChaRuDingDan";
            SQlCMDpas[1].Value = 单据编号;
            SQlCMDpas[2].Value = 提单号;
            SQlCMDpas[3].Value = 二维码图片;  
            int j = myDALMethod.UpdateData("报表统计_FRM_ErWeiMaDanHao", SQlCMDpas);

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
                string strRiQiWenJian = strWenJianQianZui + i.ToString();
                string strBaoCunLuJing = System.AppDomain.CurrentDomain.BaseDirectory;//获取项目路径

                strBaoCunLuJing = strBaoCunLuJing + "image\\" + strRiQiWenJian + ".png";//生成图片保存路径 
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

                strWenJianName += strBaoCunLuJing + ";";//把所有文件的路径累加到文件字符串。两个路径间用“；”隔开

            }
            return strWenJianName;
        }
        #endregion

    




        #region 根据单据数 日期生成订单编号
        string strDanJuShu;
        public string ShengChengDanHao()
        {
            订单管理.DingDanGuanLi_Insert myDingDanGuanLi_Insert = new 订单管理.DingDanGuanLi_Insert();
            strDanJuShu = myDingDanGuanLi_Insert.frmDingDanGuanLi_Insert_SelectHuodanhao().Tables[0].Rows[0][0].ToString().Trim();
            switch (strDanJuShu.Length)
            {
                case 1:
                    strDanJuShu = "000" + strDanJuShu;
                    break;
                case 2:
                    strDanJuShu = "00" + strDanJuShu;
                    break;
                case 3:
                    strDanJuShu = "0" + strDanJuShu;
                    break;
                case 4:
                    strDanJuShu = "" + strDanJuShu;
                    break;
                default:
                    break;
            }
            DateTime dtnNow = DateTime.Now;
            string strYear = dtnNow.Year.ToString().Trim();
            string strMouth = dtnNow.Month.ToString().Trim();
            strMouth = (strMouth.Length == 1 ? "0" + strMouth : strMouth);
            string strDay = dtnNow.Day.ToString().Trim();
            strDay = (strDay.Length == 1 ? "0" + strDay : strDay);
            return "DD" + strYear + strMouth + strDay + strDanJuShu;
        }
        #endregion

    }
}
