﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class historial
    {

        //solicitud
       public int idHistorial { get; set; }
        public int idSolicitud { get; set; }

        public string fechaHistorial { get; set; }
        public string horaHistorial { get; set; }

        public string historialMecanico { get; set; }

        



        public historial() { }


        public historial(int IdHistorial,
int IdSolicitud, string FechaHistorial, string HoraHistorial, string HistorialMecanico
            )
        {           
            idHistorial = IdHistorial;
            idSolicitud = IdSolicitud;
            fechaHistorial = FechaHistorial;
            horaHistorial = HoraHistorial;
            historialMecanico = HistorialMecanico;

        }
        public historial(
       int IdSolicitud, string FechaHistorial, string HoraHistorial, string HistorialMecanico
                   )
        {
         
            idSolicitud = IdSolicitud;
            fechaHistorial = FechaHistorial;
            horaHistorial = HoraHistorial;
            historialMecanico = HistorialMecanico;

        }

    }
}



