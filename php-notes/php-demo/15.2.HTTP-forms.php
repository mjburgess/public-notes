<!-- RUN THIS FILE via APACHE, ie. put it in htdocs and browse to localhost -->
<!DOCTYPE html>
<html>
<head>
    <title>Example Forms</title>
</head>
<style>

label, button {  /* select all the label and button tags */
    display: block;  /* display them as blocks, ie. on their own lines */
    margin-top: 2%;  /* separate them out a bit, pushing the top up by 2% of the page's size */
}

body {
    margin: 3%; /* indent the page a little */
}

</style>
<body>

<!-- recall: pre-tags give you monospaced, whitespace-respecting output -->
<pre><?php print_r($_POST); ?></pre>

<!-- pay special attention to the layout of the POST array,
    compare it to the attributes on the form tags on this page -->


<form action="" method="post">
    <label> <!-- label tags group together the label for the input, here "First Name", with the input tag -->
        First Name:  <input type="text" name="first_name">
    </label>

    <label>
        Last Name:  <input type="text" name="last_name" />
    </label>

    <label>
        Password:  <input type="password" name="password" value=""/> <!-- password-type input -->
    </label>

    <label>
        Description: <textarea rows="5" cols="50" name="description"></textarea>
        <!-- textareas are the large boxes -->
    </label>

    <label>
        Adult? <input type="checkbox" name="is_adult" value="on">
    </label>

    <label>
        Subscribe? <input type="checkbox" name="is_subscriber" value="on">
    </label>


    <label> <!-- a radio selects one of several options for a particular entry -->
        <input type="radio" name="colour" value="red"> Red              <!-- colour=red -->
        <input type="radio" name="colour" value="green"> Green          <!-- or, colour=green -->
    </label>

    <label> Size:
        <select name="size">        <!-- one name, for multiple options... -->
            <option value="s" selected>Small</option>       <!-- the value is what gets sent by the browser -->
            <option value="m">Medium</option>               <!-- Small, Medium, etc. is just displayed on the page -->
            <option value="l">Large</option>
            <option value="xl">Extra Large</option>
        </select>
    </label>

    <input type="hidden" name="extra_information" value="this is an example!" />

    <button type="submit"> Send! </button>
</form>
</body>
</html>
