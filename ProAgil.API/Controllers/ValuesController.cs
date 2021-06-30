using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProAgil.API.Data;
using ProAgil.API.Model;

namespace ProAgil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public DataContext _context { get; }
        public ValuesController(DataContext context)
        {
            _context = context;

        }



        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _context.Eventos.ToListAsync();
                return Ok(results);
            }
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }
             

        //   new Evento(){
        //              EventoId = 1,
        //             Tema = "Asp Net Core Angular" ,
        //             Local = "Rio de Janeiro" ,
        //              Lote = "1º Lote",
        //             QtdPessoas = 200,
        //              DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
        //
        //                 }
        //        ,
        //           new Evento(){
        //                EventoId = 2,
        //               Tema = "Angular e suas novidades" ,
        //            Local = "São Paulo" ,
        //              Lote = "2º Lote",
        //              QtdPessoas = 200,
        //              DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")//
        //               }  

        }

        // GET api/values/1
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            
            try
            {
                var results = await _context.Eventos.FirstOrDefaultAsync(x => x.EventoId == id);
                return Ok(results );
            }
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
