using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Completa_Contexto.Models;

namespace Completa_Contexto.Controllers
{
    public class Completa_AssinaturasController : ApiController
    {
        private Completa_Contextoss db = new Completa_Contextoss();

        // GET: api/Completa_Assinaturas
        public IQueryable<Completa_Assinaturas> GetCompleta_Assinaturas()
        {
            return db.Completa_Assinaturas;
        }

        // GET: api/Completa_Assinaturas/5
        [ResponseType(typeof(Completa_Assinaturas))]
        public IHttpActionResult GetCompleta_Assinaturas(int id)
        {
            Completa_Assinaturas Completa_Assinaturas = db.Completa_Assinaturas.Find(id);

            if (Completa_Assinaturas == null)
            {
                return NotFound();
            }

            return Ok(Completa_Assinaturas);
        }


        // GET: api/Completa_Assinaturas/ByCli_Id/5
        [HttpGet]
        [Route("api/Completa_Assinaturas/ByCli_Id/{Cli_Id:int}")]
        [ResponseType(typeof(Completa_Assinaturas))]
        public IHttpActionResult Completa_AssinaturasByCli_Id(int Cli_Id)
        {
            var Completa_AssinaturasDTO = db.Completa_Assinaturas
                .Where(x => x.Cli_Id == Cli_Id)
                .Select(o =>
                    new Completa_AssinaturasDTO
                    {
                        Ass_Id = o.Ass_Id,
                        Cli_Id = o.Cli_Id
                    }).ToList();

            if (Completa_AssinaturasDTO == null)
            {
                return NotFound();
            }
            return Ok(Completa_AssinaturasDTO);
        }

        // PUT: api/Completa_Assinaturas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompleta_Assinaturas(int id, Completa_Assinaturas Completa_Assinaturas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != Completa_Assinaturas.Ass_Id)
            {
                return BadRequest();
            }

            db.Entry(Completa_Assinaturas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Completa_AssinaturasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Completa_Assinaturas
        [ResponseType(typeof(Completa_Assinaturas))]
        public IHttpActionResult PostCompleta_Assinaturas(Completa_Assinaturas Completa_Assinaturas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Completa_Assinaturas.Add(Completa_Assinaturas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = Completa_Assinaturas.Ass_Id }, Completa_Assinaturas);
        }

        // DELETE: api/Completa_Assinaturas/5
        [ResponseType(typeof(Completa_Assinaturas))]
        public IHttpActionResult DeleteCompleta_Assinaturas(int id)
        {
            Completa_Assinaturas Completa_Assinaturas = db.Completa_Assinaturas.Find(id);
            if (Completa_Assinaturas == null)
            {
                return NotFound();
            }

            db.Completa_Assinaturas.Remove(Completa_Assinaturas);
            db.SaveChanges();

            return Ok(Completa_Assinaturas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Completa_AssinaturasExists(int id)
        {
            return db.Completa_Assinaturas.Count(e => e.Cli_Id == id) > 0;
        }
    }
}