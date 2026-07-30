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

                    //if ($("#dbLink").prop("hidden") === true) {
                    //    $("#dbLink").prop("hidden") === false;
                    //}
                }
            }
        });
    });
   
    $(document).on('click', '#btnUser', function () {
            loadUsers();
        
    });

    function loadUsers() {
        $.ajax({
            type: "GET",
            success: function (response) {
                alert(response);
            }
        });
})
//access select option






//    var tbody = $("#userTable tbody");
//    tbody.empty();


//        tbody.append(`
//<tr>
//    <td>${user.email}</td>
//    <td>${user.age}</td>
//    <td>
//        <button class="btn btn-warning btn-sm">Edit</button>
//        <button class="btn btn-danger btn-sm">Delete</button>
//    </td>
//</tr>
//`);




