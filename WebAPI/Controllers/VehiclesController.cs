using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        IVehicleService _vehicleService; //To avoid instance generation process everytime,injection was implemented.

        public VehiclesController(IVehicleService vehicleService)
        {
            this._vehicleService = vehicleService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll() //The method to obtain all the items in the list.
        {
            var result = _vehicleService.GetAll(); //The method to obtain all the items in the list.
            if (result.Success)
            {
                return Ok(result); //If the process was successful, it will return 200 status code with a relevant message.
            }
            return BadRequest(result); //If the process was fail, it will return 400 status code with a relevant message.
        }

        [HttpGet("GetContainers")]

        public IActionResult GetContainers(int id)  //The method to obtain all the related items in the list.
        {
            var result = _vehicleService.GetContainers(id); //The method to obtain all the related items in the list.

            if (result.Success)
            {
                return Ok(result); //If the process was successful, it will return 200 status code with a relevant message.
            }
            return BadRequest(result); //If the process was fail, it will return 400 status code with a relevant message.
        }

        [HttpGet("PartitionContainers")]
        public IActionResult PartitionContainers(int vehicleId, int partitionNumber)
        {
            var result = _vehicleService.PartitionContainers(vehicleId, partitionNumber);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody] Vehicle vehicle) //This method of adding the instance with the parameters taken from body to the list.
        {
            var result = _vehicleService.Add(vehicle);
            if (result.Success)
            {
                return Ok(result); //If the process was successful, it will return 200 status code with a relevant message.
            }
            return BadRequest(result);//If the process was fail, it will return 400 status code with a relevant message.
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] Vehicle vehicle) //This method of updating the instance according to the parameters taken from body to the list.
        {
            var result = (_vehicleService.Update(vehicle));
            if (result.Success)
            {
                return Ok(result); //If the process was successful, it will return 200 status code with a relevant message.
            }
            return BadRequest(result);//If the process was fail, it will return 400 status code with a relevant message.
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            var result = _vehicleService.Delete(id); //This method of deleting the instance according to id.
            if (result.Success)
            {
                return Ok(result);//If the process was successful, it will return 200 status code with a relevant message.
            }
            return BadRequest(result);//If the process was fail, it will return 400 status code with a relevant message.
        }
    }
}
