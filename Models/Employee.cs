namespace EFCoreTasks.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ManagerID { get; set; }

        public Employee? Manager { get; set; }

        public ICollection<Employee> subordinates { get; set; }

        //now we will be writing derived property

        public string FullInformation
        {
            get
            {
                return Manager != null ? $"{Name} Manager Name : {Manager.Name}" : $"{Name}";
            }
        }
    }
}
