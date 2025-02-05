﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class SQLHelper
    {
        SqlConnection conn;
        public SQLHelper(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }

        public SQLHelper()
        {
        }

        public bool IsConnection
        {
            get
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return true;
            }
        }

        //Kiểm tra chuỗi cấu hình data LinQ
        public int Check_Config()
        {
            conn = new SqlConnection(Properties.Settings.Default.QL_KHOHANGConnectionString);
            if (Properties.Settings.Default.QL_KHOHANGConnectionString == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }

        public DataTable GetSeverName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }

        public DataTable GetDBName(string pSever, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source=" + pSever + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " + pPass + "");
            da.Fill(dt);
            return dt;
        }
    }
}
