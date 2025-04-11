<?php
require_once 'classes/Sessao.php';
require_once 'classes/Autenticador.php';

Sessao::iniciar();

$email = $_POST['email'];
$senha = $_POST['senha'];
$lembrar = isset($_POST['lembrar']);

$usuario = Autenticador::logar($email, $senha);

if ($usuario) {
    Sessao::set('usuario', $usuario);
    if ($lembrar) setcookie('email', $email, time()+3600);
    header("Location: dashboard.php");
} else {
    echo "Login inválido. <a href='login.php'>Tentar novamente</a>";
}
exit;
