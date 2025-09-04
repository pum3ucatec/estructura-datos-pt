# Ejamplo de diagrama para ....

```mermaid
flowchart TD

A[Inicio] --> B[Crear nodo nuevo]
B --> C{posicion == 0?}

C -- Sí --> D[Enlazar nuevo.Siguiente = cabeza]
D --> E[Actualizar cabeza = nuevo]
E --> F[Fin]

C -- No --> G[actual = cabeza, indice = 0]
G --> H{actual != null y indice < posicion - 1?}

H -- Sí --> I[actual = actual.Siguiente<br/>indice++]
I --> H

H -- No --> J{actual == null?}
J -- Sí --> K[Posición fuera de rango<br/>Console.WriteLine]
K --> F

J -- No --> L[Enlazar nuevo.Siguiente = actual.Siguiente]
L --> M[actual.Siguiente = nuevo]
M --> F[Fin]

```

# Ejemplo de datos

flowchart LR
    H["HEAD"]:::head --> A["A"]:::nodo
    A --> B["B"]:::nodo
    B --> C["C"]:::nodo
    C --> D["D"]:::nodo
    D --> N["null"]:::null

    classDef head fill:#2196F3,stroke:#0D47A1,color:#fff,stroke-width:2px;
    classDef nodo fill:#4CAF50,stroke:#2E7D32,color:#fff,stroke-width:2px;
    classDef null fill:#F44336,stroke:#B71C1C,color:#fff,stroke-width:2px;
