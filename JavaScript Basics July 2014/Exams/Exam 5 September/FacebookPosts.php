<?php
date_default_timezone_set("Europe/Sofia");
$text = $_GET['text'];
$postsPattern = "/[\r\n]+/";
$piecesPattern = "/\s*[;]\s*/";
$commentsPattern = "/\s*[\/]\s*/";
$allPostsList = [];

$posts = preg_split($postsPattern, $text, -1, PREG_SPLIT_NO_EMPTY);

foreach ($posts as $post) {
    $pieces = preg_split($piecesPattern, $post, -1, PREG_SPLIT_NO_EMPTY);
    $author = $pieces[0];
    $date = $pieces[1];
    $postText = $pieces[2];
    $likesCount = $pieces[3];

    $key = date("U", strtotime($date));
    if (isset($pieces[4])) {
        $comments = $pieces[4];
        $comments = preg_split($commentsPattern, $comments, -1, PREG_SPLIT_NO_EMPTY);
    }

    $formatedDate = date("j F Y", strtotime($date));


    $outputPost = '<article><header><span>'.htmlspecialchars($author).'</span><time>'.htmlspecialchars($formatedDate).'</time></header><main><p>'.htmlspecialchars($postText).'</p></main><footer><div class="likes">'.htmlspecialchars($likesCount).' people like this</div>';

    if (isset($comments)) {
        $outputPost.='<div class="comments">';
        foreach ($comments as $comment) {
            $outputPost.='<p>'.htmlspecialchars(trim($comment)).'</p>';
        }
        $outputPost.= '</div>';
    }

    $outputPost .= '</footer></article>';

    $allPostsList[$key] = $outputPost;

    unset($comments);
}

krsort($allPostsList);

foreach ($allPostsList as $pos) {
    echo $pos;
}

