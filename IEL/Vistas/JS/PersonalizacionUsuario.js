var usuario;
/*
Obtiene el usuario activo en el sistema.
Hace la consulta de la base de datos que obtiene la información del usuario. 
*/
$(document).ready(function () {
    usuario = $('#logear').text();
    IEL.Servicios.wsUsuario.getUsuarioByID(usuario, cargarUsuario);
});

/*
Carga los datos del usuario en los elementos correspondientes en la página.
*/
function cargarUsuario(resultado) {
    var logeado = JSON.parse(resultado);
    document.getElementById("privilegio").innerHTML = logeado.Privilegio;
    document.getElementById("lblUsuario").innerHTML = logeado.User;
    document.getElementById("lblCorreo").innerHTML = logeado.Correo;
    document.getElementById("imgUsuario").src = logeado.Foto;
}

/*
Se encarga de cambiar la contraseña del usuario, verifica que el campo no esté vacío, en caso de no estar, ejecuta la consulta que actualiza la contraseña del usuario.
*/
function cambiarPassword() {
    var nueva = document.getElementById("txtNuevaContrasena").value;
    if (nueva.localeCompare("") == 0) {
        alert("Debes escribir una contraseña válida");
        location.reload();
    } else {
        IEL.Servicios.wsUsuario.cambiarPassword(usuario, nueva, limpiar);
    }
}
/*
Una vez que el sistema ejecuta la nueva actualización de la contraseña, se encarga de limpiar los campos de la contraseña escrita en la caja de texto.
*/
function limpiar(resultado) {
    alert("Contraseña guardada");
    document.getElementById("txtNuevaContrasena").value = "";
    document.getElementById("txtNuevaContrasena").focus();
}

/*
Manda al usuario a la ventana de cambiar imagen de usuario.
*/
function salirImagen() {
    window.location.href = "CambiarImagen.aspx";
}
