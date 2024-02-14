﻿using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Abstracts
{
    public interface ICourseService
    {
        List<Course> GetCourseId(int id);
    }
}
