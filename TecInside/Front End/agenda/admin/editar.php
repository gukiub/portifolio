<?php
include_once 'dbconfig.php';

if(isset($_POST['btn-atualizar'])){
	$id = $_GET['editar_id'];
	$nome = $_POST['nome'];
	$telefone = $_POST['telefone'];
	$email = $_POST['email'];

	if($crud->update($id,$nome,$telefone,$email)){
		$msg = "<div class='alert alert-success'>
				<strong>Uau!</strong> Registro atualizado com sucesso <a href='index.php'>HOME</a>!
				</div>";
	}else	{
		$msg = "<div class='alert alert-warning'>
				<strong>Desculpa!</strong> ERRO ao atualizar registro !
				</div>";
	}
}

if(isset($_GET['editar_id'])){
	$id = $_GET['editar_id'];
	extract($crud->getID($id));
}
?>

<?php include_once 'header.php'; ?>


<div class="clearfix"></div>

<div class="container">
	<?php
		if(isset($msg)){
			echo $msg;
		}
	?>
</div>

<div class="clearfix"></div><br>

<div class="container">
	 
     <form method='post'>
		    <table class='table table-bordered'>
		    	<div class="alert alert-info"><i class="fa fa-pencil-square-o"></i> Editar contato</div>
		        <tr>
		            <td>Nome</td>
		            <td><input type='text' name='nome' class='form-control' value="<?php echo $nome; ?>" required maxlength="30"></td>
		        </tr>
		 
		        <tr>
		            <td>Telefone</td>
		            <td><input type='text' name='telefone' class='form-control' value="<?php echo $telefone; ?>"  maxlength="10 "pattern="[0-9]{10}"></td>
		        </tr>
		 
		        <tr>
		            <td>Email</td>
		            <td><input type='email' name='email' class='form-control' value="<?php echo $email; ?>" required maxlength="30"></td>
		        </tr>
		 
		        <tr>
		            <td colspan="2">
		                <button type="submit" class="btn btn-primary btn-info" name="btn-atualizar">
		                	Atualizar registro
						</button>
		                <a href="index.php" class="btn btn-primary btn-success"><i class="fa fa-angle-double-left"></i> &nbsp; Voltar</a>
		            </td>
		        </tr>
		 
		    </table>
		</form>
</div>
<?php include_once '../footer.php'; ?>