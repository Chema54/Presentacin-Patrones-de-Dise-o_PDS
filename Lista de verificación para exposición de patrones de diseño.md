# Lista de verificación para exposición de patrones de diseño GoF
## Instrucciones para el equipo
Antes de entregar, revisen esta lista completa. Si alguna casilla queda sin marcar, el trabajo todavía no está listo para entregarse.

La entrega debe permitir que el profesor revise el trabajo sin adivinar:
- qué patrones les tocaron,
- dónde están las láminas,
- dónde está el código,
- qué parte dice cada integrante,
- qué fuentes usaron,
- cómo comprobaron que los ejemplos funcionan.
---
# 1. Entregables obligatorios
## 1.1 Presentación
- [V] La presentación fue exportada en formato **PDF**.
- [V] El archivo PDF abre correctamente.
- [V] El nombre del archivo identifica claramente al equipo y los patrones asignados.
- [V] La presentación incluye portada con:
  - [V] nombre de la experiencia educativa,
  - [V] nombre de los integrantes,
  - [V] patrones asignados,
- [V] La presentación incluye una lámina final de **referencias completas**.
- [V] La presentación incluye citas dentro de las láminas, no solo al final.
## 1.2 Repositorio de código
- [V] Se entrega una liga funcional al repositorio.
- [V] El repositorio es público o accesible para el profesor.
- [V] El repositorio contiene ejemplos de implementación para **cada patrón asignado**.
- [V] El repositorio tiene un archivo `README.md`.
- [V] El `README.md` explica:
  - [V] qué patrones se implementan,
  - [V] qué problema resuelve cada ejemplo,
  - [V] cómo ejecutar el proyecto,
  - [V] versión del lenguaje, framework o herramientas usadas,
  - [V] comandos necesarios para instalar dependencias,
  - [V] comandos necesarios para ejecutar los ejemplos.
- [V] El código fue probado antes de entregar.
- [V] El repositorio no contiene archivos innecesarios, temporales o basura.
- [V] El código está organizado por carpetas, paquetes o módulos comprensibles.
- [V] El código fuente tiene nombres de clases, interfaces y métodos coherentes con el patrón explicado.
## 1.3 Guion de exposición
- [ ] Se entrega un guion por escrito.
- [ ] El guion indica **lámina por lámina** qué se dirá.
- [ ] El guion indica **qué integrante habla en cada lámina**.
- [ ] El guion incluye las transiciones entre integrantes.
- [ ] El guion incluye el momento exacto en que se pasa de la teoría a la demostración práctica.
- [ ] El guion está redactado para hablar, no como texto copiado de las diapositivas.
- [ ] El guion evita improvisaciones prolongadas.
- [ ] El guion permite explicar el tema con claridad a compañeros que aún no dominan el patrón.
---
# 2. Cobertura por cada patrón asignado
> Esta sección debe verificarse por separado para cada patrón del equipo.
## Patrón 1: Builder
### 2.1 Identificación del patrón
- [V] Se indica el nombre oficial del patrón según GoF.
- [V] Se indica si el patrón tiene alias o nombres alternativos.
- [ ] Se explica la intención del patrón.
- [V] Se indica su clasificación:
  - [V] creacional,
  - [ ] estructural,
  - [ ] de comportamiento.
- [ ] Se indica su alcance:
  - [ ] clase,
  - [V] objeto.
- [V] Se explica el problema de diseño que motiva el patrón.
- [F] Se explica qué fuerzas, tensiones o cambios hacen necesario aplicar el patrón.
- [V] Se evita presentar el patrón como “receta de código” sin explicar el problema.
### 2.2 Solución propuesta por el patrón
- [V] Se explica la solución general que propone el patrón.
- [V] Se incluye un diagrama UML formal de la estructura del patrón.
- [V] El diagrama UML usa nombres, relaciones y multiplicidades de forma comprensible.
- [V] Se identifican los participantes del patrón.
- [V] Se explica la responsabilidad de cada participante.
- [V] Se explica cómo colaboran los participantes entre sí.
- [V] Se explica qué parte del diseño queda desacoplada.
- [V] Se explica qué elemento del sistema puede variar sin modificar todo el código.
- [V] Se relaciona el patrón con al menos uno de estos principios:
  - [] encapsular lo que varía,
  - [] favorecer composición sobre herencia,
  - [V] programar para interfaces, no para implementaciones.
