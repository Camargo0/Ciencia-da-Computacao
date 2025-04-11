<?php
class Usuario {
    private $nome;
    private $email;
    private $senha;

    public function __construct($nome, $email, $senha) {
        $this->nome = htmlspecialchars(trim($nome));
        $this->email = filter_var($email, FILTER_SANITIZE_EMAIL);
        if (!empty($senha)) {
            $this->senha = password_hash($senha, PASSWORD_DEFAULT);
        }
    }

    public static function criarComHash($nome, $email, $senhaHash) {
        $usuario = new self($nome, $email, '');
        $usuario->senha = $senhaHash;
        return $usuario;
    }

    public function autenticar($email, $senha) {
        return $this->email === $email && password_verify($senha, $this->senha);
    }

    public function getNome() {
        return $this->nome;
    }

    public function getEmail() {
        return $this->email;
    }

    public function getSenhaHash() {
        return $this->senha;
    }
}
