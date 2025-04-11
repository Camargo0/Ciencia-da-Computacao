<?php
class Sessao {
    public static function iniciar() {
        if (session_status() === PHP_SESSION_NONE) session_start();
    }

    public static function set($chave, $valor) {
        $_SESSION[$chave] = serialize($valor); // ✅ SERIALIZA o objeto
    }

    public static function get($chave) {
        return isset($_SESSION[$chave]) ? unserialize($_SESSION[$chave]) : null; // ✅ DESSERIALIZA o objeto
    }

    public static function destruir() {
        session_destroy();
    }
}
