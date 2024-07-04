

using EFCoreTasks.Data;
using EFCoreTasks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly AppDBContext dBContext;

        public HomeController(AppDBContext dBContext)
        { 
            this.dBContext = dBContext;
        }

        [HttpGet("GetViews")]
        public IActionResult GetViews()
        {
            var view = dBContext.view1.ToList();

            return Ok(view);
        }

        [HttpGet("GetEmployees")]
        public IActionResult GetEmployees()
        {
            var employeeswithManagers = dBContext.employees.Select(e => new
            {
                EmployeeName = e.Name,
                ManagerName = e.Manager != null ? e.Manager.Name : "No Manager",
                e.FullInformation
            }).ToList();

            return Ok(employeeswithManagers);
        }

        [HttpGet("AddRoomInfo")]
        public IActionResult AddRoomsInfo()
        {
            var roomNames = new[] { "room1", "room2", "room3", "room4", "room5"
            , "room6", "room7", "room8", "room9", "room10"};

            var counter = 0;

            foreach (var student in dBContext.Students)
            {
                var room = new RoomInfo
                {
                    Name = roomNames[counter],
                    Student = student,
                };

                counter++;  

                dBContext.Rooms.Add(room);
            }

            dBContext.SaveChanges();

            return Ok();
        }

        [HttpGet("EagerLoading")]
        public async Task<IActionResult> GetRoomsEagerLoading()
        {
            var rooms = await dBContext.Rooms.Include(a => a.Student).ToListAsync();
   
            return Ok(rooms);
        }

        [HttpGet("LazyLoading")]
        public async Task<IActionResult> GetRoomsLazyLoading()
        {
            var students = await dBContext.Students.ToListAsync();

            foreach (var student in students)
            {
                var room = dBContext.Rooms.Where(e => e.StudentId.Equals(student.id)).FirstOrDefault();

                student.room = room;
            }
            return Ok(students);
        }
    }
}
