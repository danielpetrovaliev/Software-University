<?php
$listOfTags = [];
if (isset($_POST['tags'])) {
    $tags = $_POST['tags'];
    $arrOfTags = explode(", ", $tags);
    $result = "";
    foreach ($arrOfTags as $key) {
        if (!isset($listOfTags[$key])) {
            $listOfTags[$key] = 1;
        } else{
            $listOfTags[$key]++;
        }
    }
    arsort($listOfTags);
    foreach ($listOfTags as $key => $value) {
        $result .= "$key : $value times" . "<br />";
    }
    $mostFreqTag = $listOfTags[0];


}
?>
<!DOCTYPE html>
<html>
<head>
    <title>Most Frequent Tag</title>
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
    <p>
        <?= $mostFreqTag ?>
    </p>
</body>
</html>





