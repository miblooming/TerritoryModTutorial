# Sonidos y música: Sounds

[Tutorial principal](../../README.md) · [Estructura de carpetas](../README.md) · [Original en chino](../../../../ModExample/Sounds/README.md)

El sistema de mods carga los archivos de audio de esta carpeta. Puedes usarlos para sustituir sonidos del juego o añadir otros.

## Preparar los archivos

Coloca los archivos en `Sounds`, dentro de tu mod:

| Contenido | Formato indicado en el tutorial |
| --- | --- |
| Efectos de sonido | `wav` |
| Música de fondo | `mp3` |

Si un sonido del mod tiene el mismo nombre que uno original, lo sustituirá automáticamente.

La mayoría de los sonidos se asignan por su nombre en las tablas de [Defs](../Defs/README.md). En esos casos, el juego los reproduce cuando corresponde.

## Reproducir audio desde código

Si necesitas controlarlo desde una DLL, el tutorial proporciona estas firmas de los métodos. Se muestran los tipos y los valores predeterminados de sus parámetros; no son llamadas listas para pegar.

Para música de fondo:

```csharp
SoundManager.Ins.PlayBgMusic(string bg_name, bool loop = true)
```

Para efectos de sonido:

```csharp
SoundManager.Ins.PlaySound(string sound_name, AudioSource audio_source = null, bool loop = false, float delay = 0)
```

El mod debe estar activado para utilizar sus recursos. Consulta [Assemblies](../Assemblies/README.md) para saber dónde colocar las DLL.
