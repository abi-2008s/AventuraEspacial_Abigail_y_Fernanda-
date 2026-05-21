# SISTEMA DE SIMULACIÓN AVENTURA ESPACIAL
## Información del proyecto
### Universidad Don Bosco
### **Materia:** Programación Estructurada
### **Ciclo:** Ciclo 01
### **Integrantes:** Abigail Romero y Fernanda Campos

**Descripción General del Sistema**

El proyecto Aventura Espacial es una aplicación de escritorio desarrollada en el entorno de
C# utilizando la tecnología de Windows Forms. El objetivo principal de este sistema es
simular un entorno de exploración planetaria interactivo, donde el usuario puede navegar a
través de diferentes interfaces que representan destinos celestes, gestionar recursos
críticos y visualizar un reporte de datos acumulados durante la sesión de juego. La
aplicación está diseñada bajo un enfoque modular, distribuyendo la carga de trabajo de las
interfaces de manera eficiente para garantizar una experiencia de usuario fluida y
coherente.

**Estructura de Interfaces y Flujo del Programa**

La arquitectura del programa se divide en múltiples formularios independientes que se
comunican entre sí para mantener la persistencia del estado de la simulación. El formulario
principal, denominado Inicio, actúa como el menú central y punto de partida de la aplicación,
proporcionando los accesos directos hacia las distintas dinámicas del sistema. Desde este
nodo central, el usuario puede acceder al formulario Explorar, el cual se encarga de
procesar la lógica de selección de planetas y la simulación del viaje espacial. Asimismo, el
sistema cuenta con el formulario Historial, una interfaz dedicada a recopilar, ordenar y
mostrar los datos estadísticos y las decisiones tomadas por el usuario a lo largo de la
ejecución del programa.

**Cumplimiento de Requisitos Técnicos y Rúbrica**

La implementación de este simulador se acopló estrictamente a las indicaciones
metodológicas y técnicas exigidas en la rúbrica de evaluación del proyecto, destacando los
siguientes componentes de ingeniería de software:

- **Gestión de Variables Globales Compartidas:** Para resolver la comunicación entre
formularios sin romper el paradigma estructurado, se implementó una clase de
configuración global que almacena variables estáticas compartidas. Esto permite que datos
críticos, como la puntuación, el nombre del jugador, el combustible restante y el nivel de
daño, se actualicen en tiempo real desde el formulario de exploración y se reflejen de
manera idéntica en el formulario de historial.

- **Optimización Mediante Código No Seguro y Pointers:** Atendiendo la solicitud de incorporar
estructuras avanzadas de memoria, se habilitó el uso de bloques unsafe dentro del núcleo
del programa. Mediante el uso de punteros nativos de C#, el sistema realiza el cálculo del
daño acumulado de la nave de forma directa en las direcciones de memoria de las
variables. Este enfoque optimiza el rendimiento del procesamiento aritmético al simular
impactos de asteroides o fallas críticas durante el viaje interplanetario.

- **Modularidad y Limpieza de Código:** El código fuente se estructuró siguiendo principios de
modularidad, separando la lógica de diseño visual de los componentes de procesamiento de
datos. Cada evento de los botones y controladores está debidamente documentado y
limitado a su función específica, evitando la redundancia de funciones y facilitando el
mantenimiento del software.

**Guía de Ejecución para la Evaluación**

Para comprobar el correcto funcionamiento de la dinámica del programa, el evaluador
puede optar por dos vías de ejecución:

1. **Ejecución desde el Entorno de Desarrollo:** Al abrir la solución Aventura Espacial dentro de
Microsoft Visual Studio, es necesario verificar en las propiedades del proyecto,
específicamente en la pestaña de Compilación, que la casilla Permitir código no seguro esté
debidamente marcada. Esto es indispensable para que el compilador de .NET reconozca
los bloques unsafe que gestionan los punteros de daño. Posteriormente, se debe compilar
la solución y presionar el botón Iniciar.

2. **Ejecución Directa mediante Archivo Ejecutable:** En cumplimiento con los requisitos de
distribución, el proyecto genera un archivo ejecutable independiente denominado Aventura
Espacial.exe, ubicado dentro de la ruta bin Debug del directorio del proyecto. Este archivo
permite correr la aplicación de forma inmediata en cualquier computadora con el sistema
operativo Windows, sin necesidad de cargar las herramientas de Visual Studio, facilitando
una auditoría rápida de la interfaz y la lógica del simulador.

## ⚠️ SI EL PROGRAMA NO CORRE CLONAR EL REPOSITORIO ⚠️
