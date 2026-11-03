# Terreno & Avatares 3D - Proyecto Unity

![Unity](https://img.shields.io/badge/Unity-2021.3%2B-blue?logo=unity)
![Render Pipeline](https://img.shields.io/badge/Render%20Pipeline-URP-brightgreen)
![Language](https://img.shields.io/badge/Language-C%23-blueviolet?logo=csharp)
![License](https://img.shields.io/badge/License-MIT-orange)

Proyecto interactivo desarrollado en **Unity 3D** con estilo **Low-Poly** utilizando **URP (Universal Render Pipeline)**. Incluye un mapa esculpido con zonas niveladas, exploración en tercera/primera persona y mecánicas de interacción con objetos y puzles de entorno.

---

## Mecánicas e Interacciones

- **Sistema de Cofres Interactivos:**
  - Acércate a un cofre y presiona `E` para abrirlo.
  - Vuelve a presionar `E` para recolectar el objeto dentro del cofre.
- **Puzle de Apertura de Puertas:**
  - El escenario cuenta con un sistema controlador de eventos (`PuertasController`).
  - Al encontrar y recoger los **3 objetos ocultos** en los cofres, las dos puertas del recinto rotan 90° automáticamente para dar paso a la siguiente área.
- **Entorno Esculpido:**
  - Terreno optimizado y aplanado para la libre navegación del jugador.
  - Materiales y Shaders adaptados a **URP (Universal Render Pipeline)**.

---

## Controles

| Accion | Tecla / Control |
| :--- | :--- |
| **Movimiento** | `W` `A` `S` `D` o Flechas de dirección |
| **Interactuar / Abrir / Recoger** | `E` |
| **Cámara / Mirar** | Ratón |

---

## Estructura del Código Principal

```text
Assets/
 ├── Scripts/
 │    ├── CofreController.cs    # Maneja la apertura del cofre y la recolección del item
 │    └── PuertasController.cs  # Controla el conteo de items y la animación de las puertas
 ├── Prefabs/                   # Modelos Low-Poly de cofres, puertas y accesorios
 └── Scenes/                    # Escenas principales del proyecto
