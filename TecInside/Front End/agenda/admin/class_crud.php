<?php

class crud
{
	private $db;

	function __construct($db_con){
		$this->db = $db_con;
	}

	// função para adicionar contatos
	public function create($nome, $telefone, $email){
		try{
			$stmt = $this->db->prepare("INSERT INTO contatos (nome, telefone,email) VALUES(:nome,:telefone,:email)");
			$stmt->bindparam(":nome",$nome);
			$stmt->bindparam(":telefone",$telefone);
			$stmt->bindparam(":email",$email);

			$stmt->execute();
			return true;

		}catch(PDOException $e){
			echo $e->getMessage();
			return false;
		}
	}

	//função que pega id da tabela contatos
	public function getID($id){
		$stmt = $this->db->prepare("SELECT * FROM contatos WHERE id=:id");
		$stmt->execute(array(":id"=>$id));
		$editarLinha=$stmt->fetch(PDO::FETCH_ASSOC);

		return $editarLinha;
	}

	//função para atulizador contatos
	public function update($id,$nome,$telefone,$email){
		try{
			$stmt = $this->db->prepare("UPDATE contatos SET nome=:nome, telefone=:telefone, email=:email WHERE id=:id");
			$stmt->bindparam(":nome",$nome);
			$stmt->bindparam(":telefone",$telefone);
			$stmt->bindparam(":email",$email);
			$stmt->bindparam(":id", $id);
			$stmt->execute();

			return true;

		}catch(PDOException $e){
			echo $e->getMessage();
			return false;
		}
	}

	//função deletar contatos
	public function delete($id){
		$stmt = $this->db->prepare("DELETE FROM contatos WHERE id=:id");
		$stmt->bindparam(":id",$id);
		$stmt->execute();
		return true;
	}

	
	// função para criação de mascaras para representação de dados
	public function mascara_string($mascara,$string)
		{
		   $string = str_replace(" ","",$string);
		   for($i=0;$i<strlen($string);$i++)
		   {
		      $mascara[strpos($mascara,"#")] = $string[$i];
		   }
		   return $mascara;
		}

	// função para visualizar dados
	public function viewDados($query)
	{
		$stmt = $this->db->prepare($query);
		$stmt->execute();
	
		if($stmt->rowCount()>0)
		{
			while($row=$stmt->fetch(PDO::FETCH_ASSOC))
			{
				?>
<tr>
    <td>
        <?php print($row['id']); ?>
    </td>
    <td>
        <?php print($row['nome']); ?>
    </td>
    <td>
        <?php $tel = $row['telefone']; print($this->mascara_string("(##) ####-####",$tel)); ?>
    </td>
    <td><a href="mailto:<?php print($row['email']); ?>">
            <?php print($row['email']); ?></a></td>
</tr>
<?php
			}
		}
		else
		{
			?>
<tr>
    <td colspan="4"><span class="text-error">Nenhum contato cadastrado...</span></td>
</tr>
<?php
		}
		
	}

	// função para visualizar dados com botão editar e excluir
	public function viewEditar($query)
	{
		$stmt = $this->db->prepare($query);
		$stmt->execute();
	
		if($stmt->rowCount()>0)
		{
			while($row=$stmt->fetch(PDO::FETCH_ASSOC))
			{
				?>
<tr>
    <td>
        <?php print($row['id']); ?>
    </td>
    <td>
        <?php print($row['nome']); ?>
    </td>
    <td>
        <?php print($row['telefone']); ?>
    </td>
    <td>
        <?php print($row['email']); ?>
    </td>
    <td style="text-align:center">
        <a href="editar.php?editar_id=<?php print($row['id']); ?>" data-toggle="tooltip" data-placement="top" title="Editar"><i class="fa fa-pencil-square-o"></i></a>
    </td>
    <td style="text-align:center">
        <a href="deletar.php?deletar_id=<?php print($row['id']); ?>" data-toggle="tooltip" data-placement="top" title="Excluir"><i class="fa fa-trash"></i></a>
    </td>
</tr>
<?php
			}
		}
		else
		{
			?>
<tr>
    <td colspan="4"><span class="text-error">Nenhum contato cadastrado...</span></td>
</tr>
<?php
		}
		
	}
	
	public function paging($query,$registro_por_pagina)
	{
		$starting_position=0;
		if(isset($_GET["page_no"]))
		{
			$starting_position=($_GET["page_no"]-1)*$registro_por_pagina;
		}
		$query2=$query." limit $starting_position,$registro_por_pagina";
		return $query2;
	}
	
	public function paginglink($query,$registro_por_pagina)
	{
		
		$self = $_SERVER['PHP_SELF'];
		
		$stmt = $this->db->prepare($query);
		$stmt->execute();
		
		$total_no_of_records = $stmt->rowCount();
		
		if($total_no_of_records > 0)
		{
			?>
<ul>
    <?php
			$total_no_of_pages=ceil($total_no_of_records/$registro_por_pagina);
			$current_page=1;
			if(isset($_GET["page_no"]))
			{
				$current_page=$_GET["page_no"];
			}
			if($current_page!=1)
			{
				$previous =$current_page-1;
				echo "<li><a href='".$self."?page_no=1'>Primeiro</a></li>";
				echo "<li><a href='".$self."?page_no=".$previous."'>Anterior</a></li>";
			}
			for($i=1;$i<=$total_no_of_pages;$i++)
			{
				if($i==$current_page)
				{
					echo "<li><a href='".$self."?page_no=".$i."' style='color:rgb(0,85,128);'>".$i."</a></li>";
				}
				else
				{
					echo "<li><a href='".$self."?page_no=".$i."'>".$i."</a></li>";
				}
			}
			if($current_page!=$total_no_of_pages)
			{
				$next=$current_page+1;
				echo "<li><a href='".$self."?page_no=".$next."'>Avançar</a></li>";
				echo "<li><a href='".$self."?page_no=".$total_no_of_pages."'>Último</a></li>";
			}
			?>
</ul>
<?php
		}
	}
	
	/* paging */
	/*visualização dos dados*/
}
