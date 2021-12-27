package com.example._20211223jsp.dto;

public class MemberDto {
    private String email;
    private String pwd;
    private String gender;

    public String getMail() {
        return email;
    }

    public void setMail(String email) {
        this.email = email;
    }

    public String getPwd() {
        return pwd;
    }

    public void setPwd(String pwd) {
        this.pwd = pwd;
    }

    public String getGender() {
        return gender;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }

    @Override
    public String toString() {
        return "MemberDto{" +
                "mail='" + email + '\'' +
                ", pwd='" + pwd + '\'' +
                ", gender='" + gender + '\'' +
                '}';
    }
    public MemberDto(){}
    public MemberDto(String email, String pwd, String gender) {
        this.email = email;
        this.pwd = pwd;
        this.gender = gender;
    }
}
