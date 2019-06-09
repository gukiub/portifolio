$(document).ready(carregou);

function carregou() {
    console.log("funcionou");
    
    $("#carregar").click(click);
    function click(){
    var nome_digitado = $("#nome").val();
    var idade_digitada = $("#idade").val();
    var area_digitada = $("#area").val();
    var pretensao_digitada = $("#pretensao").val();
    $("#saida").html(" Meu nome é " + nome_digitado + " tenho " + idade_digitada + " anos e estou buscando uma oportunidade na área de " + area_digitada + "." + " <p> Minha pretensão salarial é de " + "R$" + pretensao_digitada + "." + 
                     " <p> Atenciosamente, " + nome_digitado);
    }
    
}