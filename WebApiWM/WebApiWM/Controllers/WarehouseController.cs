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
using WebApiWM.Entities;
using WebApiWM.Models;

namespace WebApiWM.Controllers
{
    public class WarehouseController : ApiController
    {
        private WarehouseManagementEntities db = new WarehouseManagementEntities();

        // GET: Warehouse
        [ResponseType(typeof(List<Warehouse>))]

        public IHttpActionResult GetWarehouse()
        {
            return Ok(db.Склады.ToList().ConvertAll(p => new Warehouse(p)));
        }
    }
}