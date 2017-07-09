<?php

function user_create($pdo, $user) {
    $user['password'] = password_hash($user['password'], PASSWORD_DEFAULT);

    $query = $pdo->prepare('INSERT INTO users(email, password) VALUES(:email, :password)');
    $success = $query->execute($user);

    return $success;
}

function user_read($pdo, $email) {
    $query = $pdo->prepare('SELECT * FROM users WHERE email = :email');
    $success = $query->execute(['email' => $email]);

    return $query->fetch(PDO::FETCH_ASSOC);
}

function user_update($pdo) {}
function user_delete($pdo) {}
