using Hospital_LinqToSql.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Hospital_LinqToSql.Controllers
{
    public class NurseController : ApiController
    {
        static string connectionString = "Data Source=laptop-a88v89ut;Initial Catalog=HospitalDB;Integrated Security=True;Pooling=False";
        NurseDataContext DataContext = new NurseDataContext(connectionString);


        // GET: api/Nurse
        public IHttpActionResult Get()
        {
            try
            {
                List<Nurse> Nurses = DataContext.Nurses.ToList();
                return Ok(new { Nurses });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // GET: api/Nurse/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Nurse nurses = DataContext.Nurses.First((item) => item.Id == id);
                return Ok(new { nurses });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //// POST: api/Nurse
        public IHttpActionResult Post([FromBody] Nurse nurses)
        {
            try
            {
                DataContext.Nurses.InsertOnSubmit(nurses);
                DataContext.SubmitChanges();
                return Ok("success");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //// PUT: api/Nurse/5
        public IHttpActionResult Put(int id, [FromBody] Nurse nurse)
        {
            try
            {
                Nurse nurseToUpdate = DataContext.Nurses.Single(rnurseItem => rnurseItem.Id == id);
                nurseToUpdate = nurse;
                DataContext.SubmitChanges();
                return Ok("success");

            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //// DELETE: api/Nurse/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Nurse Nurse = DataContext.Nurses.First(residentItem => residentItem.Id == id);
                DataContext.Nurses.DeleteOnSubmit(Nurse);
                DataContext.SubmitChanges();
                return Ok("success");
            }
            catch (SqlException sqlEx)
            {
                return BadRequest(sqlEx.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
