using API.Data;
using API.Dtos;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }



        [HttpGet("{id}")]
        public IActionResult GetStudent(int? id)
        {
            if (id == null)
            {
                // return BadRequest();
                ModelState.AddModelError("", "Error!");
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }
           Student student = _context.Students.Find(id);
            if (student == null)
            {
                ModelState.AddModelError("", "Error! not found!");
                return StatusCode(StatusCodes.Status404NotFound, ModelState);
            }
            return Ok(student);
        }
           
            
        
        [HttpGet]
        public IActionResult GetStudents()
        {
            List<DtoStudent> dtoStudents = new List<DtoStudent>();
            foreach (var item in _context.Students.ToList())
            {
                DtoStudent dtoStudent = new DtoStudent();
                dtoStudent.Id = item.Id;
                dtoStudent.Name = item.Name;
                dtoStudent.Surname = item.Surname;
                dtoStudent.Age = item.Age;
                dtoStudent.PositinId = item.PositinId;
                dtoStudent.CreatedDate = item.CreatedDate;
                //dtoStudent.Position = _context.Positions.Select(p => new { p.Id, p.Name }).FirstOrDefault(pa => pa.Id == item.PositinId);

                dtoStudents.Add(dtoStudent);
            }

            return Ok(dtoStudents);
        }

        [HttpPost]
        public IActionResult CreateStudents(Student model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                _context.Students.Add(model);
                _context.SaveChanges();
                return Ok();
              
            }

            return BadRequest();
        }
    }

}
