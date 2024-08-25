
# While-loop
counter = 0
while counter < 5:
    print(f"While loop, iteration {counter}")
    counter += 1

# For-loop över en lista
fruits = ["äpple", "banan", "körsbär"]
for fruit in fruits:
    print(f"For loop, frukt: {fruit}")

# For-loop med range
for i in range(5):
    print(f"For loop med range, iteration {i}")

# Dictionary (motsvarande Dictionary i C#)
person = {
    "name": "Alice",
    "age": 25,
    "city": "Stockholm"
}

# Loop genom dictionary
for key, value in person.items():
    print(f"Nyckel: {key}, Värde: {value}")
