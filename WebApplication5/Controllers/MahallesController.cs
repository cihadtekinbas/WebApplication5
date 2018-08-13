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
    public class MahallesController : ApiController
    {
        private HaritaContext db = new HaritaContext();

        // GET: api/Mahalles
        public IQueryable<Mahalle> GetMahalles()
        {
            return db.Mahalles;
        }

        // GET: api/Mahalles/5
        [ResponseType(typeof(Mahalle))]
        public async Task<IHttpActionResult> GetMahalle(int id)
        {
            Mahalle mahalle = await db.Mahalles.FindAsync(id);
            if (mahalle == null)
            {
                return NotFound();
            }

            return Ok(mahalle);
        }

        // PUT: api/Mahalles/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMahalle(int id, Mahalle mahalle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mahalle.Id)
            {
                return BadRequest();
            }

            db.Entry(mahalle).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MahalleExists(id))
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

        // POST: api/Mahalles
        [ResponseType(typeof(Mahalle))]
        public async Task<IHttpActionResult> PostMahalle(Mahalle mahalle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Mahalles.Add(mahalle);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = mahalle.Id }, mahalle);
        }

        // DELETE: api/Mahalles/5
        [ResponseType(typeof(Mahalle))]
        public async Task<IHttpActionResult> DeleteMahalle(int id)
        {
            Mahalle mahalle = await db.Mahalles.FindAsync(id);
            if (mahalle == null)
            {
                return NotFound();
            }

            db.Mahalles.Remove(mahalle);
            await db.SaveChangesAsync();

            return Ok(mahalle);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MahalleExists(int id)
        {
            return db.Mahalles.Count(e => e.Id == id) > 0;
        }
    }
}