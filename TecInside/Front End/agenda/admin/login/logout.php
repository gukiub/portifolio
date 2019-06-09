<?php

// inicio da sessão
session_start();

// destroindo a sessão
$_SESSION = array();
session_destroy();

// redireciona para o index da app
header("Location: ../../index.php");