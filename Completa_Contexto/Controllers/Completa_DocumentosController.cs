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
    public class Completa_DocumentosController : ApiController
    {
        private Completa_Contextoss db = new Completa_Contextoss();

        // GET: api/Completa_Documentos
        public IQueryable<Completa_Documentos> GetCompleta_Documentos()
        {
            return db.Completa_Documentos;
        }

        // GET: api/Completa_Documentos/5
        [ResponseType(typeof(Completa_Documentos))]
        public IHttpActionResult GetCompleta_Documentos(int id)
        {
            Completa_Documentos completa_Documentos = db.Completa_Documentos.Find(id);

            if (completa_Documentos == null)
            {
                return NotFound();
            }

            return Ok(completa_Documentos);
        }


        // GET: api/Completa_Documentos/ByCli_Id/5
        [HttpGet]
        [Route("api/Completa_Documentos/ByCli_Id/{Cli_Id:int}")]
        [ResponseType(typeof(Completa_Documentos))]
        public IHttpActionResult Completa_DocumentosByCli_Id(int Cli_Id)
        {
            var completa_DocumentosDTO = db.Completa_Documentos
                .Where(x => x.Cli_Id == Cli_Id)
                .Select(o =>
                    new Completa_DocumentosDTO
                    {
                        Doc_Id = o.Doc_Id,
                        Doc_Nome = o.Doc_Nome,
                        Cli_Id = o.Cli_Id,
                        Tip_Id = o.Tip_Id,
                        Doc_Aud = o.Doc_Aud
                    }).ToList();

            if (completa_DocumentosDTO == null)
            {
                return NotFound();
            }
            return Ok(completa_DocumentosDTO);
        }

        // PUT: api/Completa_Documentos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompleta_Documentos(int id, Completa_Documentos completa_Documentos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != completa_Documentos.Doc_Id)
            {
                return BadRequest();
            }

            db.Entry(completa_Documentos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Completa_DocumentosExists(id))
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

        // POST: api/Completa_Documentos
        [ResponseType(typeof(Completa_Documentos))]
        public IHttpActionResult PostCompleta_Documentos(Completa_Documentos completa_Documentos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Completa_Documentos.Add(completa_Documentos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = completa_Documentos.Doc_Id }, completa_Documentos);
        }

        // DELETE: api/Completa_Documentos/5
        [ResponseType(typeof(Completa_Documentos))]
        public IHttpActionResult DeleteCompleta_Documentos(int id)
        {
            Completa_Documentos completa_Documentos = db.Completa_Documentos.Find(id);
            if (completa_Documentos == null)
            {
                return NotFound();
            }

            db.Completa_Documentos.Remove(completa_Documentos);
            db.SaveChanges();

            return Ok(completa_Documentos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Completa_DocumentosExists(int id)
        {
            return db.Completa_Documentos.Count(e => e.Doc_Id == id) > 0;
        }
    }
}