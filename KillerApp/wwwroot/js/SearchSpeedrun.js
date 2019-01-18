jQuery(document).ready(function () {
    $("#prodId").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#myTable tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
});

jQuery(document).ready(function () {
    $("#Category").click(function (e) {
        $("#myTable tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf("l") > -1)
        });
    });
});