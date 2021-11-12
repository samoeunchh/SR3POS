// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var options = "";
$.ajax({
    method: "GET",
    dataType: "json",
    url: "/Products/GetUnits",
    success: function (data) {
        $.each(data, function (i, v) {
            options += "<option value='" + v.unitId + "'>" + v.unitName + "</option>";
        });
    },
    error: function (error) {
        console.log(error);
    }
});
