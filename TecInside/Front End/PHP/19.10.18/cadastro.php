<html>
    <body>
        <form name="form1" method="POST"
              action="cadastrar.php">
            <br>Nome: <input type="text"
                              name="CadastroNome" required />
            <br>Email: <input type="email"
                              name="Cadastroemail" required />
            <br>Senha: <input type="password"
                              name="CadastroSenha" required />
            <br><input type="submit"
                       name="btnsubmit" value="Cadastrar-se"/>
            
            <br><input type="submit"
name="btncadastrp" value="Login" onclick="location.href='login.php'"/>
            
        </form>
    </body>
</html>


