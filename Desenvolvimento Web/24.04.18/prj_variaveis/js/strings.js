$(document).ready(carregou);

function carregou() {
    console.log("carregou a parada");
    
    var frase = "Bom dia!";
    
    $("#resultado1").html(frase);
    
    $("#btn1").click(clicou1)
    function clicou1 () {
        frase = "Boa tarde!";
        $("#resultado1").html(frase);
    }
 
//teste 2 - concatenação de Strings
    var saudacao = "Boa noite";
    var nome = "Gustavo";
    var frase2 = saudacao + ", " + nome + "!";
    $("#btn2").click(clicou2)
    function clicou2 (){
        $("#resultado2").html(frase2);
    }



//Teste 3 - resgatando string de inputs
    $("#btn3").click(clicou3);
    function clicou3(){
    var saudacao_recebida = $("#saudacao").val();
    var nome_recebido = $("#nome").val();
    $("#resultado3").html(saudacao_recebida + " ," + nome_recebido);
    
    
    
}

}