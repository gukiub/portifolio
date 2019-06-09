<?php
include_once 'dbconfig.php';

if(isset($_POST['btn-deletar'])){
	$id = $_GET['deletar_id'];
	$crud->delete($id);
	header("Location: deletar.php?deletado");
}
?>

<?php include_once 'header.php'; ?>

<div class="clearfix"></div>

<div class="container">
	<?php if(isset($_GET['deletado'])){ ?>
		<div class='alert alert-success'>
		<strong>Uau!</strong> Contato removido com sucesso <a href='index.php' class="text-error">HOME</a>!
		</div>
	<?php } else { ?>
		<div class='alert alert-danger'>
		<strong>Certo!</strong> Deseja remover o contato?
		</div>
	<?php }	?>
</div>

<div class="clearfix"></div>

<div class="container">
 	
	 <?php
	 if(isset($_GET['deletar_id']))
	 {
		 ?>
         <table class='table table-bordered'>
         <tr>
         <th>#</th>
         <th>Nome</th>
         <th>Número</th>
         <th>Email</th>
         </tr>
         <?php
         $stmt = $db_con->prepare("SELECT * FROM contatos WHERE id=:id");
         $stmt->execute(array(":id"=>$_GET['deletar_id']));
         while($row=$stmt->fetch(PDO::FETCH_BOTH))
         {
             ?>
             <tr>
             <td><?php print($row['id']); ?></td>
             <td><?php print($row['nome']); ?></td>
             <td><?php print($row['telefone']); ?></td>
             <td><?php print($row['email']); ?></td>
             </tr>
             <?php
         }
         ?>
         </table>
         <?php
	 }
	 ?>
</div>

<div class="container">
<p>
<?php
if(isset($_GET['deletar_id']))
{
	?>
  	<form method="post">
        <input type="hidden" name="id" value="<?php echo $row['id']; ?>" />
        <button class="btn btn-primary" type="submit" name="btn-deletar"><i class="fa fa-trash"></i> &nbsp; Sim</button>
        <a href="index.php" class="btn btn-primary btn-success"><i class="fa fa-angle-double-left"></i> &nbsp; Não</a>
    </form>  
	<?php
}
else
{
	?>
    <a href="index.php" class="btn btn-primary btn-success"><i class="fa fa-angle-double-left"></i> &nbsp; Voltar</a>
    <?php
}
?>
</p>
</div>