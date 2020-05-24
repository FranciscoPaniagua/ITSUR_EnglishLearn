/*JavaScript para la ventana de Quiz*/
var usuario;
/*Realiza la llamada hacía la base de datos mediante el web service para obtener la lista de preguntas almacenadas en la base de datos
El valor del usuario activo es obtenido desde el elemento html de la página maestra
*/
$(document).ready(function () {
    IEL.Servicios.wsQuiz.getAllPreguntas(cargarPrimera);    
    usuario = $('#logear').text();    
});



var listaObtenida;
var numeroPregunta = 0;
var correctas = 0;
var seguir = false;
/*Se ejecuta al llamarse el método del web service exitosamente, mezcla las preguntas en un orden aleatorio y carga la primer pregunta, además de las opciones de respuesta.
Inicia los colores iniciales en los rectangulos correspondientes a cada pregunta.
Se encarga de incrementar la variable que lleva el control de las posiciones en las preguntas.
*/
function cargarPrimera(resultado) {    
    listaObtenida = JSON.parse(resultado);
    listaObtenida = mezclar(listaObtenida);
    var primera = listaObtenida[numeroPregunta];
    document.getElementById("textopregunta").innerHTML = primera.pregunta;
    document.getElementById("answerA").innerHTML = primera.RespuestaCorrecta;
    document.getElementById("answerB").innerHTML = primera.RespuestaIncorrecta1;
    document.getElementById("answerC").innerHTML = primera.RespuestaIncorrecta2;
    document.getElementById("answerD").innerHTML = primera.RespuestaIncorrecta3;

    document.getElementById("color1").style.backgroundColor = "#6666CC";
    document.getElementById("color2").style.backgroundColor = "#9999FF";
    document.getElementById("color3").style.backgroundColor = "#9999FF";
    document.getElementById("color4").style.backgroundColor = "#9999FF";
    document.getElementById("color5").style.backgroundColor = "#9999FF";
    document.getElementById("color6").style.backgroundColor = "#9999FF";
    document.getElementById("color7").style.backgroundColor = "#9999FF";
    document.getElementById("color8").style.backgroundColor = "#9999FF";
    document.getElementById("color9").style.backgroundColor = "#9999FF";
    document.getElementById("color10").style.backgroundColor = "#9999FF";
    numeroPregunta = numeroPregunta + 1;    
}
/*
Función que se encarga de cambiar la siguiente pregunta, mezcla las opciones de respuesta cada vez que se ejecuta.
Cambia el color del rectangulo correspondiente a la pregunta actual.
Habilita los botones de opción de respuesta para que el usuario pueda seleccionar.
Cambia el color del texto de las opciones de respuesta para que el usuario pueda elegir.
En caso de ejecutarse ésta función cuando aún no se ha seleccionado una respuesta, manda un mensaje de alerta
*/
function cambiar() {
    if (seguir) {
        if (numeroPregunta > 9) {
            numeroPregunta = 0;
            alert("Obtuviste: " + correctas + " correctas");
        }
        var letras = ['A', 'B', 'C', 'D'];
        letras = mezclar(letras);
        var pregunta = listaObtenida[numeroPregunta];
        document.getElementById("textopregunta").innerHTML = pregunta.pregunta;
        document.getElementById("answer" + letras[0]).innerHTML = pregunta.RespuestaCorrecta;
        document.getElementById("answer" + letras[1]).innerHTML = pregunta.RespuestaIncorrecta1;
        document.getElementById("answer" + letras[2]).innerHTML = pregunta.RespuestaIncorrecta2;
        document.getElementById("answer" + letras[3]).innerHTML = pregunta.RespuestaIncorrecta3;

        document.getElementById("color" + (numeroPregunta + 1).toString()).style.backgroundColor = "#6666CC";
        numeroPregunta = numeroPregunta + 1;

        document.getElementById("answerA").disabled = false;
        document.getElementById("answerB").disabled = false;
        document.getElementById("answerC").disabled = false;
        document.getElementById("answerD").disabled = false;

        document.getElementById("answerA").style.color = "#CC33CC";
        document.getElementById("answerB").style.color = "#CC33CC";
        document.getElementById("answerC").style.color = "#CC33CC";
        document.getElementById("answerD").style.color = "#CC33CC";
        seguir = false;
    } else {
        alert("Debes elegir una respuesta para continuar");
    }
}
/*
Funcion que realiza la inserción de la respuesta del usuario, de ser correcta inserta Correcto en la base de datos, de ser incorrecta inserta Incorrecto.
Cambia el color del texto de la opción elegida por el usuario.
Una vez que se ejecuta, deshabilita las opciones de respuesta para que el usuario no pueda seleccionar más de una opción.
*/
function respuestaUsuario(boton) {    
    
    seguir = true;
    var actual = listaObtenida[numeroPregunta-1];
    var id=actual.idPregunta;
    var correcto;    
    if (boton.innerHTML.toString().localeCompare(actual.RespuestaCorrecta)==0) {
        correcto = "Correcto";
        correctas = correctas + 1;
    }else{
        correcto="Incorrecto";
    }

    var idbtn = boton.id;    
    document.getElementById(idbtn).style.color = "#6666CC";
    IEL.Servicios.wsQuiz.insertPregunta(usuario,id,correcto,deshabilitar);
}
/*Función que deshabilita las opciones de respuesta*/
function deshabilitar() {
    document.getElementById("answerA").disabled = true;
    document.getElementById("answerB").disabled = true;
    document.getElementById("answerC").disabled = true;
    document.getElementById("answerD").disabled = true;
}
/*Función que mezcla los elementos de un arreglo en posiciones aleatorias.*/
function mezclar(arreglo) {
    var currentIndex = arreglo.length, temporaryValue, randomIndex;

    while (0!==currentIndex) {
        randomIndex = Math.floor(Math.random() * currentIndex);
        currentIndex -= 1;

        temporaryValue = arreglo[currentIndex];
        arreglo[currentIndex] = arreglo[randomIndex];
        arreglo[randomIndex] = temporaryValue;
    }
    return arreglo;
}