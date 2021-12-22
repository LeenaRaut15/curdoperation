var savereg = function () {
    var name = $("#txtname").val();
    var address = $("#txtaddress").val();
    var mobile_no = $("#txtmobile_no").val();

    var model = {
        Name: name,
        Address: address,
        Mobile_no: mobile_no,
    };
    $.ajax({
        url: "/Reg/SaveReg",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert("Successful");
        }

    })
}