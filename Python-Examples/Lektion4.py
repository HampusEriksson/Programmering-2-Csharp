
# Enkel funktion utan returvärde
def greet(name):
    print(f"Hej {name}!")

print(greet("whatever"))

# Funktion med returvärde
def add(a, b):
    return a + b

result = add(3, 5)
print(f"Summan är: {result}")

# Funktion med standardvärden
def greet_with_time(name, time_of_day="dag"):
    print(f"God {time_of_day}, {name}!")

greet_with_time("Alice", "morgon")
greet_with_time("Bob")
