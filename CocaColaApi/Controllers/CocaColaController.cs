using CocaColaApi.Models;
using CocaColaBll.Interfaces;
using CocaColaBll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CocaColaApi.Controllers
{
    public class CocaColaController : ApiController
    {
        private readonly IBaseService _service;
        private const string adminEmail = "adminadmin";

        public CocaColaController(IBaseService service)
        {
            _service = service;
        }

        [Route("api/register"), HttpPost]
        public async Task<IHttpActionResult> Register([FromBody]AddUserViewModel user)
        {
            var code = _service.GetCodeByTitle(user.Title);
            if (code == null)
                return NotFound();

            if(code.Used)
                return StatusCode(HttpStatusCode.Forbidden);

            await _service.Add(new UserBll
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Codes = new List<CodeBll> { code }
            });
            return Ok();
        }

        [Route("api/user"), HttpGet]
        public async Task<IHttpActionResult> GetByEmail(string email)
        {
            if (string.Equals(email, adminEmail, StringComparison.OrdinalIgnoreCase))
                return Ok(_service.GetAll());
            var result= await _service.GetByEmail(email);
            if (result.ToList()[0] == null)
                return NotFound();
            else
            return Ok(result);
        }
    }
}
