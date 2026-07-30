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
   
        //$("#select").on('change', function () {
        //if ($("#select option:selected").text() === "User") {    .... applicable ra nis select option

    $(document).on('click', '#btnShowUser', function () {
        $.ajax({
            type: "GET",
            url: "/Home/GetUser",
            data: {},
            success: function (data) {

                alert(data.message); //kung success sya, i display niya katong query nga "SELECT * FROM {tblName};"

                $("#tblBody").empty(); //iya ireset ang table para d mag doble ang entry

                //ari iya gi populate ang table sa bag ong given data
                if (data.getUser.length > 0) {
                    for (var i = 0; i < data.getUser.length; i++) {
                        //sya maghimo sulod sa table body
                        $("#tblBody").append("<tr>" +
                            "<td>" + data.getUser[i].email + "</td>" +
                            "<td>" + data.getUser[i].age + "</td>" +
                            "<td>" + data.getUser[i].password + "</td>" +
                            "<td>" +
                            "<a href='#' onclick='getUserById(" + data.getUser[i].UserId + ")' class='btn btn-success'>Edit</a>" +
                            "<a href='#' onclick='DeleteUser(" + data.getUser[i].UserId + ")' class='btn btn-danger'>Delete</a>" +
                            "</td>" +
                            "</tr>");
                    }
                }
            },
            //error(response) {
            //  alert(response.message);
            //}
        });
    });
})





//function loadUsers() {
//    $.ajax({
//        url: "/Home/GetUser",
//        type: "GET",
//        success: function (response) {
//            alert(response);
//        }
//    })
//}

// 'on' function ang gamiton kung dynamic ang HTML nga nag load
//$('#content-container').on('click', '.btn-edit', function () {

// Kuhaon ang ID sa gi-click nga row
//var idToEdit = $(this).data('id');

//alert("Mag-edit ta sa ID nga: " + idToEdit);

// Diri naka pwede mag-ajax padulong sa imong Controller
// $.ajax({ url: '/Products/Edit/' + idToEdit, ... });




