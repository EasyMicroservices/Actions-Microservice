﻿using EasyMicroservices.ActionsMicroservice.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.ActionsMicroservice
{
    public class DatabaseBuilder : IDatabaseBuilder
    {
        readonly IConfiguration config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        .Build();

        public void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("ActionDatabase");
            //optionsBuilder.UseSqlServer(config.GetConnectionString("local"));
        }
    }
}
