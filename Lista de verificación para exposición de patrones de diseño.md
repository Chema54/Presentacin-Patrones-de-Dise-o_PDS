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
- [ ] La presentación fue exportada en formato **PDF**.
- [ ] El archivo PDF abre correctamente.
- [ ] El nombre del archivo identifica claramente al equipo y los patrones asignados.
- [ ] La presentación incluye portada con:
  - [ ] nombre de la experiencia educativa,
  - [V] nombre de los integrantes,
  - [V] patrones asignados,
- [ ] La presentación incluye una lámina final de **referencias completas**.
- [ ] La presentación incluye citas dentro de las láminas, no solo al final.
## 1.2 Repositorio de código
- [ ] Se entrega una liga funcional al repositorio.
- [ ] El repositorio es público o accesible para el profesor.
- [V] El repositorio contiene ejemplos de implementación para **cada patrón asignado**.
- [ ] El repositorio tiene un archivo `README.md`.
- [ ] El `README.md` explica:
  - [ ] qué patrones se implementan,
  - [ ] qué problema resuelve cada ejemplo,
  - [ ] cómo ejecutar el proyecto,
  - [ ] versión del lenguaje, framework o herramientas usadas,
  - [ ] comandos necesarios para instalar dependencias,
  - [ ] comandos necesarios para ejecutar los ejemplos.
- [V] El código fue probado antes de entregar.
- [ ] El repositorio no contiene archivos innecesarios, temporales o basura.
- [ ] El código está organizado por carpetas, paquetes o módulos comprensibles.
- [ ] El código fuente tiene nombres de clases, interfaces y métodos coherentes con el patrón explicado.
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
- [ ] Se explica el problema de diseño que motiva el patrón.
- [ ] Se explica qué fuerzas, tensiones o cambios hacen necesario aplicar el patrón.
- [ ] Se evita presentar el patrón como “receta de código” sin explicar el problema.
### 2.2 Solución propuesta por el patrón
- [ ] Se explica la solución general que propone el patrón.
- [ ] Se incluye un diagrama UML formal de la estructura del patrón.
- [ ] El diagrama UML usa nombres, relaciones y multiplicidades de forma comprensible.
- [ ] Se identifican los participantes del patrón.
- [ ] Se explica la responsabilidad de cada participante.
- [ ] Se explica cómo colaboran los participantes entre sí.
- [ ] Se explica qué parte del diseño queda desacoplada.
- [ ] Se explica qué elemento del sistema puede variar sin modificar todo el código.
- [ ] Se relaciona el patrón con al menos uno de estos principios:
  - [ ] encapsular lo que varía,
  - [ ] favorecer composición sobre herencia,
  - [ ] programar para interfaces, no para implementaciones.
### 2.3 Consecuencias del patrón
- [ ] Se explican ventajas reales de aplicar el patrón.
- [ ] Se explican desventajas, costos o riesgos de aplicar el patrón.
- [ ] Se indica cuándo conviene usarlo.
- [ ] Se indica cuándo **no** conviene usarlo.
- [ ] Se advierte si puede convertirse en antipatrón cuando se usa sin necesidad.
- [ ] Se mencionan patrones relacionados.
- [ ] Se explica brevemente la relación con esos patrones relacionados.
### 2.4 Implementación del patrón
- [ ] Se presenta un ejemplo propio de implementación.
- [ ] El ejemplo resuelve un problema concreto, no solo muestra clases vacías.
- [ ] El ejemplo permite identificar claramente los participantes del patrón.
- [ ] El código coincide con el diagrama UML presentado.
- [ ] Se muestran fragmentos clave de código en las láminas.
- [ ] Las láminas no están saturadas de código completo.
- [ ] El código completo está disponible en el repositorio.
- [ ] Se explica cómo se ejecuta el ejemplo.
- [ ] Se explica qué salida, comportamiento o resultado debe observarse.
- [ ] Se demuestra que el patrón realmente resuelve el problema planteado.
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
- [ ] Se explica cómo se ejecuta el ejemplo.
- [ ] Se explica qué salida, comportamiento o resultado debe observarse.
- [V] Se demuestra que el patrón realmente resuelve el problema planteado.
---
# 3. Comparación entre los dos patrones
- [ ] Se explica en qué se parecen los dos patrones asignados.
- [ ] Se explica en qué se diferencian.
- [ ] Se aclara qué problema resuelve cada uno.
- [ ] Se evita confundir patrones parecidos.
- [ ] Se incluye al menos un criterio para decidir cuándo usar uno y cuándo usar el otro.
- [ ] Se explica si ambos patrones podrían combinarse en un mismo diseño.
- [ ] Si se pueden combinar, se presenta un ejemplo breve.
- [ ] Si no conviene combinarlos, se explica por qué.
---
# 4. Calidad
## 4.1 Fuentes permitidas
- [ ] Se usó como fuente principal el libro de GoF:
  - Gamma, Helm, Johnson y Vlissides, *Design Patterns: Elements of Reusable Object-Oriented Software*.
