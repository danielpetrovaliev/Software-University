<?php

if ($_SERVER['REQUEST_METHOD'] == "POST") {
    $bannedWords = explode(", ",$_POST['banlist']);
    $text = $_POST['text'];

    foreach ($bannedWords as $word) {
        $text = str_replace($word,str_repeat("*", strlen($word)), $text);
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
    <label for="banlist">Banned Words: </label>
    <input type="text" id="banlist" name="banlist"/>
    <br/>
    <label for="text">Text:</label>
    <br/>
    <textarea cols="50" id="text" rows="5" name="text"></textarea>
    <br/>
    <input type="submit" value="Filter"/>
</form>
<br/>
<?php if(isset($text)): ?>
<h1>Filtred Text: </h1>
<p>
    <?= $text ?>
</p>
<?php endif; ?>
</body>
</html>