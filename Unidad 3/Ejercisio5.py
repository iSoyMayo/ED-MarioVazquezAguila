from collections import Counter

texto = "Python es divertido y Python es poderoso. Programar en Python es genial"

palabras = texto.lower().replace(".", "").split()

# Contar con Counter
conteo = Counter(palabras)

print("Conteo de palabras:")
for palabra, cantidad in conteo.items():
    print(f"{palabra}: {cantidad}")
