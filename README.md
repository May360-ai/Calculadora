# Calculadora

Esta es una simple aplicación de calculadora construida con .NET.

## Estructura del Proyecto

El proyecto está dividido en las siguientes capas:

*   **Calculadora.Dominio:** Contiene las entidades de dominio e interfaces.
*   **Calculadora.Aplicacion:** Contiene la lógica de la aplicación y los servicios.
*   **Calculadora.Infraestructura:** Contiene el código de infraestructura, como el contexto de la base de datos y los repositorios.
*   **Calculadora.WebAPI:** El backend de la aplicación, que expone una API REST.
*   **Calculadora.Frontend:** El frontend de la aplicación, que es una aplicación Blazor WebAssembly.

## Para Empezar

Para ejecutar la aplicación, necesitarás tener instalado el SDK de .NET.

### Backend

1.  Abre una terminal y navega al directorio `Calculadora.WebAPI`.
2.  Ejecuta el siguiente comando:

    ```bash
    dotnet run
    ```

### Frontend

1.  Abre otra terminal y navega al directorio `Calculadora.Frontend`.
2.  Ejecuta el siguiente comando:

    ```bash
    dotnet run
    ```

La aplicación estará disponible en la dirección indicada en la terminal.

## Tecnologías Utilizadas

*   .NET 8
*   ASP.NET Core
*   Entity Framework Core
*   Blazor WebAssembly
*   SQLite