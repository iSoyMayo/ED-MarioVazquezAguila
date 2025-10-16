### **Actividad 1: Construcción**
Crea una clase Node con atributos data y children.
Construye un árbol que represente el sistema de carpetas:
```
Root
 ├── Documentos
 │    ├── Escuela
 │    └── Trabajo
 └── Imágenes
      ├── Vacaciones
      └── Familia
```
Implementa un método print_tree() para mostrarlo jerárquicamente.

### **Actividad 2: Árbol binario**

Estructura visual:

```
        A
       / \
      B   C
     / \   \
    D   E   F
```

1. Implementa la clase `NodoBinario`.
2. Crea el árbol del ejemplo anterior (A–F).
3. Implementa e imprime los recorridos:

   * Preorden
   * Inorden
   * Postorden

### **Actividad 3**

Agrega un método a `NodoBinario` que calcule la **altura** del árbol:

```python
def altura(nodo):
    if nodo is None:
        return 0
    return 1 + max(altura(nodo.izquierdo), altura(nodo.derecho))
```
