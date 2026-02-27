# TerritoryModTutorial
这是游戏《领地：种田与征战》（Territory: Farming and Warfare）的Mod制作教程

# 注意
本仓库中所提供的所有游戏元素，均有游戏作者版本所有，仅可用于制作MOD之用，不能拿作它用。

# 当前已实现的功能
在Assemblies添加dll，修改游戏功能

在ModXXX/BuildBlueprint中保存建造布局蓝图，以Mod的形式，分享给其它人[查看详情](https://github.com/miblooming/TerritoryModTutorial/tree/main/ModExample/BuildBlueprint)

在ModXXX/Map中保存自定义地图，以Mod的形式，分享给其它人[查看详情](https://github.com/miblooming/TerritoryModTutorial/tree/main/ModExample/Map)

在ModXXX/Defs中保存配置文件，自动修改游戏数据[查看详情](https://github.com/miblooming/TerritoryModTutorial/tree/main/ModExample/Defs)

在ModXXX/Textures中保存图片文件，自动修改游戏图片或添加图片[查看详情](https://github.com/miblooming/TerritoryModTutorial/tree/main/ModExample/Textures)

在ModXXX/Sounds中保存音频文件，自动修改或添加音效或背景音乐[查看详情](https://github.com/miblooming/TerritoryModTutorial/tree/main/ModExample/Sounds)

在ModXXX/Languages中保存本地化翻译文件，优化翻译文本[查看详情](https://github.com/miblooming/TerritoryModTutorial/tree/main/ModExample/Languages)

# 教程注意
ModExample为Mod示例教程，每个文件夹打开后，还有相关简要说明


# Mod制作方法
1.复制一份ModExample，重命名为自己将来发布的Mod的英文名，名称需使用英文及下划线。
  
2.修改ModExample/About/About.xml文件  
	name为Mod名称  
	authors为作者，如为多人合作，可以填写多个作者名称  
	description为简单的描述（更丰富的描述，可以在Mod的Steam页面上编写）  
	url为Mod相关信息（如开源代码库或其它说明网页等）  
	packageId为包名，通常为"作者名.Mod名"  
	supportedVersions默认填写1.0  
	modVersion为Mod的版本号  
	
3.修改ModExample/About/Preview.png预览图文件  	
	预览图尺寸：637 x 658 像素  
	格式：Png  
	
4.将dll保存到ModExample/Assemblies文件夹中  

5.其它文件夹，存放图片，音效及配置等，如果本Mod不涉及，需删除

6.注意  
	新的mod上传后，会生成Mod在Steam平台的唯一Id：ModExample/About/PublishedFileId.txt  
	不要修改此文件，这样后续更新Mod后，Steam会根据此Id更新Mod，所有订阅Mod的玩家将收到更新  
	如果不存在PublishedFileId.txt这个文件，则将当全新的Mod上传 



	
