# 注意
此文件夹存放Mod需要使用的音效文件，系统会自动加载此处的音效，Mod可通过接口播放音效

# 教程
将音效文件（格式为wav）或背景音乐文件（格式为mp3），存放在ModExample\Sounds中

在Mod启用于，可通过 SoundManager.Ins.PlayBgMusic(string bg_name, bool loop = true) 播放背景音乐

通过SoundManager.Ins.PlaySound(string sound_name, AudioSource audio_source = null, bool loop = false, float delay = 0) 播放音效

如果Mod中的音效与游戏原本音效名称一样，则会自动替换游戏中的音效

大部分音效是通过在Defs中数据表中配置名称，由游戏自动按需播放