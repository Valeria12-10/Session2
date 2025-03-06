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
    public class ProductsController : ApiController
    {
        private WarehouseManagementEntities db = new WarehouseManagementEntities();

        // GET: api/товары
        [ResponseType(typeof(List<Products>))]

        public IHttpActionResult GetGoods()
        {
            return Ok(db.Товары.ToList().ConvertAll(p => new Products(p)));
        }

        [ResponseType(typeof(List<Products>))]
        public IHttpActionResult PostGoods([FromBody] Товары товар)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Товары.Add(товар);
            db.SaveChanges();
            var response = new Products(товар);
            return CreatedAtRoute("DefaultApi", new { id = товар.IDТовара }, response);
        }
    }
}