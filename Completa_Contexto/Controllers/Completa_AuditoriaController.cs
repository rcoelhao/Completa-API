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
    public class Completa_AuditoriaController : ApiController
    {
        private Completa_Contextoss db = new Completa_Contextoss();

        // GET: api/Completa_Auditoria
        public IQueryable<Completa_Auditoria> GetCompleta_Auditoria()
        {
            return db.Completa_Auditoria;
        }

        // GET: api/Completa_Auditoria/5
        [ResponseType(typeof(Completa_Auditoria))]
        public IHttpActionResult GetCompleta_Auditoria(int id)
        {
            Completa_Auditoria completa_Auditoria = db.Completa_Auditoria.Find(id);
            if (completa_Auditoria == null)
            {
                return NotFound();
            }

            return Ok(completa_Auditoria);
        }

        // PUT: api/Completa_Auditoria/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompleta_Auditoria(int id, Completa_Auditoria completa_Auditoria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != completa_Auditoria.Aud_Id)
            {
                return BadRequest();
            }

            db.Entry(completa_Auditoria).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Completa_AuditoriaExists(id))
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

        // POST: api/Completa_Auditoria
        [ResponseType(typeof(Completa_Auditoria))]
        public IHttpActionResult PostCompleta_Auditoria(Completa_Auditoria completa_Auditoria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Completa_Auditoria.Add(completa_Auditoria);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = completa_Auditoria.Aud_Id }, completa_Auditoria);
        }

        // DELETE: api/Completa_Auditoria/5
        [ResponseType(typeof(Completa_Auditoria))]
        public IHttpActionResult DeleteCompleta_Auditoria(int id)
        {
            Completa_Auditoria completa_Auditoria = db.Completa_Auditoria.Find(id);
            if (completa_Auditoria == null)
            {
                return NotFound();
            }

            db.Completa_Auditoria.Remove(completa_Auditoria);
            db.SaveChanges();

            return Ok(completa_Auditoria);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Completa_AuditoriaExists(int id)
        {
            return db.Completa_Auditoria.Count(e => e.Aud_Id == id) > 0;
        }
    }
}