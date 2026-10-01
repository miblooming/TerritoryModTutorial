# Metadatos y portada: About

[Tutorial principal](../../README.md) · [Estructura de carpetas](../README.md) · [Original en chino](../../../../ModExample/About/README.md)

Esta carpeta identifica el mod y contiene la información que se muestra al jugador. Edita los archivos de `About` en la copia de tu mod.

> **Ampliación de la edición española:** se reúne aquí la información sobre `About` que aparece en la guía principal del autor, con enlaces a los archivos de ejemplo.

## About.xml: nombre, descripción y versión

Abre el [`About.xml` de ejemplo](../../../../ModExample/About/About.xml) y conserva su estructura XML al cambiar los valores.

| Campo | Qué debes indicar |
| --- | --- |
| `name` | Nombre visible del mod. |
| `authors` | Autor o autores. El ejemplo usa un elemento `<li>` por autor dentro de `authors`. |
| `description` | Descripción breve. Puedes escribir una descripción más extensa en la página del mod en Steam. |
| `url` | Enlace con información del mod, como su repositorio o una página explicativa. |
| `packageId` | Identificador del paquete; normalmente tiene la forma `Author.ModName`. |
| `supportedVersions` | Versiones del juego compatibles. El ejemplo contiene `<li>1.0</li>` dentro de este campo. |
| `modVersion` | Versión del mod. Revisa el [formato aceptado por el panel de subida](../../README.md#error-al-subir-formato-de-modversion): por ejemplo, `1.0` o `1.62`. |

`packageId` identifica el paquete del mod. `PublishedFileId.txt`, explicado más abajo, identifica su publicación en Steam; son datos distintos.

## Preview.png: la portada

Sustituye `About/Preview.png` por tu propia imagen. El tutorial especifica **637 × 658 píxeles**, en formato **PNG**. Puedes consultar la [portada del ejemplo](../../../../ModExample/About/Preview.png).

## PublishedFileId.txt: actualizar la misma publicación

Este archivo se genera al publicar un mod nuevo y contiene su identificador único en Workshop. Por eso no aparece en el ejemplo sin publicar.

**Conserva el archivo al actualizar tu mod.** Si lo eliminas, el juego tratará la subida como una publicación nueva. No sustituyas su contenido por el identificador de otro mod.

Para subir el paquete, selecciona la carpeta que contiene `About`, no la carpeta `About` en sí. Consulta [cómo publicar o actualizar en Workshop](../../README.md#publicar-o-actualizar-en-workshop).
