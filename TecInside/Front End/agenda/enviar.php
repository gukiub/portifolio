<?php

$curso = $_GET["curso"];
$periodo = $_GET["periodo"];
$faculdade = $_GET["faculdade"];
$descricao = $_GET["descricao"];

?>

<!DOCTYPE html>
<html lang="pt">
  <head>
    <meta charset="utf-8">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <!-- Le styles -->
    <link href="css/bootstrap.css" rel="stylesheet">
    <style type="text/css">
      body {
        padding-top: 40px;
        padding-bottom: 40px;
        background-color: #f5f5f5;
      }

      .form-signin {
        max-width: 300px;
        padding: 19px 29px 29px;
        margin: 0 auto 20px;
        background-color: #fff;
        border: 1px solid #e5e5e5;
        -webkit-border-radius: 5px;
           -moz-border-radius: 5px;
                border-radius: 5px;
        -webkit-box-shadow: 0 1px 2px rgba(0,0,0,.05);
           -moz-box-shadow: 0 1px 2px rgba(0,0,0,.05);
                box-shadow: 0 1px 2px rgba(0,0,0,.05);
      }
      .form-signin .form-signin-heading,
      .form-signin .checkbox {
        margin-bottom: 10px;
      }
      .form-signin input[type="text"],
      .form-signin input[type="password"] {
        font-size: 16px;
        height: auto;
        margin-bottom: 15px;
        padding: 7px 9px;
      }
	  .hero-unit h1{
		  font-size:55px;
	  }

    </style>
    <link href="css/bootstrap-responsive.css" rel="stylesheet">

    <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->

  <body>

    <div class="container"> 
		<!-- INCLUSÃO DO CABEÇALHO -->
		<div class="row"><div class="alignCenter"><?php include_once "cabecalho.php" ;?></div></div>
      
	  <!-- AQUI VC DEFINE AS VARIAVEIS PARA IMPRESSÃO NA TELA -->
	  <div class="hero-unit">
        <h1><?php echo $curso ;?></h1><br>
        <p><?php echo $descricao ;?></p><BR>
		<p><strong>Faculdade:</strong> <?php echo $faculdade;?> | <strong>Período:</strong> <?php echo $periodo;?></p>
      </div>

    </div> <!-- /container -->

  </body>
</html>


