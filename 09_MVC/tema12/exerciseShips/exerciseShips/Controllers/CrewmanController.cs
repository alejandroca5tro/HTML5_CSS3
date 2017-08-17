﻿using exerciseShips.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exerciseShips.Controllers
{
    public class CrewmanController : Controller
    {
        // GET: Crewman
        public ActionResult Index(int id, string nombre)
        {
            List<Crewman> listaTripulantes = CrearTripulacion();
            var query =
                listaTripulantes
                .Where(t => t.BarcoId.Equals(id))
                .Select(t => t)
                .ToList();
            ViewBag.Ship = query;
            return View(query);
        }
        public List<Crewman> CrearTripulacion()
        {
            List<Crewman> crew = new List<Crewman>
            {
                new Crewman {TripulanteId=1,NombreTripulante="David",Cargo="Contramaestre",FechaTituloNavegacion=Convert.ToDateTime("05/08/1999"), BarcoId=1},
                new Crewman {TripulanteId=2,NombreTripulante="Felix",Cargo="Almirante",FechaTituloNavegacion=Convert.ToDateTime("05/09/2001"), BarcoId=2},
                new Crewman {TripulanteId=3,NombreTripulante="Ricardo",Cargo="Marinero",FechaTituloNavegacion=Convert.ToDateTime("08/08/1988"),BarcoId=1},
                new Crewman {TripulanteId=4,NombreTripulante="Elena",Cargo="Marinero",FechaTituloNavegacion=Convert.ToDateTime("16/08/1999"),BarcoId=3},
                new Crewman {TripulanteId=5,NombreTripulante="Susana",Cargo="Sobrecargo",FechaTituloNavegacion=Convert.ToDateTime("17/10/2002"),BarcoId=1},
                new Crewman {TripulanteId=6,NombreTripulante="Javier",Cargo="Marinero 1ª",FechaTituloNavegacion=Convert.ToDateTime("05/08/2001"),BarcoId=4},
                new Crewman {TripulanteId=7,NombreTripulante="Federico",Cargo="Marinero 2ª",FechaTituloNavegacion=Convert.ToDateTime("19/01/1999"),BarcoId=4},
                new Crewman {TripulanteId=8,NombreTripulante="Inmaculada",Cargo="Piloto",FechaTituloNavegacion=Convert.ToDateTime("17/10/2003"),BarcoId=4}

            };
            return crew;
        }

        public List<Ship> CrearFlota()
        {
            List<Ship> flota = new List<Ship>
            {
                new Ship {BarcoId=1,NombreBarco="María Luisa",AñoConstruccion=2003, CosteConstruccion=1200, FechaUltimaReparacion=Convert.ToDateTime("12/07/2005")},
                new Ship {BarcoId=2,NombreBarco="La Pili",AñoConstruccion=1997,CosteConstruccion=2400, FechaUltimaReparacion=Convert.ToDateTime("12/10/1999")},
                new Ship {BarcoId=3,NombreBarco="El Torreon",AñoConstruccion=1993,CosteConstruccion=1700, FechaUltimaReparacion=Convert.ToDateTime("12/07/2005")},
                new Ship {BarcoId=4,NombreBarco="La Niña",AñoConstruccion=1998,CosteConstruccion=3100, FechaUltimaReparacion=Convert.ToDateTime("10/06/2002")}
            };
            flota[0].crew = new List<Crewman>{ new Crewman{TripulanteId=1,NombreTripulante="David",Cargo="Contramaestre",FechaTituloNavegacion=Convert.ToDateTime("05/08/1999"), Ship = flota[0]},
                                 new Crewman {TripulanteId=4,NombreTripulante="Elena",Cargo="Marinero",FechaTituloNavegacion=Convert.ToDateTime("16/08/1999"), Ship = flota[0]},
                                 new Crewman {TripulanteId=5,NombreTripulante="Susana",Cargo="Sobrecargo",FechaTituloNavegacion=Convert.ToDateTime("17/10/2002"), Ship = flota[0]}};

            flota[1].crew = new List<Crewman> { new Crewman { TripulanteId = 2, NombreTripulante = "Felix", Cargo = "Almirante", FechaTituloNavegacion = Convert.ToDateTime("05/09/2001"), Ship = flota[1] } };

            flota[2].crew = new List<Crewman> { new Crewman { TripulanteId = 3, NombreTripulante = "Ricargo", Cargo = "Marinero", FechaTituloNavegacion = Convert.ToDateTime("16/08/1999"), Ship = flota[2] } };

            flota[3].crew = new List<Crewman>{ new Crewman{TripulanteId=6,NombreTripulante="Javier",Cargo="Marinero 1ª",FechaTituloNavegacion=Convert.ToDateTime("05/08/2001"), Ship = flota[3]},
                                 new Crewman {TripulanteId=7,NombreTripulante="Federico",Cargo="Marinero 2ª",FechaTituloNavegacion=Convert.ToDateTime("19/01/1999"), Ship = flota[3]},
                                 new Crewman {TripulanteId=8,NombreTripulante="Inmaculada",Cargo="Piloto",FechaTituloNavegacion=Convert.ToDateTime("17/10/2003"), Ship = flota[3]}};


            return flota;
        }

        public ActionResult Inicio()
        {
            //List<Tripulante> listaTripulantes = CrearTripulacion();
            List<Ship> listaBarcos = CrearFlota();

            var query =
                listaBarcos
                .Select(b => b)
                .ToList();
            return View(query);
        }
    }
}