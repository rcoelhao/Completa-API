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
    public class Completa_AutorizacaoController : ApiController
    {
        private Completa_Contextoss db = new Completa_Contextoss();

        // GET: api/Completa_Autorizacao
        public IQueryable<Completa_Autorizacao> GetCompleta_Autorizacao()
        {
            return db.Completa_Autorizacao;
        }

        // GET: api/Completa_Autorizacao/5
        [ResponseType(typeof(Completa_Autorizacao))]
        public IHttpActionResult GetCompleta_Autorizacao(int id)
        {
            Completa_Autorizacao completa_Autorizacao = db.Completa_Autorizacao.Find(id);
            if (completa_Autorizacao == null)
            {
                return NotFound();
            }

            return Ok(completa_Autorizacao);
        }

        // GET: api/Completa_Autorizacao/ByCli_Id/5
        [HttpGet]
        [Route("api/Completa_Autorizacao/ByCli_Id/{Cli_Id:int}")]
        [ResponseType(typeof(Completa_Autorizacao))]
        public IHttpActionResult Completa_AutorizacaoByCli_Id(int Cli_Id)
        {
            List<Completa_Autorizacao> completa_AutorizacaoList = db.Completa_Autorizacao
                .Where(x => x.Cli_Id == Cli_Id).ToList();

            if (completa_AutorizacaoList == null)
            {
                return NotFound();
            }
            return Ok(completa_AutorizacaoList);
        }

        // PUT: api/Completa_Autorizacao/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompleta_Autorizacao(int id, Completa_Autorizacao completa_Autorizacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != completa_Autorizacao.Au_Id)
            {
                return BadRequest();
            }

            db.Entry(completa_Autorizacao).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Completa_AutorizacaoExists(id))
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

        // POST: api/Completa_Autorizacao
        [ResponseType(typeof(Completa_Autorizacao))]
        public IHttpActionResult PostCompleta_Autorizacao(Completa_Autorizacao completa_Autorizacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Completa_Autorizacao.Add(completa_Autorizacao);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = completa_Autorizacao.Au_Id }, completa_Autorizacao);
        }

        // DELETE: api/Completa_Autorizacao/5
        [ResponseType(typeof(Completa_Autorizacao))]
        public IHttpActionResult DeleteCompleta_Autorizacao(int id)
        {
            Completa_Autorizacao completa_Autorizacao = db.Completa_Autorizacao.Find(id);
            if (completa_Autorizacao == null)
            {
                return NotFound();
            }

            db.Completa_Autorizacao.Remove(completa_Autorizacao);
            db.SaveChanges();

            return Ok(completa_Autorizacao);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Completa_AutorizacaoExists(int id)
        {
            return db.Completa_Autorizacao.Count(e => e.Au_Id == id) > 0;
        }
    }
}