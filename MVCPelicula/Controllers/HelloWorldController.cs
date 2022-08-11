﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPelicula.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public string Index()
        //{
        //    return "Esta es mi acción <b> predeterminada </b> ...";
        //}

        public ActionResult Index()
        {
            return View();
        }

        //GET: /HelloWorld/Welcome
        public ActionResult Welcome(string nombre, string apellido, int numVeces = 1)
        {
            ViewBag.Mensaje = "Hola " + nombre + " " + apellido + ", veces mostrado:";
            ViewBag.NumVeces = numVeces;

            return View();
        }
        
    }
}