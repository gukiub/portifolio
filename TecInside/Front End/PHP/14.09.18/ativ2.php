<?php
   $nota1 = 6;
   $nota2 = 5;
   $nota3 = 4;
   $nota4 = 5;
   $media = ($nota1 + $nota2)/2;
   $media2 = ($nota3 + $nota4)/2;
   $mediafinal = ($nota1 + $nota2 + $nota3 + $nota4)/4;
   echo "Média final = ".$mediafinal;
   echo "<br>Média (av1) = ".$media;
   echo "<br>Média (av2) = ".$media2;
   
   if ($mediafinal < 6) {
    echo "<br> nota baixa";
}
    elseif ($mediafinal >= 6 && $mediafinal <= 8)  {
        echo "<br>nota media";
}
    else{
        echo "<br>nota alta";
    }
    
    if ($mediafinal >= 6){
        echo "<br>aprovado";
    }
    
    else{
        echo "<br>reprovado";
    }
?>      