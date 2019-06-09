<!DOCTYPE html>
<html lang="pt">
  <head>
    <meta charset="utf-8">
    <title>Agenda</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Projeto Acadêmico - criação de CRUD em PHP">
    <meta name="author" content="Airon Gabriel">

    <!-- Le styles -->
    <link href="bootstrap/css/bootstrap.css" rel="stylesheet">
    <link href="bootstrap/css/bootstrap-responsive.css" rel="stylesheet">
    <link href="bootstrap/css/stylo.css" rel="stylesheet">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css">

    <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->

    <!-- Fav and touch icons -->
    <link rel="shortcut icon" href="../assets/ico/favicon.ico">
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="../assets/ico/apple-touch-icon-144-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="../assets/ico/apple-touch-icon-114-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="../assets/ico/apple-touch-icon-72-precomposed.png">
    <link rel="apple-touch-icon-precomposed" href="../assets/ico/apple-touch-icon-57-precomposed.png">
  </head>

  <body>
    <div class="container">
      <div class="masthead">
        <ul class="nav nav-pills pull-right">
          <li class="active"><a href="<?php echo 'admin/cadastrar-user/index.php' ;?>">Inscreva-se</a></li>
          <li><a href="<?php echo dirname($_SERVER['PHP_SELF']) . '/admin/' ;?>">Login</a></li>
        </ul> 
      </div>      
    </div>

    <div class="container">
        <!-- INCLUSÃO DO CABEÇALHO -->
        <div class="row"><div class="alignCenter"><?php include_once "cabecalho.php" ;?></div></div>
    </div>