- [ ] Se usó al menos un libro complementario adecuado para licenciatura.
- [ ] Las fuentes consultadas son libros especializados, documentación técnica formal o publicaciones académicas.
- [ ] No se usaron blogs, videos, páginas genéricas o respuestas de IA como fuente principal.
- [ ] Si se usó alguna fuente web, se justifica su uso y se cita correctamente.
- [ ] Las referencias existen y fueron verificadas.
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
- [ ] La presentación tiene una sección final de referencias.
- [ ] Las referencias están completas.
- [ ] Las referencias incluyen autor, año, título, editorial o fuente.
- [ ] Las referencias coinciden con las citas usadas en las láminas.
- [ ] No aparecen referencias que no fueron usadas.
- [ ] No se omiten fuentes que sí fueron usadas.
---
# 5. Uso responsable de inteligencia artificial
- [ ] El equipo verificó que ninguna definición, cita o referencia haya sido inventada por una herramienta de IA.
- [ ] El equipo contrastó la información teórica con libros o fuentes formales.
- [ ] El equipo no copió texto generado por IA sin revisarlo, corregirlo y fundamentarlo.
- [ ] El equipo entiende y puede explicar oralmente todo lo que aparece en las láminas.
- [ ] El equipo puede responder de dónde salió cada definición importante.
- [ ] El equipo incluye una breve declaración de uso de IA, si la utilizó.
Ejemplo de declaración:
> Para preparar este trabajo se utilizó inteligencia artificial como apoyo para organizar ideas, revisar redacción o generar preguntas de estudio. Las definiciones, citas, diagramas y referencias fueron verificadas contra fuentes bibliográficas formales. El equipo asume la responsabilidad académica completa del contenido presentado.
---
# 6. Calidad de las láminas
- [ ] Las láminas tienen poco texto y explican una idea principal por lámina.
- [ ] El tamaño de letra permite leer desde el aula.
- [ ] Los diagramas se distinguen con claridad.
- [ ] Los fragmentos de código son legibles.
- [ ] No hay capturas de pantalla borrosas.
- [ ] No hay láminas saturadas de texto.
- [ ] No se copian párrafos completos de libros o páginas web.
- [ ] Las imágenes, diagramas o figuras tomadas/adaptadas de fuentes externas tienen cita.
- [ ] La presentación tiene una secuencia lógica:
  - [ ] problema,
  - [ ] patrón,
  - [ ] estructura,
  - [ ] participantes,
  - [ ] consecuencias,
  - [ ] implementación,
  - [ ] demostración,
  - [ ] cierre.
---
# 7. Calidad de los diagramas UML
- [ ] Cada patrón tiene al menos un diagrama UML de su estructura general.
- [ ] Cada implementación tiene al menos un diagrama UML que corresponde al código real.
- [ ] Los diagramas distinguen correctamente clases, interfaces, clases abstractas y relaciones.
- [ ] Las relaciones UML usadas son correctas:
  - [ ] asociación,
  - [ ] dependencia,
  - [ ] generalización/herencia,
  - [ ] realización de interfaz,
  - [ ] composición/agregación, si aplica.
- [ ] Los nombres de clases e interfaces del diagrama coinciden con el código.
- [ ] Los métodos principales del patrón aparecen en el diagrama.
- [ ] El diagrama no contradice la explicación oral.
- [ ] El equipo puede justificar por qué modeló así la solución.
---
# 8. Demostración práctica
- [ ] La demostración fue ensayada antes de la clase.
- [ ] El equipo puede ejecutar los ejemplos sin depender de configuraciones ocultas.
- [ ] El equipo tiene preparado el entorno antes de iniciar la exposición.
- [ ] El equipo sabe qué archivo, clase o comando abrir primero.
- [ ] La demostración muestra el problema o situación inicial.
- [ ] La demostración muestra cómo el patrón organiza la solución.
- [ ] La demostración muestra qué pasaría si se agrega una nueva variante, clase, comportamiento o producto.
- [ ] La demostración no se limita a enseñar código: explica decisiones de diseño.
- [ ] La demostración dura máximo 10 minutos.
- [ ] El equipo tiene un plan alternativo si falla la ejecución en vivo:
  - [ ] capturas,
  - [ ] salida esperada,
  - [ ] video corto,
  - [ ] explicación guiada del código.
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
- [ ] El PDF final fue revisado después de exportarse.
- [ ] La liga al repositorio fue probada en una ventana privada o desde otra cuenta.
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
| Liga al repositorio | |
| Liga o archivo del guion | |
| Lenguaje usado en la implementación |C#|
| Herramienta usada para diagramas UML |Enterprise Architect 15.2|
| Duración ensayada de la teoría ||
| Duración ensayada de la demostración | |
| Fuentes bibliográficas principales | |
| ¿Se usó IA? ¿Para qué? | |
---
# 13. Declaración de entrega
- [ ] Confirmamos que el contenido fue revisado por todo el equipo.
- [ ] Confirmamos que las fuentes fueron verificadas.
- [ ] Confirmamos que el código funciona.
- [ ] Confirmamos que podemos explicar todo lo presentado.
- [ ] Confirmamos que la exposición fue ensayada y cumple con el tiempo máximo.
