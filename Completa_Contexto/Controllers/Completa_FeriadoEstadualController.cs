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
    public class Completa_FeriadoEstadualController : ApiController
    {
        private Completa_Contextoss db = new Completa_Contextoss();

        // GET: api/Completa_FeriadoEstadual
        public IQueryable<Completa_FeriadoEstadual> GetCompleta_FeriadoEstadual()
        {
            return db.Completa_FeriadoEstadual;
        }

        // GET: api/Completa_FeriadoEstadual/5
        [ResponseType(typeof(Completa_FeriadoEstadual))]
        public IHttpActionResult GetCompleta_FeriadoEstadual(int id)
        {
            Completa_FeriadoEstadual completa_FeriadoEstadual = db.Completa_FeriadoEstadual.Find(id);
            if (completa_FeriadoEstadual == null)
            {
                return NotFound();
            }

            return Ok(completa_FeriadoEstadual);
        }

        // PUT: api/Completa_FeriadoEstadual/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompleta_FeriadoEstadual(int id, Completa_FeriadoEstadual completa_FeriadoEstadual)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != completa_FeriadoEstadual.FerEst_Id)
            {
                return BadRequest();
            }

            db.Entry(completa_FeriadoEstadual).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Completa_FeriadoEstadualExists(id))
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

        // POST: api/Completa_FeriadoEstadual
        [ResponseType(typeof(Completa_FeriadoEstadual))]
        public IHttpActionResult PostCompleta_FeriadoEstadual(Completa_FeriadoEstadual completa_FeriadoEstadual)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Completa_FeriadoEstadual.Add(completa_FeriadoEstadual);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = completa_FeriadoEstadual.FerEst_Id }, completa_FeriadoEstadual);
        }

        // DELETE: api/Completa_FeriadoEstadual/5
        [ResponseType(typeof(Completa_FeriadoEstadual))]
        public IHttpActionResult DeleteCompleta_FeriadoEstadual(int id)
        {
            Completa_FeriadoEstadual completa_FeriadoEstadual = db.Completa_FeriadoEstadual.Find(id);
            if (completa_FeriadoEstadual == null)
            {
                return NotFound();
            }

            db.Completa_FeriadoEstadual.Remove(completa_FeriadoEstadual);
            db.SaveChanges();

            return Ok(completa_FeriadoEstadual);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Completa_FeriadoEstadualExists(int id)
        {
            return db.Completa_FeriadoEstadual.Count(e => e.FerEst_Id == id) > 0;
        }
    }
}