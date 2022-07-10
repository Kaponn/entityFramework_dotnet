﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Database.Entities
{
    [Table("tblStreet")]
    public class Street
    {
        public int Id { get; set; }

        public City City { get; set; }

        public string Name { get; set; }
    }
}
