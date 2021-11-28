from Movie import *

class Movie:
    movie_list = []
    def MovieStart():
        while 1:
            start = input("영화를 선택 하시겠습니까 (1.시작 2.취소)")
            if start == "1":
                Movies.MovieSelect(start)
            elif start == "2":
                break
            else:
                print("잘못입력하셨습니다.")
                continue

Movie.MovieStart()