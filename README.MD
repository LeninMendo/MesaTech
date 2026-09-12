<h1 align="center"> MesaTech 🗃️</h1>
<h3 align="center"> Gestor dinámico de tickets para soporte académico</h1>

🧰 Herramientas usadas

[![Tools](https://skillicons.dev/icons?i=cs,git,visualstudio,github,&theme=light)](https://skillicons.dev)


## 1. Descripción del Problema
La empresa ficticia MesaTech brinda soporte tecnológico a laboratorios académicos. Los estudiantes y docentes reportan incidencias como fallas de teclado, problemas de acceso a software, equipos sin conexión, solicitudes de instalación o préstamos de accesorios. Actualmente los tickets se registran en notas sueltas, por lo que se pierden solicitudes, se atienden fuera de orden y no existe una forma clara de eliminar o buscar un ticket ya resuelto.

El equipo desarrollará un prototipo usando C# que utilice una lista enlazada simple para registrar, recorrer, buscar y eliminar tickets. El caso se desarrolla completamente en esta única guía de laboratorio; por ello, el equipo debe analizar el problema, diseñar la estructura, implementar la solución, ejecutar pruebas y comunicar resultados como un único producto de aprendizaje. No se debe plantear como trabajo pendiente para semanas o sesiones posteriores.

---

## 2. Requerimient0s del caso
- Crear una clase Nodo que almacene como mínimo: código del ticket, descripción, prioridad y referencia al siguiente nodo.
- Crear una clase ListaEnlazadaTickets con el atributo cabeza o head.
- Permitir registrar tickets nuevos al final de la lista.
- Permitir listar todos los tickets registrados en el orden en que fueron ingresados.
- Permitir buscar un ticket por código.
- Permitir eliminar un ticket por código, considerando si está al inicio, al medio o no existe.
- Permitir contar la cantidad total de tickets activos.
- Validar que no se registre un ticket con código vacío o repetido.
- Mostrar mensajes claros cuando la lista esté vacía, cuando se encuentre un ticket o cuando no exista.


## 3. Diagrama de la lista enlazada simple

```
HEAD
 ↓
[Nodo T001] → [Nodo T002] → [Nodo T003] → null
```

### ¿Qué información tendrá cada ticket?

Cada ticket se representará como un nodo en la lista enlazada simple, conteniendo la siguiente información:

| Dato        | Ejemplo                      |
| ----------- | ---------------------------- |
| Código      | T001                         |
| Descripción | Teclado no funciona          |
| Prioridad   | Alta                         |
| Siguiente   | Referencia al siguiente nodo |

Y en codigo seguira esta esta estructura:

```
Nodo
 ├── Codigo
 ├── Descripcion
 ├── Prioridad
 └── Siguiente

 ```

 ## Ejemplo de conexión de nodos

 ```
 Cabeza
  ↓
┌──────────────┐
│ T001         │
│ Teclado      │
│ Alta         │
│ Siguiente ─────────┐
└──────────────┘     ↓
                ┌──────────────┐
                │ T002         │
                │ Sin Internet │
                │ Media        │
                │ Siguiente ────────┐
                └──────────────┘     ↓
                                ┌──────────────┐
                                │ T003         │
                                │ Instalación  │
                                │ Baja         │
                                │ Siguiente ──→ null
                                └──────────────┘
```