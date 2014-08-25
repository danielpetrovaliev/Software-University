<?php
if ($_SERVER['REQUEST_METHOD'] == "POST") {
    $categories = $_POST['categories'];
    $tags = $_POST['tags'];
    $months = $_POST['months'];

    $listOfCategories = explode(", ", $categories);
    $listOfTags = explode(", ", $tags);
    $listOfMonths = explode(", ", $months);

}

?>

<!DOCTYPE html>
<html>
<head>
    <title>Sidebar Builder</title>
    <meta charset="utf-8"/>
    <style>
        .aside{
            margin-top: 15px;
            font-size: 13px;
            font-family: Tahoma, sans-serif;
            max-width: 200px;
            border-radius: 15px;
            border: 1px solid black;
            background: rgb(183,222,237); /* Old browsers */
            background: -moz-linear-gradient(top, rgba(183,222,237,1) 0%, rgba(113,206,239,1) 50%, rgba(33,180,226,1) 51%, rgba(183,222,237,1) 100%); /* FF3.6+ */
            background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(183,222,237,1)), color-stop(50%,rgba(113,206,239,1)), color-stop(51%,rgba(33,180,226,1)), color-stop(100%,rgba(183,222,237,1))); /* Chrome,Safari4+ */
            background: -webkit-linear-gradient(top, rgba(183,222,237,1) 0%,rgba(113,206,239,1) 50%,rgba(33,180,226,1) 51%,rgba(183,222,237,1) 100%); /* Chrome10+,Safari5.1+ */
            background: -o-linear-gradient(top, rgba(183,222,237,1) 0%,rgba(113,206,239,1) 50%,rgba(33,180,226,1) 51%,rgba(183,222,237,1) 100%); /* Opera 11.10+ */
            background: -ms-linear-gradient(top, rgba(183,222,237,1) 0%,rgba(113,206,239,1) 50%,rgba(33,180,226,1) 51%,rgba(183,222,237,1) 100%); /* IE10+ */
            background: linear-gradient(to bottom, rgba(183,222,237,1) 0%,rgba(113,206,239,1) 50%,rgba(33,180,226,1) 51%,rgba(183,222,237,1) 100%); /* W3C */
            filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#b7deed', endColorstr='#b7deed',GradientType=0 ); /* IE6-9 */
        }

        aside ul li a{
            color: black;
        }

        aside ul li{
            list-style-type: circle;
        }

        aside h2{
            border-bottom: 1px solid black;
            margin-left: 10px;
        }
    </style>
</head>
<body>
<form method="post">
    <label for="categories">Categories: </label>
    <input type="text" id="categories" name="categories"/>
    <br/>
    <label for="tags">Tags: </label>
    <input type="text" id="tags" name="tags"/>
    <br/>
    <label for="months">Months: </label>
    <input type="text" id="months" name="months"/>
    <br/>
    <input type="submit" value="Generate"/>
</form>

<?php if(isset($categories) && isset($tags) && isset($months)): ?>
    <div>
        <aside class="aside">
            <h2>Categories</h2>
            <ul>
                <?php foreach($listOfCategories as $category): ?>
                    <li>
                        <a href="#"><?= $category ?></a>
                    </li>
                <?php endforeach; ?>
            </ul>
        </aside>
        <aside class="aside">
            <h2>Tags</h2>
            <ul>
                <?php foreach($listOfTags as $tag): ?>
                    <li>
                        <a href="#"><?= $tag ?></a>
                    </li>
                <?php endforeach; ?>
            </ul>

        </aside>
        <aside class="aside">
            <h2>Months</h2>
            <ul>
                <?php foreach($listOfMonths as $month): ?>
                    <li>
                        <a href="#"><?= $month ?></a>
                    </li>
                <?php endforeach; ?>
            </ul>
        </aside>
    </div>
<?php endif; ?>
</body>
</html>