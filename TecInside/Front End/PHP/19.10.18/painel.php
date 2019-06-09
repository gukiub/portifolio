
<?php
session_start();
if(isset($_SESSION["usercod"])){
echo "<left>Você está logado ! <a href='logout.php'>Sair</a></left>"; }
else {
header("Location: login.php");
exit; }
?>
