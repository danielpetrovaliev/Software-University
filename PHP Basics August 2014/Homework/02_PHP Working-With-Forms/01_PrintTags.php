<?php
$listOfTags = [];
if (isset($_POST['tags'])) {
    $tags = $_POST['tags'];
    $arrOfTags = explode(", ", $tags);
    $result = "";
    foreach ($arrOfTags as $key => $value) {
        $result .= $key . " : " . $value . "<br />";
    }
}
?>
<!DOCTYPE html>
<html>
<head>
    <title>Print Tags</title>
</head>
<body>
<p>Enter Tags: </p>
<form action="" method="post">
    <input name="tags" style="background: #FAFFBD" type="text"/>
    <input type="submit"/>
</form>
<p>
    <?php
    if (isset($result)) {
        echo $result;
    }
    ?>
</p>
</body>
</html>





