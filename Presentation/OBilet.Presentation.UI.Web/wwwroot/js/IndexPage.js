$(document).ready(function () {
    // GET BY ID
    $(".btn-get-student").on("click", function () {
       var formData = $("#obilet-form").val()


        $.ajax({
            type: 'GET',
            url: "/index/locationBus",
            contentType: false,
            processData: false,
            cache: false,
            data: formData,
            success: function (response) {
                if (response.responseCode == 0) {
                }
                else {
                    bootbox.alert(response.ResponseMessage);
                }
            },
            error: errorCallback
        });
    });
});