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
    public class ItemController : ControllerBase
    {
        private IRepo _repo;
        public ItemController(IRepo repo)
        {
            _repo = repo;
        }

        [HttpGet("fromlist")]
        public IActionResult GetListItems(int id)
        {
            var result = _repo.GetListItems(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetItemById(int id)
        {
            var result = _repo.GetItemById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddItem(Item newItem)
        {
            var result = _repo.AddItem(newItem);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult DeleteItem(int id)
        {
            var result = _repo.DeleteItem(id);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateItem(Item updatedItem)
        {
            var result = _repo.UpdateItem(updatedItem);
            return Ok(result);
        }
    }
}





// GET http://localhost:1234/api/item