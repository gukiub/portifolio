<html>

    <form name="frmCadastro" method="post" action="">
        Numero1 <input type="number" name="Num1" required>  <br>
        Numero2 <input type="number" name="num2" required> <br>
        Numero3 <input type="number" name="num3" required> <br>
        <input type="submit" name="enviar" value="Cadastrar">
    </form>

</html>

<?php
if (isset($_POST["enviar"])) {


    $numero1 = $_POST["Num1"];
    $numero2 = $_POST["num2"];
    $numero3 = $_POST["num3"];

    function Maior($par1, $par2, $par3) {

        if ($par3 > $par2 && $par3 > $par1) {


            $res = "O Maior Valor é: " . $par3;
        } elseif ($par2 > $par1 && $par2 > $par3) {

            $res = "O Maior Valor é: " . $par2;
        } else {
            $res = "O Maior Valor é: " . $par1;
        }

        return $res;
    }

    $aparecer = Maior($numero1, $numero2, $numero3);
    echo $aparecer;
}



if (isset($_POST["enviar"])) {


    $numero1 = $_POST["Num1"];
    $numero2 = $_POST["num2"];
    $numero3 = $_POST["num3"];

  function Menor ($par1, $par2, $par3) {
      
     if ( $par3 < $par2 && $par3 < $par1) {
         
         
         $res="'<br>'O Menor Valor é: " . $par3;
         
     }
         
        
     elseif ( $par2 < $par1 && $par2 < $par3){
         
         $res="'<br>'O Menor Valor é: " . $par2;
         
         }
         
       else {
             $res="<br>O Menor Valor é: " . $par1;
           
       }  
            
     return $res;
      
  }
  
  $Menor = Menor($numero1, $numero2, $numero3);
  echo $Menor;
  
}
        ?>