
# Lista (motsvarande array i C#)
numbers = [1, 2, 3, 4, 5]
print(f"Första talet i listan: {numbers[0]}")

# Lägg till ett element i listan
numbers.append(6)
print(f"Lista efter append: {numbers}")

# Dictionary (motsvarande Dictionary i C#)
person = {
    "name": "Alice",
    "age": 25,
    "city": "Stockholm"
}
print(f"Personens namn: {person['name']}")

# Lägg till ett nyckel-värde par
person["job"] = "lärare"
print(f"Uppdaterad dictionary: {person}")

# Loop genom dictionary
for key, value in person.items():
    print(f"Nyckel: {key}, Värde: {value}")
