using Newtonsoft.Json;
using QLXLT_Data.Data;
using QLXLT_Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace API.Controllers
{
    
    [RoutePrefix("Api/Student")]
    public class StudentController : ApiController
    {
        XLTContext context = new XLTContext();

        //[HttpGet, Route("GetAll")]
        //public async Task<IHttpActionResult> GetPlaylistUser()
        //{
        //    string dataClientSend = await Request.Content.ReadAsStringAsync();
        //    Student userFromClient = JsonConvert.DeserializeObject<Student>(dataClientSend);
        //    try
        //    {
        //        List<Student> listStudent = context.Student.ToList();
        //        foreach (Student student in listStudent)
        //        {
        //            context.Entry(student).Collection(u => u.CreditClasses).Load();
        //            context.Entry(student).Collection(u => u.CreditClassGroups).Load();
        //        }
        //        return Ok(listStudent);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        [HttpGet, Route("GetAll")]
        public HttpResponseMessage GetAll(HttpRequestMessage requestMessage)
        {
            try
            {
                List<Student> list = context.Student.ToList();
                HttpResponseMessage response = requestMessage.CreateResponse<List<Student>>(HttpStatusCode.OK,
                    list);
                return response;
            }
            catch (Exception)
            {
                HttpResponseMessage response = requestMessage.CreateResponse(HttpStatusCode.InternalServerError);
                return response;
            }
        }
    }
}
