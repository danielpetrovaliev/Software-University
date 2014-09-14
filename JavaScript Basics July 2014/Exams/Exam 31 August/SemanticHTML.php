<?php
$html = $_GET['html'];
$htmlTags = explode("\n", $html);

$outTags = [];



for ($i = 0; $i < count($htmlTags); $i++) {
	$outTags[$i] = replace($htmlTags[$i]);

}


var_dump($outTags);

echo implode("\n", $outTags);

function replace($element){
    /*$replacementOpenTag = '<${6}${2}${7}>';*/
    /*$patternOpenTag = '/(<div)((.)+)((id|class)[ ]*=[ ]*"(\w+)")(.*)(>)/';*/
    $replacementOpenTag = '<${7}${1}${8}>';
    $patternOpenTag = '/<div(.*?)( )((id|class)(\s*?)=(\s*?)"(.*?)")(.*?)( ?)*>/';

    $patternCloseTag = '/(<\/div>)(\s*)\<\!\-\-\s*(\w+)\s*\-\-\>/';
    $replacementCloseTag = '</${3}>';

    if (preg_match($patternOpenTag, $element) == 1) {
        $element = preg_replace($patternOpenTag, $replacementOpenTag, $element);
    } elseif (preg_match($patternCloseTag, $element) == 1) {
        $element = preg_replace($patternCloseTag, $replacementCloseTag, $element);
    }


    return $element;
}