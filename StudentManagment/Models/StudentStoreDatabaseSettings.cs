using System;

namespace StudentManagment.Models
{
    public class StudentStoreDatabaseSettings : IStudentStoreDatabaseSettings
    {
        public string StudentCoursesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

        public StudentStoreDatabaseSettings()
        {
            // Set default values if needed
            StudentCoursesCollectionName = string.Empty;
            ConnectionString = string.Empty;
            DatabaseName = string.Empty;
        }
    }
}
