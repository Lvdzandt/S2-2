jQuery(function () {
    $("a.toggler").click(function (e) {
        var prodCat = ($(this).attr("data-prod-cat"));
        $(".cat" + prodCat).toggle();
    });
});

jQuery(document).ready(function () {
    $("#prodId").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#myTable tr").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1) 
        });
        
    });
});
