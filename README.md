# 📄 Ziur Software - Prueba Técnica Blazor (.NET 10)

Aplicación desarrollada en **Blazor Web App** para el consumo y visualización de la API REST de documentos de Ziur Software, protegida mediante token Bearer.

---

## 🚀 Características e Implementación
- **Consumo de API REST:** Integración asíncrona usando `HttpClient`, `AuthenticationHeaderValue` y `JsonSerializer`.
- **Inyección de Dependencias:** Registro de `DocumentoService` como cliente tipado (*Typed Client*) en `Program.cs`.
- **Interfaz Interactiva:** Renderizado interactivo (`InteractiveServer`) con filtrado dinámico en tiempo real utilizando **LINQ**.
- **Manejo de Excepciones:** Control de estados HTTP mediante `EnsureSuccessStatusCode()` con retroalimentación visual en la UI.
- **Diseño:** Tabla responsiva en Bootstrap con insignias de estado (badges) y componentes limpios.

---

## 🛠️ Tecnologías Utilizadas
- **Lenguaje:** C#
- **Framework:** .NET 10 / Blazor Web App
- **Estilos:** Bootstrap 5

---

## ⚙️ Instrucciones de Ejecución Local

1. Clonar el repositorio:
   
   git clone https://github.com/Nestor5697/Ziur-Prueba-Tecnica.git


<img width="1910" height="890" alt="Animación" src="https://github.com/user-attachments/assets/d399b9bb-14e8-414e-9250-5d19485f521c" />
