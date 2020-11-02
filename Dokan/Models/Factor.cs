﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dokan.Models
{
    public class Factor
    {
        public int FactorId { get; set; }

        public string TodayDate { get; set; }
        public string CustomerName { get; set; }
        public int Balance { get; set; }

        public int Cash { get; set; }
        public int Total { get; set; }
        

    }
}
