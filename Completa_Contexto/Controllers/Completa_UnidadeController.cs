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
    public class Completa_UnidadeController : ApiController
    {
        private Completa_Contextoss db = new Completa_Contextoss();

        // GET: api/Completa_Unidade
        public IQueryable<Completa_Unidade> GetCompleta_Unidade()
        {
            return db.Completa_Unidade;
        }

        // GET: api/Completa_Unidade/5
        [ResponseType(typeof(Completa_Unidade))]
        public IHttpActionResult GetCompleta_Unidade(int id)
        {
            Completa_Unidade completa_Unidade = db.Completa_Unidade.Find(id);
            if (completa_Unidade == null)
            {
                return NotFound();
            }

            return Ok(completa_Unidade);
        }

        // PUT: api/Completa_Unidade/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompleta_Unidade(int id, Completa_Unidade completa_Unidade)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != completa_Unidade.Uni_Id)
            {
                return BadRequest();
            }

            db.Entry(completa_Unidade).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Completa_UnidadeExists(id))
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

        // POST: api/Completa_Unidade
        [ResponseType(typeof(Completa_Unidade))]
        public IHttpActionResult PostCompleta_Unidade(Completa_Unidade completa_Unidade)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Completa_Unidade.Add(completa_Unidade);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = completa_Unidade.Uni_Id }, completa_Unidade);
        }

        // DELETE: api/Completa_Unidade/5
        [ResponseType(typeof(Completa_Unidade))]
        public IHttpActionResult DeleteCompleta_Unidade(int id)
        {
            Completa_Unidade completa_Unidade = db.Completa_Unidade.Find(id);
            if (completa_Unidade == null)
            {
                return NotFound();
            }

            db.Completa_Unidade.Remove(completa_Unidade);
            db.SaveChanges();

            return Ok(completa_Unidade);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Completa_UnidadeExists(int id)
        {
            return db.Completa_Unidade.Count(e => e.Uni_Id == id) > 0;
        }
    }
}