using System;
using System.Collections.Generic;

namespace FacultyManagement.Services
{
    public class FacultyServices: IFacultyServices
    {
        private List<Faculty> _faculties;

        public FacultyServices()
        {
            _faculties = new List<Faculty>();
        }

        public List<Faculty> GetFaculty()
        {
            return _faculties;
        }

        public Faculty AddFaculty(Faculty faculty)
        {
            _faculties.Add(faculty);
            return faculty;
        }

        public Faculty UpdateFaculty(string id, Faculty faculty)
        {
            for (var index = _faculties.Count - 1; index >= 0; index--)
            {
                if (_faculties[index].ID == id)
                {
                    _faculties[index] = faculty;
                }
            }
            return faculty;
        }

        public string DeleteFaculty(string id)
        {
            for (var index = _faculties.Count - 1; index >= 0; index--)
            {
                if (_faculties[index].ID == id)
                {
                    _faculties.RemoveAt(index);
                }
            }

            return id;
        }
    }
}
