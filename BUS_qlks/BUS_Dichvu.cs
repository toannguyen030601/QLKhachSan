﻿using DAL_qlks;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_qlks
{
    public class BUS_Dichvu
    {
        DAL_Dichvu busnv = new DAL_Dichvu();
        public DataTable Danhsachdvu()
        {
           return busnv.Danhsachdvu();
        }
    }
}
