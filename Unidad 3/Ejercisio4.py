calificaciones = {
    "Matemáticas": [90, 85, 88],
    "Programación": [100, 95, 97],
}

for materia, notas in calificaciones.items():
    promedio = sum(notas) / len(notas)
    print(f"{materia}: promedio = {promedio:.2f}")
