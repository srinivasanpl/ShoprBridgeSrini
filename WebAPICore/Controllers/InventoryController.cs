using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAPICore.Models;
using WebAPICore.Service;

namespace WebAPICore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        public InventoryService InventoryService = new InventoryService();
        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            return InventoryService.Get();
        }

        [HttpPost]
        [Route("GetByID")]
        public JsonResult GetByID(Object model)
        {
            var jsonString = model.ToString();
            InventoryData newdata = JsonConvert.DeserializeObject<InventoryData>(jsonString);
            return InventoryService.GetByID(newdata.InventoryId);
        }

        [HttpPost]
        [Route("DeleteByID")]
        public IActionResult DeleteByID(Object model)
        {
            var jsonString = model.ToString();
            InventoryData newdata = JsonConvert.DeserializeObject<InventoryData>(jsonString);
            return InventoryService.DeleteByID(newdata.InventoryId);
        }


        [HttpPost]
        [Route("InsertUpdateInventory")]
        public JsonResult InsertUpdateInventory(Object model )
        {
           // InventoryData newdata = null;
            var jsonString = model.ToString();
            InventoryData newdata = JsonConvert.DeserializeObject<InventoryData>(jsonString);
            return InventoryService.InsertUpdateInventory(newdata, newdata.InventoryId);
        }


    }
        
}
