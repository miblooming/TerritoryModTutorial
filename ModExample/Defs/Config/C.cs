using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Windows;
using Random = System.Random;

[Serializable]
public class ConfigItem
{
    public string key;
    public string value;
    public string name;
    public string remark;
}

[Serializable]
public class C
{
    public static List<List<float>> tulips_price_level = new List<List<float>>()
    {
        new List<float>(){0.5f, 1.0f, 1.3f, 1.6f},
        new List<float>(){0.3f, 1.0f, 1.5f, 2.0f},
        new List<float>(){0.2f, 0.9f, 1.6f, 3.0f},
    };
    public static readonly List<int>  upgrade_dragon_control_level = new List<int>() { 0, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
    public static readonly List<int>  upgrade_dragon_control_count = new List<int>() { 0, 100, 150, 200, 250, 300, 300, 300, 300, 300, 300, 300, 300, 300, 300, 300 };
    public static List<int> build_menu_group_order = new List<int>(){1,2,3,4,5,6,7};
    public static List<int> tulips_price_cycle_duration_year_count_max = new List<int>() { 5, 4, 3, 2 };
    
    
    public static int init_religion_point = 100;
    public static float religion_point_increase_per_day = 0.25f;
    public static int days_to_reset_time_record_of_unnecessary_stuff_to_carry = 30;
    public static int cool_down_on_failed_to_order_stuff = 2;
    public static int when_total_count_is_too_less_and_ignore_min_count_to_carry_of_wagon = 500;
    public static int effect_of_efficient_storage = 10;
    public static float rate_of_refugee_from_other_player = 0.75f;
    public static int dragon_max_nature_count_in_active = 5;
    public static float dragon_hp_effect_of_potentiality = 0.05f;

    public static float share_of_emperor = 0.4f;
    public static float share_of_king = 0.6f;
    public static int year_to_start_develop_empire_village = 50;
    public static float min_lightning_bright = 1.25f;
    public static int duration_days_before_die_to_notice = 60;

    public static int max_dragon_control_level_to_upgrade_in_king_eternal_temple = 5;
    public static int max_dragon_control_count_to_upgrade_in_king_eternal_temple = 2;

    public static int fluorescent_effect_range = 2;
    public static float effect_of_fluorescent_red = 1.1f;
    public static int effect_of_fluorescent_blue = 1;
    public static float effect_of_fluorescent_green = 0.5f;
    public static int duration_days_effect_of_fluorescent = 180;

    public static int insurance_end_month = 1;
    public static float price_rate_of_insurance = 0.8f;
    public static float base_fee_rate_of_insurance = 0.1f;
    public static int max_insurance_year_count = 3;
    
    public static float create_baby_rate_in_public_bath = 0.01f;   
    
    public static int work_duration_year_of_resident_in_empire_village_max = 5;
    public static int work_duration_year_of_resident_in_empire_village_default = 3;
    
    public static float percent_of_people_to_escape_to_other_territory = 0.01f;
    public static int duration_days_of_people_to_escape_to_other_territory = 90;
    public static int happiness_to_escape_to_other_territory = 40;
    public static int count_of_too_many_prisoner_escape_one_month = 5;
    public static float trading_effect_of_lord_has_nature_wisdom = 0.05f;
    
    public static float move_speed_effect_of_dirt_road = 1.25f;
    public static float move_speed_effect_of_floor = 1.35f;
    public static float move_speed_effect_of_stone_road = 1.5f;
    public static float move_speed_effect_of_ladder = 0.25f;
    public static float move_speed_effect_of_bridge_wood = 0.75f;
    public static float move_speed_effect_of_bridge_stone = 1.25f;
    
    public static float walk_time_user_rate_of_level1 = 0.5f;
    public static float walk_time_user_rate_of_level2= 0.75f;
    public static int keep_royal_count_on_arrange_governor = 2;

    public static int reinforcement_days_cooldown = 360 * 3;
    public static float rate_to_build_cannon_for_enemy = 0.1f;

    //一神教的城堡，士兵在突袭时，有概率使用“狂热”技能
    public static float rate_to_dare_to_die_of_soldier_on_invade = 0.1f;
    public static float max_hurt_percent_to_dragon_of_magic_bomb_explosion = 0.05f;
    public static float soldier_training_effect_of_atk_increase = 0.5f;

/// <summary>
/// 狼人死了亲人后的愤怒战力加成时长
/// </summary>
public static int attack_power_effect_by_relative_member_dead_duration_days = 180;
/// <summary>
/// NPC移动速度（1秒移动的距离，可以为小数） 
/// </summary>
public static float npc_move_speed = 0.75f;
/// <summary>
/// NPC移动速度随机浮动范围 
/// </summary>
public static float npc_move_speed_random_float = 0.1f;
/// <summary>
/// 动物移动速度 
/// </summary>
public static float animal_move_speed = 0.6f;
/// <summary>
/// 动物移动速度随机浮动范围 
/// </summary>
public static float animal_move_speed_random_float = 0.1f;
/// <summary>
/// 一年居民年龄岁数增长数 
/// </summary>
public static int age_for_year = 5;
/// <summary>
/// 游戏时间是现实时间的倍数，1年等于真实1小时
///  真实1小时，等于1年。一年360天
///时钟：
///1年 12个月 真实1小时
///每个月 真实5分钟
///每天 真实10秒钟
///正常流逝，1年，真实时间1小时
///5倍速，真实时间12分钟(游戏时间1天，真实时间2秒）
///10倍速，真实时间6分钟(游戏时间1天，真实时间1秒）
/// 游戏时间1天，真实时间10秒
///10倍速，真实1秒
///60倍速，真实时间10帧（60帧）
/// </summary>
public static float time_scale = 8640f;
/// <summary>
/// 震屏幅度 
/// </summary>
public static float camera_shake_amplitude = 0.2f;
/// <summary>
/// 震屏时长 
/// </summary>
public static float camera_shake_duration = 0.2f;
/// <summary>
/// 震屏抖动次数 
/// </summary>
public static int camera_shake_times = 4;
/// <summary>
/// 树木初始区域截取（噪声高度截取） 
/// </summary>
public static float tree_init_rate = 0.52f;
/// <summary>
/// 陆地上树的初始填充率 
/// </summary>
public static float tree_init_rate_on_land = 0.45f;
/// <summary>
/// 山顶上树的初始填充率 
/// </summary>
public static float tree_init_rate_on_hill = 0.75f;
/// <summary>
/// 初始的树木生长点被清空后，每日发芽长苗概率  1/3600,十年恢复
/// </summary>
public static float tree_recover_rate = 0.000278f;
/// <summary>
/// 野花初始区域截取（噪声高度截取） 
/// </summary>
public static float flower_wild_init_rate = 0.45f;
/// <summary>
/// 初始陆地上花的初始填充率 
/// </summary>
public static float flower_wild_init_rate_on_land = 0.7f;
/// <summary>
/// 石头初始填充率 
/// </summary>
public static float stone_init_rate = 0.1f;
/// <summary>
/// 铁块初始填充率 
/// </summary>
public static float iron_init_rate = 0.1f;
/// <summary>
/// 石头聚集范围 
/// </summary>
public static int stone_block_size = 20;
/// <summary>
/// 石头聚集范围内的出现概率 
/// </summary>
public static float stone_in_block_rate = 0.5f;
/// <summary>
/// 铁块聚集范围 
/// </summary>
public static int iron_block_size = 15;
/// <summary>
/// 铁矿聚集范围内的出现概率 
/// </summary>
public static float iron_in_block_rate = 0.6f;
/// <summary>
/// 树苗状态持续的年数 
/// </summary>
public static int tree_sapling_years = 1;
/// <summary>
/// 树木成材的年数 
/// </summary>
public static int tree_mature_years = 3;
/// <summary>
/// 古树的判定标准（年数），草药只在古树附近生长 
/// </summary>
public static int old_tree_age = 10;
/// <summary>
/// 树木的最大年龄，超过则变枯木 
/// </summary>
public static int max_tree_age = 20;
/// <summary>
/// 树木腐化，超过则变树桩 
/// </summary>
public static int tree_rot_age = 22;
/// <summary>
/// 树的消失年龄，超过则彻底消失 
/// </summary>
public static int tree_disappear_age = 24;
/// <summary>
/// 居民饥饿度最大值 
/// </summary>
public static int hunger_max = 100;
/// <summary>
/// 居民开始寻找食物的阀值 
/// </summary>
public static float hunger_force_find_food = 50f;
/// <summary>
/// 居民空闲时寻找食物的阀值 
/// </summary>
public static float hunger_find_food_when_idle = 70f;
/// <summary>
/// 居民起床后寻找食物的阀值 
/// </summary>
public static float hunger_find_food_after_sleep = 80f;
/// <summary>
/// 居民头顶显示饥饿提示图标的阀值 
/// </summary>
public static float hunger_show_notice = 30f;
public static float hunger_force_interrupt_task = 20f;
/// <summary>
/// 居民寻找食物失败的CD天数 
/// </summary>
public static int find_food_cd_days = 3;
/// <summary>
/// 居民最大保暖值 
/// </summary>
public static float heat_max = 100f;
/// <summary>
/// 居民开始寻找取暖处的阀值 
/// </summary>
public static float heat_force_find_warm = 50f;
/// <summary>
/// 居民空闲时开始寻找取暖处的阀值 
/// </summary>
public static float heat_force_find_warm_when_idle = 70f;
/// <summary>
/// 士兵开始寻找取暖处的阀值 
/// </summary>
public static float heat_force_find_warm_of_soldier = 30f;
/// <summary>
/// 居民头顶显示寒冷提示图标的阀值 
/// </summary>
public static float heat_show_notice = 40f;
public static float heat_force_interrupt_task = 30f;
/// <summary>
/// 居民温暖的判定阀值 
/// </summary>
public static float heat_warm = 80f;
/// <summary>
/// 居民寻找取暖处失败的CD天数 
/// </summary>
public static int find_warm_cd_days = 5;
/// <summary>
/// 居民悼念行为的CD天数 
/// </summary>
public static int mourn_cd_days = 360;
/// <summary>
/// 居民保暖值从0恢复到最大值，所需的天数 
/// </summary>
public static float days_count_heat_recover = 0.5f;
/// <summary>
/// 居民开始自然降低保暖值的天气温度阀值 
/// </summary>
public static int heat_loss_start_temp = 10;
/// <summary>
/// 居民开始自然保暖的天气温度阀值 
/// </summary>
public static int heat_increase_start_temp = 20;
/// <summary>
/// 室内保暖影响系数（对热量损失打折） 
/// </summary>
public static float indoor_keep_warm_effect = 0.8f;
/// <summary>
/// 熔炉一天消耗的燃料点数 
/// </summary>
public static float fuel_day_cost_of_furnace = 0.5f;
/// <summary>
/// 烹饪台一天消耗的燃料点数 
/// </summary>
public static float fuel_day_cost_of_cook_table = 0.1f;
/// <summary>
/// 公共浴场一天消耗的燃料点数
/// </summary>
public static float fuel_day_cost_of_public_bath = 30f;
/// <summary>
/// 公共浴场补水上限
/// </summary>
public static int public_bath_water_count_max = 10000;
/// <summary>
/// 公共浴场一天消耗的水量
/// </summary>
public static int water_count_of_public_bath_per_day = 100;
/// <summary>
/// 公共浴场一天消耗的水量(没有顾客时）
/// </summary>
public static int water_count_of_public_bath_per_day_on_no_customer = 5;
/// <summary>
/// 公共浴场同时接待的人数
/// </summary>
public static int npc_count_taking_a_bath_max = 100;
/// <summary>
/// 柴火库存低于该值，优先搬运地地上的柴火 
/// </summary>
public static int firewood_lack_threshold = 10;
/// <summary>
/// 一次篝火晚会需要柴火数量（燃烧持续时间由物品表“篝火堆”配置） 
/// </summary>
public static int fuel_cost_of_bonfire_onetime = 20;
/// <summary>
/// 居民提前开始准备篝火堆的天数 
/// </summary>
public static int day_count_for_prepare_bonfire = 10;
/// <summary>
/// 篝火晚会可推迟的最大天数 
/// </summary>
public static int day_count_for_max_delay_start_bonfire = 20;
/// <summary>
/// 参加篝火晚会的居民最大数量 
/// </summary>
public static int max_bonfire_party_npc_count = 100;
/// <summary>
/// 切割动物时，产出物品分堆大小 
/// </summary>
public static int heap_size_cut_dead_body = 10;
/// <summary>
/// 切割大鱼时，产出物品分堆大小 
/// </summary>
public static int heap_size_cut_big_fish = 20;
/// <summary>
/// 教育对渔民的生产效率（单次渔获量）的影响倍数 
/// </summary>
public static float education_effect_of_fishing_efficiency = 1.75f;
/// <summary>
/// 居民去看医生的阀值 健康相关
/// </summary>
public static float health_force_see_doctor = 60f;
/// <summary>
/// 看医生失败的CD天数 
/// </summary>
public static int see_doctor_cd_days = 5;
/// <summary>
/// 居民卧床休养的健康度阀值 
/// </summary>
public static float health_to_force_rest = 40f;
/// <summary>
/// 长期吃生食N天，居民陷入更严重的营养不良 
/// </summary>
public static int innutrition_days_to_level2 = 360;
/// <summary>
/// 长期营养不良N天，居民有风险患病 
/// </summary>
public static int innutrition_days_to_ill = 900;
/// <summary>
/// 长期睡地上N天，居民会得关节炎 
/// </summary>
public static int days_sleep_on_groud_to_ill = 1080;
/// <summary>
/// 得关节炎对行动速度影响的天数 
/// </summary>
public static int arthritis_side_effect_duration_days = 90;
/// <summary>
/// 关节炎对行动速度的影响系数（乘法） 
/// </summary>
public static float ill_arthritis_effect_of_speed = 0.5f;
/// <summary>
/// 居民卧床休养，恢复1点健康所需的天数 
/// </summary>
public static float day_count_of_health_recover_on_bed = 0.5f;
/// <summary>
/// 居民卧医疗床休养，恢复1点健康所需的天数 
/// </summary>
public static float day_count_of_health_recover_on_medical_bed = 0.25f;
/// <summary>
/// 银制地板，对医疗床作用的增益
/// </summary>
public static float effect_of_silver_floor_for_medical_bed = 1.5f;
/// <summary>
/// 健康度过低，每天居民患病的概率 
/// </summary>
public static float ill_rate = 0.0005f;
/// <summary>
/// 下雪导致穿着破烂的民居感冒概率（按天） 
/// </summary>
public static float ill_by_rain_rate_of_day = 0.005f;
/// <summary>
/// 下雪导致穿着破烂的民居感冒概率（按天） 
/// </summary>
public static float ill_by_snow_rate_of_day = 0.0025f;
/// <summary>
/// 生病至晕倒后，N天内不再因病晕例 
/// </summary>
public static float ill_shock_interval = 180f;
/// <summary>
/// 幸福度<=N时，NPC产生“散心”的需求 
/// </summary>
public static int happiness_to_make_self_feel_better = 40;
/// <summary>
/// 幸福度<=N时，NPC产生负面行为（散心,暴饮暴食，酗酒，躺平休息） 
/// </summary>
public static int happiness_to_event_action = 20;
/// <summary>
/// 幸福度<=N时，离开 
/// </summary>
public static int happiness_to_leave = 0;
/// <summary>
/// 因幸福度过低，每年离开人数占比不超过N 
/// </summary>
public static float happiness_to_leave_percent_pre_year = 0.03f;
/// <summary>
/// 重置幸福度离开统计数值的时间（月份） 
/// </summary>
public static int month_in_year_to_leave = 4;
/// <summary>
/// 居民散心行为的CD天数 
/// </summary>
public static int make_self_feel_better_cd_days = 360;
/// <summary>
/// 幸福度负面行为冷却时间（天） 
/// </summary>
public static int happiness_event_action_cd_days = 360;
/// <summary>
/// 酗酒事件行为，对酒的消耗量 
/// </summary>
public static int wine_count_of_alcaoholism = 50;
/// <summary>
/// 躺平消耗的时间（天） 
/// </summary>
public static int lie_flat_duration_days = 30;
/// <summary>
/// 单个设施派给闲杂工的任务上限 
/// </summary>
public static int max_handyman_task_count_of_one_facility = 10;
/// <summary>
/// 居民背包重量上限 
/// </summary>
public static int max_npc_bag_weight = 100;
/// <summary>
/// 居民皮包重量上限 
/// </summary>
public static int max_npc_leather_bag_weight = 100;
/// <summary>
/// 搬运工单次运输数量上限 
/// </summary>
public static int max_npc_transporter_bag_count = 500;
/// <summary>
/// 搬运工单次运输数量上限 
/// </summary>
public static int max_npc_coachman_transporter_unload_bag_count = 2000;
/// <summary>
/// 拆除建筑时，参与的居民数量上限 
/// </summary>
public static int max_npc_count_to_dismantle_transport = 10;
/// <summary>
/// 建筑工每次施工增加的工作量 
/// </summary>
public static int build_workload_per_time = 10;
/// <summary>
/// 居民寻找衣服失败CD天数 
/// </summary>
public static int find_clothes_cd_days = 5;
/// <summary>
/// 衣服耐久度低于N时，去换新衣服 
/// </summary>
public static int clothes_durable_to_change = 45;
/// <summary>
/// 寻找雨伞失败CD天数 
/// </summary>
public static int find_umbrella_cd_days = 30;
/// <summary>
/// 雨伞的耐久度 
/// </summary>
public static int umbrella_durable_max = 1080;
/// <summary>
/// 皮包的耐久度 
/// </summary>
public static int leather_bag_durable_max = 1080;
/// <summary>
/// 寻找工具失败CD天数 
/// </summary>
public static int find_tool_cd_days = 5;
/// <summary>
/// 工具耐久度 
/// </summary>
public static int tool_durable_max = 100;
/// <summary>
/// 优质工具耐久度 
/// </summary>
public static int better_tool_durable_max = 200;
/// <summary>
/// 寻找酒失败CD天数 
/// </summary>
public static int find_wine_cd_days = 10;
/// <summary>
/// 酒喝偏好（间隔时间下限) 
/// </summary>
public static int drink_wine_interval_days_min = 150;
/// <summary>
/// 酒喝偏好（间隔时间上限) 
/// </summary>
public static int drink_wine_interval_days_max = 180;
/// <summary>
/// 需求喝酒的年龄 
/// </summary>
public static int age_for_demand_wine = 40;
/// <summary>
/// 寻找巧克力失败CD天数 
/// </summary>
public static int find_chocolate_cd_days = 15;
/// <summary>
/// 吃巧克力偏好（间隔时间下限) 
/// </summary>
public static int eat_chocolate_interval_days_min = 150;
/// <summary>
/// 吃巧克力偏好（间隔时间上限) 
/// </summary>
public static int eat_chocolate_interval_days_max = 180;
/// <summary>
/// 寻找巧克力失败CD天数 
/// </summary>
public static int find_coffee_cd_days = 15;
/// <summary>
/// 寻找偏好物品的间隔时间
/// </summary>
public static int find_favor_interval_days = 360;
/// <summary>
/// 喝咖啡偏好（间隔时间下限) 
/// </summary>
public static int drink_coffee_interval_days_min = 45;
/// <summary>
/// 喝咖啡偏好（间隔时间上限) 
/// </summary>
public static int drink_coffee_interval_days_max = 60;
/// <summary>
/// 咖啡影响时长（天数） 
/// </summary>
public static int coffee_effect_duration_days = 60;
/// <summary>
/// 咖啡对移动速度影响 
/// </summary>
public static float coffee_effect_of_speed = 1.5f;
/// <summary>
/// 咖啡对工作效率影响 
/// </summary>
public static float coffee_effect_of_work_duration = 1.5f;
/// <summary>
/// 灵感对工作效率的影响 
/// </summary>
public static float insprition_effect_of_work_duration = 3f;
/// <summary>
/// 凉茶的偏好（间隔时间下限) 
/// </summary>
public static int drink_herbal_tea_interval_days_min = 150;
/// <summary>
/// 凉茶的偏好（间隔时间上限) 
/// </summary>
public static int drink_herbal_tea_interval_days_max = 170;
/// <summary>
/// 距上次喝凉茶后N天，产生戒断反应 
/// </summary>
public static int drink_herbal_tea_withdrawal_reaction_threshold = 360;
/// <summary>
/// 衰老开始的年龄 
/// </summary>
public static int senility_age = 60;
/// <summary>
/// 存储物品失败CD天 
/// </summary>
public static int put_cd_days = 3;
/// <summary>
/// 气温低于作物存活温度时，每天冻死的比例 
/// </summary>
public static float percent_of_crop_dead_by_cold_one_day = 0.1f;
/// <summary>
/// 巨型农作物，出现概率 
/// </summary>
public static float giant_crop_rate = 0.02f;
/// <summary>
/// 每次钓鱼获得巨型鱼的概率 
/// </summary>
public static float big_fish_rate = 0.00066f;
/// <summary>
/// 巨型鱼钓上来之后，先保留N天，再杀 
/// </summary>
public static int big_fish_temp_disable_day_count = 10;
/// <summary>
/// 巨型农作物所在格，增产倍数 
/// </summary>
public static int giant_crop_product_count_rate = 333;
/// <summary>
/// 巨型农作物所在农田，小棵作物增产 
/// </summary>
public static int giant_crop_product_side_effect = 2;
/// <summary>
/// 野菜刷新分组单位格大小（影响开局初始状态） 
/// </summary>
public static int wild_refresh_block_size = 50;
/// <summary>
/// 一个分组单位格中野菜的数量（影响开局初始状态） 
/// </summary>
public static int wild_vegetable_count_in_block = 50;
/// <summary>
/// 一个分组单位格中草药的数量（影响开局初始状态） 
/// </summary>
public static int herb_count_in_block = 50;
/// <summary>
/// 地图上，野生动物最大群数 
/// </summary>
public static int max_wild_animal_group_count = 35;
/// <summary>
/// 初始鹿群密度（一群鹿占的范围） 
/// </summary>
public static int init_wild_animal_density = 50;
/// <summary>
/// 鹿群迁移时间间隔天数 
/// </summary>
public static int wild_animal_move_interval_days = 90;
/// <summary>
/// 鹿群迁移距离 
/// </summary>
public static int wild_animal_move_dist = 90;
/// <summary>
/// 未与设施关联的动物尸体保留时间（天） 
/// </summary>
public static int animal_dead_body_keep_days = 1080;
/// <summary>
/// 猎鹿时，一群鹿至少保留的数量 
/// </summary>
public static int min_wild_animal_group_count_for_hunt = 3;
/// <summary>
/// 野生动物与设施保持距离值 
/// </summary>
public static int wild_animal_keep_dist_to_facility = 10;
/// <summary>
/// 一群鹿中，鹿与鹿之间的间隔 
/// </summary>
public static int deer_distance_in_one_group = 2;

public static int max_count_deer_in_group = 15;
/// <summary>
/// 学生学业上限 
/// </summary>
public static float max_knowledge_of_student = 100f;
/// <summary>
/// 受教育后，对工作效率的影响因子 
/// </summary>
public static float educated_effect = 1.25f;
/// <summary>
/// 地板对工作效率的影响
/// </summary>
public static float positive_impact_floorboard_around = 1.1f;
/// <summary>
/// 居民年龄上限随机范围，小值 
/// </summary>
public static int max_age_range1 = 60;
/// <summary>
/// 居民年龄上限随机范围，大值 
/// </summary>
public static int max_age_range2 = 99;
/// <summary>
/// 使用信仰“重生”之后，居民寿命延长年数
/// </summary>
public static int extend_age_of_magic_rebirth = 30;
/// <summary>
/// 祈祷开始日期 
/// </summary>
public static int pray_start_day_in_year = 315;
/// <summary>
/// 一对夫妻最多生育数量 
/// </summary>
public static int max_baby_count_of_one_family = 4;
/// <summary>
/// 一对贵族夫妻最多生育数量 
/// </summary>
public static int max_baby_count_of_one_noble_family = 8;
/// <summary>
/// 贵族生育的幸福度要求 
/// </summary>
public static int min_happiness_of_noble_create_baby = 80;
/// <summary>
/// 篝火晚会匹配成功率 
/// </summary>
public static float effect_of_bonfire = 0.5f;
/// <summary>
/// 自由恋爱解锁后，篝火晚会匹配成功率 
/// </summary>
public static float effect_of_bonfire_on_unlock_free_love = 0.1f;
/// <summary>
/// 参与自动婚配的最低幸福度（低于该值，只能通过篝火堆匹配） 
/// </summary>
public static int happiness_min_value_to_marry = 50;
/// <summary>
/// 解锁自由恋爱后，参与自动婚配的最低幸福度（低于该值，只能通过篝火堆匹配） 
/// </summary>
public static int happiness_min_value_to_marry_on_free_love_unlocked = 60;
/// <summary>
/// 解锁自由恋爱后，每月自动匹配的数量上限 
/// </summary>
public static int max_pair_count_pre_month_of_free_love = 5;
/// <summary>
/// 居民因单身产生孤独情绪的最小年龄 
/// </summary>
public static int min_lonely_age = 30;
/// <summary>
/// 居民因单身产生孤独情绪的最大年龄 
/// </summary>
public static int max_lonely_age = 50;
/// <summary>
/// 婴儿状态最大年龄 
/// </summary>
public static int baby_age_max = 3;
/// <summary>
/// 学生逃学N天后，转为辍学 
/// </summary>
public static int student_truancy_duration_days_max = 30;
/// <summary>
/// 老年人的判定年龄 
/// </summary>
public static int age_of_elder = 60;
/// <summary>
/// 门开后保持的时间（忽略加速的真实时间） 
/// </summary>
public static float open_door_keep_duration = 3f;
/// <summary>
/// 开门所需时间（忽略加速的真实时间） 
/// </summary>
public static float open_door_duration = 0.5f;
/// <summary>
/// 开栅栏门所需时间（忽略加速的真实时间） 
/// </summary>
public static float open_fence_door_duration = 0.5f;
/// <summary>
/// 独立房间的判定最大范围（在这个范围内必须有墙围住床） 
/// </summary>
public static int house_range_max = 15;
/// <summary>
/// 天黑时的灯光亮度 
/// </summary>
public static float dark_light_intensity = 0.75f;
/// <summary>
/// 居民一次睡觉天数的随机波动值 
/// </summary>
public static int npc_sleep_days_random = 5;
/// <summary>
/// 居民开始睡觉日期的随机波动值 
/// </summary>
public static int npc_sleep_start_random = 8;
/// <summary>
/// 搜集一次资源后，冷却的天数 
/// </summary>
public static int collect_cooldown_days = 1;
/// <summary>
/// 设施上展示的物品一堆所表示的数量 
/// </summary>
public static int max_heap_size = 500;
/// <summary>
/// 信仰领悟值的上限 
/// </summary>
public static int belief_value_max = 100;
/// <summary>
/// 每天增加的信仰点数 100/360
/// </summary>
public static float belief_magic_point_increase_every_day = 0.277778f;
/// <summary>
/// 每多新建一个传道台，信仰之力恢复速度增加百分比 
/// </summary>
public static float belief_magic_point_increase_speed_of_one_sermon_desk = 0.08f;
/// <summary>
/// 一次祈祷增加的领悟值 
/// </summary>
public static int belief_value_step = 10;
/// <summary>
/// 居民自行参悟信仰的每月增长信仰点数 
/// </summary>
public static int belief_value_self_taught_step_per_month = 10;
/// <summary>
/// 更换信仰，居民信仰混乱持续的年数 
/// </summary>
public static int belief_confusion_year_count_on_change_belief = 2;
/// <summary>
/// 旅行商队出现月份 
/// </summary>
public static string months_of_travel_caravan_appear = "2,8";
/// <summary>
/// 商队出现后，开始第一次寻路前等待的天数 
/// </summary>
public static int caravan_search_days = 3;
/// <summary>
/// 商队第一次寻路失败后，再次等待的天数 
/// </summary>
public static int caravan_search_again_days = 27;
/// <summary>
/// 商队会面等待的天数 
/// </summary>
public static int caravan_meeting_days = 30;
/// <summary>
/// 商队救命之恩的礼金（白银数量） 
/// </summary>
public static int gift_silver_count_of_caravan_requite = 3;
/// <summary>
/// 商队救命之恩的礼金放置在地图上，临时禁止天数 
/// </summary>
public static int gift_stuff_disable_days_count_of_caravan_requite = 5;
/// <summary>
/// 贸易码头界面上加减操作一次改变的数量 
/// </summary>
public static int trading_pos_increase_step = 200;
/// <summary>
/// 马车站发车间隔（天） 
/// </summary>
public static int wagon_station_dispatch_interval_days = 5;
/// <summary>
/// 线路马车，在起点车站运出牧草时，最多数自己保留的牧草数量
/// </summary>
public static int keep_count_of_forage_grass_for_wagon_station = 2000;
/// <summary>
/// 马车回车站后，冷却N天后，再开始运输 
/// </summary>
public static int wagon_cool_down_for_transport = 10;
/// <summary>
/// 马车夫一趟运输完，放假N天 
/// </summary>
public static int coachman_rest_days_count = 30;
/// <summary>
/// 居民浇水壶的容量 
/// </summary>
public static int water_kettle_capacity_max = 50;
/// <summary>
/// 居民钓鱼成功率 
/// </summary>
public static float fishing_succ_rate = 0.75f;
/// <summary>
/// 采集工人（采集小屋，草药屋）背包存量达到N时，将物品放到设施中 
/// </summary>
public static int stuff_count_to_put_for_gather = 10;
/// <summary>
/// 采集营地，单人单位产出所需天数 
/// </summary>
public static int mature_interval_one_res_one_work = 6;
/// <summary>
/// 合成制作设施，产品存储上限 
/// </summary>
public static int workshop_product_storage_count = 1;
/// <summary>
/// 任务分配周期 
/// </summary>
public static float assign_task_interval = 0.5f;
/// <summary>
/// 玩家地图，边界N格的区域，不能建造 
/// </summary>
public static int map_border_width = 10;
/// <summary>
/// 通商口岸在地图边缘可建造区域宽度 
/// </summary>
public static int map_border_width_for_trading_port = 25;
/// <summary>
/// 怪物在初期闲逛的区域 
/// </summary>
public static int map_border_width_for_monster_wander = 50;
/// <summary>
/// 求援冷却时间（天） 
/// </summary>
public static int ask_rescue_cd_days = 3;
/// <summary>
/// 照顾临终老人失败后的冷却时间(天) 
/// </summary>
public static int look_after_elder_cd_days = 30;
/// <summary>
/// 休克后总的生命值 
/// </summary>
public static int shock_life_value = 360;
/// <summary>
/// 婴儿休克后总的生命值 
/// </summary>
public static int shock_life_value_of_baby = 30;
/// <summary>
/// 因病休克后的生命值 
/// </summary>
public static int shock_life_value_of_ill = 720;
/// <summary>
/// 休克状态，睡医疗床上，生命值减少速度 
/// </summary>
public static float shock_decrease_life_value_on_medical_bed = 0.5f;
/// <summary>
/// 休克状态，睡床上，生命值减少速度 
/// </summary>
public static float shock_decrease_life_value_on_bed = 1f;
/// <summary>
/// 休克状态，睡地上，生命值减少速度 
/// </summary>
public static float shock_decrease_life_value_on_ground = 3f;
/// <summary>
/// 居民被攻击休克后，昏迷时间（天数） 
/// </summary>
public static int shock_by_attack_duration_days = 60;
/// <summary>
/// 刷出第一个属性的概率 
/// </summary>
public static float nature_rate1 = 0.25f;
/// <summary>
/// 刷出第一个属性的概率 
/// </summary>
public static float nature_rate2 = 0.25f;
/// <summary>
/// 游戏加速档位 
/// </summary>
public static string speed_config = "1, 3, 5, 10";
/// <summary>
/// 帧动画播放加速档位 
/// </summary>
public static string anim_speed_config = "0.75, 0.875, 1, 1.5";
/// <summary>
/// 工具缺乏判定延迟天数 
/// </summary>
public static int no_tools_days_to_notice = 10;
/// <summary>
/// 衣服缺乏判定延迟天数 
/// </summary>
public static int no_clothes_days_to_notice = 10;
/// <summary>
/// 空闲判定延迟天数 
/// </summary>
public static int no_work_days_to_notice = 10;
/// <summary>
/// 寻路失败后，对某类任务的禁止期（天） 
/// </summary>
public static int task_black_list_duration_days = 3;
/// <summary>
/// 雨水浇地，对单个农田，一天最多可以浇的块数 
/// </summary>
public static int max_count_watering_by_rain_a_day = 4;
/// <summary>
/// 大雨浇地，对单个农田，一天最多可以浇的块数 
/// </summary>
public static int max_count_watering_by_rain_heavy_a_day = 8;
/// <summary>
/// 小雨每天为花盆成功浇水的概率
/// </summary>
public static float watering_rate_for_flowerpot_by_rain_a_day = 1/60f;
/// <summary>
/// 大雨每天为花盆成功浇水的概率
/// </summary>
public static float watering_rate_for_flowerpot_by_rain_heavy_a_day = 1/30f;
/// <summary>
/// 下大雨的概率 
/// </summary>
public static float rain_heavy_rate = 0.5f;
/// <summary>
/// 春天或夏下下雨的概率 
/// </summary>
public static float rain_rate_in_spring_or_summer_of_day = 0.02f;
/// <summary>
/// 秋天或冬天下雨的概率
/// </summary>
public static float rain_rate_in_autumn_or_winter_of_day = 0.005f;
/// <summary>
/// 春雨持续天数最小 
/// </summary>
public static int rain_duration_days_min_in_spring = 15;
/// <summary>
/// 春雨持续天数最大 
/// </summary>
public static int rain_duration_days_max_in_spring = 20;
/// <summary>
/// 夏雨持续天数最小 
/// </summary>
public static int rain_duration_days_min_in_summer = 7;
/// <summary>
/// 夏雨持续天数最大 
/// </summary>
public static int rain_duration_days_max_in_summer = 12;
/// <summary>
/// 秋雨持续天数最小 
/// </summary>
public static int rain_duration_days_min_in_autumn = 15;
/// <summary>
/// 秋雨持续天数最大 
/// </summary>
public static int rain_duration_days_max_in_autumn = 20;
/// <summary>
/// 冬雨持续天数最小 
/// </summary>
public static int rain_duration_days_min_in_winter = 7;
/// <summary>
/// 冬雨持续天数最大 
/// </summary>
public static int rain_duration_days_max_in_winter = 12;
/// <summary>
/// 雪持续的天数 
/// </summary>
public static int snow_duration_days = 15;
/// <summary>
/// 干旱天气概率 平均50年一遇
/// </summary>
public static float dry_weather_rate = 0.02f;
/// <summary>
/// 干旱开始发生的月份 从0开始
/// </summary>
public static int dry_weather_start_month = 2;
/// <summary>
/// 干旱结束月份 从0开始
/// </summary>
public static int dry_weather_end_month = 11;
/// <summary>
/// 干旱最多持续时间（年） 
/// </summary>
public static int dry_weather_duration_years_max = 3;
/// <summary>
/// 干旱水域单格掉落概率 
/// </summary>
public static float dry_weather_stuff_drop_rate = 0.05f;
/// <summary>
/// 干旱单位掉数数量（平均） 
/// </summary>
public static int dry_weather_stuff_drop_count_unit = 50;
/// <summary>
/// 干旱后一年，水产减产到比例 
/// </summary>
public static float dry_weather_effect_of_fishing_product_next_year_after_end_year = 0.5f;
/// <summary>
/// 日食概率 
/// </summary>
public static float eclipse_weather_rate = 0.02f;
/// <summary>
/// 日食持续时间（月数） 
/// </summary>
public static int eclipse_duration_months = 3;
/// <summary>
/// 日食发生时，墓园最多产生的幽灵数量 
/// </summary>
public static int max_ghost_count_of_cemetery_on_eclipse = 15;
/// <summary>
/// 荒废的单墓碑，在晚上每N个，出一只鬼魂 
/// </summary>
public static float ghost_pre_tombstone_count = 0.1f;
/// <summary>
/// 深井开采后，矿产资源总数倍数 
/// </summary>
public static int mine_deep_res_multiple = 5;
/// <summary>
/// 深井开采时，开采时长倍数 
/// </summary>
public static float mine_deep_work_duration_multiple = 2f;
/// <summary>
/// 废弃的矿井，在晚上出怪最少 
/// </summary>
public static int monster_count_of_abandoned_mine_min = 3;
/// <summary>
/// 废弃的矿井，在晚上出怪最多 
/// </summary>
public static int monster_count_of_abandoned_mine_max = 6;
/// <summary>
/// 室内设施建在室外后，工作效率影响（工时延长倍数） 
/// </summary>
public static float indoor_facility_in_outside_effect = 2f;
/// <summary>
/// 商队最早出现时间（年） 
/// </summary>
public static int caravan_first_appear_year = 1;
/// <summary>
/// 初始可召唤的小精灵的次数 
/// </summary>
public static int sprite_call_count_max_default = 5;
public static int sprite_call_count_max = 9;
/// <summary>
/// 小精灵存活的天数 
/// </summary>
public static int sprite_exist_day_count = 90;
/// <summary>
/// 小精灵移动速度倍率 
/// </summary>
public static float sprite_move_speed_rate = 2.5f;
/// <summary>
/// 挨饿人数超过这值时，判定为发生了饥荒 
/// </summary>
public static float npc_count_of_famine = 10f;
/// <summary>
/// APP过期时间 
/// </summary>
public static string date_app_expire = "2024-12-30";
/// <summary>
/// 脱离战斗N秒后，开始自动回血 
/// </summary>
public static float duration_to_auto_hp_recover_from_battle = 3f;
/// <summary>
/// 每次回血间隔 
/// </summary>
public static float interval_of_auto_hp_recover_from_battle = 3f;
/// <summary>
/// 每次自动回血百分比（相对于总血量） 
/// </summary>
public static float rate_of_auto_hp_recover_from_battle = 0.01f;
/// <summary>
/// 一批强盗被消灭后，下一批出现延迟月数 
/// </summary>
public static int bandit_level_interval_month_count = 23;
/// <summary>
/// 强盗讲和，每个强盗士兵所需物品折价为白银 
/// </summary>
public static int bandit_stuff_need_as_silver = 100;
/// <summary>
/// 采石点，加速模式，加速倍率 
/// </summary>
public static int quarry_point_speed_up_rate = 3;
/// <summary>
/// 拆果园时，安排砍果树的闲杂工数量上限 
/// </summary>
public static int max_cut_fruit_tree_npc_count = 5;
/// <summary>
/// 牧场动物超载数量倍率,超过后，动物不再产仔 
/// </summary>
public static float max_animal_count_outstrip_rate_in_pasture = 1.5f;
/// <summary>
/// 牧场动物超载后,幼仔数量的比例超过后，停止产仔 
/// </summary>
public static float max_young_animal_rate_in_pasture_on_full = 0.2f;
/// <summary>
/// 采石场开采量，超过该百分比，会留下大坑 
/// </summary>
public static float quarry_res_stock_remain_rate_of_dismantle_to_water_pool = 0.9f;
/// <summary>
/// 蜜蜂移动速度 
/// </summary>
public static float bee_move_speed = 0.35f;
/// <summary>
/// 蜜蜂采蜜时间（秒） 
/// </summary>
public static float bee_idle_duration = 5f;
/// <summary>
/// 蜜蜂派出间隔 
/// </summary>
public static float bee_send_out_interval = 2f;
/// <summary>
/// 蜂箱的容量 
/// </summary>
public static int hive_capacity = 100;
/// <summary>
/// 赏花的消耗时间 
/// </summary>
public static float watch_flower_duration = 2f;
/// <summary>
/// 赏花数量在N时，算比较多的 
/// </summary>
public static int count_of_watch_flower_a_lot = 3;
/// <summary>
/// 赏花冷却时间 
/// </summary>
public static int watch_flower_cool_down_duration_days = 5;
/// <summary>
/// 史莱姆第一次出现的年份（即N年前不出） 
/// </summary>
public static int slime_monster_egg_first_appear_years = 10;
/// <summary>
/// 史莱姆在边境出现的时间间隔N年 
/// </summary>
public static int slime_monster_egg_appear_interval_years = 5;
/// <summary>
/// 史莱姆出现的月份 
/// </summary>
public static int slime_monster_egg_appear_month_in_year = 8;
/// <summary>
/// 史莱姆吃庄稼N个之后，会下蛋 
/// </summary>
public static int slime_lay_egg_condition_of_food = 5;
/// <summary>
/// 史莱姆吃东西需要的时间（秒） 
/// </summary>
public static int slime_eat_food_duration_second = 15;
/// <summary>
/// 史莱姆在农田中移动速度倍率 
/// </summary>
public static float slime_move_speed_rate_on_crop_field = 0.5f;
/// <summary>
/// 史莱姆下蛋的冷却间隔（天） 
/// </summary>
public static int lay_egg_interval_days = 3;
/// <summary>
/// 史莱姆吃下巨型作物后，下蛋数量上限 
/// </summary>
public static int lay_egg_max_pre_time = 9;
/// <summary>
/// 随机一次出现的传染病蜗牛数量  
/// </summary>
public static int monster_count_of_infection = 3;
/// <summary>
/// 传染病蜗牛每年出现的概率 
/// </summary>
public static float rate_of_monster_infection_appear = 0.1f;
/// <summary>
/// 蜗牛产生鼻涕的时间间隔 
/// </summary>
public static int monster_drop_infection_source_interval_days = 1;
/// <summary>
/// 鼻涕（传染源）在地图上保留时间（天） 
/// </summary>
public static int infection_source_keep_days = 15;
/// <summary>
/// 士兵在军营区域内待机N秒后，自动转为非战斗状态 
/// </summary>
public static int duration_of_soldier_auto_line_up_in_barracks_range = 100;
/// <summary>
/// 被药丸治疗后，士兵血量恢复到总血量的比率 
/// </summary>
public static float hp_percent_on_rescue_by_pill = 0.8f;
/// <summary>
/// 盔甲的保暖系数 
/// </summary>
public static float armor_clothes_heat_effect = 0.5f;
/// <summary>
/// 药剂的免疫功效时长（天） 
/// </summary>
public static int immune_duration_days_of_pill = 1080;
/// <summary>
/// 蜗牛产生鼻涕的时间间隔 
/// </summary>
public static float battle_target_give_up_track_dist_rate = 1.5f;
/// <summary>
/// 囚犯绑定事件的概率 
/// </summary>
public static float prison_event_rate = 0.25f;
/// <summary>
/// 蛮族部队，随机移动目标位置，到当前位置的最近距离 
/// </summary>
public static int troop_random_move_dist_min = 20;
/// <summary>
/// 蛮族部队，随机移动目标位置，到当前位置的最远距离 
/// </summary>
public static int troop_random_move_dist_max = 50;
/// <summary>
/// 蛮族部队换行间隔 
/// </summary>
public static int interval_days_changing_of_guard = 30;
/// <summary>
/// 蛮族部队，士兵移动间隔 
/// </summary>
public static int interval_days_team_move = 6;
/// <summary>
/// 通商口岸非计划物品，默认折扣 
/// </summary>
public static int trading_port_default_discount = 50;
/// <summary>
/// 旅行商人非计划物品，默认折扣 
/// </summary>
public static int trading_desk_default_discount = 80;
/// <summary>
/// 旅行商人前期优惠折扣配置，按人口优惠减少 
/// </summary>
public static string discount_config_favourable_of_travel_caravan = "60,120,180:40,20,0";
/// <summary>
/// 通商口岸的采购优惠取消条件（玩家人口数） 
/// </summary>
public static int discount_favourable_cancel_of_port_caravan = 200;
/// <summary>
/// 开局前N年，强制怪物只在地图边缘活动 
/// </summary>
public static int before_this_year_monster_only_wander_at_map_edge = 20;
/// <summary>
/// 放弃最佳任务分配算法的阀值（任务数*备选人>N） 
/// </summary>
public static int threshold_to_skip_finding_best_path_on_task_assign = 100;
/// <summary>
/// 贷款金额上限 
/// </summary>
public static int loan_limit = 9999;
/// <summary>
/// 贷款年利率 
/// </summary>
public static float loan_interest_rate = 0.035f;
/// <summary>
/// 存款利率 
/// </summary>
public static float deposit_rate = 0.01f;
/// <summary>
/// 单次雇佣人数上限 
/// </summary>
public static int hire_count_limit = 100;
/// <summary>
/// 雇佣最大年限 
/// </summary>
public static int hire_duration_years_limit = 5;
/// <summary>
/// 雇佣单人一年的费用 
/// </summary>
public static int hire_fee_of_one_year = 1;
/// <summary>
/// 雇工死亡赔偿 
/// </summary>
public static int fee_of_hire_worker_dead = 10;
/// <summary>
/// 招揽一个流民的预估费用 
/// </summary>
public static int fee_of_solicit_refugee = 50;
/// <summary>
/// 每年流民自动出现的概率 
/// </summary>
public static float refugee_appear_rate = 0.33f;
/// <summary>
/// 有文化雇工价格倍数 
/// </summary>
public static float hire_worker_educated_discount = 3f;
/// <summary>
/// 贸易口岸单物品上限 
/// </summary>
public static int caravan_max_stuff_count = 99999;
/// <summary>
/// 牧场动物少于N只时，不播放动物音效 
/// </summary>
public static int min_animal_count_in_pasture_to_play_sound_effect = 3;
/// <summary>
/// 设施场景音效尝试播放的间隔 
/// </summary>
public static int facility_env_sound_interval = 3;
/// <summary>
/// 设施场景音效播放概率 
/// </summary>
public static float facility_env_sound_rate = 0.1f;
/// <summary>
/// 囚犯不在牢房内，N天后，会自己逃跑 
/// </summary>
public static int max_prison_escape_duration_days = 90;
/// <summary>
/// 先知每次洗脑，囚犯降低抵抗度 
/// </summary>
public static int decrease_of_resistance_pre_time_one_converting = 10;
/// <summary>
/// 囚犯被洗脑一次（或洗脑任务失败）后冷却N天，才可再被洗脑 
/// </summary>
public static int be_convert_cd_days = 10;
/// <summary>
/// 囚犯被处决任务失败后，冷却N天才能再次被处决 
/// </summary>
public static int be_execute_cd_days = 5;
/// <summary>
/// 囚犯吃到精致食物，降低抵抗度的值 
/// </summary>
public static int decrease_resistance_by_supply_good_food = 2;
/// <summary>
/// 囚犯喝到酒，降低抵抗度的值 
/// </summary>
public static int decrease_resistance_by_supply_wine = 2;
/// <summary>
/// 囚犯生病后，每月降低抵抗度的值 
/// </summary>
public static int decrease_resistance_by_ill = 1;
/// <summary>
/// 研究员每天贡献的研究点数 
/// </summary>
public static float research_point_per_day = 1f;
/// <summary>
/// 临终死亡前，开始找床卧床到最终死亡的持续的时间 
/// </summary>
public static int days_count_stay_on_bed_before_old_to_die = 90;
/// <summary>
/// 资源生产型设施，N天没人搬物品，则不论数量多少，也让闲杂工搬 
/// </summary>
public static int days_count_of_res_facility_handyman_to_clear_product = 30;

/// <summary>
/// 一神教加学习效率影响 
/// </summary>
public static float study_impact_of_belief_monotheism = 1.25f;
/// <summary>
/// 灵感爆发的作用的次数 
/// </summary>
public static int inspiration_explode_max_times = 5;
/// <summary>
/// 奖励对幸福度的影响 
/// </summary>
public static int reward_effect_of_happiness = 15;
/// <summary>
/// 奖励对工作效率的影响倍数 
/// </summary>
public static float reward_effect_of_work = 1.5f;
/// <summary>
/// 奖励对有作用时长 
/// </summary>
public static int reward_effect_duration_days = 90;
/// <summary>
/// 居民执行捡起任务，物品附近有怪物时，短期禁止物品的捡起任务天数 
/// </summary>
public static int stuff_on_map_disabled_duration_days_by_danger_around = 30;
/// <summary>
/// 附近N格有怪物时，算有危险 
/// </summary>
public static int dist_to_fear_danger = 10;

public static int danger_area_dist_of_map_edge = 20;
/// <summary>
/// 自由恋爱开启后，结婚匹配的最大年龄差 
/// </summary>
public static int max_age_gap_when_free_love_unlock = 10;
/// <summary>
/// 拳头伤害按百分比 
/// </summary>
public static float fist_hurt_percent = 0.05f;
/// <summary>
/// 士兵的补给周期天数 
/// </summary>
public static int soldier_supply_interval_days = 30;
/// <summary>
/// 连续捡东西时，扫描的范围N 
/// </summary>
public static int pick_up_nearby_dist = 5;
/// <summary>
/// 连续捡东西时，如果附近范围N内有怪，则不连续捡 
/// </summary>
public static int give_up_pick_up_nearby_dist_of_soldier = 7;
/// <summary>
/// 士兵掉落组号段 
/// </summary>
public static int soldier_drop_group_id = 1000;
/// <summary>
/// 居民颜值随机范围下限 
/// </summary>
public static int init_npc_appearance_min = 30;
/// <summary>
/// 居民颜值随机范围上限 
/// </summary>
public static int init_npc_appearance_max = 80;
/// <summary>
/// 玩家士兵被打倒后，武器损坏概率 
/// </summary>
public static float soldier_weapon_damage_chance_on_be_hit_to_shock = 0.05f;
/// <summary>
/// 自由模式下，马车夫运输N次后，进入休息状态 
/// </summary>
public static int count_to_rest_after_task_transport_by_wagon_in_mode_no_fixed_route = 5;
/// <summary>
/// 怪物吃了食物后的温顺时间 
/// </summary>
public static int tame_duration_days_after_eat_food = 90;
/// <summary>
/// 怪物在一格中，过于拥挤而停止进食数量阀值 
/// </summary>
public static int too_crowded_for_monster = 100;
    
    
    public static int expand_range_to_find_pos_at_edge_for_monster_create = 5;
    public static int year_to_start_show_guide_of_facility = 5;
    public static int year_to_start_show_toolbar_guide_tip = 6;
    public static int year_to_start_show_guide_tip_on_facility_window = 6;
    public static int year_not_notice_elf_created = 5;

    public static float hire_worker_for_collect_share_rate = 0.25f;
    public static int years_before_dead_to_retire_of_soldier = 5;
    public static int area_product_multiple_on_first_occupy = 3;
    public static int max_develop_level = 5;
    public static int village_war_max_duration = 720;
    public static int max_year_count_of_conscript = 3;
    public static int duration_days_of_facility_restore_hp_start = 15;
    public static float restore_facility_workload_percent_per_time = 0.1f;
    public static int restore_facility_workload_per_time_min = 10;
    public static int ai_cannon_supply_interval_days = 30;
    public static int gather_people_count_per_level = 10;
    public static float ai_ship_shoot_bomb_cooldown_unscale_time = 3;
    public static float drop_wood_of_ship_percent = 0.25f;
    public static float prisoner_work_duration_multiple = 2f;
    public static int max_wagon_for_clear_transport = 2;
    public static int furnace_burn_interval = 3;
    public static int megalodon_stay_duration_days = 360;
    public static int month_of_lizard_man = 5;
    public static int happiness_of_werewolf_to_crazy = 60;
    public static int happiness_of_werewolf_to_crazy_on_eclipse = 80;
    public static int max_crazy_werewolf_count = 5;
    public static int max_kill_animal_count_on_crazy = 20;
    public static int feed_animal_interval_of_wagon = DTime.DAY_IN_YEAR;
    public static int feed_interval_of_mount = 360;
    public static int month_of_animals_in_estrus = 2;
    public static int animal_courtship_duration_days_outside_pasture = 30;
    public static int max_days_for_npc_dead_body_to_skeleton = 5400;
    public static int skeleton_soldier_lifetime = 3600;
    public static int recruit_immigrants_count_per_time = 30;
    public static int recruit_immigrants_price = 100;
    public static int prison_resistance_refuse_noble = 80;
    public static float militia_hp_recovery_percent_per_day = 0.033f;
    public static int carry_pill_count_max_of_soldier = 10;
    public static int loyalty_effect_when_has_nature_loyal = 30;
    public static int loyalty_effect_when_is_royal = 10;
    public static int loyalty_effect_on_enter_banquet = 2;
    public static int loyalty_effect_on_enter_banquet_max = 50;
    public static int loyalty_effect_for_canonize = 20;
    public static int loyalty_to_corrupt = 60;
    public static int loyalty_too_low_and_notice = 30;
    public static int management_ability_too_low_and_notice = 30;
    public static int loyalty_of_good_governor = 80;
    public static int loyalty_of_good_earl = 80;
    public static int max_silver_of_earl = 10000;
    public static int change_of_loyalty_every_year_80_100 = 5;
    public static int change_of_management_ability_every_year_80_100 = 5;
    public static int effect_of_management_ability = 3;
    public static int change_of_loyalty_after_query_of_governor = 5;
    public static int change_of_loyalty_after_query_of_earl = 3;
    public static int change_of_loyalty_after_battle_of_earl = 3;
    public static int change_of_loyalty_after_inherit_of_earl = 5;
    public static int loyalty_increase_of_royal = 10;
    public static int change_of_loyalty_after_marriage_of_earl = 20;
    public static int change_of_loyalty_after_marriage_of_earl_posterity = 10;
    public static int loyalty_effect_of_reward_max = 50;
    public static int loyalty_effect_of_saint = 10;
    public static int loyalty_for_living_room_with_golden_floor = 10;
    public static int book_count_limit_for_noble = 10;
    public static int military_ability_effect_when_has_nature_brave = 30;
    public static int management_ability_effect_when_has_nature_wisdom = 30;
    public static float noble_attr_from_parent_percent = 0.3f;
    public static int military_ability_effect_of_battle_max = 50;
    public static float military_ability_effect_of_battle_of_monster = 0.1f;
    public static int year_of_territory_initial = 10;
    public static int days_count_neutral_soldier_change_to_traveller = 5;
    public static float atk_range_to_near_for_remote_rate = 0.333f;
    public static float atk_range_for_remote_rate_to_keep_dist = 0.6f;
    public static int noble_training_program_min_age = 10;
    public static int noble_training_program_max_age = 60;
    public static int official_selection_program_min_age = 20;
    public static int official_selection_program_max_age = 60;
    public static int min_count_keep_noble_for_diplomacy = 10;
    public static int max_count_keep_noble_for_diplomacy = 999;
    
    public static float reward_of_kill_monster = 0.5f;
    public static float reward_of_kill_enemy = 1f;
    
    public static int max_npc_count_in_burrow = 20;
    public static float career_effect_of_make_of_race_not_dwarf = 0.85f;
    public static float career_effect_when_mismatch_of_teacher_or_minister = 0.5f;
    public static int max_effect_range_of_banquet_table = 100;
    public static float magic_power_of_one_book = 0.01f;
    public static float decrease_hurt_of_magic_of_titan = 0.1f;
    public static float decrease_hurt_iron_bomb_of_titan = 0.01f;
    public static int year_of_titan_sermon_by_altar = 10;
    public static int banquet_start_day_in_month = 10;
    public static int banquet_end_day_in_month = 25;
    public static float rate_of_contracting_malaria_from_mosquito_bites = 0.01f;
    public static int max_count_of_mosquito_to_create_in_pig_man_houes = 3;
    public static int month_in_year_to_create_mosquito = 4;
    public static int month_in_year_to_destroy_mosquito = 7;
    public static int mosquito_count_max_create_on_faeces = 20;
    public static float faeces_to_create_mosquito_rate = 0.5f;
    public static float facility_to_create_mosquito_rate = 0.5f;
    public static int cat_man_marry_month = 1;
    public static int cat_man_divorce_month = 6;
    public static int save_day_in_year = 181;
    public static int dinner_table_service_range_max = 20;
    public static float mount_drop_rate_after_repel = 0.1f;
    public static float soldier_restraint_effect_on_attack = 1.5f;
    public static float lord_inherit_fee_rate = 0.1f;
    public static int new_lord_follower_count_min = 3;
    public static int new_lord_follower_count_max = 10;
    public static float hit_to_dead_rate_by_unknown = 0.3f;
    //贵族兵种，血量为零时，直接致死的概率进一步降低
    public static float dead_rate_reduce_of_noble_soldier = 0.25f;
    public static int cost_gem_count_of_ice_cellar = 1;

    public static float inventory_gaps_prompting_replenish_of_facility_default = 0.8f;
    
    public static int[] holy_star_of_word_game = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17 };
    public static int word_count_to_obtain_holy_star = 8;
    
