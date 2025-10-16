class NodoBinario:
    def __init__(self, data):
        self.data = data
        self.left = None
        self.right = None

def preorden(nodo):
    if nodo:
        print(nodo.data, end=' ')
        preorden(nodo.left)
        preorden(nodo.right)

def inorden(nodo):
    if nodo:
        inorden(nodo.left)
        print(nodo.data, end=' ')
        inorden(nodo.right)

def postorden(nodo):
    if nodo:
        postorden(nodo.left)
        postorden(nodo.right)
        print(nodo.data, end=' ')

def altura(NodoBinario):
    if NodoBinario is None:
        return 0
    return 1 + max(altura(NodoBinario.left), altura(NodoBinario.right))


RamaA = NodoBinario("A")
RamaB = NodoBinario("B")
RamaC = NodoBinario("C")
RamaD = NodoBinario("D")
RamaE = NodoBinario("E")
RamaF = NodoBinario("F")

RamaA.left = RamaB
RamaA.right = RamaC
RamaB.left = RamaD
RamaB.right = RamaE
RamaC.right = RamaF

print("Recorrido en preorden:")
preorden(RamaA)

print("\nRecorrido en inorden:")
inorden(RamaA)

print("\nRecorrido en postorden:")
postorden(RamaA)

print("\nAltura del árbol:", altura(RamaA))