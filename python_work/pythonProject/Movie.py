class Movies:

    def Prime_Theater(MS,TIME):
        Ms  = MS
        time = TIME


    def Nomal_Theater(MS, TIME):
        Ms = MS
        time = TIME


    def SisSelect(MS,TIME):
        Ms = MS
        time = TIME
        if Ms == "a":
            if time == "14:00" or time=="16:00":
                Movies.Prime_Theater(Ms,time)
            elif time == "18:00" or time=="21:00":
                Movies.Nomal_Theater(Ms,time)
        elif Ms == "b":
            if time == "14:00" or time=="16:00":
                Movies.Nomal_Theater(Ms,time)
            elif time == "18:00" or time=="21:00":
                Movies.Prime_Theater(Ms,time)
        elif Ms == "c":
            if time == "14:00" or time=="16:00":
                Movies.Prime_Theater(Ms,time)
            elif time == "18:00" or time=="21:00":
                Movies.Nomal_Theater(Ms,time)
        elif Ms == "d":
            if time == "14:00" or time=="16:00":
                Movies.Nomal_Theater(Ms,time)
            elif time == "18:00" or time=="21:00":
                Movies.Prime_Theater(Ms,time)
        elif Ms == "e":
            if time == "14:00" or time=="16:00":
                Movies.Prime_Theater(Ms,time)
            elif time == "18:00" or time=="21:00":
                Movies.Nomal_Theater(Ms,time)
        elif Ms == "f":
            if time == "14:00" or time=="16:00":
                Movies.Nomal_Theater(Ms,time)
            elif time == "18:00" or time=="21:00":
                Movies.Prime_Theater(Ms,time)
        elif Ms == "g":
            if time == "14:00" or time=="16:00":
                Movies.Prime_Theater(Ms,time)
            elif time == "18:00" or time=="21:00":
                Movies.Prime_Theater(Ms,time)





    def TimeSelect(MS):
        Ms = MS
        if Ms == "a":
            print("14:00  16:00  18:00  21:00")
            time = input("시간 선택 ")
            Movies.SisSelect(Ms,time)
        elif Ms == "b":
            print("14:00  16:00  18:00  21:00")
            time = input("시간 선택 ")
            Movies.SisSelect(Ms,time)
        elif Ms == "c":
            print("14:00  16:00  18:00  21:00")
            time = input("시간 선택 ")
            Movies.SisSelect(Ms,time)
        elif Ms == "d":
            print("14:00  16:00  18:00  21:00")
            time = input("시간 선택 ")
            Movies.SisSelect(Ms,time)
        elif Ms == "e":
            print("14:00  16:00  18:00  21:00")
            time = input("시간 선택 ")
            Movies.SisSelect(Ms,time)
        elif Ms == "f":
            print("14:00  16:00  18:00  21:00")
            time = input("시간 선택 ")
            Movies.SisSelect(Ms,time)
        elif Ms == "g":
            print("14:00  16:00  18:00  21:00")
            time = input("시간 선택 ")
            Movies.SisSelect(Ms,time)

    def MovieSelect(self):
        A = "a"
        B = "b"
        C = "c"
        D = "d"
        E = "e"
        F = "f"
        G = "g"
        print("A=a, B=b, C=c, D=d, E=e, F=f, G=g")
        select = input("영화를 선택하세요")
        if select == A:
            print("a선택되었습니다.")
            Movies.TimeSelect(select)
        elif select == B:
            print("b선택되었습니다.")
            Movies.TimeSelect(select)
        elif select == C:
            print("c선택되었습니다.")
            Movies.TimeSelect(select)
        elif select == D:
            print("d선택되었습니다.")
            Movies.TimeSelect(select)
        elif select == E:
            print("e선택되었습니다.")
            Movies.TimeSelect(select)
        elif select == F:
            print("f선택되었습니다.")
            Movies.TimeSelect(select)
        elif select == G:
            print("g선택되었습니다.")
            Movies.TimeSelect(select)

