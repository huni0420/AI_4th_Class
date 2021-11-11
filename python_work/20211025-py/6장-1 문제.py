print("1번문제")
st = "The Espresso Spirit"
print(st.upper())
print(st.lower())

print()
print("2번문제")

def birth_only(birth):
    a = birth.split("-")
    return a[0]
a = birth_only("070609-2011xxx")
print(a)
a = birth_only("090716-1012xxx")
print(a)

# birthonly = "090716-1012xxx"
# a = birthonly.split("-")
# print(a)