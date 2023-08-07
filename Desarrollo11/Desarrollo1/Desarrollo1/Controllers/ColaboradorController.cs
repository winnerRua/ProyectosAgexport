using Desarrollo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Desarrollo1.Controllers
{
    //[EnableCors(origins: "https://localhost:44366/", headers:"*", methods:"*")]
    [EnableCors(origins: "*", headers: "*", methods: "GET, POST, PUT, DELETE, OPTIONS")]
    public class ColaboradorController : ApiController
    {
        // GET: api/Colaborador
        public IEnumerable<Colaborador> Get()
        {
            ColaboradorDBContexto contextColaborador = new ColaboradorDBContexto();
            return contextColaborador.ObtenerColaborador();
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Colaborador/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Colaborador
        public bool Post([FromBody]Colaborador colaborador)
        {
            ColaboradorDBContexto contextColaborador = new ColaboradorDBContexto();
            bool res = contextColaborador.AgregarColaborador(colaborador);

            return res;
        }

        // PUT: api/Colaborador/5
        public bool Put(int id, [FromBody]Colaborador colaborador)
        {
            ColaboradorDBContexto contexto = new ColaboradorDBContexto();
            bool res = contexto.ActualizaColaborador(id, colaborador);

            return res;
        }

        // DELETE: api/Colaborador/5
        public bool Delete(int id)
        {
            ColaboradorDBContexto contexto = new ColaboradorDBContexto();
            bool res = contexto.BorraColaborador(id);

            return res;
        }
    }
}
