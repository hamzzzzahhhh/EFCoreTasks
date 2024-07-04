namespace EFCoreTasks.Models
{
    public class RoomInfo //each student can have one room 
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }
    }
}
