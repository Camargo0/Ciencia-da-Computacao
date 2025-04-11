<?php
require_once 'classes/Sessao.php';
require_once 'classes/Usuario.php';
require_once 'classes/Autenticador.php';

Sessao::iniciar();

$nome = $_POST['nome'];
$email = $_POST['email'];
$senha = $_POST['senha'];

$usuario = new Usuario($nome, $email, $senha);
Autenticador::registrar($usuario);

header("Location: login.php");
exit;
