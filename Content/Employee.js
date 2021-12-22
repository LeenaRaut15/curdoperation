$(document).ready(function(){
    getMainEmployeeList();
});
var saveemployee = function () {
    var emp_name = $("#txtempname").val();
    var emp_address = $("#txtempaddress").val();
    var emp_mobileno = $("#txtempmobileno").val();
    var emp_emailid = $("#txtempemailid").val();
    var emp_qualification = $("#txtempqualification").val();
    var id = $("hdnid").val();

    var model = {
        Emp_Name: emp_name,
        Emp_Address: emp_address,
        Emp_Mobileno: emp_mobileno,
        Emp_Emailid: emp_emailid,
        Emp_Qualification: emp_qualification,
        id: id,
    };
    $.ajax({
        url: "/Employee/SaveEmployee",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert("Successful");
        }

    })
};

var getMainEmployeeList = function () {
    $.ajax({
        url: "/Employee/GetEmployeeList",
        method: "Post",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#tblEmployee tbody").empty();
            $.each(response.model, function (index, elementvalue) {
                html += "<tr><td>" + elementvalue.id + "</td><td>" + elementvalue.Emp_Name + "</td><td>" + elementvalue.Emp_Address + "</td><td>" + elementvalue.Emp_Mobileno + "</td><td>" + elementvalue.Emp_Emailid + "</td><td>" + elementvalue.Emp_Qualification + "</td><td><input type='Submit' value='Edit' onclick='editEmployee(" + elementvalue.id + ")'/><input type='Submit' value='Delete' onclick='deleteEmployee(" + elementvalue.id + ")'/></td></tr>";
            });
            $("#tblEmployee tbody").append(html);

        }
    });
}

var deleteEmployee = function (id) {
    var model = { id: id };
    $.ajax({
        url: "/Employee/deleteEmployee",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            alert("Record Deleted Successfully");
            getEmployeeList();

        }
    });
}

var editEmployee = function (id) {
    var model = { id: id };
    $.ajax({
        url: "/Employee/GetEditEmployee",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "Json",
        async: false,
        success: function (response) {
            $("#hdnid").val(response.model.id);
            $("#txtempname").val(response.model.Emp_Name);
            $("#txtempaddress").val(response.model.Emp_Address);
            $("#txtempmobileno").val(response.model.Emp_Mobileno);
            $("#txtempemailid").val(response.model.Emp_Emailid);
            $("#txtempqualification").val(response.model.Emp_Qualification);
        }
    });
}