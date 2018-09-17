using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using VWSWebApp.Models;
using VWSWebApp.Tools;
using System.Net.Sockets;

namespace VWSWebApp.Controllers
{
    public class SocketStopController : ApiController
    {
        // GET: api/SocketStop
        public HttpResponseMessage Get()
        {
            HttpResponseMessage response;
            try
            {
                AsynchronousClient.StopClient(GlobalVariables.GlobalSocketList);
                response = Request.CreateResponse(HttpStatusCode.OK, "All connections was stoped: " + GlobalVariables.GlobalSocketList.Count);
                GlobalVariables.GlobalSocketList.Clear();
            }
            catch (Exception)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "No existing connection. Please create a connection first.");
                return response;
            }
            return response;
        }

        // GET: api/SocketStop
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/SocketStop/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/SocketStop
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT: api/SocketStop/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE: api/SocketStop/5
        //public void Delete(int id)
        //{
        //}
    }
}