### 2.3 Consecuencias del patrón
- [V] Se explican ventajas reales de aplicar el patrón.
- [V] Se explican desventajas, costos o riesgos de aplicar el patrón.
- [V] Se indica cuándo conviene usarlo.
- [V] Se indica cuándo **no** conviene usarlo.
- [V] Se advierte si puede convertirse en antipatrón cuando se usa sin necesidad.
- [V] Se mencionan patrones relacionados.
- [V] Se explica brevemente la relación con esos patrones relacionados.
### 2.4 Implementación del patrón
- [V] Se presenta un ejemplo propio de implementación.
- [V] El ejemplo resuelve un problema concreto, no solo muestra clases vacías.
- [V] El ejemplo permite identificar claramente los participantes del patrón.
- [V] El código coincide con el diagrama UML presentado.
- [V] Se muestran fragmentos clave de código en las láminas.
- [V] Las láminas no están saturadas de código completo.
- [V] El código completo está disponible en el repositorio.
- [V] Se explica cómo se ejecuta el ejemplo.
- [V] Se explica qué salida, comportamiento o resultado debe observarse.
- [V] Se demuestra que el patrón realmente resuelve el problema planteado.
---
## Patrón 2: Abstract Factory
### 2.5 Identificación del patrón
- [V] Se indica el nombre oficial del patrón según GoF.
- [V] Se indica si el patrón tiene alias o nombres alternativos.
- [V] Se explica la intención del patrón.
- [V] Se indica su clasificación:
  - [V] creacional,
  - [ ] estructural,
  - [ ] de comportamiento.
- [V] Se indica su alcance:
  - [] clase,
  - [V] objeto.
- [V] Se explica el problema de diseño que motiva el patrón.
- [ ] Se explica qué fuerzas, tensiones o cambios hacen necesario aplicar el patrón.
- [V] Se evita presentar el patrón como “receta de código” sin explicar el problema.
### 2.6 Solución propuesta por el patrón
- [V] Se explica la solución general que propone el patrón.
- [V] Se incluye un diagrama UML formal de la estructura del patrón.
- [V] El diagrama UML usa nombres, relaciones y multiplicidades de forma comprensible.
- [V] Se identifican los participantes del patrón.
- [V] Se explica la responsabilidad de cada participante.
- [V] Se explica cómo colaboran los participantes entre sí.
- [V] Se explica qué parte del diseño queda desacoplada.
- [V] Se explica qué elemento del sistema puede variar sin modificar todo el código.
- [V] Se relaciona el patrón con al menos uno de estos principios:
  - [V] encapsular lo que varía,
  - [ ] favorecer composición sobre herencia,
  - [V] programar para interfaces, no para implementaciones.
### 2.7 Consecuencias del patrón
- [V] Se explican ventajas reales de aplicar el patrón.
- [V] Se explican desventajas, costos o riesgos de aplicar el patrón.
- [V] Se indica cuándo conviene usarlo.
- [V] Se indica cuándo **no** conviene usarlo.
- [V] Se advierte si puede convertirse en antipatrón cuando se usa sin necesidad.
- [V] Se mencionan patrones relacionados.
- [V] Se explica brevemente la relación con esos patrones relacionados.
### 2.8 Implementación del patrón
- [V] Se presenta un ejemplo propio de implementación.
- [V] El ejemplo resuelve un problema concreto, no solo muestra clases vacías.
- [V] El ejemplo permite identificar claramente los participantes del patrón.
- [V] El código coincide con el diagrama UML presentado.
- [V] Se muestran fragmentos clave de código en las láminas.
- [V] Las láminas no están saturadas de código completo.
- [V] El código completo está disponible en el repositorio.
- [V] Se explica cómo se ejecuta el ejemplo.
- [V] Se explica qué salida, comportamiento o resultado debe observarse.
- [V] Se demuestra que el patrón realmente resuelve el problema planteado.
---
# 3. Comparación entre los dos patrones
- [V] Se explica en qué se parecen los dos patrones asignados.
- [V] Se explica en qué se diferencian.
- [V] Se aclara qué problema resuelve cada uno.
- [V] Se evita confundir patrones parecidos.
- [V] Se incluye al menos un criterio para decidir cuándo usar uno y cuándo usar el otro.
- [V] Se explica si ambos patrones podrían combinarse en un mismo diseño.
- [V] Si se pueden combinar, se presenta un ejemplo breve.
- [ ] Si no conviene combinarlos, se explica por qué.
---
# 4. Calidad
## 4.1 Fuentes permitidas
- [V] Se usó como fuente principal el libro de GoF:
  - Gamma, Helm, Johnson y Vlissides, *Design Patterns: Elements of Reusable Object-Oriented Software*.
