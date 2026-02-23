# 注意
此文件夹存放Mod需要使用的图片文件，系统会自动加载此处的图片，Mod可通过统一的接口使用图片。（此功能尚在开发中）

# 教程
游戏中当前正在使用的图片，保存在 ModExample\Textures\Images being used in the game文件夹中

如果修改图片，在图片保存到Mod的Textures文件平促，再在textures.xml中配置图片信息

数据形如：

<Image 

  file="kingdom_treasure_box_0.png"
  
  action="replace"
  
  anchor="0,0"
  
  />
 
file为图片文件名

action为动作，替换游戏原有图片使用replace， 添加新的图片使用add

anchor为图片对齐时的锚点。一般建筑图的锚点为"0,0", 其它图为"0.5,0.5"  如果发现图片坐标对不齐，可尝试修改此值

大多数的图片，只需要名称配置在Mod的Defs中的数据配置表中，即可生效

如需在代码中调用和修改图片，常用方法是：

UI界面上的元素Image img.sprite = SpriteManager.Get(sprite_name);

或者
场景元素MySpriteRenderer sp_body.sprite_id = SpriteManager.Ins.TryGetSpriteId(sprite_name); 




