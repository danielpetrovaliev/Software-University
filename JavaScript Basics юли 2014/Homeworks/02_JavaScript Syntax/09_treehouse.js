function treeHouseCompare(a, b) {
    var house = (a*a) + (0.5*3*2);
    var tree = b*(b/3) + (Math.PI * (b*2/3)*(b*2/3));
    if (tree > house) {
        return "tree/" + tree.toFixed(2);
    }
    else {
        return "house/" + house.toFixed(2);
    }
}


console.log(treeHouseCompare(3, 2));
console.log(treeHouseCompare(3, 3));
console.log(treeHouseCompare(4, 5));