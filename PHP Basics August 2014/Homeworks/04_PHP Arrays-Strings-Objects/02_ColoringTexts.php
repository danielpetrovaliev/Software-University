<?php
if (isset($_POST['input'])) {
    $input = $_POST['input'];
    $letters = [];

    for ($i = 0; $i < strlen($input); $i++) {
    	if ($input[$i] !== "" && $input[$i] !== " ") {
            $letters[] = $input[$i];
        }
    }
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>Coloring Texts</title>
    <meta charset="utf-8"/>
</head>
<body>
<form method="post">
    <textarea cols="50" rows="3" name="input" type="text"></textarea>
    <br/>
    <input type="submit" value="Color text"/>
</form>
<br/>
<p>
    <?php foreach($letters as $letter): ?>
        <?php if(ord($letter) % 2 == 0): ?>
            <span style="font-family: Consolas, sans-serif; color: red;">
                <?= $letter ?>
            </span>
        <?php elseif(ord($letter) % 2 != 0): ?>
            <span style="font-family: Consolas, sans-serif; color: blue;">
                <?= $letter ?>
            </span>
        <?php endif; ?>
    <?php endforeach; ?>
</p>
</body>
</html>