- [V] Se usó al menos un libro complementario adecuado para licenciatura.
- [V] Las fuentes consultadas son libros especializados, documentación técnica formal o publicaciones académicas.
- [V] No se usaron blogs, videos, páginas genéricas o respuestas de IA como fuente principal.
- [] Si se usó alguna fuente web, se justifica su uso y se cita correctamente.
- [V] Las referencias existen y fueron verificadas.
## 4.2 Citas dentro de las láminas
- [ ] Toda definición importante tiene cita.
- [ ] Toda intención del patrón tiene cita.
- [ ] Todo diagrama adaptado de una fuente tiene cita.
- [ ] Toda afirmación teórica relevante tiene cita.
- [ ] Las citas aparecen en la lámina donde se usa la información.
- [ ] Las citas son consistentes en formato APA, IEEE u otro estilo académico definido por el equipo.
- [ ] No hay referencias inventadas.
- [ ] No hay citas decorativas que no correspondan con lo que se afirma.
## 4.3 Referencias finales
- [V] La presentación tiene una sección final de referencias.
- [V] Las referencias están completas.
- [V] Las referencias incluyen autor, año, título, editorial o fuente.
- [V] Las referencias coinciden con las citas usadas en las láminas.
- [V] No aparecen referencias que no fueron usadas.
- [V] No se omiten fuentes que sí fueron usadas.
---
# 5. Uso responsable de inteligencia artificial
- [V] El equipo verificó que ninguna definición, cita o referencia haya sido inventada por una herramienta de IA.
- [V] El equipo contrastó la información teórica con libros o fuentes formales.
- [V] El equipo no copió texto generado por IA sin revisarlo, corregirlo y fundamentarlo.
- [V] El equipo entiende y puede explicar oralmente todo lo que aparece en las láminas.
- [V] El equipo puede responder de dónde salió cada definición importante.
- [V] El equipo incluye una breve declaración de uso de IA, si la utilizó.
Ejemplo de declaración:
> Para preparar este trabajo se utilizó inteligencia artificial como apoyo para organizar ideas, revisar redacción o generar preguntas de estudio. Las definiciones, citas, diagramas y referencias fueron verificadas contra fuentes bibliográficas formales. El equipo asume la responsabilidad académica completa del contenido presentado.
---
# 6. Calidad de las láminas
- [V] Las láminas tienen poco texto y explican una idea principal por lámina.
- [V] El tamaño de letra permite leer desde el aula.
- [V] Los diagramas se distinguen con claridad.
- [V] Los fragmentos de código son legibles.
- [V] No hay capturas de pantalla borrosas.
- [V] No hay láminas saturadas de texto.
- [V] No se copian párrafos completos de libros o páginas web.
- [V] Las imágenes, diagramas o figuras tomadas/adaptadas de fuentes externas tienen cita.
- [V] La presentación tiene una secuencia lógica:
  - [V] analogía,
  - [V] problema,
  - [V] patrón,
  - [V] estructura,
  - [V] participantes,
  - [V] implementación,
  - [V] demostración,
  - [V] cierre.
---
# 7. Calidad de los diagramas UML
- [V] Cada patrón tiene al menos un diagrama UML de su estructura general.
- [V] Cada implementación tiene al menos un diagrama UML que corresponde al código real.
- [V] Los diagramas distinguen correctamente clases, interfaces, clases abstractas y relaciones.
- [V] Las relaciones UML usadas son correctas:
  - [V] asociación,
  - [ ] dependencia,
  - [V] generalización/herencia,
  - [ ] realización de interfaz,
  - [ ] composición/agregación, si aplica.
