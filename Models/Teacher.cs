namespace EFCoreTasks.Models
{
    public class Teacher
    {
        public int teacherId { get; set; }

        public string teacherName { get; set; }

        public string teacherDescription { get; set; }

        public string teacherStatus { get; set; }

        public string educationlevel { get; set; }

        public ICollection<Student> students { get; set; }

        public Assistant assistant { get; set; }

    }
}
