package Geometry;

import Geometry.PlaneShapes.Circle;
import Geometry.PlaneShapes.PlaneShape;
import Geometry.PlaneShapes.Rectangle;
import Geometry.PlaneShapes.Triangle;
import Geometry.SpaceShape.Cuboid;
import Geometry.SpaceShape.SpaceShape;
import Geometry.SpaceShape.Sphere;
import Geometry.SpaceShape.SquarePyramid;

public class PlayWithShapes {

	public static void main(String[] args) {
		Vertex[] triangle = new Vertex[3];
		triangle[0] = new Vertex(3, 4);
		triangle[1] = new Vertex(5, 6);
		triangle[2] = new Vertex(6, 4);
		
		PlaneShape trian = new Triangle(triangle);
		System.out.println("Triangle area: " + trian.getArea());
		System.out.println("Triangle perimeter: " + trian.getPerimeter());
		System.out.println();
		
		Vertex[] rectVertex = new Vertex[1];
		rectVertex[0] = new Vertex(3, 4);
		PlaneShape rect = new Rectangle(rectVertex, 5, 5);
		System.out.println("Rectangle area:  " + rect.getArea());
		System.out.println("Rectangle perimeter: " + rect.getPerimeter());
		System.out.println();
		
		Vertex[] cirVertex = new Vertex[1];
		cirVertex[0] = new Vertex(3, 4);
		PlaneShape circle = new Circle(cirVertex, 5);
		System.out.println("Circle area:  " + circle.getArea());
		System.out.println("Circle perimeter: " + circle.getPerimeter());
		System.out.println();
		
		Vertex[] pyramidVertex = new Vertex[1];
		pyramidVertex[0] = new Vertex(5, 6);
		SpaceShape pyramid = new SquarePyramid(pyramidVertex, 8, 10);
		System.out.println("Square pyramid area:  " + pyramid.getArea());
		System.out.println("Square pyramid volume:  " + pyramid.getVolume());
		System.out.println();
		
		Vertex[] cuboidVertex = new Vertex[1];
		cuboidVertex[0] = new Vertex(5, 6);
		SpaceShape cuboid = new Cuboid(cuboidVertex, 10, 5, 30);
		System.out.println("Cuboid area:  " + cuboid.getArea());
		System.out.println("Cuboid volume:  " + cuboid.getVolume());
		System.out.println();
		
		Vertex[] sphereVertex = new Vertex[1];
		sphereVertex[0] = new Vertex(5, 6);
		SpaceShape sphere = new Sphere(sphereVertex, 10);
		System.out.println("Sphere area:  " + sphere.getArea());
		System.out.println("Sphere volume:  " + sphere.getVolume());
		System.out.println();
		
	}

}
