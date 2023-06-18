using BankApplication.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankApplication.Controllers
{
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly DbHelper _db;

        public CustomersController(EF_DataContext eF_DataContext)
        {
            _db = new DbHelper(eF_DataContext);
        }
        // GET: api/<CustomersController>
        [HttpGet]
        [Route("api/[controller]/GetCustomers")]
        public IActionResult Get()
        {
            ResponseType type = ResponseType.Success;
            try
            {
                IEnumerable<CustomerModel> data = _db.GetCustomers();
                if(!data.Any())
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type,data));
            }
            catch (Exception ex)
            {
                type = ResponseType.Faliure;
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // GET api/<CustomersController>/5
        [HttpGet]
        [Route("api/[controller]/GetCustomerById/{id}")]
        public IActionResult Get(int id)
        {
            ResponseType type = ResponseType.Success;
            try
            {
                CustomerModel data = _db.GetCustomersById(id);

                if (data == null)
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // POST api/<CustomersController>
        [HttpPost]
        [Route("api/[controller]/SaveCustomer")]
        public IActionResult Post([FromBody] CustomerModel model)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.SaveCustomer(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // PUT api/<CustomersController>/5
        [HttpPut]
        [Route("api/[controller]/UpdateCustomer")]
        public IActionResult Put([FromBody] CustomerModel model)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.SaveCustomer(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete]
        [Route("api/[controller]/DeleteCustomer/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.DeleteCustomer(id);
                return Ok(ResponseHandler.GetAppResponse(type, "Delete Successfully"));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }
    }
}
