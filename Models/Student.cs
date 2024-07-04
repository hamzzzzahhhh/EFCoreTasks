using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTasks.Models
{
    public class Student
    {
        public int id {  get; set; }
        public string? name { get; set; }

        public int age { get; set; }

        public string? email { get; set; }

        public int rank { get; set; }

        //[ForeignKey("teacher_id")] -> relationship done in model builder in dbcontext
        public int teacher_id { get; set; }

        public Teacher teacher { get; set; }

        public ICollection<StudentProjects> StudentProjects { get; set; }

        public Guid RoomId { get; set; }

        public RoomInfo room { get; set; }
    }
}
