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
    public class Completa_AgendamentoController : ApiController
    {
        private Completa_Contextoss db = new Completa_Contextoss();

        // GET: api/Completa_Agendamento
        public IQueryable<Completa_Agendamento> GetCompleta_Agendamento()
        {
            return db.Completa_Agendamento;
        }

        // GET: api/Completa_Agendamento/5
        [ResponseType(typeof(Completa_Agendamento))]
        public IHttpActionResult GetCompleta_Agendamento(int id)
        {
            Completa_Agendamento completa_Agendamento = db.Completa_Agendamento.Find(id);
            if (completa_Agendamento == null)
            {
                return NotFound();
            }

            return Ok(completa_Agendamento);
        }

        // PUT: api/Completa_Agendamento/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompleta_Agendamento(int id, Completa_Agendamento completa_Agendamento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != completa_Agendamento.Age_Id)
            {
                return BadRequest();
            }

            db.Entry(completa_Agendamento).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Completa_AgendamentoExists(id))
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

        // POST: api/Completa_Agendamento
        [ResponseType(typeof(Completa_Agendamento))]
        public IHttpActionResult PostCompleta_Agendamento(Completa_Agendamento completa_Agendamento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Completa_Agendamento.Add(completa_Agendamento);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = completa_Agendamento.Age_Id }, completa_Agendamento);
        }

        // DELETE: api/Completa_Agendamento/5
        [ResponseType(typeof(Completa_Agendamento))]
        public IHttpActionResult DeleteCompleta_Agendamento(int id)
        {
            Completa_Agendamento completa_Agendamento = db.Completa_Agendamento.Find(id);
            if (completa_Agendamento == null)
            {
                return NotFound();
            }

            db.Completa_Agendamento.Remove(completa_Agendamento);
            db.SaveChanges();

            return Ok(completa_Agendamento);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Completa_AgendamentoExists(int id)
        {
            return db.Completa_Agendamento.Count(e => e.Age_Id == id) > 0;
        }
    }
}