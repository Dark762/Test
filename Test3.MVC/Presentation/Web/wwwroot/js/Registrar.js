var Cliente = function () {

    var RegistrarCliente = function () {
        $("#btnRegistrar").click(function () {

            var request = {
                Nombres: $("#Nombres").val(),
                Apellidos: $("#Apellidos").val(),
                Correo: $("#Apellidos").val(),
                FechaNacimiento: $("#FechaNacimiento").val(),
                Direccion: $("#Direccion").val(),
                Activo: $("#Activo").val(),
            };


            $.ajax({
                url: '/Cliente/Registrar',
                type: 'POST',
                data: JSON.stringify(request),
                dataType: "json",
                contentType: "application/json",
                //headers: {
                //    RequestVerificationToken:
                //        $('input:hidden[name="__RequestVerificationToken"]').val()
                //},
                success: function (data) {
                    if (data) {

                        alert("Registro correcto del cliente.")
                    }
                    else {
                        alert("No se realizo el registro del cliente.")
                    }
                },
                error: function (xhr) {

                }
            });

        });
    };


    return {
        init: function () {
            RegistrarCliente();
        }
    };

}();


$(document).ready(function () {
    //Cliente.init();
    $("#FormCliente").submit(function (e) {
        e.preventDefault(); // prevent actual form submit
        var form = $(this);
        var url = form.attr('action'); //get submit url [replace url here if desired]
        $.ajax({
            type: "POST",
            url: '/Cliente/Registrar',
            data: form.serialize(), // serializes form input
            success: function (data) {
                if (data.success) {
                    if (data.value) {
                       

                        setTimeout(function () { alert("Usuario registrado"); window.location.href = "/Cliente/Index"; }, 3000);
                    }
                    else {
                        alert(data.message);
                    }
                } else {
                    alert(data.message)
                }
            }
        });
    });

    $(document).on('submit', function (event) {

        event.preventDefault();
        
        // everything else you want to do on submit
    });

});
