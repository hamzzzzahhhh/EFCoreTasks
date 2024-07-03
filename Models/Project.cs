namespace EFCoreTasks.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //public string student_id { get; set; }
        public ICollection<StudentProjects> StudentProjects { get; set; }
    }
}
