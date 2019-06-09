<?php 
    session_start();
?>


<!DOCTYPE html>
<html lang="pt">
  <head>
    <meta charset="utf-8">
    <title>Login</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Empresa de desenvolvimento">
    <meta name="author" content="TecInside">

    <!-- Le styles -->
    <link href="../bootstrap/css/bootstrap.css" rel="stylesheet">
    <link href="../bootstrap/css/bootstrap-responsive.min.css" rel="stylesheet">
    <link href="../bootstrap/css/stylo.css" rel="stylesheet">

    <link href="../font-awesome-4.5.0/css/font-awesome.css" rel="stylesheet">

  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>


    <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->

  </head>

<body>

<div class="clearfix"></div><br />


<div class="container">
    
    <!-- FORMULARIO -->
      <form class="form-signin"  method="post" action="index.php">
        <?php if(!empty($_SESSION['login_erro'])) : ?>
            <div class='alert alert-warning'>
                <p><strong>Erro!</strong> <?php echo $_SESSION['login_erro']; ?></p>
                <?php $_SESSION['login_erro'] = ''; ?>
            </div>
        <?php endif; ?>
        <h2 class="form-signin-heading">Login</h2>
        <input type="text" class="input-block-level" placeholder="login" name="usuario" maxlength="30">
        <input type="password" class="input-block-level" placeholder="password" name="senha" maxlength="30">
        <button class="btn btn-primary " type="submit" name="btn-login">Enviar</button><br><br>
        <a href="cadastrar-user/">Inscrever</a> - <a href="<?php echo "../"; ?>">Visitar ao site</a>
      </form>
</div> <!-- /container -->



