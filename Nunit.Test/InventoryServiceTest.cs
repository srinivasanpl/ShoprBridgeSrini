using System;
using NUnit.Framework;
using WebAPICore.Models;
using WebAPICore.Service;

namespace Nunit.Test
{
    [TestFixture]
    public class InventoryServiceTest
    {
        [Test]
        public void TestGet()
        {
            var data = new InventoryService();
            var result = data.Get();
            Assert.AreEqual(true,result == null?false:true);
        }
        [Test]
        public void TestGetByID()
        {
            var data = new InventoryService();
            var input = new InventoryData();
            var result = data.GetByID(input.InventoryId =1);
            Assert.AreEqual(true, result == null ? false : true);
        }
        [Test]
        public void TestSaveDate()
        {
            var data = new InventoryService();
            InventoryData input = new InventoryData();
            input.Name = "Testing";
            input.Description = "Testing";
            input.Price = (decimal?)12.12;
            var result = data.InsertUpdateInventory(input);
            bool add = (result.Value.ToString().Split(',')[0].Split('=')[1]).Trim() == "Record Added Successfully" ? true : false;
            bool exists = (result.Value.ToString().Split(',')[0].Split('=')[1]).Trim() == "Record Exists Already" ? true : false;
            Assert.AreEqual(true, add == true || exists == true ? true : false);
          
        }
        [Test]
        public void TestUpdateDate()
        {
            var data = new InventoryService();
            InventoryData input = new InventoryData();
            input.Name = "Testing";
            input.Description = "Testing";
            input.Price = (decimal?)12.12;
            input.InventoryId = 30;
            var result = data.InsertUpdateInventory(input);
            Assert.AreEqual(true, ((result.Value.ToString().Split(',')[0]).Split('=')[1]).Trim() == "Record Updated Successfully" ? true : false);
        }
        [Test]
        public void TestDeleteDate()
        {
            var data = new InventoryService();
            InventoryData input = new InventoryData();
            input.InventoryId = 15;
            var result = data.DeleteByID(input.InventoryId);
            Assert.AreEqual(true, ((result.Value.ToString().Split(',')[0]).Split('=')[1]).Trim() == "Record Deleted Successfully" ? true : false);
        }
    }
}
