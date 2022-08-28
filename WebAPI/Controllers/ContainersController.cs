using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContainersController : ControllerBase
    {
        IContainerService _containerService; //To avoid instance generation process everytime,injection was implemented.

        public ContainersController(IContainerService containerService)
        {
            _containerService = containerService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll() //The method to obtain all the items in the list.
        {
            var result = _containerService.GetAll(); //The method to obtain all the items in the list.
            if (result.Success)
            {
                return Ok(result); //If the process was successful, it will return 200 status code with a relevant message.
            }
            return BadRequest(result); //If the process was fail, it will return 400 status code with a relevant message.
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody] Container container) //This method of adding the instance with the parameters taken from body to the list.
        {
            var result = _containerService.Add(container);

            if (result.Success)
            {
                return Ok(result); //If the process was successful, it will return 200 status code with a relevant message.
            }
            return BadRequest(result);//If the process was fail, it will return 400 status code with a relevant message.
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] Container container) //This method of updating the instance according to the parameters taken from body to the list.
        {
            var result = (_containerService.Update(container));
            if (result.Success)
            {
                return Ok(result); //If the process was successful, it will return 200 status code with a relevant message.
            }
            return BadRequest(result);//If the process was fail, it will return 400 status code with a relevant message.
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            var result = _containerService.Delete(id); //This method of deleting the instance according to id.
            if (result.Success)
            {
                return Ok(result);//If the process was successful, it will return 200 status code with a relevant message.
            }
            return BadRequest(result);//If the process was fail, it will return 400 status code with a relevant message.
        }
    }
}
