using System;
using System.Collections.Generic;
using SchoolPortalAPI.Models;

namespace SchoolPortalAPI.Services
{
    public interface IFacultyService
    {
        public List<Faculty> GetFaculties();

        public Faculty AddFaculty(Faculty faculty);

        public Faculty UpdateFaculty(int Facultyid, Faculty faculty);

        public Faculty DeleteFaculty(int FacultyID);

        public Faculty GetByFacultyId(int Facultyid);
    }
}



