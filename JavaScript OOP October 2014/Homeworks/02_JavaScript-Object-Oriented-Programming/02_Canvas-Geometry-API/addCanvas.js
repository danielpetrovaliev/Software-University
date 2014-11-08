/**
 * Created by petrovaliev95 on 05-Nov-14.
 */

function addCanvas() {
    var x1 = document.getElementById("x").value;
    var y1 = document.getElementById("y").value;
    var color = document.getElementById("color").value;
    var typeOfShape = document.getElementById("shape").value;
    console.log("canvas element for create is " + typeOfShape);
    switch (typeOfShape) {
        case "triangle":
            var x2 = document.getElementById("x2").value;
            var y2 = document.getElementById("y2").value;
            var x3 = document.getElementById("x3").value;
            var y3 = document.getElementById("y3").value;

            var triangle = new Shapes.Triangle(x1, y1, color, new Shapes.Point(x2, y2), new Shapes.Point(x3, y3));

            triangle.draw();
            console.log(typeOfShape + " created.");
            break;
        case "rectangle":
            var width = document.getElementById("width").value;
            var height = document.getElementById("height").value;

            var rect = new Shapes.Rectangle(x1, y1, color, width, height);
            rect.draw();

            console.log(typeOfShape + " created.");
            break;
        case "segment":
            var x2 = document.getElementById("x2").value;
            var y2 = document.getElementById("y2").value;
            var seg = new Shapes.Segment(x1, y1, color, new Shapes.Point(x2, y2));
            seg.draw();

            console.log(typeOfShape + " created.");
            break;
        case "circle":
            var radius = document.getElementById("radius").value;
            var circle = new Shapes.Circle(x1, y1, color, radius);
            circle.draw();

            console.log(typeOfShape + " created.");
            break;
        case "point":
            var point = new Shapes.Point(x1, y1);
            point.draw();

            console.log(typeOfShape + " created.");
            break;
        default :
            console.log("Invalid shape " + typeOfShape.toLowerCase());
            break;
    }
}