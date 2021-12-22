var savestudent = function () {
    var name = $("#txtname").val();
    var address = $("#txtaddress").val();
    var mobile_no = $("#txtmobileno").val();
    var email_id = $("#txtemailid").val();
    

    var model = {
        Name: name,
        Address: address,
        Mobile_no: mobile_no,
        Email_id: emp_email_id,
        
    };
    $.ajax({
        url: "/Student/SaveStudent",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert("Successful");
        }

    })
}

