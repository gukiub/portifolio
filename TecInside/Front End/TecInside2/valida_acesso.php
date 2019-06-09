<?php
     session_start();
     include 'conexao.php';
?>
<!DOCTYPE HTML>
<html lang="br" class="no-js">
     <head>
          <title>Sistema de Login e Senha Criptografados</title>
          <link href="estilo.css" rel="stylesheet" />
     </head>
     <body>
          <div id="conteudo">
                <h1>Sistema de login e senha criptografados - Verificando Informações</h1>
                <div class="borda"></div>
                <?php
                        $recebeEmail = $_POST['email'];
                        $filtraEmail = filter_var($recebeEmail,FILTER_SANITIZE_SPECIAL_CHARS);
                        $filtraEmail = filter_var($filtraEmail, FILTER_SANITIZE_MAGIC_QUOTES);
                        $recebeSenha = $_POST['senha'];
                        $filtraSenha = filter_var($recebeSenha,FILTER_SANITIZE_SPECIAL_CHARS);
                        $filtraSenha = filter_var($filtraSenha, FILTER_SANITIZE_MAGIC_QUOTES);
                        function criptoSenha($criptoSenha){
                             return md5($criptoSenha);
                        }
                        
                        $criptoSenha = criptoSenha($filtraSenha);
                        $consultaInformacoes = mysqli_query($conecta, "SELECT * FROM tblusuario WHERE email_tblusuario = '$filtraEmail' AND senha_tblusuario = '$criptoSenha'") or die (mysql_error());
                        $verificaInformacoes = ($consultaInformacoes);
                        if($verificaInformacoes == $consultaInformacoes){
                             while ($result=mysqli_fetch_array($verificaInformacoes)){
                                  $_SESSION['login']=true;
                                  $_SESSION['nome_usuario']=$result['nome_tblusuario'];
                                  header("Location: conteudoExclusivo.php");
                             }
                        } else {
                            header("location: http://www.google.com");
                             }
                ?>
          </div>
     </body>
</html>