<!DOCTYPE HTML>
<html>
     <head>
          <meta charset="utf-8">
          <title>Sistema de cadastro</title>
          <link href="css/style.css" rel="stylesheet" />
     </head>
     <body>
          <div id="conteudo">
               <h1> Cadastro de usuário</h1>
               <div class="borda"></div>
               <p>Cadastre-se utilizando o formulário abaixo!</p>
               <form method="post" action="cadastrausuario.php" id="validaAcesso">
                    <fieldset>
                         <legend>Faça seu cadastro abaixo!</legend>
                         <label for="nome">Seu nome:</label>
                         <input type="text" name="nome" id="nome" required />
                         <div class="clear"></div>
                         <label for="email">E-mail:</label>
                         <input type="email" name="email" id="email" required />
                         <div class="clear"></div>
                         <label for="senha">Senha:</label>
                         <input type="password" name="senha" id="senha" required />
                         <div class="clear"></div>
                         <input type="submit" value="Efetuar cadastro" />
                    </fieldset>
               </form>
          </div>
     </body>
</html>
