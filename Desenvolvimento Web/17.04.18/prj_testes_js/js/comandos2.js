$(document).ready(carregou);

function carregou(){
    console.log("está funfando");
    $("#btn1").click(incluir);
    $("#btn2").click(mudar);
    function incluir(){
        $("#resultado").append("A <b>Uninove</b> é 9<br>");
        
        
    }
    function mudar(){
        $("#resultado").html("A Uninove com vc é 8!");
    }
    
    
    
    
}