$(document).ready(function () {
    $.ajax({
        url: '/Home/Countries',
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8',
        success: function (response) {
            var obj = "";
            obj += '<option selected>Open this select menu</option>';
            $.each(response, function (index, item) {
                obj += '<option value="' + item.CountryName + '">' + item.CountryName + '</option>';
            });
            $('select').html(obj);
        },
        error: function (xhr, status, error) {
            console.error("AJAX Error:", status, error);
        }
    });
});
