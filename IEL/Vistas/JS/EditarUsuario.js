var User, Password, Nombre, ApellidoPaterno, ApellidoMaterno, Correo, Privilegio = "Alumno", Foto;
var elegir = false;
var actual;
var contrasenia;
/*
Obtiene el usuario que se desea editar.
Deshabilita la caja de texto para que no se pueda editar el nombre de usuario.
*/
$(document).ready(function () {
    actual = localStorage.Usr;    
    document.getElementById('EditUser').disabled = true;
    IEL.Servicios.wsUsuario.getUsuarioByID(actual, cargar);
    document.getElementById('EditPassword').focus();
});
/*
Carga los valores del usuario obtenido en las cajas de texto.
*/
function cargar(response) {
    var usuario = JSON.parse(response);   
    document.getElementById('EditUser').value = usuario.User;
    document.getElementById('EditPassword').value = usuario.Password;
    contrasenia = usuario.Password;
    document.getElementById('EditNombre').value = usuario.Nombre;
    document.getElementById('EditApellidoPaterno').value = usuario.ApellidoPaterno;
    document.getElementById('EditApellidoMaterno').value = usuario.ApellidoMaterno;
    document.getElementById('EditCorreo').value = usuario.Correo;
}
/*
Coloca la imagen de perfil seleccionada por el usuario.
*/
function cambiarAvatar(foto) {
    var nueva = foto.src;
    if (foto.id.localeCompare("imgHombre") == 0) {
        document.getElementById('imgHombre').style.border = "thick solid blue";
        document.getElementById('imgMujer').style.border = "none";
    } else {
        document.getElementById('imgHombre').style.border = "none";
        document.getElementById('imgMujer').style.border = "thick solid blue";
    }
    var indice = nueva.indexOf('V');
    Foto = nueva.substring((indice - 1), nueva.length);
    elegir = true;
}
/*
Obtiene los nuevos valores insertados por el usuario y verifica que todos los campos estén completos.
Si es así, edita el usuario.
*/
function editar() {
    User = document.getElementById('EditUser').value;   
    Password = document.getElementById('EditPassword').value;
    var n = contrasenia.localeCompare(Password);
    if (n == 0) {
        Password = "igual";
        
    }
    Nombre = document.getElementById('EditNombre').value;
    ApellidoPaterno = document.getElementById('EditApellidoPaterno').value;
    ApellidoMaterno = document.getElementById('EditApellidoMaterno').value;
    Correo = document.getElementById('EditCorreo').value;
    if (Password.localeCompare("") == 0 || Nombre.localeCompare("") == 0 || ApellidoPaterno.localeCompare("") == 0 || ApellidoMaterno.localeCompare("") == 0 || Correo.localeCompare("") == 0 || !elegir) {
        alert("Todos los campos son obligatorios");
    } else {
        
        IEL.Servicios.wsUsuario.update(User,Password,Nombre,ApellidoPaterno,ApellidoMaterno,Correo,Foto,Privilegio,volver);
    }
}
/*
Devuelve al usuario al catálogo de usuarios.
*/
function volver(response) {
    alert("Usuario editado");
    location.href = "CatalogoUsuarios.aspx";
}