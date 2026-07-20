$(function () {

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
