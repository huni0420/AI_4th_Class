class Rectangle{
	private int x,y,width,height;
	private String name;
	public Rectangle(int x, int y, int width,int height,String name) {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
		this.name = name;
	}
	public void show() {
		System.out.println("("+x+","+y+")에서 크기가 "+width+" X "+height+"인 사각형");
		System.out.println(name+"의 넓이는 "+width*height);
	}
	public boolean contains(Rectangle t) {
		if(t.x>this.x && t.y>this.y) {
			if(t.height+t.y<this.height+this.y && t.width+t.x<this.width+this.x)
				return true;
		}
			return false;
	}	
}
public class problem_class04 {
	
	public static void main(String[] args) {
		Rectangle r = new Rectangle(2, 2, 8, 7,"사각형 r");
		Rectangle s = new Rectangle(5, 5, 6, 6,"사각형 s");
		Rectangle t = new Rectangle(1, 1, 10, 10,"사각형 t");
		
		r.show();
		s.show();
		if(t.contains(r))System.out.println("t는 r을 포함합니다.");
		if(t.contains(s))System.out.println("t는 s를 포함합니다.");
	}
}
