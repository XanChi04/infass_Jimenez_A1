$(function () {

    $(document).on('click', '#btnRegister', function (e) {
        e.preventDefault();
        $.ajax({
            url: "/Home/Register",
            type: "POST",
            data: {
                email: $('#email').val(),
                age: $('#age').val(),
                password: $('#password').val(),
                confirmPassword: $('#confirmPassword').val()
            },
            success: function (response) {
                alert(response);

                window.location.href = "/Home/Login";
            }
        });
    });

    $(document).on('click', '#btnLogin', function (e) {
        e.preventDefault();
        $.ajax({
            url: "/Home/Login",
            type: "POST",
            data: {
                email: $("#email").val(),
                password: $("#password").val()
            },
            success: function (response) {
                alert(response.message);

                if (response.success) {

                    window.location.href = "/Home/Index";
                    if ($("#dbLink").prop("hidden") === true) {
                        $("#dbLink").prop("hidden") === false;
                    }
                }
        });
    });













