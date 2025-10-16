class Node:
    def __init__(self, data):
        self.data = data
        self.children = []

    def add_child(self, child):
        self.children.append(child)

    def print_tree(self, level=0):
        print(" " * (level * 4) + "|-- " + self.data)
        for child in self.children:
            child.print_tree(level + 1)


# Construcción del árbol
root = Node("Root")

# Documentos
documentos = Node("Documentos")
escuela = Node("Escuela")
trabajo = Node("Trabajo")
documentos.add_child(escuela)
documentos.add_child(trabajo)

# Imágenes
imagenes = Node("Imágenes")
vacaciones = Node("Vacaciones")
familia = Node("Familia")
imagenes.add_child(vacaciones)
imagenes.add_child(familia)

# Agregamos ramas al root
root.add_child(documentos)
root.add_child(imagenes)

# Mostrar el árbol
root.print_tree()
