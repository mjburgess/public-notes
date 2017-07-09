<?php
include 'lib/common.php';
include 'lib/article_db.php';
include 'lib/user_db.php';

$latest = article_read_latest($gPDO);


// .phtml just for person reading hte file name
// has no effect on the include mechanism...
// files can have any extension
// phtml = mostly html + php

include 'templates/index.phtml';
