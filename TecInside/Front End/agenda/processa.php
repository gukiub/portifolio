<?php
session_start();
include_once("conexao.php");

$nome = filter_input(INPUT_POST, 'nome', FILTER_SANITIZE_STRING);
$email = filter_input(INPUT_POST, 'email', FILTER_SANITIZE_EMAIL);
$cpf = filter_input(INPUT_POST, 'cpf', FILTER_SANITIZE_NUMBER_INT);
$tel = filter_input(INPUT_POST, 'tel', FILTER_SANITIZE_NUMBER_INT);
$uf = filter_input(INPUT_POST, 'uf', FILTER_SANITIZE_STRING);
$cidade = filter_input(INPUT_POST, 'cidade', FILTER_SANITIZE_STRING);
$senha = filter_input(INPUT_POST, 'senha', FILTER_SANITIZE_NUMBER_INT);
$confirmsenha = filter_input(INPUT_POST, 'confirmsenha', FILTER_SANITIZE_NUMBER_INT); //Eu sei que aqui não é "int"

//echo "Nome: $nome <br>";
//echo "E-mail: $email <br>";

$result_usuario = "INSERT INTO cliente (nome, email,cpf, tel, uf, cidade, senha, confirmsenha, created) VALUES ('$nome', '$email','$cpf','$tel','$uf','$cidade','$senha','$confirmsenha', NOW())";
$resultado_usuario = mysqli_query($conn, $result_usuario);

if(mysqli_insert_id($conn)){
	$_SESSION['msg'] = "<p style='color:green;'>Usuário cadastrado com sucesso</p>";
	header("Location: ../index.html");
}else{
	$_SESSION['msg'] = "<p style='color:red;'>Usuário não foi cadastrado com sucesso</p>";
	header("Location: ../index.html");
}
?>
