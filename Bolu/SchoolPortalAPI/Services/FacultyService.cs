using System;
using System.Collections.Generic;
using System.Linq;
using SchoolPortalAPI.Models;

namespace SchoolPortalAPI.Services
{
    public class FacultyService : IFacultyService
    {
        private Dictionary<int, Faculty> _faculties;
        private int FacultyID = 1;

        public FacultyService()
        {
            _faculties = new Dictionary<int, Faculty>();
        }

        public List<Faculty> GetFaculties()
        {
            return _faculties.Values.ToList();
        }

        public Faculty AddFaculty(Faculty faculty)
        {
            if (!_faculties.ContainsKey(faculty.FacultyID))
            {
                faculty.FacultyID = FacultyID++;
                _faculties.Add(faculty.FacultyID, faculty);
                
            }

            return faculty;
        }

        public Faculty GetByFacultyId(int FacultyID)
        {
            if (_faculties.ContainsKey(FacultyID))
                return _faculties[FacultyID];

            return null;
        }

        public Faculty UpdateFaculty(int FacultyID, Faculty faculty)
        {
            if (!_faculties.ContainsKey(FacultyID))
            {
                _faculties[FacultyID] = AddFaculty(faculty);
             
            }
            else
            {
                _faculties[FacultyID] = faculty;
               

            }

            return faculty;

        }
        public Faculty DeleteFaculty(int FacultyID)
        {
            var removed = _faculties[FacultyID];
            for (var index = _faculties.Count - 1; index >= 0; index--)
            {
                if (_faculties.ContainsKey(FacultyID))
                {
                    _faculties.Remove(FacultyID);
                }

            }
            return removed;
        }
        //public Faculty DeleteFaculty(int FacultyID)
        //{
            
        //    if (!_faculties.ContainsKey(FacultyID))
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        var removed = _faculties[FacultyID];

        //        _faculties.Remove(FacultyID);

        //        return removed;
        //    }

            
        
    }
}

