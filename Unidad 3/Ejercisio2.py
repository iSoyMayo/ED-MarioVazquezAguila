texto = "hola mundo hola python mundo"
contador = {}
for palabra in texto.split():
    if palabra in contador:
        contador[palabra] += 1
    else:
        contador[palabra] = 1
print(contador)