﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoast_EducationAPI.ModelViews
{
    public class TeacherViewForPosting
    {
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public ICollection<CourseViewForPosting> Courses { get; set; }
            = new List<CourseViewForPosting>();
    }
}
