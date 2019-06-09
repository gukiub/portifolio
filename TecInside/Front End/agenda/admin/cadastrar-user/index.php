<?php
// arquivos de configuração
include('../dbconfig.php');

// Variavél para preencher o erro (se existir)

$sucesso = '';
$errado = '';
$certo = '';
$erro = false;

// Apaga usuários
if ( isset( $_GET['del'] ) ) {

	$deleta_usuario = $db_con->prepare('DELETE FROM usuarios WHERE user_id=?');
	$deleta_usuario->execute( array( (int)$_GET['del'] ) );
	
	header('location: http://localhost/agenda/admin/cadastrar-user/');
}

// Verifica se algo foi postado para publicar ou editar
if ( isset( $_POST ) && ! empty( $_POST ) ) {
	// Cria as variáveis
    $certo = 'cheio';
    $errado = '';
    $sucesso = 'Usuário cadastrado com sucesso';
    
	foreach ( $_POST as $chave => $valor ) {
		$chave = $valor;
		
		// Verifica se existe algum campo em branco
		if ( empty ( $valor ) ) {
			// Preenche o erro
            $errado = 'vazio';
            $certo = '';
		}
	}
	
    $form_nome = $_POST['form_nome'];
    $form_senha = $_POST['form_senha'];
    $form_usuario = $_POST['form_usuario'];

	// Verifica se as variáveis foram configuradas
	if ( empty( $form_usuario ) || empty( $form_senha ) || empty( $form_nome ) ) {
		$erro = 'Existem campos em branco';  
	}
	
	// Verifica se o usuário existe
	$verifica_usuarios = $db_con->prepare('SELECT * FROM usuarios WHERE user = ?');
	$verifica_usuarios -> execute( array( $form_usuario ) );
	
	// Captura os dados da linha
	$user_id = $verifica_usuarios->fetch();
	$user_id = $user_id['user_id'];
	
	// Verifica se tem algum erro
	if ( ! $erro ) {
		// Se o usuário existir, atualiza
		if ( ! empty( $user_id ) ) {
			$inserir_usuario = $db_con->prepare('UPDATE usuarios SET user=?, user_password=?, user_name=? WHERE user_id=?');
			$inserir_usuario->execute( array( $form_usuario, $form_senha, $form_nome, $user_id ) );
			
		// Se o usuário não existir, cadastra novo
		} else {   
			$inserir_usuario = $db_con->prepare('INSERT INTO usuarios (user, user_password, user_name) VALUES (?, ?, ?)');
			$inserir_usuario->execute( array( $form_usuario, $form_senha, $form_nome ) );
		}
	}
}
?>

<?php include_once 'header.php'; ?>
<div class="container">
    <div>
        <hr>
        <p>Cadastrar ou editar um usuário já cadastrado.</p>
        <hr>
    </div>
    <form action="index.php" method="post">
        <table>
            <tr>
                <td>Nome do Usuário<br><input type="text" name="form_nome"></td>
                <td></td>
                <td>Usuário<br><input type="email" name="form_usuario"></td>
                <td></td>
                <td>Senha<br><input type="password" name="form_senha"></td>
                <input value="enviado" type="hidden" name="form_confirma">

            </tr>

            <?php if ( $errado == 'vazio' ) :?>
            <tr>
                <td style="color: red;">
                    <div class='alert alert-info'>
                        <i class="fa fa-group"></i>
                        <strong>
                            <?php echo $erro; ?></strong>
                    </div>
                </td>
            </tr>
            <?php endif;     
                    if($certo == 'cheio') :?>
            <tr>
                <td style="color: blue;">
                    <div class='alert alert-info'>
                        <i class="fa fa-group"></i>
                        <strong>
                            <?php echo $sucesso; ?></strong>
                    </div>
                </td>
            </tr>
            <?php endif;
            
            
            ?>
            <tr>
                <td><input type="submit" value="Cadastrar Usuário" class="btn btn-primary btn-info"></td>
            </tr>
        </table>
    </form>
</div>

<?php 
		// Mostra os usuários
		$pdo_verifica = $db_con->prepare('SELECT * FROM usuarios ORDER BY user_id DESC');
		$pdo_verifica->execute();
		?>

<?php if($_SESSION['logado'] === true) { ?>
<div class="container">
    <table class="table table-bordered table-responsive">
        <tr>
            <th>ID</th>
            <th>Nome do Usuário</th>
            <th>Usuário</th>
            <th>Senha</th>
            <th style="text-align:center">Ação</th>
        </tr>
        <?php
					while( $fetch = $pdo_verifica->fetch() ) {
						echo '<tr>';
						echo '<td>' . $fetch['user_id'] . '</td>';
						echo '<td>' . $fetch['user_name'] . '</td>';
						echo '<td>' . $fetch['user'] . '</td>';
						echo '<td>' . $fetch['user_password'] . '</td>';
						echo '<td style="text-align:center"> <a href="?del=' . $fetch['user_id'] . '"><i class="fa fa-trash"></i></a> </td>';
						echo '</tr>';
					}
					?>
    </table>
</div>
<?php } ;?>
</body>

</html>
