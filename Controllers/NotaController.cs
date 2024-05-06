using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Backend2.Data;
using Backend2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

/* http://localhost:5070 en point */ 



namespace RegistroHoras.Controllers
{
    public class AuthController : Controller
    {
        private readonly BaseContext _context;

        public AuthController(BaseContext context)
        {
            _context = context;
        }


       



    [HttpPost]
    public async Task<IActionResult> CreateNota([FromBody] Nota nota)
    {
        if (nota == null)
        {
            return BadRequest("Note object is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        _context.Notas.Add(nota);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetNote", new { id = nota.id }, nota);
    }
    
    
}
        
}
