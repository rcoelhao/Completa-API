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
    public class Completa_FeriadoMunicipalController : ApiController
    {
        private Completa_Contextoss db = new Completa_Contextoss();

        // GET: api/Completa_FeriadoMunicipal
        public IQueryable<Completa_FeriadoMunicipal> GetCompleta_FeriadoMunicipal()
        {
            return db.Completa_FeriadoMunicipal;
        }

        // GET: api/Completa_FeriadoMunicipal/5
        [ResponseType(typeof(Completa_FeriadoMunicipal))]
        public IHttpActionResult GetCompleta_FeriadoMunicipal(int id)
        {
            Completa_FeriadoMunicipal completa_FeriadoMunicipal = db.Completa_FeriadoMunicipal.Find(id);
            if (completa_FeriadoMunicipal == null)
            {
                return NotFound();
            }

            return Ok(completa_FeriadoMunicipal);
        }

        // PUT: api/Completa_FeriadoMunicipal/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompleta_FeriadoMunicipal(int id, Completa_FeriadoMunicipal completa_FeriadoMunicipal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != completa_FeriadoMunicipal.Fem_Id)
            {
                return BadRequest();
            }

            db.Entry(completa_FeriadoMunicipal).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Completa_FeriadoMunicipalExists(id))
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

        // POST: api/Completa_FeriadoMunicipal
        [ResponseType(typeof(Completa_FeriadoMunicipal))]
        public IHttpActionResult PostCompleta_FeriadoMunicipal(Completa_FeriadoMunicipal completa_FeriadoMunicipal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Completa_FeriadoMunicipal.Add(completa_FeriadoMunicipal);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = completa_FeriadoMunicipal.Fem_Id }, completa_FeriadoMunicipal);
        }

        // DELETE: api/Completa_FeriadoMunicipal/5
        [ResponseType(typeof(Completa_FeriadoMunicipal))]
        public IHttpActionResult DeleteCompleta_FeriadoMunicipal(int id)
        {
            Completa_FeriadoMunicipal completa_FeriadoMunicipal = db.Completa_FeriadoMunicipal.Find(id);
            if (completa_FeriadoMunicipal == null)
            {
                return NotFound();
            }

            db.Completa_FeriadoMunicipal.Remove(completa_FeriadoMunicipal);
            db.SaveChanges();

            return Ok(completa_FeriadoMunicipal);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Completa_FeriadoMunicipalExists(int id)
        {
            return db.Completa_FeriadoMunicipal.Count(e => e.Fem_Id == id) > 0;
        }
    }
}