<?php 
     include "conexao.php";
 
     $recebeId = $_GET['id'];
     $filtraId = filter_var($recebeId,FILTER_SANITIZE_SPECIAL_CHARS);
     $filtraId = filter_var($filtraId, FILTER_SANITIZE_MAGIC_QUOTES);
 
     $sql="DELETE from tblusuario where id_tblusuario = $filtraId ";
?>
<!DOCTYPE HTML>
<html>
     <head>
          <title>Exclusão de dados</title>
          <link href="css/style.css" rel="stylesheet" />
     </head>
     <body>
          <div id="conteudo">
               <h1>Exclusão de dados</h1>
               <div class="borda"></div>
               <?php
                    if (mysqli_query($conecta, $sql)) {
                         echo "<p>Registro excluído com sucesso!</p>";
                         echo "<p><a href='javascript:history.back();'> Volte</a> para a página anterior! Obrigado!</p>";
                    }
                    else{
                         echo "<p>Erro ao excluir o registro!</p>";
                         echo "<p><a href='javascript:history.back();'> Volte</a> para a página anterior! Obrigado! </p>";
                    }
               ?>
          </div>
     </body>
</html>