<?php
$input = "";
if (isset($_POST['input'])) {
    $input = strtolower($_POST['input']);
    preg_match_all("/([A-Za-z])+/", $input, $words);
    $countElements = array_count_values($words[0]);
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>Word Mapping</title>
    <meta charset="utf-8"/>
    <style>
        table{
            background: #D3D3D3;
        }
        table td{
            padding: 2px 5px;
            font-weight: bold;
        }
    </style>
</head>
<body>
<form method="post">
    <textarea name="input" cols="60" rows="5"></textarea>
    <br/>
    <input type="submit" value="Count words"/>
</form>

    <p>
        <table border="1">
            <?php foreach($countElements as $word => $count): ?>
                <tr>
                    <td>
                        <?= htmlentities($word); ?>
                    </td>
                    <td>
                        <?= $count; ?>
                    </td>

                </tr>
            <?php endforeach; ?>
        </table>
    </p>

</body>
</html>