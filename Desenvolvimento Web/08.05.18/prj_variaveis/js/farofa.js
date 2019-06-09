$(document).ready(carregou)

    function carregou() {
        console.log("carregou")
        
    $("#calcular_btn").click(CalcularOnClick);
    function CalcularOnClick() {
    var p = $("#pessoas").val();
        p = parseInt(p);
        
        
    var total_frango = p * 430; 
    var total_farofa = p * 1500;
    
    $(".resultado").html(" nesta viagem você precisa comprar " + total_frango + " gramas de frango e " + total_farofa + " gramas de farofa. ");
        
        
        
        }
    }