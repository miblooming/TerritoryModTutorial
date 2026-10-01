# Traducciones y nombres: Languages

[Tutorial principal](../../README.md) · [Estructura de carpetas](../README.md) · [Original en chino](../../../../ModExample/Languages/README.md)

Usa esta carpeta para corregir textos del juego o preparar listas de nombres de personajes. Puedes incluir las entradas que quieras cambiar, conservando sus identificadores.

El documento original señala que la localización está en desarrollo. Esta página conserva sus ejemplos y distingue entre **mejorar un idioma existente** y **registrar uno nuevo**.

## Mejorar una traducción existente

El ejemplo del autor utiliza el francés. El procedimiento consiste en localizar una entrada, traducir su contenido y guardarla en el archivo del idioma de destino.

1. Busca el archivo de referencia:

   ```text
   ModExample\Languages\Text being used in the game\localization_mod\localization_str_English.txt
   ```

2. Localiza el texto correspondiente. Por ejemplo:

   ```text
   <@ID=window_txt-1-txt_@>
   The translation of this game is provided or improved by enthusiasts. Thank you all.
   Russian: <color=#4CB34C>Zerlin</color>, <color=#4CB34C>Tristis Oris</color>
   ```

3. Traduce el texto situado después de su identificador y guarda la entrada completa en `Languages/localization_str_French.txt`, dentro de tu mod. Conserva `<@ID=window_txt-1-txt_@>` sin cambios.

4. Activa el mod y selecciona el idioma correspondiente en el juego para comprobar el resultado.

### Si vas a mejorar el español

**Adaptación del ejemplo:** para español, el archivo de destino es `Languages/localization_str_Spanish.txt`. El repositorio incluye un [catálogo de referencia en español](../../../../ModExample/Languages/Text%20being%20used%20in%20the%20game/localization_mod/localization_str_Spanish.txt).

El sufijo del archivo identifica el idioma: `French` para el ejemplo en francés y `Spanish` para español. No traduzcas esa parte del nombre a `Francés` o `Español`. Para corregir un idioma ya existente, no necesitas añadirlo de nuevo a `Defs/language.json`.

### Apellidos y nombres de personajes

Para añadir o modificar las listas de nombres del ejemplo en francés, utiliza estos archivos dentro de `Languages`:

```text
character_name/family_name_French.txt
character_name/male_name_French.txt
character_name/female_name_French.txt
```

`family_name` contiene apellidos; `male_name`, nombres masculinos; y `female_name`, nombres femeninos. Conserva la estructura y el formato de los archivos de referencia al preparar tus listas.

### Qué debes conservar al traducir

- `<@ID=window_txt-1-txt_@>` es el identificador del texto y no debe modificarse.
- `<color=#4CB34C>` y `</color>` son etiquetas de color; cada etiqueta de apertura debe tener su correspondiente cierre.

## Añadir un idioma

El tutorial original utiliza el vietnamita como ejemplo. Sus identificadores y valores se reproducen a continuación como referencia histórica.

> **Nota de actualización:** el juego **1.0.20260916.20** ya incluye vietnamita. Para mejorar su traducción, utiliza el procedimiento anterior. No copies esta definición para dar de alta un idioma que ya existe; comprueba primero los idiomas y los identificadores de la versión del juego con la que estés trabajando.

### 1. Definir el idioma

El ejemplo original crea `Defs/language.json` con este contenido:

```json
[
    {
        "language_id": 12,
        "language_name_cn": "越南语",
        "enable": 1,
        "language_name": "Tiếng Việt",
        "language_name_en": "Vietnamese",
        "language_code": "vi",
        "unity_language_code": "Vietnamese",
        "steam_language_code": "vietnamese",
        "is_surname_come_first": true
    }
]
```

### 2. Traducir los textos

Copia `localization_str_English.txt` a la carpeta `Languages` del mod, cambia su nombre a `localization_str_Vietnamese.txt` y traduce su contenido.

### 3. Preparar los nombres de personajes

Copia los archivos `family_name_English.txt`, `male_name_English.txt` y `female_name_English.txt` de `ModExample/Languages/Text being used in the game/localization_mod/character_name/` a `Languages/character_name/` de tu mod.

Cambia sus nombres a:

```text
family_name_Vietnamese.txt
male_name_Vietnamese.txt
female_name_Vietnamese.txt
```

Borra el contenido de las copias y añade, respectivamente, apellidos, nombres masculinos y nombres femeninos del idioma nuevo.

> **Nota adicional sobre la ruta:** el original abrevia la carpeta de origen como `Language/character_name`. Aquí se indica la ruta completa comprobada en el repositorio. La carpeta de destino del mod es `Languages/character_name/`.
