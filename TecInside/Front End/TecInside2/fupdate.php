<?php
     include "conexao.php";
 
     $recebeId = $_GET['id'];
     $filtraId = filter_var($recebeId,FILTER_SANITIZE_SPECIAL_CHARS);
     $filtraId = filter_var($filtraId, FILTER_SANITIZE_MAGIC_QUOTES);
 
     $sql=mysqli_query($conecta, "Select * from tblusuario where id_tblusuario = $filtraId ");
?>
<!DOCTYPE HTML>
<html>
     <head>
          <meta charset="utf-8">
          <title>Sistema de cadastro</title>
          <link href="css/style.css" rel="stylesheet" />
     </head>
     <body>
          <div id="conteudo">
               <h1>Atualização de dados cadastrais do usuário</h1>
               <div class="borda"></div>
               <form method="post" action="cadastrousuario.php" id="validaAcesso">
                    <fieldset>
                         <?php
                              while ($result=mysqli_fetch_assoc($sql)){
                         ?>
                                   <legend>Dados cadastrais</legend>
                                   <input type="hidden" name="id" id="id" value="<?php echo $result['id_tblusuario']; ?>" />
                                   <label for="nome">Seu nome:</label>
                                   <input type="text" name="nome" id="nome" value="<?php echo $result['nome_tblusuario']; ?>" />
                                   <div class="clear"></div>
                                   <label for="email">E-mail:</label>
                                   <input type="text" name="email" id="email" value="<?php echo $result['email_tblusuario']; ?>" />
------------------------------------------------------------------------------------------------
<div class="clear"></div>
                                   <label for="senha">Senha antiga:</label>
                                   <input type="password" name="old_pass" id="senha" />
                                   <div class="clear"></div>
                                   <label for="senha">Nova senha:</label>
                                   <input type="password" name="old_pass" id="senha" />
                                   <div class="clear"></div>
                                   <label for="senha">Redigite a nova senha:</label>
                                   <input type="password" name="conf_new_pass" id="senha" />
                                   <div class="clear"></div>
                                   <input type="submit" value="Atualizar" />
                         <?php } ?>
                    </fieldset>
               </form>
          </div>
     </body>
</html>