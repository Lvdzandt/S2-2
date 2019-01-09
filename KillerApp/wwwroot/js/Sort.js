jQuery(function () {
    $("body").on("click", "#addRow", function (ev) {
        var len = $("#tabprincipal tbody tr").toArray().length;
        var newRow = "<tr class='tabrow closed'>";
        var rowNum = $('#tabprincipal').data('myval');
        for (var i = 0; i < rowNum; i++) {
            newRow += "<td><div>" + len + "</div><div><input type='text' value='" + len + "'/></div></td>"
        }
        newRow += "</tr>";
        $(newRow).appendTo("#tabprincipal tbody");

    });
});

jQuery(function () {
    $(".toggler").click(function (e) {
        e.preventDefault();
        $('.cat' + $(this).attr('data-prod-cat')).toggle();
    });
});