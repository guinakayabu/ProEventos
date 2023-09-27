using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEvenetos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1 lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "foto.png",                              
               },
               new Evento(){
                   EventoId = 2,
                   Tema = "Angular e Suas Novidade",
                   Local = "São Paulo",
                   Lote = "2 lote",
                   QtdPessoas = 250,
                   DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                   ImagemUrl = "foto2.png",
            }
        };

        public EventoController()
        {  
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
              return _evento;
        }
         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
              return _evento.Where(evento => evento.EventoId == id);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}