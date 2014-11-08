/**
 * Created by petrovaliev95 on 04-Nov-14.
 */

function generateInputs() {
    var typeOfShape = document.getElementById("shape").value;
    var inputContainer = document.getElementById("otherParameters");
    var input = document.createElement("input");
    switch (typeOfShape) {
        case "triangle":
            inputContainer.innerHTML =
                "<label for='x2'> X2: </label>" +
                "<input id='x2' type='text' />" +
                "<label for='y2'> Y2: </label>" +
                "<input id='y2' type='text' />" +
                "<br />" +
                "<label for='x3'> X3: </label>" +
                "<input id='x3' type='text' />" +
                "<label for='y3'> Y3: </label>" +
                "<input id='y3' type='text' />";
            break;
        case "rectangle":
            inputContainer.innerHTML =
                "<label for='width'> Width: </label>" +
                "<input id='width' type='text' />" +
                "<label for='height'> Height: </label>" +
                "<input id='height' type='text' />";
            break;
        case "segment":
            inputContainer.innerHTML =
                "<label for='x2'> X2: </label>" +
                "<input id='x2' type='text' />" +
                "<label for='y2'> Y2: </label>" +
                "<input id='y2' type='text' />";
            break;
        case "circle":
            inputContainer.innerHTML =
                "<label for='radius'> Radius: </label>" +
                "<input id='radius' type='text' />";
            break;
        case "point":
            inputContainer.innerHTML =
                " ";
            break;
        default :
            console.log("Invalid shape " + typeOfShape.toLowerCase());
            break;
    }
};
generateInputs();



