var gramatica;
var verbos;
var sujetos;
var pregunta="";
var correcta=0;
var contador=0;
var contestada=0;
var puntaje=0;
var tema = 1;
var usuario = "ruiz";
/*
Obtiene los temas, los verbos y los sujetos en el sistema.
*/
$(document).ready(function () {
    tema=1;
    IEL.Servicios.wsGramatica.getByTema(tema, exito);
    IEL.Servicios.wsVerbo.getAll(exitoVerbos);
    IEL.Servicios.wsSujeto.getAll(exitoSujetos);    
});

/*
Inicializa la gramática en una posición aleatoria.
*/
function exito(resultado) {
    //Math.random()
    var gramaticas=JSON.parse(resultado);
    var nu=Math.floor(Math.random() * (gramaticas.length));
    //alert(nu);
    if(nu<0&&nu>=gramaticas.length){
        nu=0;
    }
    gramatica=gramaticas[nu];
    //alert(gramatica.Formula);    
}
/*
Estructura la pregunta de acuerdo a los verbos, sujetos y los temas.
*/
function armar(){
    var arr=gramatica.Formula.split("_");
    var nui=Math.floor(Math.random() * (sujetos.length));
    var lugar=1;
    for(var i=0; i<arr.length; i=i+1){
        switch (arr[i]) {
            case "sujeto":            
                pregunta+=sujetos[nui].sujeto+" ";
                break;
            case "tobe":
                if(lugar==1){
                    var insiso=Math.floor(Math.random() * 3);
                    pregunta+=" _____ ";
                    if(insiso==0){
                        correcta=1;
                        document.getElementById("respuestaA").innerHTML =sujetos[nui].ser;
                        if(sujetos[nui].ser=="am"){
                            document.getElementById("respuestaB").innerHTML ="are";
                            document.getElementById("respuestaC").innerHTML ="is";
                        }else if(sujetos[nui].ser=="are"){
                            document.getElementById("respuestaB").innerHTML ="is";
                            document.getElementById("respuestaC").innerHTML ="am";
                        }else if(sujetos[nui].ser=="is"){
                            document.getElementById("respuestaB").innerHTML ="am";
                            document.getElementById("respuestaC").innerHTML ="are";
                        }
                    }else if(insiso==1){
                        correcta=2;
                        document.getElementById("respuestaB").innerHTML =sujetos[nui].ser;
                        if(sujetos[nui].ser=="am"){
                            document.getElementById("respuestaA").innerHTML ="are";
                            document.getElementById("respuestaC").innerHTML ="is";
                        }else if(sujetos[nui].ser=="are"){
                            document.getElementById("respuestaA").innerHTML ="is";
                            document.getElementById("respuestaC").innerHTML ="am";
                        }else if(sujetos[nui].ser=="is"){
                            document.getElementById("respuestaA").innerHTML ="am";
                            document.getElementById("respuestaC").innerHTML ="are";
                        }
                    }else if(insiso==2){
                        correcta=3;
                        document.getElementById("respuestaC").innerHTML =sujetos[nui].ser;
                        if(sujetos[nui].ser=="am"){
                            document.getElementById("respuestaB").innerHTML ="are";
                            document.getElementById("respuestaA").innerHTML ="is";
                        }else if(sujetos[nui].ser=="are"){
                            document.getElementById("respuestaB").innerHTML ="is";
                            document.getElementById("respuestaA").innerHTML ="am";
                        }else if(sujetos[nui].ser=="is"){
                            document.getElementById("respuestaB").innerHTML ="am";
                            document.getElementById("respuestaA").innerHTML ="are";
                        }
                    }
                }
                break;
            case "verbopresentesimple":
                pregunta+=verbos[Math.floor(Math.random() * verbos.length)].VerboPresenteSimple;
                break;
            case "complemento":
                pregunta+=" in the school ";
                break;
            case "not":
                pregunta+=" not ";
                break;
            default:
                break;
        }
    }
    //alert(pregunta);
    document.getElementById("pregunta").innerHTML =pregunta;
}
/*
Carga los verbos en el sistema.
*/
function exitoVerbos(resultad){
    verbos=JSON.parse(resultad)
    //alert(resultad);
}
/*
Carga los sujetos en el sistema.
*/
function exitoSujetos(res){
    sujetos=JSON.parse(res);
    //alert(res);
    armar();
}
/*
Carga los estilos para el radio button en el inciso A
*/
function rdbA(boton){
    document.getElementById("respuestaA").style.background="#0000f4";
    document.getElementById("respuestaB").style.background="";
    document.getElementById("respuestaC").style.background="";
    contestada=1;
}
/*
Carga los estilos para el radio button en el inciso B
*/
function rdbB(boton){
    document.getElementById("respuestaA").style.background="";
    document.getElementById("respuestaB").style.background="#0000f4";
    document.getElementById("respuestaC").style.background="";
    contestada=2;
}
/*
Carga los estilos para el radio button en el inciso C
*/
function rdbC(boton){
    document.getElementById("respuestaA").style.background="";
    document.getElementById("respuestaB").style.background="";
    document.getElementById("respuestaC").style.background="#0000f4";
    contestada=3;
}
/*
Carga la siguiente pregunta en el área de práctica.
*/
function siguiente(boton){
    //Checa respuesta coorecta
    if(contestada===correcta){
        puntaje=puntaje+1;
    }
    if(contador<10){
        pregunta="";
        correcta=0;
        contestada=0;

        armar();
        document.getElementById("respuestaA").style.background="";
        document.getElementById("respuestaB").style.background="";
        document.getElementById("respuestaC").style.background="";
        contador+=1;
    }else if(contador===10){
        alert("Tu puntuacion es de "+puntaje+"/10");
        IEL.Servicios.wsPractica.insert(0,puntaje,tema,usuario,suc);
    }
}
/*
Alerta al usuario del fin de la práctica en caso de que haya contestado las demás preguntas.
*/
function suc(par) {
    if(par==true){
        alert("fin");
    }
}