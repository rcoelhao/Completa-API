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
    public class Completa_FeriadoController : ApiController
    {
        private Completa_Contextoss db = new Completa_Contextoss();

        // GET: api/Completa_Feriado
        public IQueryable<Completa_Feriado> GetCompleta_Feriado()
        {
            return db.Completa_Feriado;
        }

        // GET: api/Completa_Feriado/5
        [ResponseType(typeof(Completa_Feriado))]
        public IHttpActionResult GetCompleta_Feriado(int id)
        {
            Completa_Feriado completa_Feriado = db.Completa_Feriado.Find(id);
            if (completa_Feriado == null)
            {
                return NotFound();
            }

            return Ok(completa_Feriado);
        }

        // PUT: api/Completa_Feriado/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompleta_Feriado(int id, Completa_Feriado completa_Feriado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != completa_Feriado.Fer_Id)
            {
                return BadRequest();
            }

            db.Entry(completa_Feriado).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Completa_FeriadoExists(id))
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

        // POST: api/Completa_Feriado
        [ResponseType(typeof(Completa_Feriado))]
        public IHttpActionResult PostCompleta_Feriado(Completa_Feriado completa_Feriado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Completa_Feriado.Add(completa_Feriado);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = completa_Feriado.Fer_Id }, completa_Feriado);
        }

        // DELETE: api/Completa_Feriado/5
        [ResponseType(typeof(Completa_Feriado))]
        public IHttpActionResult DeleteCompleta_Feriado(int id)
        {
            Completa_Feriado completa_Feriado = db.Completa_Feriado.Find(id);
            if (completa_Feriado == null)
            {
                return NotFound();
            }

            db.Completa_Feriado.Remove(completa_Feriado);
            db.SaveChanges();

            return Ok(completa_Feriado);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Completa_FeriadoExists(int id)
        {
            return db.Completa_Feriado.Count(e => e.Fer_Id == id) > 0;
        }
    }
}