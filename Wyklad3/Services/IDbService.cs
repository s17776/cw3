﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wyklad3.Models;

namespace Wyklad3.Services
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
