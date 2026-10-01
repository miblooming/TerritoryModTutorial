# Estructura de carpetas del mod

[Tutorial principal](../README.md) · [Original en chino](../../../ModExample/README.md)

El mod de ejemplo se organiza por tipos de contenido. `About` contiene sus datos de presentación; las demás carpetas sirven para añadir código, configuraciones o recursos.

> **Ampliación de la edición española:** el original describe brevemente esta estructura. Aquí se reúnen las funciones de las carpetas explicadas en la guía principal y en sus páginas específicas.

```text
Mi_Mod/
├── About/
│   ├── About.xml
│   ├── Preview.png
│   └── PublishedFileId.txt    (se genera al publicar)
├── Assemblies/
├── BuildBlueprint/
├── Defs/
├── Languages/
├── Map/
├── Sounds/
└── Textures/
```

## Qué va en cada carpeta

| Carpeta | Contenido | Instrucciones |
| --- | --- | --- |
| `About` | Nombre, autores, descripción, versión, portada e identificador de Workshop | [Editar los metadatos](About/README.md) |
| `Assemblies` | DLL del mod, si incluye código | [Cuándo necesitas una DLL](Assemblies/README.md) |
| `BuildBlueprint` | Planos de construcción que quieras compartir | [Añadir planos](BuildBlueprint/README.md) |
| `Defs` | Datos de objetos, recetas, edificios y parámetros de configuración | [Modificar datos](Defs/README.md) |
| `Languages` | Textos traducidos y listas de nombres | [Preparar una traducción](Languages/README.md) |
| `Map` | Mapas personalizados | [Compartir mapas](Map/README.md) |
| `Sounds` | Efectos de sonido y música | [Preparar el audio](Sounds/README.md) |
| `Textures` | Imágenes y su configuración | [Preparar las imágenes](Textures/README.md) |

## Qué debes copiar

Parte de la carpeta [`ModExample` de la raíz del repositorio](../../../ModExample), que contiene los archivos de ejemplo. La carpeta `docs/es/ModExample` que estás leyendo contiene solo la documentación en español.

En tu copia, conserva los recursos que vaya a utilizar tu mod y elimina las carpetas de contenido que no necesites. Por ejemplo, un mod que solo cambia traducciones no necesita una DLL por ese motivo.

La carpeta raíz de tu mod es la que contiene `About`, no `About` por sí sola. Esa distinción también importa al [copiar el mod para probarlo](../README.md#6-probar-el-mod-durante-el-desarrollo) y al [seleccionar la ruta para subirlo](../README.md#publicar-o-actualizar-en-workshop).
