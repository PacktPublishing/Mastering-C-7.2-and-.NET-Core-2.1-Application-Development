using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentsAPI.Data;
using StudentsAPI.Models;

namespace StudentsAPI.Controllers
{
    [Route("api/Students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentContext _context;
        public StudentsController(StudentContext context)
        {
            _context = context;
        }

        [HttpGet("{id}", Name = "GetStudent")]
        public ActionResult<Student> GetById(Guid id)
        {
            var item = _context.Students.Where(x => x.StudentID == id);
            if (item == null)
            {
                return NotFound();
            }
            return item.Single();
        }
        [HttpGet]
        [Produces("application/xml")]
        public ActionResult<List<Student>> GetAll()
        {
            return _context.Students.ToList();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return CreatedAtRoute("GetStudent", new { id = student.StudentID }, student);
        }
    }
}
