using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTasks.Models
{
    public class Assistant
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public string Description { get; set; }

        //[ForeignKey ("teacherId")]
        public int teacherId { get; set; }

        public Teacher teacher { get; set; }

        public Enum.status status;

    }
}