    //方尖碑
    public static float obelisk_effect_duration = 15;
    public static float obelisk_circle_attack_buff_effect_interval = 1f;
    #region 战斗
    public static float soldier_re_findpath_dist_threshold_on_battle_when_target_moved = 1f;
    public static float min_dist_x_for_melle_attack = 0.5f;
    public static float stand_dist_x_for_melle_attack = 1f;
    public static float call_helper_range = 5;
    public static int npc_notify_danger_range = 5;
    public static float interval_for_batch_put = 0.1f;
    public static float monster_rov_agent_radius = 0.1f;
    public static float soldier_rov_agent_radius = 0.2f;
    public static float double_click_interval = 0.75f;
    public static float mouse_left_press_interval = 0.25f;
    public static int delta_max_of_monster_level_and_player_weapon_level = 1;
    
    public static int pill_count_take_along_multiplier_by_soldier_orderly = 3;
    public static int immune_ill_at_new_game_begining_of_year = 3;
    public static float fail_rate_shot_in_rain = 0.8f;

    #endregion

    #region 强盗配置

    public static int ai_barracks_supply_interval_days = 360;
    public static int enemy_level_interval_month_count = 39;
    #endregion

    #region 怪物

    public static int monster_level_interval_month_count = 20;
    public static int max_monster_count = 200;
    public static int max_monster_titan_count = 30;
    
