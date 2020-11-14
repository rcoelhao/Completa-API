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
    public class Completa_Assinaturas1Controller : ApiController
    {
        private Completa_Contextoss db = new Completa_Contextoss();

        // GET: api/Completa_Assinaturas1
        public IQueryable<Completa_Assinaturas> GetCompleta_Assinaturas()
        {
            return db.Completa_Assinaturas;
        }

        // GET: api/Completa_Assinaturas1/5
        [ResponseType(typeof(Completa_Assinaturas))]
        public IHttpActionResult GetCompleta_Assinaturas(int id)
        {
            Completa_Assinaturas completa_Assinaturas = db.Completa_Assinaturas.Find(id);
            if (completa_Assinaturas == null)
            {
                return NotFound();
            }

            return Ok(completa_Assinaturas);
        }

        // PUT: api/Completa_Assinaturas1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompleta_Assinaturas(int id, Completa_Assinaturas completa_Assinaturas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != completa_Assinaturas.Ass_Id)
            {
                return BadRequest();
            }

            db.Entry(completa_Assinaturas).State = EntityState.Modified;

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

        // POST: api/Completa_Assinaturas1
        [ResponseType(typeof(Completa_Assinaturas))]
        public IHttpActionResult PostCompleta_Assinaturas(Completa_Assinaturas completa_Assinaturas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Completa_Assinaturas.Add(completa_Assinaturas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = completa_Assinaturas.Ass_Id }, completa_Assinaturas);
        }

        // DELETE: api/Completa_Assinaturas1/5
        [ResponseType(typeof(Completa_Assinaturas))]
        public IHttpActionResult DeleteCompleta_Assinaturas(int id)
        {
            Completa_Assinaturas completa_Assinaturas = db.Completa_Assinaturas.Find(id);
            if (completa_Assinaturas == null)
            {
                return NotFound();
            }

            db.Completa_Assinaturas.Remove(completa_Assinaturas);
            db.SaveChanges();

            return Ok(completa_Assinaturas);
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
            return db.Completa_Assinaturas.Count(e => e.Ass_Id == id) > 0;
        }
    }
}