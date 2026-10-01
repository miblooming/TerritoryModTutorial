# Imágenes y texturas: Textures

[Tutorial principal](../../README.md) · [Estructura de carpetas](../README.md) · [Original en chino](../../../../ModExample/Textures/README.md)

Esta carpeta contiene las imágenes del mod y su configuración. El sistema las carga para sustituir recursos existentes o añadir otros.

El documento original señala que esta función está en desarrollo; los ejemplos de esta página reflejan lo documentado por el autor.

## Preparar una imagen

1. Consulta los recursos de referencia en `ModExample/Textures/Images being used in the game`.
2. Guarda la imagen que quieras usar en `Textures`, dentro de tu mod.
3. Regístrala en `Textures/textures.xml`, siguiendo la estructura del [archivo de ejemplo](../../../../ModExample/Textures/textures.xml).

Este ejemplo completo conserva el contenedor `ModImages` del archivo original y registra una sola imagen:

```xml
<ModImages version="1">
  <Image
    file="kingdom_treasure_box_0.png"
    action="replace"
    anchor="0,0"
  />
</ModImages>
```

| Atributo | Significado |
| --- | --- |
| `file` | Nombre del archivo de imagen. |
| `action` | `replace` sustituye una imagen del juego; `add` añade una nueva. |
| `anchor` | Punto de anclaje usado para alinear la imagen. El tutorial indica normalmente `0,0` para edificios y `0.5,0.5` para otras imágenes. |

Si una imagen queda desalineada, revisa su valor de `anchor`.

## Utilizar la imagen

En la mayoría de los casos basta con indicar su nombre en la tabla de datos correspondiente de [Defs](../Defs/README.md).

Si necesitas asignarla desde C#, el tutorial muestra estas dos operaciones. `sprite_name` representa el nombre del recurso que quieres utilizar.

Para un elemento `Image` de la interfaz, representado por la variable `img`:

```csharp
img.sprite = SpriteManager.Get(sprite_name);
```

O para un elemento `MySpriteRenderer` de la escena, representado por `sp_body`:

```csharp
sp_body.sprite_id = SpriteManager.Ins.TryGetSpriteId(sprite_name);
```
