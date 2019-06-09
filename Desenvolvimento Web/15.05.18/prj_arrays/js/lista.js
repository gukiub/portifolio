$(document).ready(carregou);

function carregou() {
    console.log("carregou tutu");
    var lista = [ "arroz", "feijuão", "batatão", "cebola", "pinga", "limão", "pitu"];
    
    
    $("#btn").click(btnOnClick);
    
    function btnOnClick() {
//  lenght retorna o tamanho de uma array      
        var tamanho_array = lista.length;
 // Math.random() sorteia números entre 0 e 1
        var i = Math.random() * (tamanho_array - 1);
//  i = Math.round() arredonda numeros
        i = Math.round(i);
        console.log(i);
        
        $("#resultado").html("Fui no mercado comprar " + lista[i]);
     
                
    }
}