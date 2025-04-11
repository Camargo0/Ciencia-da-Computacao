<?php
require_once 'classes/Sessao.php';
Sessao::iniciar();
$emailSalvo = $_COOKIE['email'] ?? '';
?>
<!DOCTYPE html>
<html>
<head><title>Login</title></head>
<body>
<h2>Login</h2>
<form action="processa_login.php" method="POST">
    Email: <input type="email" name="email" value="<?= htmlspecialchars($emailSalvo) ?>" required><br>
    Senha: <input type="password" name="senha" required><br>
    <label><input type="checkbox" name="lembrar" value="1"> Lembrar e-mail</label><br>
    <button type="submit">Entrar</button>
</form>
<a href="cadastro.php">Criar conta</a>
</body>
</html>
