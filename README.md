# Cube Intersection API

Este proyecto implementa una Web API en ASP.NET Core para determinar si dos cubos en un espacio 3D se intersectan y calcular el volumen de intersección. La solución ha sido diseñada siguiendo principios de arquitectura limpia, separación de responsabilidades y buenas prácticas de desarrollo en .NET, aplicando principios de Domain-Driven Design (DDD).

---

## Arquitectura

La solución está dividida en las siguientes capas:

### **1. Dominio (`Domain`)**

Contiene las entidades y la lógica asociada.

Incluye:
* Entidad `Cube`
* Objeto `Point3D`

El dominio no depende de ninguna otra capa, permitiendo test unitarios muy precisos y rápidos.

### **2. Aplicación (`Application`)**

Orquesta el flujo entre las peticiones de la API y la lógica del dominio.

Incluye:
* Servicio `IntersectionApplicationService`
* Servicio `IntersectionCalculator`

Separamos esta capa para:

* Convertir datos de entrada en entidades de dominio
* Manejar validaciones y orquestación

### **3. Distribución (`WebApi`)**

Implementación de la API real que expone el servicio.

Incluye:
* DTOs para entrada y salida
* Controlador `CubeIntersectionController`
* Inyección de dependencias

Este es el punto de entrada al programa.

---

### Ventajas

* Separación de responsabilidades
* Testabilidad
* Escalabilidad

---

## 🧪 Pruebas Unitarias

Las pruebas usan `xUnit` y cubren:

* Intersección de dos cubos
* Varias intersecciones simultáneas
* Casos límite (sin intersección)
