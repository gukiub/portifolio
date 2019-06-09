<?php
    $v1 = 3;
    $v2 = 4;
    $v3 = 5;
    $v4 = 12;
    $v5 = 15;
    $v6 = 20;
   
   echo ("valor 1 = ").$v1.("<br>");
   echo ("valor 2 = ").$v2.("<br>");
   echo ("valor 3 = ").$v3.("<br>");
   echo ("valor 4 = ").$v4.("<br>");
   echo ("valor 5 = ").$v5.("<br>");
   echo ("valor 6 = ").$v6.("<br>");
   
    function compar($val1, $val2, $val3){
           
        if($val1 > $val2 && $val1 > $val3){
            echo 'o valor 1 é maior que o 2<br>';
        }        

            elseif ($val2 > $val3 && $val2 > $val1) {
                echo 'o valor 2 é maior que o 3<br>';
                
        }               
            
                else {
                    echo "o valor 3 é maior<br>";
        }
    }

    
$recebe = compar($v1, $v2, $v3);
   echo $recebe; 
   

   
   
      function menor($val4, $val5, $val6){
           
        if($val4 < $val5 && $val4 < $val6){
            echo 'o valor 4 é maior que o 5<br>';
        }        

            elseif ($val5 < $val4 && $val6 < $val5) {
                echo 'o valor 4 é menor que o 5<br>';
                
        }               
 
                else {
                    echo "o valor 6 é maior<br>";
        }
    }

    
$menorr = menor($v4, $v5, $v6);
   echo $menorr; 

?>
