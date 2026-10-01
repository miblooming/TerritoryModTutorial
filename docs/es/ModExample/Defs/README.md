# Datos y configuración: Defs

[Tutorial principal](../../README.md) · [Estructura de carpetas](../README.md) · [Original en chino](../../../../ModExample/Defs/README.md)

Los archivos de esta carpeta permiten modificar datos del juego, como objetos, recetas o parámetros de configuración. El juego los lee automáticamente cuando el mod está activado.

## Localizar los datos de referencia

El tutorial original distingue dos formatos:

- `excel_data`: tablas de origen. La primera fila contiene descripciones; la segunda, nombres de campos y tipos de datos.
- `json_data`: datos que lee el juego, obtenidos a partir de esas tablas.

Para seguir el ejemplo de modificación, usa los archivos de [`ModExample/Defs/json_data`](../../../../ModExample/Defs/json_data).

## Modificar una entrada existente

1. Copia el archivo JSON correspondiente desde `json_data` a `Defs` en tu mod.
2. En **tu copia**, conserva la entrada que quieras modificar y elimina las demás. Mantén la estructura del archivo JSON.
3. Cambia los valores necesarios y conserva el identificador de esa entrada.
4. Activa el mod y comprueba el cambio en el juego.

El identificador determina qué entrada se modifica. **Si lo cambias, se crea una entrada nueva.** Utiliza el nombre de campo que tenga cada archivo; por ejemplo, el [`stuff.json` del mod de ejemplo](../../../../ModExample/Defs/stuff.json) utiliza `stuff_id`, no un campo genérico llamado `Id`.

## Añadir contenido

| Archivo | Qué permite añadir |
| --- | --- |
| `stuff.json` | Un elemento nuevo, asignándole un identificador nuevo. |
| `blueprint.json` | Una receta nueva. |
| `build.json` | Un edificio nuevo. El tutorial indica que también hace falta escribir el código para que funcione. |

## Cambiar parámetros globales

Consulta los nombres de las variables en [`ModExample/Defs/Config/C.cs`](../../../../ModExample/Defs/Config/C.cs). Esos nombres son los que debes usar como `key` en `Defs/config.json`.

El ejemplo original cambia `npc_move_speed`, la velocidad básica de movimiento de los residentes, de `0.75` a `0.85`. Para reproducirlo, guarda lo siguiente en `Defs/config.json` dentro de tu mod:

```json
[
  {
    "key": "npc_move_speed",
    "value": "0.85",
    "name": "Velocidad de movimiento de los NPC",
    "remark": "Aumenta la velocidad"
  }
]
```

Puedes modificar varios parámetros en el mismo archivo: añade un objeto por parámetro dentro de la lista JSON y separa los objetos con comas.
