<?php
$output = "";
if ($_SERVER['REQUEST_METHOD'] === "POST") {
    $name = $_POST['name'];
    $age = $_POST["age"];
    $sex = $_POST['sex'];
    $output = "My name is $name. I am $age years old. I am $sex.";
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>Form Data</title>
    <style>
        form input{
            display: block;
        }
        form input[type="radio"]{
            display: inline-block;
        }
        form input[type="radio"]:after{
            content: Male;
        }
        label{
            display: block;
        }
    </style>
</head>
<body>
<form method="post" action="">
    <input placeholder="Name.." name="name" type="text"/>
    <input placeholder="Age.." name="age" type="text"/>
    <label for="male"><input id="male" value="Male" name="sex" type="radio" />Male</label>
    <label for="female"><input id="female" value="Female" name="sex" type="radio" />Female</label>
    <input name="submit" type="submit"/>

</form>

<?php echo $output; ?>

</body>
</html>