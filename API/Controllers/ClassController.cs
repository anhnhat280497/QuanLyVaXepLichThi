using QLXLT_Data.Data;
using QLXLT_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("Api/Class")]
    public class ClassController : ApiController
    {
        XLTContext context = new XLTContext();
        [HttpGet, Route("GetAll")]
        public HttpResponseMessage GetAll(HttpRequestMessage requestMessage)
        {
            try
            {
                List<Class> list = context.Class.ToList();
                HttpResponseMessage response = requestMessage.CreateResponse<List<Class>>(HttpStatusCode.OK,
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
