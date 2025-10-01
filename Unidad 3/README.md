# 📘 Ejercicios con Diccionarios en Python

Este repositorio contiene varios ejercicios prácticos donde se aplican las operaciones básicas con **diccionarios en Python**.  
Los diccionarios son estructuras de datos que permiten almacenar información en forma de pares **clave → valor**.

---

## 🚀 Ejercicios Realizados

### 1. Diccionario `alumno`
Se creó un diccionario llamado **`alumno`** con las claves `nombre`, `edad` y `carrera`.  
Luego se imprimió cada clave y su valor en el formato solicitado.

```python
# Crear el diccionario alumno
alumno = {
    "nombre": "Ana",
    "edad": 21,
    "carrera": "Ingeniería en Sistemas"
}

# Imprimir cada clave y valor
for clave, valor in alumno.items():
    print(f"{clave}: {valor}")
📌 Salida esperada:
```

makefile
Copiar código
nombre: Ana
edad: 21
carrera: Ingeniería en Sistemas

---

## 2. Conteo de palabras `.split()`
Se explicó y ejemplificó el uso del método .split(), que permite dividir cadenas en partes y devolver una lista.

```python

texto = "hola mundo hola python mundo"
# Resultado esperado:
# {"hola": 2, "mundo": 2, "python": 1}```

```
---

# 3. Agenda telefonica 
Se desarrolló un programa que utiliza un diccionario de contactos.
Las operaciones implementadas son:

Agregar un contacto.

Buscar un contacto por nombre.

Eliminar un contacto existente.

Mostrar todos los contactos guardados.

```python
# Diccionario de contactos
contactos = {}

def agregar_contacto(nombre, numero):
    contactos[nombre] = numero
    print(f"✅ Contacto '{nombre}' agregado.")

def buscar_contacto(nombre):
    if nombre in contactos:
        print(f"📞 {nombre}: {contactos[nombre]}")
    else:
        print("⚠️ Contacto no encontrado.")

def eliminar_contacto(nombre):
    if nombre in contactos:
        del contactos[nombre]
        print(f"🗑️ Contacto '{nombre}' eliminado.")
    else:
        print("⚠️ Contacto no encontrado.")
```
# Ejemplo de uso
agregar_contacto("Ana", "5544332211")
agregar_contacto("Luis", "5522113344")

buscar_contacto("Ana")
eliminar_contacto("Luis")
buscar_contacto("Luis")
📌 Salida esperada:

perl
Copiar código

✅ Contacto 'Ana' agregado.

✅ Contacto 'Luis' agregado.

📞 Ana: 5544332211

🗑️ Contacto 'Luis' eliminado.

⚠️ Contacto no encontrado.
---
# 🎯 Objetivo
Comprender cómo se crean y manipulan los diccionarios en Python.

Aplicar métodos comunes (.items(), .keys(), .values(), del) para trabajar con ellos.

Resolver problemas prácticos usando diccionarios como base de almacenamiento.
---
📌 Conclusión
Los diccionarios son una de las estructuras más útiles en Python, ya que permiten guardar información asociada a una clave y acceder a ella de forma rápida y sencilla.
Los ejercicios realizados demuestran su uso desde lo más básico (crear un diccionario) hasta una aplicación práctica (agenda de contactos).