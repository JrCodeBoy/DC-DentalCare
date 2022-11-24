// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $("#submitDate").on("click", function () {
        $.ajax({
            type: "POST",
            url: "../MyController/Calculate?date=" + $("input#date").val(),
            // syntax was wrong here
            success: function (result) {
                $("#DaysToBeViewed").val(result);
            },
            error: function () {
                alert("Error in calculation method");
            }
        });
    });
});