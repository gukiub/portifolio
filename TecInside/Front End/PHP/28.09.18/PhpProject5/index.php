<html>

    <form name="frmCadastro" method="post" action="">
        Numero1 <input type="number" name="Num1" required>  <br>
        Numero2 <input type="number" name="num2" required> <br>
        Numero3 <input type="number" name="num3" required> <br>
        Numero3 <input type="number" name="num4" required> <br>
        <input type="submit" name="enviar" value="Cadastrar">
    </form>

</html>

<?php
if (isset($_POST["enviar"])) {

    $numero1 = $_POST["Num1"];
    $numero2 = $_POST["num2"];
    $numero3 = $_POST["num3"];
    $numero4 = $_POST["num4"];
    
  
  $media1 = ($_POST["Num1"]+$_POST["num2"]) / 2;
  $media2 = ($_POST["num3"]+ $_POST["num4"]) / 2;
  $mediaFinal = ($_POST["Num1"] + $_POST["num2"]+ $_POST["num3"] + $_POST["num4"]) / 4;
  
  number_format($mediaFinal, 2 );
  number_format($media2, 2);
  number_format($media2, 2);
  
    echo $media1 . " = Média N1 <br>";
    echo $media2 . " = Média N2 <br>";
    echo $mediaFinal . " = Média Final <br>";
    
    
    function notas ($par1) {
        
        if ($par1 < 6 ) {
            
            $resultado = " <br> Você foi Reprovado";
            
        }
        elseif ($par1 >6 && $par1 < 8  ) {
            
            $resultado = " <br> Você foi Aprovado, porém sua nota é média";
            
        }

        elseif ($par1 >6 && $par1 < 8  ) {
            
            $resultado = " <br> Você foi Aprovado com uma ótima nota, parabéns!";
            
        }        
        
        
         return $resultado;
        
        
    }
  
    
    $Notas = notas ($mediaFinal);
    echo $Notas;
   
        ?>
      