    public static int monster_facility_layout_grid_size = 30;
    public static float monster_idle_time_on_find_no_way = 10;
    public static int monster_great_view_range_rate = 10;
    public static float find_facility_to_attack_range_multiplier = 0.5f;
    public static int eat_wood_duration_or_monster18 = 10;
    public static int eat_wood_duration_or_monster19 = 20;
    public static int min_appearance_of_good_look = 80;
    
    public static float slime_lay_egg_duration_second = 30;
    public static int monster_eat_food_interval_days_on_groud = 3;
    
    public static int megalodon_appear_month_in_year = 3;
    public static int dead_body_count_for_megalodon_appear = 100;
    public static int megalodon_count_appear_for_npc_dead_body = 20;
    public static int max_count_of_megalodon = 1000;
    
    public static int hp_buff_area_keep_days = 90;

    public static int dist_max_of_monster_in_group = 10;
    #endregion
    
    public static int days_count_for_stuff_to_dismiss_on_water = 360;
    
    #region AI生产配置
    
    public static int days_count_caravan_force_to_leave = 200;
    public static int caravan_notice_keep_days_count = 90;
    #endregion

    public static int workshop_materails_access_range_default = 50;
    public static int workshop_bed_connect_dist_limit = 40;

    public static int map_extend_h = 150;
    public static int map_extend_gate_width = 20;
    public static int map_extend_board = 20;
    
