﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tutorial.SqlConn
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"ADMINISTRATOR\SQLEXPRESS";

            string database = "OnlineTeachingDB";
            string username = "sa";
            string password = "11223344";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }

}