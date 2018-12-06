using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyQQ
{
    class DataOperator
    {
        private static string connString = "Server=DESKTOP-M5AGCMI;Database=db_MyQQ;integrated security=SSPI";
        //数据库连接字符串
        public static SqlConnection connection = new SqlConnection(connString);
        //数据库连接对象

        public int ExecSQL(string sql) //执行sql语句并返回结果中第一行第一列
        {
            SqlCommand command = new SqlCommand(sql, connection);
            if(connection.State==ConnectionState.Closed)  //如果数据库连接是关闭的
            {
                connection.Open();  //打开数据库连接
            }
            int num = Convert.ToInt32(command.ExecuteScalar());  //将查询结果的第一行第一列赋值给num
            connection.Close(); //关闭连接
            return num;
        }

        public int ExecSQLResult(string sql)  //执行sql语句并返回受影响的行数
        {
            SqlCommand command = new SqlCommand(sql, connection);
            if(connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }
            int result = command.ExecuteNonQuery();  //将受影响的行数赋值给result
            connection.Close();
            return result;
        }
    }
}
