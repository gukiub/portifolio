<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>Untitled Document</title>
</head>
 
<body>
<?php 
//PREENCHA OS DADOS DE CONEXÃO A SEGUIR:
 
$host= 'tecinside2018@gmail.com';
$bd= 'dbTecInside';
$senhabd= 'MeUP@uDeOCuL0s';
$userbd = $bd; 
 
 
// RECEBENDO OS DADOS PREENCHIDOS DO FORMULÁRIO !
$nome	= $_POST ["nome"];	
$email	= $_POST ["email"];	
$tel	= $_POST ["telefone"];	
$endereco	= $_POST ["endereco"];	
$cidade	= $_POST ["cidade"];	
$login	= $_POST ["login"];	
$senha	= $_POST ["senha"];	
$confsenha = $_POST ["conformar senha"];
//Gravando no banco de dados !
 
//conectando com o localhost - mysql
$conexao = mysql_connect($host,$bd, $senhabd);
if (!$conexao)
	die ("Erro de conexão com localhost, o seguinte erro ocorreu -> ".mysql_error());
//conectando com a tabela do banco de dados
$banco = mysql_select_db($bd,$conexao);
if (!$banco)
	die ("Erro de conexão com banco de dados, o seguinte erro ocorreu -> ".mysql_error());
 
 
 
$query = "INSERT INTO `clientes` ( default, `nome` , `email`, `telefone`, `cidade`, `login` , `senha`, `id` , `confsenha` ) 
VALUES ( default, '$nome', '$email', '$tel', '$endereco', '$cidade', '$login', '$senha', '$confsenha')";
 
mysql_query($query,$conexao);
 
echo "Seu cadastro foi realizado com sucesso!<br>Agradecemos a atenção.";
?> 
</body>
</html>