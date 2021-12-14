$(
function()
{
    //모든코드 한번에 변경 ctrl+f2
    const name = $('#name')
    const gen = $('#gen')
    const beonho = $('#beonho')

    const print = $('#print')
    const reset = $('#reset')
    const printOrderBy = $('#printOrderBy')
    const information = $('#information')
    
    function resetInfo()
    {
        //information.innerHTML = '' //화면 리셋해주기
        information.html('')
    }

    reset.on('click',function()
    {
        resetInfo() // 화면 리셋
        students =[] // 배열 리셋
    })

    print.on('click',function()
    {
        let student = new Student(name.val(), gen.val(), beonho.val())
        let newStudentInfo = $('<h1></h1>')
        newStudentInfo.text(student.toString())
        if(student.gender == "남")
        {
            newStudentInfo.css('background-color','springgreen').css('color','blue')
            //newStudentInfo.style.backgroundColor = 'green'
            //newStudentInfo.style.color = 'blue'
            
        }
        else
        {
            newStudentInfo.css('background-color','black').css('color','pink')
            //newStudentInfo.style.backgroundColor = 'black'
            //newStudentInfo.style.color = 'pink'
        }
        information.append(newStudentInfo)
    })
    printOrderBy.on('click',function()
    {
        //findIndex
        //indexOf랑 좀 유사한 건데... 주로 객체배열에서 쓰임
        //객체 배열상에서 내가 원한느 객체의 인데스를 찾는데, 콜백함수 이용함
        //이 함수가 true일때 리턴하는 조건을 만족하는 부분의 인덱스값 리턴해줌
        //만족하는 조건이 없을경우 -1을 리턴해줌
        const idx = students.findIndex(
            function(item){
                return item.number === Number(beonho.val())
            }
        )
        if(idx != -1)
        {
            alert('번호 중복')
            return
        }

        resetInfo()//기존에 있던것들 싹 지움
        students.push(new Student(name.val(), gen.val(), Number(beonho.val())))
        //Sort
        //콜백함수 이용 값이 양수, 0, 음수냐에 따라서 정렬됨
        students.sort(function(a,b){
            return a.number-b.number
        })

        for(let i = 0; i<students.length; i++)
        {
            let newStudentInfo = $('<h1></h1>')
            newStudentInfo.text(student[i].toString())
            if(students[i].gender == "남")
            {
            newStudentInfo.css('background-color','springgreen').css('color','blue')
            //newStudentInfo.style.backgroundColor = 'green'
            //newStudentInfo.style.color = 'blue'
            
            }
            else
            {
            newStudentInfo.css('background-color','black').css('color','pink')
            //newStudentInfo.style.backgroundColor = 'black'
            //newStudentInfo.style.color = 'pink'
            }
            information.append(newStudentInfo)
        }
    })
})