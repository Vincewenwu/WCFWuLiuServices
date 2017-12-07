using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DALPublic
{
    public class DALMethod
    {
        
        #region 连接字符串
        //public string strConnect = @"Data Source=192.168.2.254,14334;Initial Catalog=广信软件物流管理系统WCF版150120NETA钟振浩;User ID=AG11;Password=AG11";

        public string strConnect = @"Data Source=(local);Initial Catalog=广信物流最终版;User ID=sa;Password=123";
   
        #endregion

        #region 插入、更新、删除
        public int UpdateData(String sql, SqlParameter[] param)
        {
            int count = 0;

            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                count = cmd.ExecuteNonQuery();
                conn.Close();
            }
           
            return count;
        }
        #endregion

        #region 查询数据表
        public DataTable QueryDataTable(String sql, SqlParameter[] param)
        {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddRange(param);
                    da.Fill(dt);
                    conn.Close();
                }

                return dt;
        }
        #endregion

        #region 二进制文件查询方法
        public byte[] QueryDataByte(String sql, SqlParameter[] param)
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                conn.Open();//打开连接
                SqlDataReader dr = null;//初始化数据读取器  
                SqlCommand cmd = new SqlCommand(sql, conn);//创建命令对象
                cmd.CommandType = CommandType.StoredProcedure;//设置命令类型
                cmd.Parameters.AddRange(param);//把参数加进命令对象
                dr = cmd.ExecuteReader();//启动dr
                byte[] File = null;//初始化byte
                if (dr.Read())//执行把二进制流加进byte[]中
                {
                    File = (byte[])dr[0];
                }
                dr.Close();//关闭数据读取器
                conn.Close();//关闭连接
                return File;
            }
        }
        #endregion

     }
}
