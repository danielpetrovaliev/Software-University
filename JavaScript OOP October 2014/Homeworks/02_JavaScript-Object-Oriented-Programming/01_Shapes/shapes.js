var Shapes = (function () {
	// Abstract Class Shape
	var Shape = (function () {
		function Shape(x, y, color) {
			this._x = x;
			this._y = y;
			this._color = color;
		}

		Shape.prototype.toString = function () {
			return "x=" + this._x + ", y=" + this._y + ", color=" + this._color;
		};

		Shape.prototype.canvas = function () {
			var canvas = {
				element: document.getElementById("canvas").getContext("2d")
			};

			return canvas;
		};

		return Shape;
	}());


	// Class Circle
	var Circle = (function () {
		function Circle(x, y, color, radius) {
			Shape.apply(this, arguments);
			this._radius = radius;

		}

		Circle.prototype = Object.create(Shape.prototype);
		Circle.prototype.toString = function () {
			return Shape.prototype.toString.call(this) + ", radius=" + this._radius;
		};

		Circle.prototype.draw = function () {
			this.canvas().element.fillStyle = this._color;
			this.canvas().element.arc(this._x,this._y,this._radius,0,2*Math.PI);
			this.canvas().element.fillStyle = this._color;
			this.canvas().element.fill();
		};

		return Circle;
	}());


	// Class Rectangle

	var Rectangle = (function () {
		function Rectangle(x, y, color, width, height) {
			Shape.apply(this, arguments);
			this._width = width;
			this._height = height;
		}

		Rectangle.prototype = Object.create(Shape.prototype);
		Rectangle.prototype.toString = function () {
			return Shape.prototype.toString.call(this) + ", width=" + this._width + ", height=" + this._height;
		};

		Rectangle.prototype.draw = function () {
			this.canvas().element.beginPath();
			this.canvas().element.fillRect(this._x, this._y, this._width, this._height);
			this.canvas().element.fillStyle = this._color;
			this.canvas().element.fill();

		};

		return Rectangle;
	}());




	// Class Triangle
	var Triangle = (function() {
		function Triangle(x, y, color, p1, p2) {
			Shape.apply(this, arguments);
			this._p1 = p1;
			this._p2 = p2;
		}

		Triangle.prototype = Object.create(Shape.prototype);
		Triangle.prototype.toString = function () {
			return Shape.prototype.toString.call(this) + ", p1=" + this._p1.toString() + ", p2=" + this._p2.toString();
		};

		Triangle.prototype.draw = function () {
			this.canvas().element.beginPath();
			this.canvas().element.moveTo(this._x, this._y);
			this.canvas().element.lineTo(this._p1._x, this._p1._y);
			this.canvas().element.lineTo(this._p2._x, this._p2._y);
			this.canvas().element.fillStyle = this._color;
			this.canvas().element.fill();
		};

		return Triangle;
	}());


	var  Segment = (function() {
		function Segment(x, y, color, p2) {
			Shape.apply(this, arguments);
			this._p2 = p2;
		}

		Segment.prototype = Object.create(Shape.prototype);
		Segment.prototype.toString = function () {
			return Shape.prototype.toString.call(this) + ", p2=" + this._p2.toString();
		};

		Segment.prototype.draw = function () {
			this.canvas().element.beginPath();
			this.canvas().element.moveTo(this._x, this._y);
			this.canvas().element.lineTo(this._p2._x, this._p2._y);
			this.canvas().element.stroke();
		};

		return Segment;
	}());

	// Class Point
	var Point = (function () {
		function Point(x, y) {
			this._x = x;
			this._y = y;
		}

		Point.prototype = Object.create(Shape.prototype);

		Point.prototype.toString = function () {
			return "(" + this._x + ", " + this._y + ")";
		};

		Point.prototype.draw = function () {
			this.canvas().element.beginPath();
			this.canvas().element.arc(this._x, this._y, 2, 0, 2*Math.PI)
			this.canvas().element.fillStyle = "#000000";
			this.canvas().element.fill();
		};

		return Point;
	}());

	return{
		Shape: Shape,
		Circle: Circle,
		Rectangle: Rectangle,
		Triangle: Triangle,
		Segment: Segment,
		Point: Point
	};
}());


/*
var fig = new Shapes.Shape(3, 2, "#555");
var krug = new Shapes.Circle(1, 2, "#258745", 5);
var rect = new Shapes.Rectangle(1, 5, "#FFF", 20, 30);

var p1 = new Shapes.Point(2, 3);
var p2 = new Shapes.Point(8, 5);
var p3 = new Shapes.Point(1, 2);
var trian = new Shapes.Triangle(2, 4, "#000000", p1, p2, p3);

console.log(fig.toString());
console.log(krug.toString());
console.log(rect.toString());
console.log(trian.toString());*/
