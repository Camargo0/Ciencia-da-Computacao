<?php
require_once 'Usuario.php';

class Autenticador {
    public static function registrar(Usuario $usuario) {
        if (!isset($_SESSION['usuarios'])) {
            $_SESSION['usuarios'] = [];
        }
        $_SESSION['usuarios'][] = [
            'nome' => $usuario->getNome(),
            'email' => $usuario->getEmail(),
            'senha' => $usuario->getSenhaHash()
        ];
    }

    public static function logar($email, $senha) {
        if (!isset($_SESSION['usuarios'])) return null;

        foreach ($_SESSION['usuarios'] as $u) {
            if ($u['email'] === $email && password_verify($senha, $u['senha'])) {
                return Usuario::criarComHash($u['nome'], $u['email'], $u['senha']);
            }
        }
        return null;
    }
}
