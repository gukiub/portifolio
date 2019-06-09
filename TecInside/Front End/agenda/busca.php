<?php
include_once 'admin/dbconfig.php';
include_once 'header.php';

$nome=$_POST["filtro"];
$pesquisa=$_POST['buscar'];

if(isset($pesquisa)&&!empty($nome))
{
	$stmt = $db_con->prepare("select * from contatos where nome like :letra");
	$stmt->bindValue(':letra', '%'.$nome.'%', PDO::PARAM_STR);
	$stmt->execute();
	$resultados = $stmt->rowCount();

  	if($resultados>=1){
  		echo '<div class="container">';
	  	echo "Resultado(s) encontrado(s): ".$resultados."<br /><br />";
	  	while($reg = $stmt->fetch(PDO::FETCH_OBJ))
	   {
	   		$teste = $reg->telefone;
	   		$tel = $crud->mascara_string("(##) ####-####",$teste);

	    	echo '<strong>Nome: </strong>' . $reg->nome." - ";
	    	echo '<strong>telefone: </strong>' . $tel ." - ";
	    	echo '<strong>Email: </strong>' . $reg->email."<br />";
	    	
	   }

	   echo '<hr><a href="./" class="btn btn-primary btn-info">Voltar</a>';
	   echo '</div>';
	}else{
		echo '<div class="container">';
		echo '<hr><div class="alert alert-warning">Não existe dados cadastrados na agenda</div>';
		echo '<hr><a href="./" class="btn btn-primary btn-info">Voltar</a>';
		echo '</div></div>';
	}
}else{
	echo '<div class="container">';
	echo "Preencha o campo de pesquisa";
	echo '</div>';
}
?>