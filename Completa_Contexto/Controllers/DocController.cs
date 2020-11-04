using Completa_Contexto.Models;
using Completa_Contexto.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Completa_Contexto.Controllers
{
    public class DocController : ApiController
    {


        private Completa_Contextoss db = new Completa_Contextoss();

        // GET: api/Completa_Documentos/5
        [ResponseType(typeof(Completa_DocumentosID))]
        public IHttpActionResult GetCompleta_DocumentosID(int id)
        {
            List<Completa_DocumentosID> ListaDocs = new List<Completa_DocumentosID>();

            var ListDoc = ListaDocs.Where(x => x.Cli_Id == id).ToList();

            if (ListDoc == null)
            {
                return NotFound();
            }

            return Ok(ListDoc);
        }
    }
}
