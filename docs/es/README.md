# Tutorial de creación de mods de Territory

Español | [中文（原文）](../../README.md)

Guía en español para crear, probar y publicar mods de **Territory: Farming and Warfare**, basada en el tutorial del autor. La redacción y la navegación se han adaptado para facilitar su uso; los archivos originales en chino se conservan sin cambios. Las comprobaciones adicionales se identifican como tales.

Si es tu primer mod, empieza por [crear un mod](#crear-un-mod). Si ya tienes una carpeta preparada, consulta [cómo publicarla o actualizarla](#publicar-o-actualizar-en-workshop).

## Aviso sobre los recursos del juego

Todos los elementos del juego incluidos en este repositorio pertenecen al autor del juego. Solo pueden utilizarse para crear mods; no se permite destinarlos a otros usos.

## Elige qué quieres modificar

Consulta la página correspondiente al contenido que quieras incluir en tu mod.

| Quiero… | Carpeta | Explicación |
| --- | --- | --- |
| Definir el nombre, la descripción y la portada | `About` | [Metadatos y publicación](ModExample/About/README.md) |
| Añadir o modificar funciones mediante código | `Assemblies` | [Uso de DLL](ModExample/Assemblies/README.md) |
| Compartir planos de construcción | `BuildBlueprint` | [Cómo incluir planos](ModExample/BuildBlueprint/README.md) |
| Modificar objetos, recetas o parámetros | `Defs` | [Datos y configuración](ModExample/Defs/README.md) |
| Corregir traducciones o preparar nombres | `Languages` | [Textos e idiomas](ModExample/Languages/README.md) |
| Compartir un mapa personalizado | `Map` | [Cómo incluir mapas](ModExample/Map/README.md) |
| Sustituir o añadir sonidos y música | `Sounds` | [Archivos de audio](ModExample/Sounds/README.md) |
| Sustituir o añadir imágenes | `Textures` | [Imágenes y texturas](ModExample/Textures/README.md) |

## Cómo utilizar el ejemplo

Los archivos del mod de ejemplo están en [`ModExample`](../../ModExample), en la raíz del repositorio. **La carpeta `docs/es/ModExample` contiene documentación, no un mod listo para cargar.**

Consulta el [árbol de carpetas y qué incluir en tu mod](ModExample/README.md) para distinguir los metadatos, el código y los recursos. En las instrucciones siguientes, `ModExample` o `ModXXX` representan la carpeta de tu propio mod.

## Crear un mod

### 1. Preparar el juego

Suscríbete al menos a un mod para activar la instalación del sistema de mods y reinicia el juego. Los mods necesitan ese sistema para funcionar.

### 2. Copiar el ejemplo

Copia la carpeta [`ModExample` del repositorio](../../ModExample) y cambia su nombre por el que tendrá tu mod; por ejemplo, `Mi_Mod`. Utiliza letras del alfabeto inglés y guiones bajos en el nombre de la carpeta. Trabaja sobre esa copia.

### 3. Editar los metadatos y la portada

Edita `About/About.xml` en tu copia para indicar el nombre, los autores, la descripción y la versión. La [guía de About](ModExample/About/README.md) explica cada campo y qué conservar cuando publiques una actualización.

Sustituye `About/Preview.png` por la portada de tu mod. El tutorial indica un tamaño de **637 × 658 píxeles** y formato **PNG**.

### 4. Añadir el código, si hace falta

Coloca las DLL en `ModExample/Assemblies`. No todos los mods necesitan código: modificar configuraciones, imágenes o añadir contenido mediante los datos del juego puede hacerse sin generar una DLL.

### 5. Incluir los recursos utilizados

Las demás carpetas contienen imágenes, sonidos, configuraciones y otros recursos. Elimina del mod las carpetas que no utilices.

### 6. Probar el mod durante el desarrollo

Para probar un solo mod, copia **el contenido de su carpeta**, sin incluir la carpeta contenedora, a:

```text
C:/TerritoryModTest
```

El juego lo cargará automáticamente al iniciarse.

La estructura debe quedar así: `C:/TerritoryModTest/About/About.xml`, no `C:/TerritoryModTest/Mi_Mod/About/About.xml`.

Para probar varios mods, copia **las carpetas de los mods**, esta vez incluyendo cada carpeta contenedora, a:

```text
C:/TerritoryModTestBatch
```

El juego cargará los mods de esa ubicación al iniciarse. El sistema no comprueba si hay mods duplicados: evita cargar dos copias del mismo mod durante las pruebas.

## Publicar o actualizar en Workshop

> **Ampliación práctica de la edición española:** este apartado reúne las instrucciones sobre el identificador de Workshop y la ruta comprobada en el panel de subida.

1. Abre el administrador de mods del juego y elige **Subir mod**.
2. Cuando te pida una ruta, indica la **carpeta raíz de tu mod**, la que contiene `About` y los demás recursos. Si lo has preparado en `C:/TerritoryModTest`, usa esa ruta. No selecciones `About`, `docs/es` ni el archivo ZIP.
3. Si estás actualizando un mod publicado, conserva su archivo `About/PublishedFileId.txt` en esa carpeta. Contiene el identificador que Steam utiliza para actualizar el elemento existente y distribuir los cambios a sus suscriptores.
4. Tras la subida, revisa la ficha en Steam. La descripción de `About.xml` es breve; la descripción extensa puede redactarse en la página del mod.

Al subir un mod nuevo se genera `About/PublishedFileId.txt`. **No lo modifiques ni lo elimines para actualizar ese mismo mod:** si falta, la subida se trata como un mod nuevo.

## Error al subir: formato de modVersion

Esta comprobación se añadió a la traducción tras reproducir el error en el juego **1.0.20260916.20**. El panel de subida exige **dos grupos numéricos separados por un punto**:

```xml
<modVersion>1.62</modVersion>
```

- Válidos: `1.0`, `1.4`, `1.62`.
- No válido: `1.6.2`, porque contiene tres grupos numéricos.

Con un valor no válido, el panel muestra: «modVersion debe tener formato x.y, por ejemplo 1.0».

Corrige el campo en `About/About.xml` de la carpeta que estás subiendo y vuelve a intentarlo. Las notas de actualización pueden seguir indicando una edición como `1.6.2`; el campo `modVersion` debe cumplir el formato que acepta el cargador. `1.62` es un ejemplo de identificador válido, no una conversión automática del juego.