    public static float cannon_bomb_fly_speed = 5f;
    public static float nature_wisdom_effect_of_inspiration = 2;
    
    public static int go_to_toilet_interval = 360;
    public static int go_to_toilet_interval_random_range = 30;
    public static int find_militia_equip_cd_days = 30;
    public static int toilet_alternative_count = 10;
    public static int toilet_waiting_max = 5;
    public static int toilet_alternative_max_dist = 50;
    
    //柴火消耗量
    public static int day_count_for_prepare_brazier = 5;
    public static float fuel_day_cost_of_brazier = 0.2f;
    public static float fuel_day_cost_of_torch = 0.06f;
    
    public static float threshold_to_check_lack_cooked_food = 0.5f;
    
    public static int too_crowd_and_sleep_on_ground_to_leave = 300;
    
    public static int max_duration_days_for_npc_waiting_for_nearby_task = 5;
    public static int max_dist_for_npc_waiting_for_nearby_task = 100;

    public static float child_grow_well_speed_effect = 1.1f;
    
    public static int traveller_buy_stuff_cd_days = 10;
    public static int traveller_check_in_cd_days = 10;
    public static int traveller_recruit_price_min = 10;
    public static int traveller_recruit_price_max = 1000;
    public static int traveller_recruit_max_times = 3;
    public static int traveller_recruit_condition_happiness = 80;
    public static int traveller_recruit_condition_people_count = 50;
    public static float traveller_recruit_rate_for_couple = 0.5f;
    public static float traveller_recruit_rate_for_child = 0.5f;
    
