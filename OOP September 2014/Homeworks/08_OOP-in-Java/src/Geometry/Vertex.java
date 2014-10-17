package Geometry;
public class Vertex {
	private int x;
	private int y;

	public Vertex(int x, int y) {
		this.setX(x);
		this.setY(y);
	}

	public int getX() {
		return x;
	}

	public void setX(int x) {
		if (x < 1) {
			throw new IllegalArgumentException("X cannot be negative.");
		}
		this.x = x;
	}

	public int getY() {
		return y;
	}

	public void setY(int y) {
		if (y < 1) {
			throw new IllegalArgumentException("Y cannot be negative.");
		}
		this.y = y;
	}
}