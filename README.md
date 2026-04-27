# 4.2.-Movimiento-en-el-espacio-tridimensional
# README - Videojuego 3D Unity Helix Jump

## Descripción del Proyecto

Este proyecto consiste en el desarrollo de un videojuego en tercera dimensión realizado en Unity, inspirado en la dinámica de Helix Jump. El jugador controla una esfera que avanza rebotando sobre plataformas mientras aumenta la puntuación.

El objetivo principal es obtener la mayor cantidad de puntos posibles y superar el récord guardado.

---

## Características Principales

- Movimiento del personaje en espacio tridimensional.
- Sistema de rebote automático.
- Puntuación en tiempo real.
- Guardado de HighScore.
- Niveles progresivos.
- Curva de dificultad automática.
- Cámara que sigue al jugador.
- Compatible para Android.

---

## Scripts Utilizados

### PlayerBall.cs
Controla el movimiento de la esfera y los saltos.

### GameManager.cs
Administra:

- Score
- HighScore
- Niveles
- Guardado de datos
- Dificultad progresiva

### TowerSpawner.cs
Genera plataformas aleatorias en el escenario.

### CameraFollow.cs
Hace que la cámara siga al jugador.

---

## Requisitos

- Unity Hub
- Unity versión 2021 o superior
- Visual Studio Code o Visual Studio

---

## Instalación

1. Abrir Unity Hub.
2. Crear nuevo proyecto 3D.
3. Importar scripts.
4. Crear esfera como jugador.
5. Crear plataformas.
6. Asignar scripts correspondientes.
7. Ejecutar proyecto.

---

## Controles

- Click izquierdo o toque en pantalla:
  Hace saltar la esfera.

---

## Sistema de Dificultad

Cada 10 puntos:

- Aumenta el nivel.
- Incrementa velocidad del juego.
- Mayor reto para el jugador.

---

## Guardado de Datos

Se utiliza `PlayerPrefs` para guardar:

- HighScore
- Nivel alcanzado

---

## Resultado Esperado

Un videojuego funcional tipo arcade 3D con progresión de dificultad y almacenamiento de récord.

---

## Autor

Proyecto académico desarrollado en Unity.
