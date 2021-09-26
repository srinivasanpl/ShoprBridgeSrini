using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPICore.Models;

namespace WebAPICore.Service
{
    public interface IInventoryService
    {
        ObjectResult Get();
        JsonResult GetByID(int InventoryId);
        ObjectResult DeleteByID(int InventoryId);

        JsonResult InsertUpdateInventory(InventoryData newdata, int InventoryId = 0);
    }
}
