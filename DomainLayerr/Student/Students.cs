﻿using DomainLayerr.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayerr.Student
{
    public class Students : BaseEntity
    {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
            public string Education { get; set; }
            public string Address { get; set; }


    }
}
