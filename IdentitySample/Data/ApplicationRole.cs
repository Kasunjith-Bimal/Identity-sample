﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySample.Data
{
    public class ApplicationRole: IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
