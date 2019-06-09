<?php
// Verifica conexão com banco de dados
if ( ! isset( $db_con ) || ! is_object( $db_con ) ) {
	exit('Erro ao conectar com o banco de dados.');
}

// Une $_SESSION e $POST para verificação
if ( isset( $_POST ) && ! empty( $_POST ) ) {
	$info_usuario = $_POST;
} else {
	$info_usuario = $_SESSION;
}

// Verifica se os campos do form usuário e senha existem
// E se não estão em vazio
if ( 
	isset ( $info_usuario['usuario'] ) && 
	isset ( $info_usuario['senha'] )   &&
  ! empty ( $info_usuario['usuario'] ) &&
  ! empty ( $info_usuario['senha'] ) 
) {
	// Faz a consulta por nome do usuário na base de dados com limite de um
	$pdo_checa_user = $db_con->prepare('SELECT * FROM usuarios WHERE user = ? LIMIT 1');
	$verifica_pdo = $pdo_checa_user->execute( array( $info_usuario['usuario'] ) );
	
	// Verifica se a consulta foi realizada com sucesso
	if ( ! $verifica_pdo ) {
		$erro = $pdo_checa_user->errorInfo();
		exit( $erro[2] );
	}
	
	// Busca os dados da linha encontrada
	$fetch_usuario = $pdo_checa_user->fetch();
	
	// Verifica se a senha do usuário está correta
	if (  $info_usuario['senha'] === $fetch_usuario['user_password']) {
		// O usuário logado
		$_SESSION['logado']       = true;
		$_SESSION['nome_usuario'] = $fetch_usuario['user_name'];
		$_SESSION['usuario']      = $fetch_usuario['user'];
		$_SESSION['user_id']      = $fetch_usuario['user_id'];
	} else {
		// deslogado
		$_SESSION['logado']     = false;
		
		// Preenche o erro para o usuário
		$_SESSION['login_erro'] = 'Usuário ou senha inválidos';
	}
}
?>