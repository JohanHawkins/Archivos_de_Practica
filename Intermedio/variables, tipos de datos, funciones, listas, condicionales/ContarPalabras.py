#Frase del usuario
frase = input("Por favor ingresa una frase: ")

# Separar la frase en palabras
lista_palabras = frase.split()
print(lista_palabras)

# Función cuántas palabras tienen más de 5 letras
def contar_palabras_largas(palabras):
    contador = 0
    for palabra in palabras:
        if len(palabra) > 5:
            contador += 1
    return contador

# Uso de la función
total_largas = contar_palabras_largas(lista_palabras)

# Mostrar resultado
print("Cantidad de palabras con más de 5 letras:", total_largas)
