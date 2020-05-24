var usuario;
$(document).ready(function () {
    //var usuario = "Jose1";
    usuario = $('#logear').text();
    IEL.Servicios.wsUsuario.getUsuarioByID(usuario, cargarDatos);
    IEL.Servicios.wsPractica.getTotalPresenteByUser(usuario, cargarEstadisticas);
    IEL.Servicios.wsPractica.getTotalPasadoByUser(usuario, estadisticasPasado);
    IEL.Servicios.wsPractica.getTotalVerbosByUser(usuario, estadisticasVerbos);
    IEL.Servicios.wsPractica.getTotalVocabularioByUser(usuario, estadisticasVocabulario);
   // IEL.Servicios.wsPreguntaContestadaPorUsuario.getPreguntasCorrectasPresenteSimple(usuario,cargarEstadisticas);
    //IEL.Servicios.wsPreguntaPorTema.getPreguntasPorTema(2, preguntasPasado);
    //IEL.Servicios.wsPreguntaContestadaPorUsuario.getPreguntasCorrectasPasadoSimple(usuario, estadisticasPasado);
    //IEL.Servicios.wsPreguntaPorTema.getPreguntasPorTema(3, preguntasVerbos);
    //IEL.Servicios.wsPreguntaContestadaPorUsuario.getPreguntasCorrectasVerbos(usuario, estadisticasVerbos);
    //IEL.Servicios.wsPreguntaPorTema.getPreguntasPorTema(4, preguntasVocabulario);
    //IEL.Servicios.wsPreguntaContestadaPorUsuario.getPreguntasCorrectasVocabulario(usuario, estadisticasVocabulario);
    
});


var datosObtenidos;

var numPreguntasTotalPresente=0;
var preguntasCorrectasPresente;
var numPreguntasTotalPasado = 0;
var preguntasCorrectasPasado;
var numPreguntasTotalVerbos = 0;
var preguntasCorrectasVerbos;
var numPreguntasTotalVocabulario = 0;
var preguntasCorrectasVocabulario;
function preguntasPresente(resultado) {
   var preguntasTotal = JSON.parse(resultado);
   numPreguntasTotalPresente = preguntasTotal.length;
   
}
function preguntasPasado(resultado) {
    var preguntasTotal = JSON.parse(resultado);
    numPreguntasTotalPasado = preguntasTotal.length;

}
function preguntasVerbos(resultado) {
    var preguntasTotal = JSON.parse(resultado);
    numPreguntasTotalVerbos = preguntasTotal.length;
}

function preguntasVocabulario(resultado) {
    var preguntasTotal = JSON.parse(resultado);
    numPreguntasTotalVocabulario = preguntasTotal.length;
}
function cargarDatos(resultado) {
    
    datosObtenidos = JSON.parse(resultado);
   var nombre = datosObtenidos.Nombre+" "+datosObtenidos.ApellidoPaterno+" "+datosObtenidos.ApellidoMaterno;
    document.getElementById("txtNombreAlumno").innerHTML = nombre;
}
var avanceps;
function cargarEstadisticas(resultado) {
    var contestadas = JSON.parse(resultado);
    var avancePS = contestadas * 10;
    avanceps = avancePS;
    document.getElementById("txtSimplePresent").innerHTML = "Simple present: " + avancePS + "%";
}
var avancePasado;
function estadisticasPasado(resultado) {
    var contestadas = JSON.parse(resultado);
    var avancePS = contestadas * 10;
    avancePasado = avancePS;
    document.getElementById("txtSimplePast").innerHTML = "Simple past: " + avancePS + "%";
}
var avanceVerbos;
function estadisticasVerbos(resultado) {
    var contestadas = JSON.parse(resultado);
    var avancePS = contestadas * 10;
    avanceVerbos = avancePS;
    document.getElementById("txtVerbs").innerHTML = "Verbs: " + avancePS + "%";
}
var avanceVc;
function estadisticasVocabulario(resultado) {
    var contestadas = JSON.parse(resultado);
    var avancePS = contestadas * 10;
    avanceVc = avancePS;
    document.getElementById("txtVocabulario").innerHTML = "Vocabulary : " + avancePS + "%";

    cargarAvance();
}
function cargarAvance() {
    //debugger;
    var avance = (avanceps + avancePasado + avanceVerbos + avanceVc) / 4;
    document.getElementById("barraPresente").value = avanceps;
    document.getElementById("barraPasado").value = avancePasado;
    document.getElementById("barraVerbo").value = avanceVerbos;
    document.getElementById("barraVocabulario").value = avanceVc;
    
    avance = avance.toFixed(2);
    document.getElementById("txtAvance").innerHTML = "Avance: " + avance + "%";
    document.getElementById("barProgress").value = avance;



}
