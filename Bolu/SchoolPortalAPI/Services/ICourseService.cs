using System;
using System.Collections.Generic;
using SchoolPortalAPI.Models;

namespace SchoolPortalAPI.Services
{
    public interface ICourseService
    {
            public List<Course> GetCourses();

            public Course AddCourse(Course courseItem);

            public Course UpdateCourse(int CourseID, Course courseItem);

            public Course DeleteCourse(int CourseID);

            public Course GetById(int CourseID);

    }


}
