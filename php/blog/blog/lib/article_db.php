<?php
// CRUD == create read update delete

function article_read_latest($pdo) {
    $results = $pdo->query('SELECT * FROM articles ORDER BY id DESC LIMIT 10');

    return $results;
}

function article_read_id($pdo, $id) {
    $query = $pdo->prepare('SELECT * FROM articles, users WHERE articles.author_id = users.id AND articles.id = :id');
    $success = $query->execute(['id' => $id]);

    return $query->fetch(PDO::FETCH_ASSOC);
}

function article_create($pdo, $article) {
    $query = $pdo->prepare('INSERT INTO articles(body, author_id) VALUES(:body, :author_id)');
    $success = $query->execute($article);

    return $success;
}

function article_update($pdo) {}
function article_delete($pdo) {}
