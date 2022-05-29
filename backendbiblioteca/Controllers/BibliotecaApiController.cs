#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using backendbiblioteca.Modelo;
using backendbiblioteca.Data;


namespace backendbiblioteca.Controllers
{
    [Route("[controller]/[action]")]
    public class BibliotecaApiController : ControllerBase
    {
        private readonly BibliotecaApiContext _context;
        private Book book;
        private Author author;
        private Student student;
       

        public BibliotecaApiController(BibliotecaApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> CheckBook()
        {
            return Ok(await _context.Books.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult> AddBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return Ok(book);
        }
        [HttpPut]
        public async Task<ActionResult> UpdateBook(Book book)
        {
            _context.Update(book);
            await _context.SaveChangesAsync();
            return Ok(book);
        }
        [HttpDelete]
        public async Task<ActionResult> DelBook(Book book)
        {
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return Ok(book);
        }

        [HttpGet]
        public async Task<ActionResult> CheckAuthor()
        {
            return Ok(await _context.Authors.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult> AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            await _context.SaveChangesAsync();
            return Ok(author);
        }
        [HttpPut]
        public async Task<ActionResult> UpdtAuthor(Author author)
        {
            _context.Update(author);
            await _context.SaveChangesAsync();
            return Ok(author);
        }
        [HttpDelete]
        public async Task<ActionResult> DelAuthor(Author author)
        {
            _context.Authors.Remove(author);
            await _context.SaveChangesAsync();
            return Ok(author);
        }

        [HttpGet]
        public async Task<ActionResult> CheckStudent()
        {
            return Ok(await _context.Students.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult> AddStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return Ok(student);
        }
        [HttpPut]
        public async Task<ActionResult> UpdtStudent(Student student)
        {
            _context.Update(student);
            await _context.SaveChangesAsync();
            return Ok(student);
        }
        [HttpDelete]
        public async Task<ActionResult> DelStudent(Student student)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return Ok(student);
        }
        

    }
}