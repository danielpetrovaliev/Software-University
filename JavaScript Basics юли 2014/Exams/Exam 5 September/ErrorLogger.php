<?php
$text = $_GET['errorLog'];
$pattern = '/Exception in thread "[a-zA-Z]+" java\.([a-z]*)(.*?)([A-Za-z]+):[\n\s\w]+at ([\w_.]*?).([\w]+)\(([\w\.]+.java:)([\d]+)\)/';

preg_match_all($pattern, $text, $matches);

/*var_dump($matches);*/
echo "<ul>";
for ($i = 0; $i < count($matches[2]); $i++) {
    echo "<li>line <strong>".htmlspecialchars($matches[7][$i])."</strong> - <strong>".htmlspecialchars($matches[3][$i])."</strong> in <em>".htmlspecialchars($matches[6][$i]).htmlspecialchars($matches[5][$i])."</em></li>";
}
echo "</ul>";