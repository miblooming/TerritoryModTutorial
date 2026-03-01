# 注意
此文件夹存放多语言翻译文本，用于替换或补充游戏中的多语言翻译文本（此功能尚在开发中）

# 文本优化教程

比如你使用法语，发现有文本翻译有误，想制作MOD优化

第1步：找到以下文件 ModExample\Languages\Text being used in the game\localization_mod\localization_str_English.txt

第2步：在该文件中搜索到相应的文本，如

<@ID=window_txt-1-txt_@>

The translation of this game is provided or improved by enthusiasts. Thank you all.

Russian: <color=#4CB34C>Zerlin</color>, <color=#4CB34C>Tristis Oris</color>

第3步：修改翻译文本，将此条目保存到同名的文件，即localization_str_French.txt，保存到Mod的Languages即可

第4步：如需添加或修改人物名称姓氏，可修改以下：

  character_name/family_name_French.txt
  character_name/male_name_French.txt
  character_name/female_name_French.txt

*注意：*

<@ID=window_txt-1-txt_@>为文本的ID，不能修改

<color=#4CB34C>与</color>为颜色标记，需成对出现

# 新增语言
比如你使用越南语，希望为游戏添加此新的语言，你需要做3件事情：

1.Defs文件夹中，新建language.json,并填写以下内容

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

2.将localization_str_English.txt复制到Mod的Languages文件夹，将文件名修改为localization_str_Vietnamese.txt。然后翻译其中的文本。

3.将Language/character_name中的family_name_English.txt， male_name_English.txt， female_name_English.txt三个文件复制到Mod的Languages/character_name/文件夹中，
并改名为family_name_Vietnamese.txt， male_name_Vietnamese.txt， female_name_Vietnamese.txt。然后清除里面的内容后，添加新的人物姓氏，男性名称，及女性名称。

  

