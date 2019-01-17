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
//TODO filter niet hidden items
jQuery(document).ready(function () {
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById("myInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("myTable");
    tr = table.getElementsByTagName("tr");

    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[0];
        if (td) {
            txtValue = td.textContent || td.innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
            } else {
                tr[i].style.display = "none";
            }
        }
    }

});
