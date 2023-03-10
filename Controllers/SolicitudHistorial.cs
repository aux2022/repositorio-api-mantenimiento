using System;
using back_salidaActivos.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace back_salidaActivos.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "GET,POST,PUT,DELETE,OPTIONS")]
    public class HistorialController : ApiController
    {
        // GET: api/Solicitud2
        public IEnumerable<historial> Get()
        {
            GestorHistorial gSolicitud = new GestorHistorial();
            return gSolicitud.GetHistorial();

        }

        //GET: api/Solicitud2/5
        public IEnumerable<historial> Get(int id)
        {

            GestorHistorial gSolicitud = new GestorHistorial();
            return gSolicitud.GetSolicitudsByIdHistorial(id);


        }

        //// POST: api/Solicitud2
        //public bool Post([FromBody] usuarios Usuarios)
        //{
        //    GestorUsuarios gSolicitud = new GestorUsuarios();
        //    bool res = gSolicitud.addUsuarios(Usuarios);

        //    return res;
        //}



        // PUT: api/Solicitud/5
        //public bool Put(int id, [FromBody]solicitudPreventiva SolicitudPreventiva)
        //{
        //    GestorSolicitudPreventiva gSolicitud = new GestorSolicitudPreventiva();
        //    bool res = gSolicitud.updateSolicitud2(id,SolicitudPreventiva);

        //    return res;
        //}

        //// DELETE: api/Solicitud/5
        //public bool Delete(int id)
        //{
        //    GestorSolicitud gSolicitud = new GestorSolicitud();
        //    bool res = gSolicitud.deleteSolicitud(id);

        //    return res;
        //}
    }
}