    public static int take_bath_cd_days = 360;
    public static int find_public_bath_cd_days = 10;
    public static int traveller_play_poker_cd_days = 3;
    public static int duration_days_of_play_poker = 3;
    public static float play_poker_service_charge_rate = 0.02f;
    public static int poker_table_round_max_to_clear = 10;
    
    public static int traveller_play_roulette_wheel_cd_days = 3;
    public static int roulette_wheel_bet_type_count = 12;
    public static int roulette_wheel_odds = 10;
    public static int roulette_wheel_bet_max_bet_amount = 99999;
    public static int max_betting_preference_count = 6;

    /// <summary>
    /// 每建一个扑克台，可增加的旅客数量
    /// </summary>
    public static int traveller_count_increase_step_of_poker_table = 1;
    /// <summary>
    /// 扑克台能带来的旅客数量增益
    /// </summary>
    public static int poker_table_count_max_to_increase_traveller_count = 9;
    /// <summary>
    /// 每建一个轮盘，可增加的旅客数量
    /// </summary>
    public static int traveller_count_increase_step_of_roulette_wheel = 1;
    /// <summary>
    /// 轮盘能带来的旅客数量增益
    /// </summary>
    public static int roulette_wheel_count_max_to_increase_traveller_count = 9;
    /// <summary>
    /// 每建一个公共浴室，可增加的旅客数量
    /// </summary>
    public static int traveller_count_increase_step_of_public_bath = 5;
    /// <summary>
    /// 公共浴室能带来的旅客数量增益
    /// </summary>
    public static int public_bath_count_max_to_increase_traveller_count = 2;
    public static int ring_durable_max = 100;
    public static int nacklace_durable_max = 100;

