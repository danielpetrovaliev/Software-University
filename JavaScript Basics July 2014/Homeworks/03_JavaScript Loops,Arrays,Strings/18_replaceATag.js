function replaceATag(input) {

    var regex = /<a([\w\W]*)>([\w\W]*)<\/a>/gi;

    var output = input.replace(regex, '[URL $1]$2[/URL]');
    return output;

}

console.log(replaceATag('<ul>\n    <li>\n    <a href=http://softuni.bg>SoftUni</a>\n    </li>\n</ul>'));