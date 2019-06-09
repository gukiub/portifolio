using System;
using System.Net;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using TicketSystem.Api.Models;
using TicketSystem.Domain.Users;
using TicketSystem.Repository;

namespace TicketSystem.Api.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : BaseController
    {
        /// <summary>Authenticate an user.</summary>
        /// <param name="auth"></param>
        /// <returns> A json object containing the authenticated user info.</returns>
        [HttpPost]
        [Route("auth")]
        [SwaggerResponse(HttpStatusCode.OK, "Authenticated", typeof(UserModel))]
        [SwaggerResponse(HttpStatusCode.Unauthorized, "Wrong username or password.")]
        public IHttpActionResult Authorize([FromBody]AuthModel auth)
        {
            var repository = new UserRepository();
            var user = repository.Get(auth.Username, auth.Password);

            if (user == null)
                return Unauthorized();

            return this.Ok(user.ToModel());
        }

        [HttpGet]
        [Route("ticket")]
        [SwaggerResponse(HttpStatusCode.OK, "Authenticated")]
        [SwaggerResponse(HttpStatusCode.Unauthorized, "Internal Error.")]
        public IHttpActionResult Get(string status)
        {
            var repository = new TicketRepository();
            var Ticket = repository.List(status);
            var models = Ticket.ToModel();

            return Ok(models);



        }

        [HttpGet]
        [Route("tickets")]
        [SwaggerResponse(HttpStatusCode.OK, "Authenticated")]
        [SwaggerResponse(HttpStatusCode.Unauthorized, "Internal Error.")]
        public IHttpActionResult Get(long Id_Name)
        {
            var repository = new TicketRepository();
            var Ticket = repository.ListById(Id_Name);
            var models = Ticket.ToModel();

            return Ok(models);
        }


        [HttpPost]
        [Route("New")]
        public IHttpActionResult Add(TicketModel model)
        {
            try
            {
                var ticket = model.ToDomain();
                ticket.Repository = new NewTicketRepository(); 
                ticket.Add();
                return Content(HttpStatusCode.NoContent, string.Empty);
            }
            catch (Exception ex)
            {
                return this.BadRequest();
            }
        }

        [HttpPost]
        [Route("update")]
        public IHttpActionResult update(TicketModel model)
        {
            try
            {
                var ticket = model.ToDomain();
                ticket.Repository = new NewTicketRepository();
                ticket.Update(); 
                return Content(HttpStatusCode.NoContent, string.Empty);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

    }
}
