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
public class CategoriasController : ControllerBase
{
    private readonly BaseContext _context;
    public CategoriasController (BaseContext context)
    {
        _context = context;
    }
    /* ========== CLASE PARA LISTAR TODAS LAS CATEGORIAS ============= */
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Categoria>>> ListadoCategorias()
    {
        return await _context.Categorias.ToListAsync();
    }
    /* ========== CLASE PARA CREAR UNA NOTA ============= */
    [HttpPost]
    public async Task<ActionResult<Categoria>> CrearCategoria(Categoria category)
    {
        _context.Categorias.Add(category);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetCategoria", new { id = category.Id }, category);
    }
    /* public async Task<ActionResult<Nota>> CrearCategoria(Nota nota)
    {
        _context.Notas.Add(nota);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetNota", new { id = nota.id }, nota);
    } */


}