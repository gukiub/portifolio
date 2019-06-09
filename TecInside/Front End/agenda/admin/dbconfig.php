<?php

/* Define o limite de tempo da sessão em 60 minutos */
session_cache_expire(60);

// Inicia a sessão
session_start();

// Variável que verifica se o usuário está logado
if ( ! isset( $_SESSION['logado'] ) ) {
    $_SESSION['logado'] = false;
}

// Erro do login
$_SESSION['login_erro'] = false;

//variaveis de conecxão
$db_host = "localhost";
$db_base = "dbtecinside";
$db_user = "root";
$db_pass = "root";
$db_charset  = 'UTF8';
$conexao_pdo = null;

// Concatenação das variáveis para detalhes da classe PDO
$detalhes_pdo  = 'mysql:host=' . $db_host . ';';
$detalhes_pdo .= 'dbname='. $db_base . ';';
$detalhes_pdo .= 'charset=' . $db_charset . ';';

try{
	$db_con = new PDO($detalhes_pdo, $db_user, $db_pass);
	$db_con->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
}
catch(PDOException $e){
	echo $e->getMessage();
}

include_once 'class_crud.php';

$crud = new crud($db_con);
