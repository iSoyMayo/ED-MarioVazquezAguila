import os
import random
bandera=True

while bandera == True:
   
    print("===============================")
    print("      Estructuras de control     ")
    print("===============================")

    print("1. Determinar si un número es primo")
    print("2. Juego de Numeros Aleatorios   ")
    print("3. Salir                         ")
    print("===============================")

  
    eleccion = int(input("Elige una opción (1-3): "))

    if eleccion >= 1 or eleccion <= 3:
    
        if eleccion == 1:
            Numero = int(input("Ingresa un número: "))

            if Numero > 1:
                Esprimo = True
                for i in range(2, Numero):
                    if Numero % i == 0:
                        Esprimo = False
                        break
                if Esprimo:
                    print(str(Numero) + " es primo ")
                else:
                    print(str(Numero) + " NO es primo ")
            else:
                print(str(Numero) + " NO es primo ")
            input("Presiona Enter para continuar...")
            os.system('cls')
        elif eleccion == 2:
            NumeroAleratorio = random.randint(1, 100)
            Intentos = 5
            print("¡Bienvenido al juego de adivinar el número!")
            print("Tienes", Intentos, "intentos para adivinar el número entre 1 y 100.")
            NumeroSeleccionado = int(input("Ingresa tu primer intento: "))
            for Intentos in range(1, Intentos + 1):
                if NumeroSeleccionado < NumeroAleratorio:
                    print("Demasiado bajo. Intenta de nuevo.")
                elif NumeroSeleccionado > NumeroAleratorio:
                    print("Demasiado alto. Intenta de nuevo.")
                else:
                    print("¡Felicidades! Has adivinado el número", NumeroAleratorio, "en", Intentos, "intentos.")
                    break
                if Intentos == 5:
                    print("Lo siento, has agotado tus intentos. El número era", NumeroAleratorio)
                else:
                    NumeroSeleccionado = int(input("Ingresa tu siguiente intento: "))
            input("Presiona Enter para continuar...")
            os.system('cls')

        if eleccion == 3:
            bandera = False
    else:
        print("Opción inválida. Por favor, elige una opción entre 1 y 3.")
        input("Presiona Enter para continuar...")
        os.system('cls')