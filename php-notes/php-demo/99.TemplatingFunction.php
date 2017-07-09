<?php

//TEMPLATES
const TEMPLATE_DIR = 'blog/advanced/templates';
const TEMPLATE_EXT = '.phtml';

function display_page($page, $vars = []) {
  foreach(['_header', $page, '_footer'] as $template)  {
    include TEMPLATE_DIR . DIRECTORY_SEPARATOR . $template . TEMPLATE_EXT;
  }
}

display_page('error');
