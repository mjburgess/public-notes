<?php

class User {
    private $id;
    private $username;
    private $email;

    public function __construct(array $fields) {
        foreach($fields as $name => $value) {
            $this->$name = $value;
        }
    }

    public function getId() { return $this->id; }
    public function getUsername() { return $this->username; }
    public function getEmail() { return $this->email; }
}

class UserFactory {
    private $db;

    public function __construct($db) {
        $this->db = $db;
    }

    public function byName($username) {
        return new User([
            'id' => 1,
            'username' => $username,
            'email' => "$username@example.com"
        ]); //fake db request
    }
}

class View  {
    private $template;
    private $variables;

    public function __construct($template, array $variables = []) {
        $this->template = $template;
        $this->variables = $variables;
    }

    public function getTemplate() { return $this->template; }
    public function getVariables() { return $this->variables; }
}

class HtmlRenderer { }

class TextRenderer {
    private $view;

    public function __construct(View $v) {
        $this->view = $v;
    }

    public function __toString() {
        return  'TEMPLATE: '
                . $this->view->getTemplate()
                . PHP_EOL
                . print_r($this->view->getVariables(), true);
    }
}

class HttpRequest {
    public function __construct(array $get, array $post) {
        $this->get = $get;
        $this->post = $post;
    }

    public function get($key = null) {
        return $key ? $this->get[$key] : $this->get;
    }

    public function post($key = null) {
        return $key ? $this->post[$key] : $this->post;
    }
}

class UserController {
    private $user;

    public function __construct(array $services) {
        $this->user = $services['UserFactory'];
    }

    public function showUser(HttpRequest $hr) {
        return new View('show_user', [
            'user' => $this->user->byName($hr->get('username'))
        ]);
    }
}

//simulate url request
$_get = ['ctrl' => 'user', 'action' => 'showUser', 'username' => 'Michael'];

//given to all controllers
$services = ['UserFactory' => new UserFactory(null)];



// the app.

const URI_CONTROLLER_PARAMETER = 'ctrl';
const URI_ACTION_PARAMETER = 'action';

$httpRequest = new HttpRequest($_GET + $_get, $_POST);

$controller  = $httpRequest->get(URI_CONTROLLER_PARAMETER) . 'Controller';
$action      = $httpRequest->get(URI_ACTION_PARAMETER);

$controller = new $controller($services);
$view = $controller->$action($httpRequest);

echo new TextRenderer($view);
