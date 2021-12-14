class Student{
    constructor(name, gender, number)
    {
        this.name = name
        this.gender = gender
        this.number = number
    }
    toString()
    {
        return `${this.name} 학생은 ${this.gender}학생이며 ${this.number}입니다.`
    }
}

let students = []