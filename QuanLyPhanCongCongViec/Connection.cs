﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanCongCongViec
{
    public class Connection
    {
        private static string ConnectionString = "Data Source= DESKTOP-2E91IF7 ;Initial Catalog=QuanLyCongViec;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
