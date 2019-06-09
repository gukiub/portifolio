<html>

<form name="frmCadastro" method="post" action="">
    Email <input type="text" name="email" required>  <br>
    Senha <input type="text" name="senha" required> <br>
    <input type="submit" name="enviar" value="Cadastrar">
</form>

 </html>
 
<?php

if (isset($_POST["enviar"])){
$email = $_POST["email"];
$senha= $_POST["senha"];


    if ($senha == "123" && $email == "batata@gmail.com"){
    
    echo "Logou";
    
    }
   
    
    else{ 
    
    echo "Senha ou E-mail incorretos";
    header ("Location: http://www.google.com");
    
    
    
    }
}






?>
 