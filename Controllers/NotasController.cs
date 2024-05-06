using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Backend2.Data;
using Backend2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Data.SqlClient;
using MySqlConnector;
using Microsoft.AspNetCore.Cors;




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


        





        [HttpGet("archivadas")]
        public async Task<ActionResult<IEnumerable<Nota>>> GetNotasArchivadas()
        {
            try
            {
                var notasArchivadas = await _context.Notas.Where(n => n.Estado == "Archivado").ToListAsync();
                return Ok(notasArchivadas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet("Papeleria")]
        public async Task<ActionResult<IEnumerable<Nota>>> GetPapeleria()
        {
            try
            {
                var notasPapeleria = await _context.Notas.Where(n => n.Estado == "Papeleria").ToListAsync();
                return Ok(notasPapeleria);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("Activa")]
        public async Task<ActionResult<IEnumerable<Nota>>> GetActiva()
        {
            try
            {
                var notasActiva= await _context.Notas.Where(n => n.Estado == "Activa").ToListAsync();
                return Ok(notasActiva);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }










                [HttpPut("{id}/estado")]
                public IActionResult CambiarEstadoNota(int id, [FromBody] Nota notaActualizada)
                {
                    try
                    {
                        // Aquí deberías actualizar el estado de la nota en tu base de datos
                        // Por ejemplo, puedes usar Entity Framework para realizar la actualización
                        // o ejecutar una consulta SQL directa

                        // Ejemplo de Entity Framework:
                        var nota = _context.Notas.FirstOrDefault(n => n.id == id);
                        if (nota == null)
                        {
                            return NotFound($"La nota con ID {id} no existe.");
                        }

                        nota.Estado = notaActualizada.Estado;
                        _context.SaveChanges();

                        return Ok("Estado de la nota cambiado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        return StatusCode(500, $"Error al cambiar el estado de la nota: {ex.Message}");
                    }
                }


    }

 