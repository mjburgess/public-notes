<?php
include 'common.php';

$sql = "SELECT * FROM articles, users
            WHERE users.id = articles.author
            AND articles.id = :id
            ORDER BY date DESC";

$stmt = $gPDO->prepare($sql);
$stmt->execute($_GET + ['id' => DEFAULT_ARTICLE_ID]);

display_page('article', [
  'article' => $stmt->fetch()
]);
