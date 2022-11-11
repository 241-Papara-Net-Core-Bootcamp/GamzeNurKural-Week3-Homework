using GamzeNurKural_Week3_Homework.Domain.Entities;
using GamzeNurKural_Week3_Homework.Services.Abstracts;
using GamzeNurKural_Week3_Homework.Services.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection.Metadata.Ecma335;

namespace GamzeNurKural_Week3_Homework.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IWorkerService _workerService;

        public WorkerController(IWorkerService workerService)
        {
            _workerService = workerService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _workerService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _workerService.GetById(id);
            if (result != null)
                return Ok(result);
            return BadRequest("Worker with this id not found.");
        }

        [HttpPost]
        public IActionResult Post(WorkerDto workerDto)
        {
            _workerService.Add(workerDto);
            return Ok(workerDto);
        }

        [HttpPut]
        public IActionResult Update(Worker worker)
        {
           var result = _workerService.Update(worker);
            if (result < 0)
                return BadRequest("Worker with this id not found.");
            return Ok(worker);
        }

        [HttpPut("Delete")]
        public IActionResult Delete(Worker worker)
        {
           var result = _workerService.Delete(worker);
            if (result < 0)
                return BadRequest("Worker with this id not found.");
            return Ok();
        }        
        
        [HttpDelete]
        public IActionResult HardDelete(Worker worker)
        {
           var result = _workerService.HardDelete(worker);
            if (result < 0)
                return BadRequest("Worker with this id not found.");
            return Ok();
        }
    }
}
