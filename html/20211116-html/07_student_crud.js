function MyStudent(name,age,number)
{
    this.name = name
    this.age = age
    this.number = number
    this.regist = function()
    {
        alert(this.name+ "학생등록 완료")
    }
}


window.onload = function()
{
    let name = document.querySelector('#name')
    let age = document.querySelector("#age")
    let num = document.querySelector('#num')
    
    let create = document.querySelector("#create")
    let read = document.querySelector("#read")
    let update = document.querySelector("#update")
    let delete_a = document.querySelector('#delete')

    let consolelog = document.querySelector("#consolelog")

    let students = []
    create.onclick = function()
    {
        for(let item of students)
        {
            if(item.number == num.value)
            {
                alert("중복 학생 존재")
                return
            }
        }
        let tempStudendt = new MyStudent(name.value, age.value, num.value )
        students.push(tempStudendt)
        tempStudendt.regist()
        console.log(students)
    }
    read.onclick = function()
    {   
        for(let item of students){
            if(num.value == item.number)
            {
                alert(`${item.number}번 학생은 ${item.name}이며 ${item.age}입니다`)
                return
            }
        }
    }
    update.onclick = function()
    {
        for(let item of students){
            if(num.value == item.number)
            {
                item.name = name.value
                item.age = age.value
            }
        }
    }
    delete_a.onclick = function()
    {
        for(let i = 0; i<students.length;i++)
        {
            if(num.value==students[i].number)
            {
                students.splice(i,1)
            }
        }
    }
    consolelog.onclick = function()
    {
        console.log(students)
    }
}