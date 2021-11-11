import AA.Member;

/*
 * 접근제어 지시자
 * 변수랑 메서드
 * public/ protected/ default/ private
 *
 * class public deault
 *
*/

public class ex01 {
	public static void main(String[] args) {
		Member m1 = new Member();
//		m1.name = "asdf";
		m1.setName("홍길동");
		m1.setAge(10);
		m1.print();

		Member m2 = new Member();
//		m1.name = "asdf";
		m2.setName("김길동");
		m2.setAge(20);
		m2.print();

		Member m3 = new Member();
//		m1.name = "asdf";
		m3.setName("이길동");
		m3.setAge(30);
		m3.print();
	}
}
