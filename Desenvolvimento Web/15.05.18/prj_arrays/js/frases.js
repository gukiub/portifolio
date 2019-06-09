$(document).ready(carregou);

function carregou() {
    console.log("carregou tutu");
    var lista1 = ["Zé", "Jusé", "Maria", "Gustavo", "Lucas", "Diana", "Pedro"];
    var lista2 = ["Batata", "Picanha", "Pão de queijo", "lasanha", "hotdog", "maionese"];
    var lista3 = ["Pula", "Dorme", "Bebe", "corre", "anda", "chuta um balde"];
    
    $("#btn").click(btnOnClick);
    
    function btnOnClick() {
        var tamanho_array = lista1.length;
        var tamanho_array = lista2.length;
        var tamanho_array = lista3.length;

        var i = Math.random() * (tamanho_array - 1);
        var i2 = Math.random() * (tamanho_array - 1);
        var i3 = Math.random() * (tamanho_array - 1);
        
        i = Math.round(i);
        i2 = Math.round(i2);
        i3 = Math.round(i3);
        
        
        $("#resultado").html(lista1[i] + " gosta de comer " + lista2[i2] + " enquanto " + lista3[i3]);
        
        
        
    }
    
}