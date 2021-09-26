$(document).ready(function () {
    $("#idinv").val('0');
    GetInventoryData();

})

function GetInventoryData() {
    $.ajax({
        type: 'GET',
        dataType: 'json',
        url: "http://localhost:44326/api/Inventory/Get",
        contentType: "application/json; charset=utf-8",
        success: function (result) {
            // alert(result);
            if (result) {
                var html = "";
                var html1 = "";
                //add header row
                html += "<thead> <tr>";
                html += "<th>Name </th>";
                html += "<th>Description</th>";
                html += "<th>Price</th>";
                html += "<th>Edit</th>";
                html += "<th>Delete</th>";
                html += "</tr>";
                html += "</thead>";
                var lent = result.length;
                // var row = '';
                for (let i = 0; i < lent; i++) {
                    var obj = new Object();
                    obj.InventoryId = result[i].inventoryId;
                    obj.Name = result[i].name;
                    obj.Description= result[i].description;
                    obj.Price= result[i].price;

                    html1 +=
                        + "<tr> "
                        + "<td>" + result[i].name + "</td>"
                        + "<td>" + result[i].description + "</td>"
                        + "<td>" + result[i].price + "</td>"
                    + "<td><button class=btn-success onclick=EditInventory("+result[i].inventoryId+")>Edit</button></td>"
                    + "<td><button class=btn-danger onclick=DeleteInventory("+result[i].inventoryId+")>Delete</button></td>"
                    + "</tr> "
                    // html1 = html1;
                }
                html = html + html1;
                if ($.fn.DataTable.isDataTable('#tblGrid')) {
                    $('#tblGrid').DataTable().destroy();
                    $('#tblGrid').empty();
                }
                $("#tblGrid").append(html);
                gridDataTableView("Grid Example.xls");
            }

        },
        error: function (xhr, err) {
            alert(err);
        },
    });
}
gridDataTableView = function (fname) {
    $('#tblGrid').dataTable({
        "bFilter": true,
        "bLengthChange": false, "bPaginate": true, "bInfo": true,
        dom: 'Bfrtip',
        "order": [[0, 'desc'], [1, 'desc']],
        buttons: [{ extend: 'excelHtml5', text: 'Export to Excel', className: 'link_button', title: fname }]
    });
}
function SaveInventory(e) {
    if ($("#txtInventoryDescription").val() == '' || $("#txtInventoryName").val() == '' || $("#txtInventoryPrice").val() =='') {
        alert("Please enter values for all the fields.");
        return false;
    }
    var invids = 0;
    if ($("#idinv").val() != "") {
        invids = $("#idinv").val();
    }
    $.ajax({
        type: 'POST',
        dataType: 'json',
        url: "http://localhost:44326/api/Inventory/InsertUpdateInventory",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({
            InventoryId: invids,
            Name: $("#txtInventoryName").val(),
            Description: $("#txtInventoryDescription").val(),
            Price: $("#txtInventoryPrice").val()
        }),
        success: function (msg) {
            alert(msg.message);
            GetInventoryData();
        },
        error: function (xhr, err) {
            alert(err);
        },
    });
};
function Clear() {
    // alert('all');
    $("#txtInventoryName").val('');
    $("#txtInventoryDescription").val('');
    $("#txtInventoryPrice").val('');
    $("#idinv").val('0');
};
function EditInventory(e) {
  //  alert('called');
    $("#idinv").val('0');
    $.ajax({
        type: 'POST',
        dataType: 'json',
        url: "http://localhost:44326/api/Inventory/GetByID",       
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ InventoryId: e }),
        success: function (result) {
            // alert(result);
            if (result) {
                $("#txtInventoryName").val(result.name);
                $("#txtInventoryDescription").val(result.description);
                $("#txtInventoryPrice").val(result.price);
                $("#idinv").val(e);
            }

        },
        error: function (xhr, err) {
            alert(err);
        },
    });

};

function DeleteInventory(e) {
    $.ajax({
        type: 'POST',
        dataType: 'json',
        url: "http://localhost:44326/api/Inventory/DeleteByID",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ InventoryId: e }),
        success: function (msg) {
            alert(msg.message);
            GetInventoryData();
        },
        error: function (xhr, err) {
            alert(err);
        },
    });
};