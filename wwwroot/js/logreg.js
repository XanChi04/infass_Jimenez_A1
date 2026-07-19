$(function () {
    $(document).on('click', '#btnLogin', function (e) {
        e.preventDefault();
        $.ajax({
            url: "/Home/Login",
            type: "POST",
            data: {
                email: $('#email').val(),
                password: $('#password').val()
            },
            success: function (response) {
                alert(response);
            }
        })
    })

    $(document).on('click', '#btnRegister', function (e) {
        e.preventDefault();
        $.ajax({
            url: "/Home/Register",
            type: "POST",
            data: {
                email: $('#email').val(),
                password: $('#password').val(),
                confirmPassword: $('#confirmPassword').val()
            },
            success: function (response) {
                alert(response);
            }
        })
    })
})
