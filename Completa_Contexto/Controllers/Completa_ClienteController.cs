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
    public class Completa_ClienteController : ApiController
    {
        private readonly Contexto db = new Contexto();

        // GET: api/Completa_Cliente
        public IQueryable<Completa_Cliente> GetCompleta_Cliente()
        {
            return db.Completa_Cliente;
        }

        // GET: api/Completa_Cliente/5
        [ResponseType(typeof(Completa_Cliente))]
        public IHttpActionResult GetCompleta_Cliente(int id)
        {
            Completa_Cliente completa_Cliente = db.Completa_Cliente.Find(id);
            if (completa_Cliente == null)
            {
                return NotFound();
            }

            return Ok(completa_Cliente);
        }

        // PUT: api/Completa_Cliente/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompleta_Cliente(int id, Completa_Cliente completa_Cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != completa_Cliente.Cli_Id)
            {
                return BadRequest();
            }

            db.Entry(completa_Cliente).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Completa_ClienteExists(id))
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

        // POST: api/Completa_Cliente
        [ResponseType(typeof(Completa_Cliente))]
        public IHttpActionResult PostCompleta_Cliente(Completa_Cliente completa_Cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Completa_Cliente.Add(completa_Cliente);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = completa_Cliente.Cli_Id }, completa_Cliente);
        }

        // DELETE: api/Completa_Cliente/5
        [ResponseType(typeof(Completa_Cliente))]
        public IHttpActionResult DeleteCompleta_Cliente(int id)
        {
            Completa_Cliente completa_Cliente = db.Completa_Cliente.Find(id);
            if (completa_Cliente == null)
            {
                return NotFound();
            }

            db.Completa_Cliente.Remove(completa_Cliente);
            db.SaveChanges();

            return Ok(completa_Cliente);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Completa_ClienteExists(int id)
        {
            return db.Completa_Cliente.Count(e => e.Cli_Id == id) > 0;
        }
    }
}