using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VWSWebApp.Models;
using VWSWebApp.Tools;

namespace VWSWebApp.Controllers
{
    public class SocketStartController : ApiController
    {
        // GET: api/SocketStart
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/SocketStart/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/SocketStart
        public HttpResponseMessage Post(dynamic value)
        {
            HttpResponseMessage response;
            string data = JsonConvert.SerializeObject(value);

            try
            {
                Socketcmd socketcmd = JsonConvert.DeserializeObject<Socketcmd>(data);
                if (GlobalVariables.GlobalSocketList != null) { 
                    if (GlobalVariables.GlobalSocketList.Count > 0)
                    {
                        response = Request.CreateResponse(HttpStatusCode.BadRequest, "There are " + GlobalVariables.GlobalSocketList.Count + " connections running. Please stop the current connections to create more connections.");

                    }
                    else
                    {
                        GlobalVariables.GlobalSocketList = AsynchronousClient.StartClient(socketcmd.Host, socketcmd.Port, socketcmd.Connections);
                        response = Request.CreateResponse(HttpStatusCode.OK, "Sockets created based in: \r\n" + data + "\r\nYour request created " + GlobalVariables.GlobalSocketList.Count + " number of connections.");
                    }
                }
                else
                {
                    GlobalVariables.GlobalSocketList = AsynchronousClient.StartClient(socketcmd.Host, socketcmd.Port, socketcmd.Connections);
                    response = Request.CreateResponse(HttpStatusCode.OK, "Sockets created based in: \r\n" + data + "\r\nYour request created " + GlobalVariables.GlobalSocketList.Count + " number of connections.");
                }

            }
            catch (Exception)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Unable to DeserializeObject" + data);
                return response;
            }
            return response;
        }

        // PUT: api/SocketStart/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE: api/SocketStart/5
        //public void Delete(int id)
        //{
        //}
    }
}
