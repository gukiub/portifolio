<html>
    <form name="form1" method="POST" action"">
        nome:<input type="password" name="fnome" required><P>
        <input name="benvia" type="submit" value="Enviar"></p>
    </form>
 
</html>

<?php


 if(isset($_POST["benvia"])){
     $vnome=$_POST["fnome"];
     echo "<br>Você pressionou o botão Enviar";
     echo "<br> Enviou o nome: $vnome";
 }
 ?>



