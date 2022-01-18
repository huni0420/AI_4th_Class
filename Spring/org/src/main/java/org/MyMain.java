package org;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

/*
 * @Configuration 환경설정
 * 
 * */
public class MyMain {
	public static void main(String[] args) {
		AnnotationConfigApplicationContext acac
		= new AnnotationConfigApplicationContext(MyConf.class);
		
		AA aa1 = acac.getBean(AA.class);
		AA aa2 = acac.getBean(AA.class);
		
		System.out.println("aa1 = "+aa1);
		System.out.println("aa2 = "+aa2);
		aa1.doA();
		
		BB bb1 = acac.getBean(BB.class);
		bb1.doB();
		
		CC cc1 = acac.getBean(CC.class);
		cc1.doCC();
		
		acac.close();
	}
}