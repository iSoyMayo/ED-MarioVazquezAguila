# Diccionario para almacenar contactos
contactos = {}

def agregar_contacto():
    nombre = input("Ingrese el nombre del contacto: ")
    numero = input("Ingrese el número del contacto: ")
    contactos[nombre] = numero
    print(f"✅ Contacto '{nombre}' agregado correctamente.")

def buscar_contacto():
    nombre = input("Ingrese el nombre del contacto a buscar: ")
    if nombre in contactos:
        print(f"📞 {nombre}: {contactos[nombre]}")
    else:
        print("⚠️ Contacto no encontrado.")

def eliminar_contacto():
    nombre = input("Ingrese el nombre del contacto a eliminar: ")
    if nombre in contactos:
        del contactos[nombre]
        print(f"🗑️ Contacto '{nombre}' eliminado correctamente.")
    else:
        print("⚠️ Contacto no encontrado.")

# Menú principal
while True:
    print("\n--- 📒 Menú de Contactos ---")
    print("1. Agregar contacto")
    print("2. Buscar contacto")
    print("3. Eliminar contacto")
    print("4. Mostrar todos los contactos")
    print("5. Salir")

    opcion = input("Seleccione una opción: ")

    if opcion == "1":
        agregar_contacto()
    elif opcion == "2":
        buscar_contacto()
    elif opcion == "3":
        eliminar_contacto()
    elif opcion == "4":
        if contactos:
            print("\n📋 Lista de contactos:")
            for nombre, numero in contactos.items():
                print(f"- {nombre}: {numero}")
        else:
            print("⚠️ No hay contactos guardados.")
    elif opcion == "5":
        print("👋 Saliendo del programa...")
        break
    else:
        print("❌ Opción no válida, intente de nuevo.")
