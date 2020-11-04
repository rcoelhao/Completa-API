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
    public class Completa_PeriodoController : ApiController
    {
        private Completa_Contextoss db = new Completa_Contextoss();

        // GET: api/Completa_Periodo
        public IQueryable<Completa_Periodo> GetCompleta_Periodo()
        {
            return db.Completa_Periodo;
        }

        // GET: api/Completa_Periodo/5
        [ResponseType(typeof(Completa_Periodo))]
        public IHttpActionResult GetCompleta_Periodo(int id)
        {
            Completa_Periodo completa_Periodo = db.Completa_Periodo.Find(id);
            if (completa_Periodo == null)
            {
                return NotFound();
            }

            return Ok(completa_Periodo);
        }

        // PUT: api/Completa_Periodo/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompleta_Periodo(int id, Completa_Periodo completa_Periodo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != completa_Periodo.Per_Id)
            {
                return BadRequest();
            }

            db.Entry(completa_Periodo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Completa_PeriodoExists(id))
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

        // POST: api/Completa_Periodo
        [ResponseType(typeof(Completa_Periodo))]
        public IHttpActionResult PostCompleta_Periodo(Completa_Periodo completa_Periodo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Completa_Periodo.Add(completa_Periodo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = completa_Periodo.Per_Id }, completa_Periodo);
        }

        // DELETE: api/Completa_Periodo/5
        [ResponseType(typeof(Completa_Periodo))]
        public IHttpActionResult DeleteCompleta_Periodo(int id)
        {
            Completa_Periodo completa_Periodo = db.Completa_Periodo.Find(id);
            if (completa_Periodo == null)
            {
                return NotFound();
            }

            db.Completa_Periodo.Remove(completa_Periodo);
            db.SaveChanges();

            return Ok(completa_Periodo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Completa_PeriodoExists(int id)
        {
            return db.Completa_Periodo.Count(e => e.Per_Id == id) > 0;
        }
    }
}