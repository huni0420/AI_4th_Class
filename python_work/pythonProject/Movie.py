class Movies:
    def SisSelect(TS,TIME):
        Ts = TS
        time = TIME




    def TimeSelect(TS):
        Ts = TS
        if Ts == "a":
            print("14:00  16:00  18:00  21:00")
            time = input("시간 선택 ")
            Movies.SisSelect(Ts,time)
        elif Ts == "b":
            print("14:00  16:00  18:00  21:00")
            time = input("시간 선택 ")
            Movies.SisSelect(Ts,time)
        elif Ts == "c":
            print("14:00  16:00  18:00  21:00")
            time = input("시간 선택 ")
            Movies.SisSelect(Ts,time)
        elif Ts == "d":
            print("14:00  16:00  18:00  21:00")
            time = input("시간 선택 ")
            Movies.SisSelect(Ts,time)
        elif Ts == "e":
            print("14:00  16:00  18:00  21:00")
            time = input("시간 선택 ")
            Movies.SisSelect(Ts,time)
        elif Ts == "f":
            print("14:00  16:00  18:00  21:00")
            time = input("시간 선택 ")
            Movies.SisSelect(Ts,time)
        elif Ts == "g":
            print("14:00  16:00  18:00  21:00")
            time = input("시간 선택 ")
            Movies.SisSelect(Ts,time)

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

