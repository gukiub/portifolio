
<?php session_start(); ?>
<meta charset="UTF-8">
<font face="arial" color="black" size="4">
<script type="text/javascript">
    function loginsuccess() {
        setTimeout("window.location='painel.php'", 3000);
    }
    function loginfailed() {
        setTimeout("window.location='login.php'", 3000);
    }
</script>
<?php
$servidor = "localhost";
$usuario = "root";
$senha = "";
$banco = "test";
$conecta = mysqli_connect($servidor, $usuario, $senha) or print (mysqli_error());
mysqli_select_db($conecta, $banco) or print(mysqli_error($conecta));
$vemail = $_POST["Cadastroemail"];
$vpass = $_POST["CadastroSenha"];
$vnome = $_POST["CadastroNome"];


$sql = "INSERT INTO user_regs (user_name, user_email, user_pass) VALUES ('$vnome', '$vemail', aes_encrypt('$vpass', 'uni9'))";



$resulta = mysqli_query($conecta, $sql) ;
$row = mysqli_affected_rows($conecta);

if ($row > 0) {
    {
        echo '<center>Você foi Cadastrado com sucesso! Aguarde um instante ...</center>';
            header ("location:login.php");
    }
   
} Else {
    echo '<center>Seu cadastro foi recusado ...</center>';
   
}
mysqli_close($conecta);
?>
</font>
</meta>


