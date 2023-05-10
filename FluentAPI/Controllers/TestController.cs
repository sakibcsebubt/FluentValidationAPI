using FluentAPI.Models;
using FluentAPI.ModelValidator;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FluentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IValidator<UserModel> _validator;
        public TestController(IValidator<UserModel> validator)
        {
            _validator = validator;
        }
        // GET: api/<TestController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestController>
        [HttpPost]
        public async Task<IActionResult> Post(UserModel userModel)
        {
            //var tkjk = UserModelValidatorscs();
            //UserModelValidatorscs obj = new();
            //obj.UserModelValidatorscs();
            //UserModelValidatorscs customeUserModelValidatorscsrValidator = new();
            var validatorResult = await _validator.ValidateAsync(userModel);
            if (!validatorResult.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, validatorResult.Errors);
            }
            //var validation = await _validator.ValidateAsync(model);
            //if (!validation.IsValid)
            //{
            //    return BadRequest(validation.Errors?.Select(e => new ValidationResult()
            //    {
            //        Code = e.ErrorCode,
            //        PropertyName = e.PropertyName,
            //        Message = e.ErrorMessage
            //    }));
            //}
            return Ok();
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
