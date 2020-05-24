var usuario;
/*
Obtiene el usuario activo en el sistema.
*/
$(document).ready(function () {
    usuario = $('#logear').text();
});
/*
El usuario al seleccionar una imagen, se obtiene la ruta de la imagen y se ejecuta la consulta que actualiza la nueva ruta seleccionada.
*/
function cambiarImg(foto) {
    var nueva = foto.src;
    var indice = nueva.indexOf('V');
    var ruta = nueva.substring((indice - 1), nueva.length);
    IEL.Servicios.wsUsuario.cambiarImagen(usuario, ruta, respuesta);
}
/*
Notifica al usuario que la imagen que seleccionó se cambió correctamente.
*/
function respuesta(res) {
    alert("Imagen cambiada correctamente");
}

/*
Devuelve al usuario al form de personalización de usuario.
*/
function volver() {
    location.href = "PersonalizacionUsuario.aspx";
}
