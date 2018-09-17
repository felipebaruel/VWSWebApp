using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VWSWebApp.Tools;
using VWSWebApp.Models;


namespace VWSWebApp.Controllers
{
    public class SocketController : ApiController
    {
        // GET: api/Socket
        // GET: api/SocketStart
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        public HttpResponseMessage Get()
        {
            HttpResponseMessage response;
            try
            {
                
                if (GlobalVariables.GlobalSocketList.Count == 0)
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, "All connections are closed." );
                }
                else if (GlobalVariables.GlobalSocketList.Count != 0)
                {
                    response = Request.CreateResponse(HttpStatusCode.OK, "There are " + GlobalVariables.GlobalSocketList.Count + " connections opened." );
                }
                response = Request.CreateResponse(HttpStatusCode.OK, "There are " + GlobalVariables.GlobalSocketList.Count + " connections opened." );
            }
            catch (Exception)
            {

                response = Request.CreateResponse(HttpStatusCode.BadRequest, "There are any connection running, Please create a connection first.");
                return response;
            }
            return response;

        }

        // GET: api/Socket/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //[Route("api/Socket/Stop")]
        //[HttpGet]
        //public string Get(string value)
        //{
        //    if (value == "Stop")
        //    {
        //        //AsynchronousClient.StopClient(GlobalVariables.GlobalSocketList);
        //        value = "OK";
        //    }
        //    return "value";
        //}



        //// GET: api/Sock
        //public HttpResponseMessage Get()
        //{
        //    // Get a list of products from a database.
        //    //IEnumerable<Product> products = GetProductsFromDB();

        //    // Write the list to the response body.
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Test");
        //    return response;
        //}

        // POST: api/Socket
        //public void Post([FromBody]string value)
        //{

        //}

        //public HttpResponseMessage Post(dynamic value)
        //{
        //    HttpResponseMessage response;
        //    string data = JsonConvert.SerializeObject(value);

        //    try
        //    {
        //        Socketcmd socketcmd = JsonConvert.DeserializeObject<Socketcmd>(data);
        //        //GlobalVariables.GlobalSocketList = AsynchronousClient.StartClient(socketcmd.Host, socketcmd.Port, socketcmd.Connections);
        //        //AsynchronousClient.StopClient(GlobalVariables.GlobalSocketList);
        //    }
        //    catch (Exception)
        //    {
        //        response = Request.CreateResponse(HttpStatusCode.BadRequest, "Unable to DeserializeObject" + data);
        //        return response;
        //    }
        //    //Socketcmd socketcmd = JsonConvert.DeserializeObject<Socketcmd>(data);



        //    response = Request.CreateResponse(HttpStatusCode.OK, "Sockets created based in: \r\n" + data);
        //    return response;

        //}

        //// PUT: api/Socket/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Socket/5
        //public void Delete(int id)
        //{
        //}
    }
}
