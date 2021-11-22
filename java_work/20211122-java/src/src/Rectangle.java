public class Rectangle implements Cloneable {
    Point upperLeft;
    Point lowerRight;

    public Rectangle(int x1, int y1, int x2, int y2) {
        this.upperLeft = new Point(x1, y1);
        this.lowerRight = new Point(x2, y2);
    }

    @Override
    protected Object clone() throws CloneNotSupportedException {
        Rectangle r1 = (Rectangle) super.clone();

        r1.upperLeft = (Point) upperLeft.clone();
        r1.lowerRight = (Point) lowerRight.clone();

        return r1;
    }

    @Override
    public String toString() {
        return "Rectangle{" +
                "upperLeft=" + upperLeft +
                ", lowerRight=" + lowerRight +
                '}';
    }
}
