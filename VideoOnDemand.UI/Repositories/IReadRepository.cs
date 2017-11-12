﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoOnDemand.Data.Data.Entities;

namespace VideoOnDemand.UI.Repositories
{
    public interface IReadRepository
    {
        IEnumerable<Course> GetCourses(string userId);
    }
}