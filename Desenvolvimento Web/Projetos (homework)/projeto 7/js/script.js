$(document).ready(carregou)

function carregou() {
        console.log("carregou")
        
    $("#button").click(calcular);
    function calcular() {
  
        var c = $("#criancas").val();
        var m = $("#mulheres").val();    
        var h = $("#homens").val();
        
        var criancas = 230;
        var mulheres = 450;
        var homens = 340;
      
        c = parseInt(c)|0;
        m = parseInt(m)|0;
        h = parseInt(h)|0;
        
        
        
        var criancas = c * criancas;
        var mulheres = m * mulheres;
        var homens = h * homens;
        
        
    $("#resposta").html("Neste churrasco você precisará de " + criancas + "g" + " de carne para as crianças, de " + mulheres + "g" + " para as mulheres e " + homens + "g" + " para os homens.");
    
    
  
        
        
        
        }
    }