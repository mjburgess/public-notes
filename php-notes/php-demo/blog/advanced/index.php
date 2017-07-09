<?php
include 'common.php';

$sql = "SELECT * FROM articles, users
            WHERE users.id = articles.author";

if(isset($_GET['category'])) {
  $sql .= " AND articles.category = :category";
}

$sql .= " ORDER BY date DESC";

$stmt = $gPDO->prepare($sql);
$stmt->execute($_GET);

display_page('index', [
  'articles' => $stmt->fetchAll()
]);
