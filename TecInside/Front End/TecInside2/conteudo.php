<?php
     include "conexao.php";
     $sql=mysqli_query($conecta, "Select * from tblusuario order by nome_tblusuario");
?>
<!DOCTYPE HTML>
<html>
     <head>
          <meta charset="utf-8">
          <title>Listagem de conteúdo</title>
          <link href="css/style.css" rel="stylesheet" />
     </head>
     <body>
          <div id="conteudo">
               <h1>Listagem de conteúdo</h1>
               <div class="borda"></div>
               <p>Selecione um usuário para atualizar seus dados ou para excluí-lo!</p>
               <div class="dheader">Nome</div>
               <div class="dheader">Email</div>
               <div class="dheader">Ação</div>
               <div class="clear"></div>
               <?php
                    while ($result=mysqli_fetch_array($sql)){
               ?>
                         <div class="content"><?php echo $result['nome_tblusuario']; ?></div>
                         <div class="content"><?php echo $result['email_tblusuario']; ?></div>
                         <div class="content last1"><a href="fupdate.php?id=<?php echo $result['id_tblusuario']; ?>">Atualizar</a></div>
                         <div class="content last1"><a href="excluir.php?id=<?php echo $result['id_tblusuario']; ?>">Excluir</a></div>
                         <div class="clear"></div>
               <?php } ?>
          </div>
     </body>
</html>