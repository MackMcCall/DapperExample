﻿using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using DapperExample;
//^^^^MUST HAVE USING DIRECTIVES^^^^

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
string connString = config.GetConnectionString("DefaultConnection");
IDbConnection conn = new MySqlConnection(connString);

var repo = new DepartmentRepository(conn);

repo.InsertDepartment("Better Than Cool Stuff");

var departments = repo.GetAllDepartments();

foreach (var dep in departments)
{
    Console.WriteLine($"{dep.Name} | {dep.DepartmentID}");
}