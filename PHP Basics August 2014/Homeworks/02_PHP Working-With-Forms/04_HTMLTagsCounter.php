<?php
session_start();
if (!isset($_SESSION['score'])) {
    $_SESSION['score'] = 0;
}
$allHtmlTags = array("!doctype", "a", "abbr", "address", "area", "article", "aside", "audio", "b", "base", "bdi", "bdo", "big",
    "blockquote", "body", "br", "button", "canvas", "caption", "center", "cite", "code", "col", "colgroup", "command",
    "datalist", "dd", "del", "details", "dfn", "dir", "div", "dl", "dt", "em", "embed", "fieldset", "figcaption",
    "figure", "font", "footer", "form", "frame", "frameset", "h1", "h2", "h3", "h4", "h5", "h6", "head", "header",
    "hgroup", "hr", "html", "i", "iframe", "img", "input", "ins", "kbd", "keygen", "label", "legend", "li", "link",
    "map", "mark", "menu", "meta", "meter", "nav", "noframes", "noscript", "object", "ol", "optgroup", "option", "p",
    "param", "pre", "progress", "q", "rp", "rt", "ruby", "s", "samp", "script", "section", "select", "small", "source",
    "span", "strike", "strong", "style", "sub", "summary", "sup", "table", "tbody", "td", "textarea", "tfoot", "th",
    "time", "title", "tr", "track", "tt", "u", "ul", "var", "video", "wbr");

if (isset($_GET['tags'])) {
    if (in_array($_GET["tags"], $allHtmlTags)) {
        $_SESSION['score']++;
        $validator = "Valid HTML tag!";
    }
    else {
        $validator = "Invalid HTML tag!";
    }
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>Tags Counter</title>
</head>
<body>
    <form method="get">
        <label for="tags">Enter HTML tags:</label>
        <br/>
        <br/>
        <input type="text" name="tags" id="tags"/>
        <input value="Submit" type="submit"/>
    </form>
    <p style="font-size: 30px; font-weight: bold">
        <?php
        if (isset($validator)) {
            echo $validator ;
        }
        ?>
    </p>
    <div style="font-size: 30px; font-weight: bold">
        Score:
        <?php
        if (isset($_SESSION['score'])) {
            echo $_SESSION['score'];
        }
        ?>
    </div>
</body>
</html>
