using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Backend2.Data;
using Backend2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Backend2.Controllers;

    [Route("api/[Controller]")]
    [ApiController]
    public class NotasController : ControllerBase
    {
        private readonly BaseContext _context;
        public NotasController (BaseContext context)
        {
            _context = context;
        }
        
        /* ========== CLASE PARA CREAR UNA NOTA ============= */
        [HttpPost]
        public async Task<ActionResult<Nota>> CrearNota(Nota nota)
        {
            _context.Notas.Add(nota);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetNota", new { id = nota.id }, nota);
        }
        /* ========== CLASE PARA LISTAR TODAS LAS NOTAS ============= */
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nota>>> ListadoNotas()
        {
            return await _context.Notas.ToListAsync();
        }

    }
        

