﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBookProblem_ADO.NET
{
    public class DBConnection
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {
            /// Specifying the connectionString from the sql server connection.
            string connectiongString = @"Data Source=DESKTOP-4849HJR;Initial Catalog=payroll_service;Integrated Security=True;User ID=dheermeena;Password=Dheer@1998";
            SqlConnection connection = new SqlConnection(connectiongString);
            return connection;
        }
    }
}