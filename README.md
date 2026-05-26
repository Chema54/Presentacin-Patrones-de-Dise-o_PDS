# Presentación de Patrones de Diseño - Equipo 8

Este repositorio contiene los ejemplos prácticos de código en C# correspondientes a la exposición de los patrones de diseño creacionales **Builder** y **Abstract Factory**, así como un ejemplo que combina ambos.

---

## Patrones Implementados

El proyecto está dividido en submódulos que aíslan y demuestran cada patrón de diseño de forma progresiva:

1. **Builder (`BuilderEjemplo`)**
   * **Problema que resuelve:** Permite la construcción paso a paso de objetos (en este caso, la creación detallada de entidades `Person` y `Student`), evitando constructores gigantescos ("telescópicos") y permitiendo diferentes representaciones del mismo proceso de construcción a través de un `Director`.

2. **Abstract Factory (`AbstractFactoryEjemplo` / `AbstractFactory`)**
   * **Problema que resuelve:** Proporciona una interfaz para crear familias de objetos relacionados o dependientes (`ISilla` y `IMesa`) sin especificar sus clases concretas. Garantiza que los productos de un mismo estilo (Minimalista o Victoriano) no se mezclen entre sí, asegurando consistencia estética.

3. **Combinación Avanzada (`AbstractBuilderFactory`)**
   * **Problema que resuelve:** Resuelve el escenario donde una fábrica abstracta necesita devolver productos. En lugar de usar un simple `new`, la fábrica concreta delega el trabajo y la personalización de las piezas a un `Builder` específico antes de regresar los muebles indicados.

---

## Tecnologías y Versiones Usadas

* **Lenguaje:** C# 10 o superior.
* **Framework:** .NET 10.0.
* **Entorno de ejecución:** Multiplataforma (probado y compilado en entornos Linux).

---

## Instalación de Dependencias y Requisitos

Para poder compilar y ejecutar estos proyectos, es necesario tener instalado el SDK de **.NET 10.0**.

### Descarga e Instalación del SDK
Si no cuentas con el entorno de desarrollo listo, puedes descargar los instaladores o binarios para tu distribución de Linux, macOS o Windows directamente desde el sitio oficial de Microsoft:
🔗 [Descargar .NET 10.0](https://dotnet.microsoft.com/es-es/download/dotnet/10.0)

*(Nota: .NET es malvado y seguramente demorará un año en descargarse).*

---

## Instrucciones para Ejecutar los Ejemplos

Dado que el repositorio contiene múltiples proyectos de consola autónomos, debes situarte dentro de la carpeta del ejemplo específico que desees probar antes de lanzar el comando de ejecución.

Abre tu terminal y ejecuta los siguientes comandos según el caso:

| Ejemplo | Comandos |
|----------|----------|
| Builder | `cd BuilderEjemplo && dotnet run` |
| Abstract Factory | `cd AbstractFactoryEjemplo && dotnet run` |
| Combinado | `cd AbstractBuilderFactory && dotnet run` |


