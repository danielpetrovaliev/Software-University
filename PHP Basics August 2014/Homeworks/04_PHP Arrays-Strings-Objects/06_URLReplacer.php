<?php

if ($_SERVER['REQUEST_METHOD'] == "POST") {
    $text = $_POST['text'];
    $pattern = '/(<a(.+?)href="(((http\:\/\/)|(www\.))([a-zA-Z0-9\-\.\/]+))">)/';
    $replacement = '[URL=\3]';
    $text = preg_replace($pattern, $replacement, $text);
    $text = preg_replace('/(<\/a>)/', '[/URL]', $text);
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
    <label for="text">Enter Text:</label>
    <br/>
    <textarea cols="60" rows="4" id="text" name="text"></textarea>
    <br/>
    <input type="submit" value="Replace URLs"/>
</form>
<p>
    <?php if(isset($text)): ?>
    <?= htmlentities($text); ?>
    <?php endif; ?>
</p>
</body>
</html>