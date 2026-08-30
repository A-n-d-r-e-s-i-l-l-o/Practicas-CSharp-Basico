using Microsoft.AspNetCore.Mvc;
using MiApiController.Models;
using MiApiController.Services;

namespace MiApiController.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductosController : ControllerBase
{
    private readonly IProductoService _productoService;

    public ProductosController(IProductoService productoService)
    {
        _productoService = productoService;
    }

    [HttpGet]
    public IActionResult ObtenerTodos()
    {
        var productos = _productoService.ObtenerTodos();
        return Ok(productos);
    }

    [HttpGet("{id}")]
    public IActionResult ObtenerPorId(int id)
    {
        var producto = _productoService.ObtenerPorId(id);
        if (producto == null)
        {
            return NotFound(new { Mensaje = $"El producto con Id {id} no existe." });
        }
        return Ok(producto);
    }

    [HttpPost]
    public IActionResult Crear([FromBody] Producto nuevoProducto)
    {
        var productoCreado = _productoService.Crear(nuevoProducto);
        return CreatedAtAction(nameof(ObtenerPorId), new { id = productoCreado.id }, productoCreado);
    }

    [HttpPut("{id}")]
    public IActionResult Actualizar(int id, [FromBody] Producto productoActualizado)
    {
        var exito = _productoService.Actualizar(id, productoActualizado);
        if (!exito)
        {
            return NotFound(new { Mensaje = $"El producto con Id {id} no existe." });
        }
        return Ok(new { Mensaje = "Producto actualizado correctamente." });
    }

    [HttpDelete("{id}")]
    public IActionResult Eliminar(int id)
    {
        var exito = _productoService.Eliminar(id);
        if (!exito)
        {
            return NotFound(new { Mensaje = $"El producto con Id {id} no existe." });
        }
        return NoContent();
    }
}