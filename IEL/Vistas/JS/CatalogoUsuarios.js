/*Función que se ejecuta al estar listo el documento
Obtiene la lista de usuarios de la base de datos a través del Web service.
Enfoca la página en la tabla creada.
*/
$(document).ready(function () {
    IEL.Servicios.wsUsuario.getAll(onComplete_cargarlista);
    document.getElementById('tabla').focus();
});
/*
Obtiene el elemento tabla de tipo HTML y le asigna la lista de usuarios obtenida, carga los datos de los usuarios en la tabla.
*/
function onComplete_cargarlista(response) {
    var dataSet = JSON.parse(response);
    var ruta = document.getElementById('ruta').innerHTML;
    var hoy = new Date();
    var dia = String(hoy.getDate()).padStart(2, '0');
    var mes = String(hoy.getMonth() + 1).padStart(2, '0');
    var ano = hoy.getFullYear();
    hoy = dia + '/' + mes + '/' + ano;

    tabla = $('#tabla').dataTable({
        dom: 'Bfrtip',
        data: dataSet,
        buttons: [{
            extend: 'pdf',
            text: 'Exportar PDF',
            title: '        ' + 'Usuarios en el Sistema                          ' + hoy,
            filename: 'Tabla Usuarios',
            footer: true,
            exportOptions: { columns: [0, 1, 2, 3, 4, 5, 6] },
            download: 'open',
            customize: function (doc) {
                doc.content.splice(1, 0, {
                    margin: [0, 0, 0, 12],
                    alignment: 'left',
                    image: 'data:image/png;base64,' + ruta,
                    width: 100,
                    height: 60
                });
                doc['footer'] = (function (page, pages) {
                    return {
                        columns: ['Sistema de Aprendizaje IEL', { alignment: 'right', text: ['Página ', { text: page.toString() }, ' de ', { text: pages.toString() }] }],
                        margin: [10, 0]
                    }
                });
            }
        }],
        columns: [
            { title: "User", data: "User", render: $.fn.dataTable.render.text() },
            { title: "Nombre", data: "Nombre", render: $.fn.dataTable.render.text() },
            { title: "Apellido Paterno", data: "ApellidoPaterno", render: $.fn.dataTable.render.text() },
            { title: "Apellido Materno", data: "ApellidoMaterno", render: $.fn.dataTable.render.text() },
            { title: "Correo", data: "Correo", render: $.fn.dataTable.render.text() },
            { title: "Foto", data: "Foto", render: $.fn.dataTable.render.text() },
            { title: "Privilegio", data: "Privilegio", render: $.fn.dataTable.render.text() },
            { title: "Eliminar", data: null, render: function (data, type, row) { return '<input type="button" value="Eliminar ' + data.User + '" onclick="eliminar(this)" class="btn-default"/>'; } },
            { title: "Editar", data: null, render: function (data, type, row) { return '<input type="button" value="Editar ' + data.User + '" onclick="editar(this)" class="btn-default"/>'; } }
        ]
    });
}
/*
Función que elimina un usuario, debe confirmar la eliminación el administrador antes de eliminar.
*/
function eliminar(fila) {
    var Usuario = fila.value.substring(9, fila.value.length);
    var confirmar = confirm("¿Desea eliminar el usuario?");
    if (confirmar) {
        IEL.Servicios.wsUsuario.delete(Usuario, Exito);
        alert("Usuario Eliminado");
        window.location.reload(true);
    }
}

function Exito(response) { }
/*
Obtiene el valor del usuario seleccionado para editar, lo almacena en la sesión de almacenamiento actual y dirige a la ventana de edición.
*/
function editar(fila) {

    var Usuario = fila.value.substring(7, fila.value.length);
    localStorage.Usr = Usuario;
    location.href = "EditarUsuario.aspx";
}
/*
Abre la ventana para agregar un nuevo usuario a la base de datos.
*/
function agregar() {
    location.href = "AgregarUsuario.aspx";
}

