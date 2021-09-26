using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPICore.Models;

namespace WebAPICore.Service
{
    public class InventoryService: ControllerBase,IInventoryService
    {
       
        public ObjectResult Get()
        {
            using (var context = new ShopBridgeContext())
            {
                try
                {
                    var delInventoryData = context.InventoryData.ToList();
                    if (delInventoryData != null)
                    {
                        List<InventoryData> ListData = new List<InventoryData>();
                        ListData = delInventoryData.ToList();
                        return Ok(delInventoryData);
                    }
                    else
                    {
                        return new BadRequestObjectResult(new { message = "Inventory Not Found", currentDate = DateTime.Now });
                    }
                }
                catch (Exception ex)
                {
                    return new BadRequestObjectResult(new { message = "Error Occred While getting Inventory", currentDate = DateTime.Now });
                }
            }
        }

      
        public JsonResult GetByID(int InventoryId = 0)
        {
            using (var context = new ShopBridgeContext())
            {
                try
                {
                    InventoryData delInventoryData = context.InventoryData.Where(w => w.InventoryId == InventoryId).FirstOrDefault();
                    if (delInventoryData != null)
                    {
                        return new JsonResult(delInventoryData);
                    }
                    else
                    {
                        return new JsonResult(new { message = "Inventory Not Found", currentDate = DateTime.Now });
                    }
                }
                catch (Exception ex)
                {
                    return new JsonResult(new { message = "Error Occred While getting Inventory", currentDate = DateTime.Now });
                }
            }
        }


     
        public ObjectResult DeleteByID(int InventoryId = 0)
        {
            using (var context = new ShopBridgeContext())
            {
                try
                {
                    InventoryData delInventoryData = context.InventoryData.Where(w => w.InventoryId == InventoryId).FirstOrDefault();

                    if (delInventoryData != null)
                    {
                        context.Remove(delInventoryData);
                        var status = context.SaveChanges();
                        return new OkObjectResult(new { message = "Record Deleted Successfully", currentDate = DateTime.Now });
                    }
                    else
                    {
                        return new BadRequestObjectResult(new { message = "Inventory Not Found", currentDate = DateTime.Now });
                    }

                }
                catch (Exception ex)
                {
                    return new BadRequestObjectResult(new { message = "Error Occred While deleting Inventory", currentDate = DateTime.Now });
                }

            }
        }



        public JsonResult InsertUpdateInventory(InventoryData newdata, int InventoryId = 0)
        {
            using (var context = new ShopBridgeContext())
            {
                try
                {
                    InventoryData delInventoryData = context.InventoryData.Where(w => w.InventoryId == newdata.InventoryId).FirstOrDefault();

                    if (delInventoryData != null)
                    {
                        delInventoryData.Description = newdata.Description;
                        delInventoryData.Name = newdata.Name;
                        delInventoryData.Price = newdata.Price;
                        context.InventoryData.Update(delInventoryData);
                        context.SaveChanges();
                        return new JsonResult(new { message = "Record Updated Successfully", currentDate = DateTime.Now });
                    }
                    else
                    {
                        InventoryData Checkrecord = context.InventoryData.Where(w => w.Name == newdata.Name).FirstOrDefault();
                        if (Checkrecord != null)
                        {
                            return new JsonResult(new { message = "Record Exists Already", currentDate = DateTime.Now });
                        }
                        InventoryData dbupdateinventoy = new InventoryData();
                        dbupdateinventoy.Description = newdata.Description;
                        dbupdateinventoy.Name = newdata.Name;
                        dbupdateinventoy.Price = newdata.Price;
                        context.InventoryData.Add(dbupdateinventoy);
                        context.SaveChanges();
                        return new JsonResult(new { message = "Record Added Successfully", currentDate = DateTime.Now });
                    }

                }
                catch (Exception ex)
                {
                    return new JsonResult(new { message = "Error Occred While Adding/Updating Inventory", currentDate = DateTime.Now });
                }

            }
        }
    }
}