- [] Los nombres de clases e interfaces del diagrama coinciden con el código.
- [V] Los métodos principales del patrón aparecen en el diagrama.
- [V] El diagrama no contradice la explicación oral.
- [V] El equipo puede justificar por qué modeló así la solución.
---
# 8. Demostración práctica
- [V] La demostración fue ensayada antes de la clase.
- [V] El equipo puede ejecutar los ejemplos sin depender de configuraciones ocultas.
- [V] El equipo tiene preparado el entorno antes de iniciar la exposición.
- [V] El equipo sabe qué archivo, clase o comando abrir primero.
- [V] La demostración muestra el problema o situación inicial.
- [V] La demostración muestra cómo el patrón organiza la solución.
- [] La demostración muestra qué pasaría si se agrega una nueva variante, clase, comportamiento o producto.
- [ ] La demostración no se limita a enseñar código: explica decisiones de diseño.
- [ ] La demostración dura máximo 10 minutos.
- [V] El equipo tiene un plan alternativo si falla la ejecución en vivo:
  - [V] capturas,
  - [ ] salida esperada,
  - [ ] video corto,
  - [V] explicación guiada del código.
---
# 9. Distribución del trabajo en el equipo
- [ ] Todos los integrantes participan en la exposición.
- [ ] Todos los integrantes participan en la demostración o explicación del código.
- [ ] Cada integrante sabe qué parte le corresponde.
- [ ] Cada integrante puede responder preguntas básicas sobre ambos patrones.
- [ ] El guion evita que una sola persona cargue con toda la presentación.
- [ ] El equipo ensayó las transiciones entre integrantes.
- [ ] El equipo verificó que nadie lea de forma mecánica sin explicar.
---
# 10. Tiempo de exposición
La exposición completa debe durar **máximo 40 minutos**.
Distribución recomendada:
- Presentación académica: **25 a 30 minutos**
- Demostración práctica: **10 minutos**
- Margen de transición: **2 a 3 minutos**
Verificación:
- [ ] El equipo ensayó con cronómetro.
- [ ] La exposición completa no rebasa 40 minutos.
- [ ] La parte teórica no rebasa 30 minutos.
- [ ] La demostración práctica no rebasa 10 minutos.
- [ ] El equipo sabe qué recortar si se está quedando sin tiempo.
- [ ] El equipo no improvisa explicaciones largas fuera del guion.
- [ ] El equipo no dedica tiempo excesivo a leer código línea por línea.
---
# 11. Revisión final antes de entregar
- [V] El PDF final fue revisado después de exportarse.
- [V] La liga al repositorio fue probada en una ventana privada o desde otra cuenta.
- [ ] El código fue ejecutado nuevamente después del último cambio.
- [ ] El guion coincide con la versión final de las láminas.
- [ ] Las citas en láminas coinciden con las referencias finales.
- [ ] Los diagramas coinciden con el código.
- [ ] Los nombres de patrones están escritos correctamente.
- [ ] Los nombres de autores y libros están escritos correctamente.
- [ ] No hay errores ortográficos evidentes.
- [ ] No hay texto en inglés/español mezclado sin criterio.
- [ ] No hay contenido que el equipo no pueda explicar.
- [ ] El equipo puede responder: “¿por qué este patrón resuelve este problema?”
---
# 12. Entrega final
Antes de enviar, completen esta tabla:
| Elemento | Información |
|---|---|
| Equipo |7|
| Integrantes |Lenin Jesús Hernández Ramírez  José María Contreras Mota |
| Patrones asignados |Builder & Abstract Factory|
| Liga al PDF | |
| Liga al repositorio |https://github.com/Chema54/Presentacin-Patrones-de-Dise-o_PDS|
| Liga o archivo del guion | |
| Lenguaje usado en la implementación |C#|
| Herramienta usada para diagramas UML |Enterprise Architect 15.2|
| Duración ensayada de la teoría ||
| Duración ensayada de la demostración | |
| Fuentes bibliográficas principales | |
| ¿Se usó IA? ¿Para qué? |Sí, para la implementación|
---
# 13. Declaración de entrega
- [V] Confirmamos que el contenido fue revisado por todo el equipo.
- [V] Confirmamos que las fuentes fueron verificadas.
- [V] Confirmamos que el código funciona.
- [V] Confirmamos que podemos explicar todo lo presentado.
- [ ] Confirmamos que la exposición fue ensayada y cumple con el tiempo máximo.