    public static int find_equip_cd_days = 5;
    
    public static int read_book_interval_days_interval_days_min = 690;
    public static int read_book_interval_days_interval_days_max = 720;
    public static int days_count_to_unhappy_on_lack_book = 720;

    public static int find_path_to_bed_cd_days = 6;
    public static int water_count_max_in_well = 1000;
    public static int water_count_recover_a_day_of_well = 25;
    public static float water_count_recover_speed_of_well_on_dry_weather = 0.5f;

    public static int wild_vegetable_mature_days = 28;

    //每50*50的范围内，有一群鹿
    public static int min_wild_animal_group_count_of_one_type = 10;
    public static int adjust_dist_max_for_deer = 50;
    public static int adjust_dist_max_for_nav = 50;
    
    public static int tree_mature_years1 = 5;   
    public static int tree_mature_years2 = 8;   
    public static int max_age_days_of_grass = 1800;
    
    //领主光环
    public static float halo_rotate_speed1 = 90;
    public static float halo_rotate_speed2 = 180;
    public static float halo_rotate_speed3 = 270;
    public static float halo_rotate_speed4 = 360;
    public static float lord_halo_effect_cooldown = 0.5f;
    public static float atk_miss_rate_of_lord_halo_attack_to_titan = 0.75f;

    //生肓参数
    public static int max_baby_count_of_one_lord_family = 8;
    //幸福度低于50，会拒绝结婚
    public static int happiness_min_value_to_find_minister_to_tell = 50;
    public static int find_minister_to_tell_cd_days_min = 360;
    public static int find_minister_to_tell_cd_days_max = 540;

