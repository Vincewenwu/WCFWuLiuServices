using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;

namespace BLL物流管理系统.司机管理
{
    [ServiceContract]
    class BLL_FRM_SiJiGuanLi_Insert
    {
        DALPublic.DALMethod DAL = new DALPublic.DALMethod();
        [OperationContract]
        public DataSet FRM_SiJiGuanLi_Load_Insert_ChaXunZhunJiaCheXin()
        {
            SqlParameter[] pas = new SqlParameter[] { new SqlParameter("@Type", SqlDbType.Char) };
            pas[0].Value = "FRM_SiJiGuanLi_Load_Insert_ChaXunZhunJiaCheXin";
            DataTable dt = DAL.QueryDataTable("司机管理_FRM_SiJiGuanLi_Insert", pas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public bool btnQueDing_Click_XinZhengSiJi(string 司机名称,string 出生日期,string 联系电话,string 联系地址,string 身份证号,string 驾驶证号,string 备注
            ,int 机构组织ID,int 准驾车型ID,bool 是否离职)
        {
            SqlParameter[] pas = new SqlParameter[] {new SqlParameter("@Type",SqlDbType.Char),
                new SqlParameter("@司机名称",SqlDbType.Char),new SqlParameter("@出生日期",SqlDbType.Date),
                new SqlParameter("@联系电话",SqlDbType.Char),new SqlParameter("@联系地址",SqlDbType.Char),
                new SqlParameter("@身份证号",SqlDbType.Char),
                new SqlParameter("@驾驶证号",SqlDbType.Char),new SqlParameter("@备注",SqlDbType.Char),new SqlParameter("@机构组织ID",SqlDbType.Int),
                new SqlParameter("@准驾车型ID",SqlDbType.Int),new SqlParameter("@是否离职",SqlDbType.Bit)
            };
            pas[0].Value = "btnQueDing_Click_XinZhengSiJi";
            pas[1].Value = 司机名称;
            pas[2].Value = 出生日期;
            pas[3].Value = 联系电话;
            pas[4].Value = 联系地址;
            pas[5].Value = 身份证号;
            pas[6].Value = 驾驶证号;
            pas[7].Value = 备注;
            pas[8].Value = 机构组织ID;
            pas[9].Value = 准驾车型ID;
            pas[10].Value = 是否离职;

            if (DAL.UpdateData("司机管理_FRM_SiJiGuanLi_Insert", pas) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
