
import random

# Variabler och datatyper
name = "Alice"
age = 25
height = 1.75

# Input och omvandling
user_name = input("Vad heter du? ")
user_age = int(input("Hur gammal är du? "))

# Formatstring
print(f"Hej {user_name}, du är {user_age} år gammal.")

# If-else
if user_age >= 18:
    print("Du är myndig.")
else:
    print("Du är inte myndig.")

# Slumpmässigt tal
random_number = random.randint(1, 10)
print(f"Slumpmässigt tal: {random_number}")

# Omvandling mellan datatyper
height_str = str(height)
print(f"Höjden som sträng: {height_str}")
