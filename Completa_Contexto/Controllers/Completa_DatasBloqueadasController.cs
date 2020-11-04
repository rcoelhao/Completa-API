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
    public class Completa_DatasBloqueadasController : ApiController
    {
        private Completa_Contextoss db = new Completa_Contextoss();

        // GET: api/Completa_DatasBloqueadas
        public IQueryable<Completa_DatasBloqueadas> GetCompleta_DatasBloqueadas()
        {
            return db.Completa_DatasBloqueadas;
        }

        // GET: api/Completa_DatasBloqueadas/5
        [ResponseType(typeof(Completa_DatasBloqueadas))]
        public IHttpActionResult GetCompleta_DatasBloqueadas(int id)
        {
            Completa_DatasBloqueadas completa_DatasBloqueadas = db.Completa_DatasBloqueadas.Find(id);
            if (completa_DatasBloqueadas == null)
            {
                return NotFound();
            }

            return Ok(completa_DatasBloqueadas);
        }

        // PUT: api/Completa_DatasBloqueadas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompleta_DatasBloqueadas(int id, Completa_DatasBloqueadas completa_DatasBloqueadas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != completa_DatasBloqueadas.Dat_Id)
            {
                return BadRequest();
            }

            db.Entry(completa_DatasBloqueadas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Completa_DatasBloqueadasExists(id))
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

        // POST: api/Completa_DatasBloqueadas
        [ResponseType(typeof(Completa_DatasBloqueadas))]
        public IHttpActionResult PostCompleta_DatasBloqueadas(Completa_DatasBloqueadas completa_DatasBloqueadas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Completa_DatasBloqueadas.Add(completa_DatasBloqueadas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = completa_DatasBloqueadas.Dat_Id }, completa_DatasBloqueadas);
        }

        // DELETE: api/Completa_DatasBloqueadas/5
        [ResponseType(typeof(Completa_DatasBloqueadas))]
        public IHttpActionResult DeleteCompleta_DatasBloqueadas(int id)
        {
            Completa_DatasBloqueadas completa_DatasBloqueadas = db.Completa_DatasBloqueadas.Find(id);
            if (completa_DatasBloqueadas == null)
            {
                return NotFound();
            }

            db.Completa_DatasBloqueadas.Remove(completa_DatasBloqueadas);
            db.SaveChanges();

            return Ok(completa_DatasBloqueadas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Completa_DatasBloqueadasExists(int id)
        {
            return db.Completa_DatasBloqueadas.Count(e => e.Dat_Id == id) > 0;
        }
    }
}