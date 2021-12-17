<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
<head>
    <title>JSP - Hello World</title>
    <style>
        *{
            margin:0;
            padding:0;
        }
        body{
            text-align: center;
            background: linear-gradient(#dec8f0, #90b7bd);
        }
        .boxOffice{
            width: 500px;
            margin: 20px auto;
            padding: 5px;
            border: 3px dotted #fff;

        }
        ul {
            width: 100%;
            padding: 8px;
            list-style-position: inside;
            text-align: left;
            list-style-type: none;
        }
        ul li {
            width: 92%;
            margin: 5px 0;
            background: rgb(189, 235, 212);
            padding : 5px 10px;
            cursor: pointer;
        }
        ul li:hover {
            background: rgb(240, 232, 128);
        }
    </style>
</head>
<body>
<%--<div id="center">--%>
<%--아이디<input type="text" ><br>--%>
<%--패스워드<input type="text" ><br>--%>
<%--패스워드확인<input type="text" ><br>--%>
<%--취미<input type="radio" ><br>--%>
<%--성별<input type="checkbox"><br>--%>
<%--</div>--%>
<h1>영화 박스오피스 TOP 10</h1>
<p>최신 영화 박스오피스 순위를 알려 드립니다.</p>
<div class="boxOffice">
    <h2 class="boxOfficeType"></h2>
    <p class="showRange"></p>

    <ul class="boxOfficeList"></ul>
</div>
<script>
    window.addEventListener('load', () => {
        const key= "43acf2413769000d8f1218245a94a6ba";
        //어제 날짜 구하기(하루전 데이터를 가져온다)
        let y = ( d => new Date(d.setDate(d.getDate() -1)))(new Date);
        // y = y.getFullYear()+""+(y.getMonth()+1)+""+ y.getDate();
        var month = y.getMonth();
        //month의 특징
        //현재가 1월이면 0을 준다.
        //현재가 12월이면 11을 준다. 즉 현재 월보다 -1 한 숫자를 준다.
        if(Number(month)<9) //현재가 1월부터 9월인 경우
        {
            month = '0'+(Number(month)+1);
        }
        var day = y.getDate();
        if(Number(day)<9)
        {
            day = '0'+(Number(day)+1);

        }
        y = y.getFullYear()+""+month+""+ day;
        console.log(y);
        const date = y; //어제 날짜를 넣어 준다.
        const apiUrl = `http://www.kobis.or.kr/kobisopenapi/webservice/rest/boxoffice/searchDailyBoxOfficeList.json?key=${key}&targetDt=${date}`;
        console.log(apiUrl);
        const boxOfficeType = document.querySelector('.boxOfficeType');
        const showRange = document.querySelector('.showRange');
        const myUl = document.querySelector('.boxOfficeList');


        fetch(apiUrl)
            .then((response) => {
                    if(!response.ok)
                        throw new Error('400 or 500 error')

                    return response.json()
                }
            )
            .then((result)=>{
                console.log(result)
                const jsonObj = result//JSON.parse(xhr.response);
                //console.log(jsonObj);

                const boxOfficeResult = jsonObj['boxOfficeResult'];
                boxOfficeType.textContent = boxOfficeResult['boxofficeType'];
                showRange.textContent = boxOfficeResult['showRange'];

                const movieList = boxOfficeResult['dailyBoxOfficeList'];
                movieList.forEach(element => {
                    //화면 디자인에 따라 필요한 DOM 요소들을 생성해 준다.
                    const myLi = document.createElement('li');
                    const myDiv = document.createElement('Div');
                    const mh2 = document.createElement('h2');
                    const mp1 = document.createElement('p');
                    const mp2 = document.createElement('p');
                    const mp3 = document.createElement('p');
                    //영화명/개봉일/누적관객수/순위변동
                    mh2.textContent = element['movieNm'];
                    mp1.textContent = "개봉일: " + element['openDt'];
                    mp2.textContent = "누적 관객수: " + element['audiAcc'];
                    mp3.textContent = "순위 변동: " + element['rankInten'];
                    //DOM 추가하기
                    myLi.appendChild(myDiv);
                    myDiv.appendChild(mh2)
                    myDiv.appendChild(mp1)
                    myDiv.appendChild(mp2)
                    myDiv.appendChild(mp3)
                    myUl.appendChild(myLi);
                });
            }).catch(()=>{console.log("error")})





    });

</script>
</body>
</html>