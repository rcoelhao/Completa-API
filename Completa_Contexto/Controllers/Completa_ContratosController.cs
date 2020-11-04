using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Completa_Contexto.Models;

namespace Completa_Contexto.Controllers
{
    public class Completa_ContratosController : ApiController
    {
        private Completa_Contextoss db = new Completa_Contextoss();

        // GET: api/Completa_Contratos
        public IQueryable<Completa_Contratos> GetCompleta_Contratos()
        {
            return db.Completa_Contratos;
        }

        // GET: api/Completa_Contratos/5
        [ResponseType(typeof(Completa_Contratos))]
        public IHttpActionResult GetCompleta_Contratos(int id)
        {
            Completa_Contratos completa_Contratos = db.Completa_Contratos.Find(id);
            if (completa_Contratos == null)
            {
                return NotFound();
            }

            return Ok(completa_Contratos);
        }

        // PUT: api/Completa_Contratos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompleta_Contratos(int id, Completa_Contratos completa_Contratos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != completa_Contratos.Ct_Id)
            {
                return BadRequest();
            }

            db.Entry(completa_Contratos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Completa_ContratosExists(id))
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

        // POST: api/Completa_Contratos
        [ResponseType(typeof(Completa_Contratos))]
        public IHttpActionResult PostCompleta_Contratos(Completa_Contratos completa_Contratos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Completa_Contratos.Add(completa_Contratos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = completa_Contratos.Ct_Id }, completa_Contratos);
        }

        // DELETE: api/Completa_Contratos/5
        [ResponseType(typeof(Completa_Contratos))]
        public IHttpActionResult DeleteCompleta_Contratos(int id)
        {
            Completa_Contratos completa_Contratos = db.Completa_Contratos.Find(id);
            if (completa_Contratos == null)
            {
                return NotFound();
            }

            db.Completa_Contratos.Remove(completa_Contratos);
            db.SaveChanges();

            return Ok(completa_Contratos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Completa_ContratosExists(int id)
        {
            return db.Completa_Contratos.Count(e => e.Ct_Id == id) > 0;
        }
    }
}