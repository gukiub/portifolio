$(document).ready(carregou)

function carregou() {
    console.log("carregou sa merda")
    
    $("#somar_btn").click(SomarOnClick);


    function SomarOnClick() {
        var numero1 = $("#n1").val();
        var numero2 = $("#n2").val();
        
        numero1 = parseFloat(numero1)
        numero2 = parseFloat(numero2)
        
        var total = numero1 + numero2;
        $(".resultado").html(total);
            }
    
    
        $("#subtrair_btn").click(SubtrairOnClick);


    function SubtrairOnClick() {
        var numero1 = $("#n1").val();
        var numero2 = $("#n2").val();
        
        numero1 = parseFloat(numero1)
        numero2 = parseFloat(numero2)
        
        var total = numero1 - numero2;
        $(".resultado").html(total);
            }
    
    $("#multiplicar_btn").click(MultiplicarOnClick);
    
    
    function MultiplicarOnClick() {
        var numero1 = $("#n1").val();
        var numero2 = $("#n2").val();
        
        numero1 = parseFloat(numero1)
        numero2 = parseFloat(numero2)
        
        var total = numero1 * numero2;
        $(".resultado").html(total);
    
        }
     
    
    $("#dividir_btn").click(dividirOnClick);
    
    
    function dividirOnClick() {
        var numero1 = $("#n1").val();
        var numero2 = $("#n2").val();
        
        numero1 = parseFloat(numero1)
        numero2 = parseFloat(numero2)
        
        var total = numero1 / numero2;
        $(".resultado").html(total);
    
        }
    
}
