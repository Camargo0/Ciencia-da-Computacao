<?php
require_once 'classes/Sessao.php';
require_once 'classes/Usuario.php'; // Importante para evitar erro com unserialize()
Sessao::iniciar();

$usuario = Sessao::get('usuario');
if (!$usuario) {
    header("Location: login.php");
    exit;
}
?>
<!DOCTYPE html>
<html>
<head><title>Dashboard</title></head>
<body>
<h2>Bem-vindo, <?= htmlspecialchars($usuario->getNome()) ?>!</h2>
<p>Email: <?= htmlspecialchars($usuario->getEmail()) ?></p>
<a href="logout.php">Sair</a>
</body>
</html>
