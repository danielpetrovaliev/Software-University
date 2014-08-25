<?php

if ($_SERVER['REQUEST_METHOD'] == "POST") {
    $word = $_POST['word'];
    $text = $_POST['text'];
    $sentences = [];
    $trimedSentences = [];
    $outputSentences = [];

    $index = 0;
    for ($i = 0; $i < strlen($text); $i++) {
    	$letter = $text[$i];
        if ($letter == "?" || $letter == "." || $letter == "!") {
            $currSentence = mb_substr($text, $index, $i+1-$index);
            $sentences[] = $currSentence;
            $index = $i+1;
        }
    }
    $trimedSentences = array_map('trim', $sentences);

    //check word in string and print string

    foreach ($trimedSentences as $sentence) {
        if (strpos($sentence,(' ' . $word . ' '))) {
            $outputSentences[] = $sentence;
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
    <label for="word">Word: </label>
    <input type="text" id="word" name="word"/>
    <br/>
    <label for="text">Text:</label>
    <br/>
    <textarea cols="50" id="text" rows="5" name="text"></textarea>
    <br/>
    <input type="submit" value="Filter"/>
</form>
<br/>
<?php if(isset($outputSentences)): ?>
    <h1>Sentences: </h1>
    <p>
        <?php foreach($outputSentences as $sen): ?>
        <?= $sen ?>
        <br/>
        <?php endforeach; ?>
    </p>
<?php endif; ?>
</body>
</html>