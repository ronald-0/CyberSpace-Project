using System;
using System.Collections.Generic;

namespace FacultyManagement.Services
{
    public interface IFacultyServices
    {
        public List<Faculty> GetFaculty();

        public Faculty AddFaculty(Faculty falculty);

        public Faculty UpdateFaculty(string id, Faculty falculty);

        public string DeleteFaculty(string id);
    }
}
