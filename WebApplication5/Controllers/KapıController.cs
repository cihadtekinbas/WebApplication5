using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class KapıController : ApiController
    {
        private HaritaContext db = new HaritaContext();

        // GET: api/Kapı
        public IQueryable<Kapı> GetKapı()
        {
            return db.Kapı;
        }

        // GET: api/Kapı/5
        [ResponseType(typeof(Kapı))]
        public async Task<IHttpActionResult> GetKapı(int id)
        {
            Kapı kapı = await db.Kapı.FindAsync(id);
            if (kapı == null)
            {
                return NotFound();
            }

            return Ok(kapı);
        }

        // PUT: api/Kapı/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutKapı(int id, Kapı kapı)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kapı.Id)
            {
                return BadRequest();
            }

            db.Entry(kapı).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KapıExists(id))
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

        // POST: api/Kapı
        [ResponseType(typeof(Kapı))]
        public async Task<IHttpActionResult> PostKapı(Kapı kapı)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Kapı.Add(kapı);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = kapı.Id }, kapı);
        }

        // DELETE: api/Kapı/5
        [ResponseType(typeof(Kapı))]
        public async Task<IHttpActionResult> DeleteKapı(int id)
        {
            Kapı kapı = await db.Kapı.FindAsync(id);
            if (kapı == null)
            {
                return NotFound();
            }

            db.Kapı.Remove(kapı);
            await db.SaveChangesAsync();

            return Ok(kapı);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KapıExists(int id)
        {
            return db.Kapı.Count(e => e.Id == id) > 0;
        }
    }
}