    //以床为中心，N格的范围，作为判定独立房间的区域
    public static int view_range_in_fog = 8;

    public static int base_npc_count_of_belief = 500;
    public static int base_max_belief_value = 100;
    public static int increment_max_belief_value = 50;
    
    //贸易
    public static int wagon_on_free_mode_idle_days_to_park = 10;
    public static float order_stuff_price_discount = 2f;

    //玩家地图，边界10格的区域玩家不能建造，通商口岸只能建在边缘20格范围内
    public static int map_border_disable_dist_for_caravan = 1;
    public static int map_border_width_for_caravan = 4;


    //游民大概率是负面天赋
    public static float nature_bad_rate_of_refugee = 0.8f;
    public static float nature_rate_of_refugee_of_letter = 0.01f;
    public static int fee_of_solicit_resident = 100;
    
    public static float nature_bad_rate_of_immigration = 0.5f;
    public static float nature_rate_of_immigration_of_letter = 0.1f;
    
    //大地图迁移
    public static int age_for_migrate_max = 40;
    
    public static int year_of_governor_max = 8;
    public static int year_of_governor_max_of_noble = 10;

    
    public static int indoor_max_dist_to_wall = 10;
    public static int dry_weather_first_start_year = 6;
    public static float increase_rate_of_fishing_product_for_deep_water = 1.5f;
    public static int dry_weather_start_year_at_new_game = 5;


    public static float eclipse_weather_first_start_year = 10;
    
    public static int snow_anim_duration = 20;

    //游戏中的一天，对应的真实时间
    public static float days_to_game_time_second = (24 * 60 * 60) / time_scale; 
    public static float game_time_second_to_days = 1 / days_to_game_time_second;

    public static int cold_wave_effect_of_temperature = 15;
    public static int cold_wave_extreme_effect_of_temperature = 28;
    //怪物被冻住需要很低的温度，但解封需要到0度。这样怪物被冻的时间会更长一些
    public static int temperature_of_monster_be_frozen = -15;
    public static int temperature_of_monster_be_unfrozen = 0;
    public static int temperature_of_farmland_sow = 0;
    public static int temperature_of_farmland_watering = 0;
    //NPC与动物的移动，个人间都会有轻微差异，避免视觉上太过同步

    public static int batch_max_count_to_create_task = 50;
    public static int max_animal_dead_body_binding_to_hunting_cabin = 2;
    public static int flower_pot_watering_interval_days = 360;
    public static int flower_pot_water_need = 4;
    /// <summary>
    /// 花盆中的植物结果后，果实停留10天，再结果
    /// </summary>
    public static int day_in_month_to_pick_up_fruit_of_flower_pot = 10;

    public static float fertilizer_effect_of_mushroom_box = 2f;
    public static float water_effect_of_mushroom_box = 1.25f;
    public static float warm_effect_of_mushroom_box = 1.25f;
    
    public static int trading_desk_default_caravan_sell_discount = 100;
    

    public static int max_dosage_of_mushroom_essence = 3;

    public static int balance_threshold = 1000000;
    public static int max_withdraw_per_time = 1000000;
    public static float deposit_rate_of_risk = 0.03f;
    public static int caravan_max_stuff_count_of_order = 9999;
    public static int caravan_max_stuff_count_of_animal_order = 99;

