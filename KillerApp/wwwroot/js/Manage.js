function DeleteCompany(id) {
    if (confirm("Are you sure you want to delete the company?")) {
        $.post("/Company/DeleteCompany",
            {
                CompanyID: id
            },
            function (data, status) {
            }
        );
        $(this).closest('tr').addClass('hidden');

    }
}