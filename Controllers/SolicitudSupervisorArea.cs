using back_salidaActivos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace back_salidaActivos.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "GET,POST,PUT,DELETE,OPTIONS")]
    public class SolicitudSupervisorArea : ApiController
    {
        // GET: api/SolicitudSupervisorArea
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SolicitudSupervisorArea/5
        public IEnumerable<solicitudPreventiva> Get(int id)
        {

            GestorSolicitudPreventiva gSolicitud = new GestorSolicitudPreventiva();
            return gSolicitud.GetSolisitudAreaSupervById(id);


        }

        // POST: api/SolicitudSupervisorArea
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SolicitudSupervisorArea/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SolicitudSupervisorArea/5
        public void Delete(int id)
        {
        }
    }
}