    public static int decrease_resistance_by_supply_clothes = 2;

    public static int ant_soldier_idle_days_to_back = 90;
    public static int year_to_start_create_ant = 3;
    public static int year_to_start_create_ant_red = 25;
    public static int days_of_hatred_of_the_queen_ant = 90;
    public static int collect_output_multiply_of_ant = 2;
    public static int ant_nest_core_range = 5;
    public static int ant_nest_base_active_range = 10;
    public static int ant_nest_range_extend_by_level = 5;
    
    public static int year_to_start_cold_wave= 10;
    
    //提示
    public static int map_stuff_count_to_notice = 50;
    public static int collect_job_count_to_notice = 100;
    public static int map_stuff_count_so_more_to_notice = 100;
    public static int collect_job_count_so_more_to_notice = 200;
    public static int map_stuff_count_of_battle_drop_to_notice = 50;
    public static int animal_mount_stay_days_in_wild = 720;
    public static int disable_pick_up_by_orderly_days = 30;

    public static int build_count_limit_at_same_time_max = 999;
    

    public static int notice_keep_days_long = 1080;
    public static int notice_keep_days_short = 30;

    public static int people_count_to_not_random_wander_walk = 150;
    
    public static int standard_of_beauty = 80;
    public static int max_beauty_for_dan = 90;
    public static int effect_of_book_for_nobel = 10;
    public static float default_cannon_bomb_offset = 0.7f;
    
    public static int duration_days_stay_at_port = 2;
    public static int duration_days_stay_at_port_without_trade = 1;
    public static float ship_move_speed_on_world_map = 0.5f;
    public static int ship_rest_duration_days = 30;
    public static int ship_rotate_staff_duration_days = 360;
    public static int ship_go_to_sea_interval_days = 5;
    public static int ship_go_to_sea_interval_days_of_sea_route = 91;
    public static int ship_try_go_to_sea_interval_days = 5;
    public static int ship_bag_limit = 100000;

    public static int traveller_score_to_increase_after_group_leave = 2;
    public static int traveller_score_to_decrease_on_traveller_dead = 5;
    public static int traveller_score_to_decrease_on_drive_away_traveller = 10;
    public static int favorite_fruit_count_per_year = 10;
    public static int max_extend_effect_range_of_throne = 10;
    
    /// <summary>
    /// 地图尺寸 
    /// </summary>
    public static string area_map_size = "150,200,250,300";
    public static int[] month_in_year_arr_of_travel_caravan_appear;
    public static int[] grass_stage_age_days = { 60, 120, 210, 300, 360};
    public static float[] speed_list;
    public static float[] anim_speed_list;
    public static int[] temperature_day_arr;
    
    public static List<int> population_limit_count_list = new List<int>() { 0, 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 600, 700, 800, 900, 1000, 1500, 2000, 2500, 3000, 3500, 4000, 5000 };
    public static readonly List<Vector2Int> tax_config_of_king = new List<Vector2Int>() { new Vector2Int(100, 10), new Vector2Int(500, 20), new Vector2Int(1000, 50), new Vector2Int(1500, 100) };
    public static List<int> discount_config_favourable_of_travel_caravan_condition;
    public static List<int>  discount_config_favourable_of_travel_caravan_value;
    public static string map_seed_prefix = "MAP_SEED:12345";
    
    public static float GetNpcMoveSpeed(int npc_id)
    {
        return npc_move_speed * (1 + (npc_id % 100 / 100f) * npc_move_speed_random_float);
    }

    public static float GetWagonMoveSpeed(float wagon_move_speed_rate)
    {
        float wagon_move_speed = npc_move_speed * wagon_move_speed_rate;
        return wagon_move_speed + wagon_move_speed * MyRandom.NextFloat(1) * npc_move_speed_random_float;
    }

    public static float GetAnimalMoveSpeed()
    {
        return animal_move_speed + animal_move_speed * MyRandom.NextFloat(1) * animal_move_speed_random_float;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="list"></param>
    public static void ParseConfig(List<ConfigItem> list)
    {
        //MyStringBuilder sb = MyStringBuilder.Create();
        C ins = new C();
        foreach(ConfigItem t in list)
        {
            BindingFlags flag = BindingFlags.Static | BindingFlags.Public;
            FieldInfo f_key = typeof(C).GetField(t.key, flag);
            if (f_key == null)
            {
                Log.e("配置项不存在 key=" + t.key);
            }
            else
            {
                // sb = sb + "\n" + "/// <summary>";
                // sb = sb + "\n" + "/// " + t.name + " " + t.remark;
                // sb = sb + "\n" + "/// </summary>";
                
                if (f_key.FieldType == typeof(float))
                {
                    f_key.SetValue(ins, (float)Convert.ToDouble(t.value));
                    // sb = sb + "\npublic static float " + t.key + " = " + t.value +"f" + ";";
                }
                if (f_key.FieldType == typeof(int))
                {
                    f_key.SetValue(ins, (int)Convert.ToDouble(t.value));
                    // sb = sb + "\npublic static int " + t.key + " = " + t.value + ";";
                }
                else if (f_key.FieldType == typeof(string))
                {
                    f_key.SetValue(ins, t.value);
                    // sb = sb + "\npublic static string " + t.key + " = \"" + t.value + "\";";
                }
            }
        }
        // System.IO.File.WriteAllText("tmp_config.txt", sb.ToStr());

        //温度变化曲线，每天
        temperature_day_arr = new int[360];
        List<Vector3Int> temperature_month_arr = new List<Vector3Int>();
        //{-5, 2, 5, 15, 28, 35, 31, 23, 11, 5, 0, -8,-15 };
        temperature_month_arr.Add(new Vector3Int(-5, 0, 2));
        temperature_month_arr.Add(new Vector3Int(2, 3, 5));
        temperature_month_arr.Add(new Vector3Int(5, 10, 15));
        
        temperature_month_arr.Add(new Vector3Int(15, 21, 28));
        temperature_month_arr.Add(new Vector3Int(28, 31, 35));
        temperature_month_arr.Add(new Vector3Int(35, 20, 31));//夏夜有个极低值
        
        temperature_month_arr.Add(new Vector3Int(31, 27, 23));
        temperature_month_arr.Add(new Vector3Int(23, 17, 11));
        temperature_month_arr.Add(new Vector3Int(11, 9, 7));
        
        temperature_month_arr.Add(new Vector3Int(7, 2, 0));
        temperature_month_arr.Add(new Vector3Int(0, -4, -8));
        temperature_month_arr.Add(new Vector3Int(-8, -15, -10));//冬夜有个极低值
        
        
        int d = 30;
        int m = 12;
        for(int i=0;i< m; i++)
        {
            float min = temperature_month_arr[i].x;
            float mid = temperature_month_arr[i].y;
            float max = temperature_month_arr[i].z;
            for (int j = 0; j < d; j++)
            {
                int day = i * d + j;
                float start = 0;
                float end = 0;
                int delta = j;
                if (j < d / 2)
                {
                    start = min;
                    end = mid;
                }
                else
                {
                    start = mid;
                    end = max;
                    delta -= d / 2;
                }
                float v = (end - start) / (d / 2f);
                temperature_day_arr[day] = (int)(Math.Round(start + delta * v));
            }
        }

        // 打印温度
        // MyStringBuilder sb = MyStringBuilder.Create();
        // for (int i = 0; i < 360; i++)
        // {
        //     sb.Append(temperature_day_arr[i]);
        //     sb.Append(", ");
        //     if (i != 0 && i % 30 == 0)
        //     {
        //         sb.Append("\n");
        //     }
        // }
        // Log.d(sb.ToStr());

        days_to_game_time_second = (24 * 60 * 60) / time_scale;
        game_time_second_to_days = 1 / days_to_game_time_second;
        
        //商队扶持优惠
        string[] arr= discount_config_favourable_of_travel_caravan.Split(":");
        discount_config_favourable_of_travel_caravan_condition = MyUtil.StringToList(arr[0]);
        discount_config_favourable_of_travel_caravan_value = MyUtil.StringToList(arr[1]);
        if (discount_config_favourable_of_travel_caravan_condition.Count !=
            discount_config_favourable_of_travel_caravan_value.Count)
        {
            Log.e("配置有误：discount_config_favourable_of_travel_caravan=" + discount_config_favourable_of_travel_caravan);
        }
        
        arr = months_of_travel_caravan_appear.Split(",");
        month_in_year_arr_of_travel_caravan_appear = new int[arr.Length];
        for(int i=0;i<arr.Length;i++)
        {
            month_in_year_arr_of_travel_caravan_appear[i] = MyUtil.TryParseInt(arr[i]);
        }
        
        speed_list = MyUtil.StringToFloatArr(speed_config).ToArray();
        anim_speed_list = MyUtil.StringToFloatArr(anim_speed_config).ToArray();

#if UNITY_EDITOR
        //days_sleep_on_groud_to_ill = 10;
        
#endif

    }

    private static Random _random = new Random();
    // 生成符合标准正态分布 (均值0, 方差1) 的随机数
    public static double GenerateStandardNormal()
    {
        // 获取两个均匀分布的随机数
        double u1 = _random.NextDouble();
        double u2 = _random.NextDouble();

        // 使用 Box-Muller 变换计算标准正态分布的随机数
        double z0 = Math.Sqrt(-2 * Math.Log(u1)) * Math.Cos(2 * Math.PI * u2);
        return z0;
    }
    // 生成符合正态分布（指定均值mean和标准差stdDev）的随机数
    public static double GenerateNormal(double mean, double stdDev)
    {
        return mean + stdDev * GenerateStandardNormal();
    }
    public static int GetRandomAppearanceOfNpcNotForPlayer()
    {
        return (int)(GenerateNormal(0, 0.5f) + 0.5f * 99) + 1;
    }
}



