using GoceryListApi.Models;
using GoceryListApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoceryListApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListController : ControllerBase
    {
        private IRepo _repo;
        public ListController(IRepo repo)
        {
            _repo = repo;
        }

        [HttpGet("all")]
        public IActionResult GetAllLists()
        {
            var result = _repo.GetAllLists();
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetListById(int id)
        {
            var result = _repo.GetListById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddList(List newList)
        {
            var result = _repo.AddList(newList);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult DeletelList(int id)
        {
            var result = _repo.DeleteList(id);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateList(List updatedList)
        {
            var result = _repo.UpdateList(updatedList);
            return Ok(result);
        }
    }
}





// GET http://localhost:1234/api/item