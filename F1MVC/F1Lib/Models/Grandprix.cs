﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Lib.Models
{
    public class Grandprix
    {

        public int ID { get; set; }
        [StringLength(50, ErrorMessage = "Maximumlengte van {0} is {1} tekens")]

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; } = string.Empty; [DataType(DataType.Url)]
        [StringLength(250, ErrorMessage = "Maximum lengte van {0} is {1} tekens")]

        public string? Wiki { get; set; } = string.Empty;

        public Country? Country { get; set; }

        public IEnumerable<Result> Races { get; set; }
        =
        Enumerable.Empty<Result>();
    }
}
