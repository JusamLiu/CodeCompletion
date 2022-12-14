using System.Collections.Generic;
using JetBrains.ProjectModel;

namespace ReSharperPlugin.MyAwesomePlugin;

[SolutionComponent]
public class ConfigTableCache
{
    public IEnumerable<(string, string)> GetAllPossibleSceneNames()
    {
		yield return ("id","");
		yield return ("name","");
		yield return ("type","");
		yield return ("path","");
		yield return ("actionId","");
		yield return ("actionType","");
		yield return ("describe","");
		yield return ("targetSelecter","");
		yield return ("targetSelecterParam","");
		yield return ("actionParam","");
		yield return ("level","");
		yield return ("attributeName1","");
		yield return ("attributeValue1","");
		yield return ("attributeName2","");
		yield return ("attributeValue2","");
		yield return ("attributeName3","");
		yield return ("attributeValue3","");
		yield return ("attributeName4","");
		yield return ("attributeValue4","");
		yield return ("attributeName5","");
		yield return ("attributeValue5","");
		yield return ("attributeName6","");
		yield return ("attributeValue6","");
		yield return ("attributeName7","");
		yield return ("attributeValue7","");
		yield return ("attributeName8","");
		yield return ("attributeValue8","");
		yield return ("attributeName9","");
		yield return ("attributeValue9","");
		yield return ("attributeName10","");
		yield return ("attributeValue10","");
		yield return ("exp","");
		yield return ("comment","");
		yield return ("duration","");
		yield return ("function_property","");
		yield return ("function_change","");
		yield return ("skill_change","");
		yield return ("change_to_skill","");
		yield return ("impact_id_1","");
		yield return ("impact_chance_1","");
		yield return ("impact_id_2","");
		yield return ("impact_chance_2","");
		yield return ("impact_id_3","");
		yield return ("impact_chance_3","");
		yield return ("in_del_impact_type","");
		yield return ("in_del_impact_id","");
		yield return ("out_del_impact_type","");
		yield return ("out_del_impact_id","");
		yield return ("paramA","");
		yield return ("paramB","");
		yield return ("paramC","");
		yield return ("paramD","");
		yield return ("paramE","");
		yield return ("paramF","");
		yield return ("paramG","");
		yield return ("paramH","");
		yield return ("effect1","");
		yield return ("effect_on_create","");
		yield return ("effect_y1","");
		yield return ("ename","");
		yield return ("Icon_1","");
		yield return ("Icon_2","");
		yield return ("comment2","");
		yield return ("open","");
		yield return ("show_format","");
		yield return ("program_type","");
		yield return ("init_value","");
		yield return ("calculate_formula","");
		yield return ("addition_name","");
		yield return ("show_in_list","");
		yield return ("add_step","");
		yield return ("show_in_log","");
		yield return ("max_value","");
		yield return ("entity_type","");
		yield return ("attribute","");
		yield return ("config_table_name","");
		yield return ("config_table_column","");
		yield return ("key","");
		yield return ("value","");
		yield return ("positive","");
		yield return ("impact_id","");
		yield return ("checkerId","");
		yield return ("checkerType","");
		yield return ("option","");
		yield return ("checkerParam","");
		yield return ("formular","");
		yield return ("description","");
		yield return ("count","");
		yield return ("itemid_0","");
		yield return ("itemcount_0","");
		yield return ("itemweight_0","");
		yield return ("itemid_1","");
		yield return ("itemcount_1","");
		yield return ("itemweight_1","");
		yield return ("itemid_2","");
		yield return ("itemcount_2","");
		yield return ("itemweight_2","");
		yield return ("itemid_3","");
		yield return ("itemcount_3","");
		yield return ("itemweight_3","");
		yield return ("itemid_4","");
		yield return ("itemcount_4","");
		yield return ("itemweight_4","");
		yield return ("itemid_5","");
		yield return ("itemcount_5","");
		yield return ("itemweight_5","");
		yield return ("itemid_6","");
		yield return ("itemcount_6","");
		yield return ("itemweight_6","");
		yield return ("itemid_7","");
		yield return ("itemcount_7","");
		yield return ("itemweight_7","");
		yield return ("user_type","");
		yield return ("quality","");
		yield return ("heal_amount","");
		yield return ("damage","");
		yield return ("recover","");
		yield return ("armor","");
		yield return ("crit","");
		yield return ("crit_damage","");
		yield return ("hit","");
		yield return ("defence_ignore","");
		yield return ("cooperation_rate","");
		yield return ("move_power","");
		yield return ("action_power","");
		yield return ("view_range","");
		yield return ("attack_range","");
		yield return ("suit_id","");
		yield return ("sell_price","");
		yield return ("eventId","");
		yield return ("eventType","");
		yield return ("eventParam","");
		yield return ("config_id","");
		yield return ("group","");
		yield return ("weight","");
		yield return ("group_id","");
		yield return ("type_name","");
		yield return ("show_aftereffect","");
		yield return ("param_string_1","");
		yield return ("param_string_2","");
		yield return ("param_int_1","");
		yield return ("param_int_2","");
		yield return ("param_int_3","");
		yield return ("param_int_4","");
		yield return ("param_int_5","");
		yield return ("param_float_1","");
		yield return ("param_float_2","");
		yield return ("param_float_3","");
		yield return ("param_float_4","");
		yield return ("client_logic","");
		yield return ("hyper_link","");
		yield return ("client_effect","");
		yield return ("addon_sound","");
		yield return ("attr_text","");
		yield return ("fix_y","");
		yield return ("fix_x","");
		yield return ("bind_joint","");
		yield return ("buff_icon","");
		yield return ("scope","");
		yield return ("on_conflict","");
		yield return ("overlay_count","");
		yield return ("overlay_fresh","");
		yield return ("rely_source","");
		yield return ("property","");
		yield return ("cancel_type","");
		yield return ("death_clear","");
		yield return ("death_cast","");
		yield return ("dissipate_type","");
		yield return ("scriptName","");
		yield return ("funcType","");
		yield return ("angle","");
		yield return ("radius","");
		yield return ("interact_client_logic","");
		yield return ("icon","");
		yield return ("effect_times","");
		yield return ("clientActionParam","");
		yield return ("startActionAPI","");
		yield return ("startActionParam","");
		yield return ("endActionAPI","");
		yield return ("endActionParam","");
		yield return ("interact_client_logic_01","");
		yield return ("icon_01","");
		yield return ("effect_times_01","");
		yield return ("duration_01","");
		yield return ("clientActionParam_01","");
		yield return ("startActionAPI_01","");
		yield return ("startActionParam_01","");
		yield return ("endActionAPI_01","");
		yield return ("endActionParam_01","");
		yield return ("data","");
		yield return ("attributes","");
		yield return ("shot_desc","");
		yield return ("model","");
		yield return ("valid","");
		yield return ("can_trade","");
		yield return ("showbag","");
		yield return ("block_max_count","");
		yield return ("can_sale","");
		yield return ("coin","");
		yield return ("access","");
		yield return ("use_param","");
		yield return ("auto_use","");
		yield return ("score","");
		yield return ("show","");
		yield return ("can_lock","");
		yield return ("star","");
		yield return ("suitid","");
		yield return ("part","");
		yield return ("slot_count","");
		yield return ("attri_k_0","");
		yield return ("attri_v_0","");
		yield return ("attri_k_1","");
		yield return ("attri_v_1","");
		yield return ("attri_k_2","");
		yield return ("attri_v_2","");
		yield return ("attri_k_3","");
		yield return ("attri_v_3","");
		yield return ("attri_k_4","");
		yield return ("attri_v_4","");
		yield return ("attri_k_5","");
		yield return ("attri_v_5","");
		yield return ("attri_k_r1","");
		yield return ("attri_v_min1","");
		yield return ("attri_v_max1","");
		yield return ("attri_k_r2","");
		yield return ("attri_v_min2","");
		yield return ("attri_v_max2","");
		yield return ("attri_k_r3","");
		yield return ("attri_v_min3","");
		yield return ("attri_v_max3","");
		yield return ("attri_k_r4","");
		yield return ("attri_v_min4","");
		yield return ("attri_v_max4","");
		yield return ("random_attribute_id1","");
		yield return ("random_attribute_count1","");
		yield return ("random_attribute_id2","");
		yield return ("random_attribute_count2","");
		yield return ("random_attribute_id3","");
		yield return ("random_attribute_count3","");
		yield return ("attribute1","");
		yield return ("value_min1","");
		yield return ("value_max1","");
		yield return ("weight1","");
		yield return ("attribute2","");
		yield return ("value_min2","");
		yield return ("value_max2","");
		yield return ("weight2","");
		yield return ("attribute3","");
		yield return ("value_min3","");
		yield return ("value_max3","");
		yield return ("weight3","");
		yield return ("attribute4","");
		yield return ("value_min4","");
		yield return ("value_max4","");
		yield return ("weight4","");
		yield return ("attribute5","");
		yield return ("value_min5","");
		yield return ("value_max5","");
		yield return ("weight5","");
		yield return ("attribute6","");
		yield return ("value_min6","");
		yield return ("value_max6","");
		yield return ("weight6","");
		yield return ("attribute7","");
		yield return ("value_min7","");
		yield return ("value_max7","");
		yield return ("weight7","");
		yield return ("attribute8","");
		yield return ("value_min8","");
		yield return ("value_max8","");
		yield return ("weight8","");
		yield return ("slot_type","");
		yield return ("sub_type","");
		yield return ("sub_type_name","");
		yield return ("filter_value","");
		yield return ("filter_name","");
		yield return ("filter_icon","");
		yield return ("filter_selected_icon","");
		yield return ("chinese","");
		yield return ("traditional","");
		yield return ("english","");
		yield return ("sur","");
		yield return ("boy","");
		yield return ("girl","");
		yield return ("profession","");
		yield return ("weapon","");
		yield return ("equipment","");
		yield return ("max_mastery_point","");
		yield return ("mastery","");
		yield return ("upgrade_id","");
		yield return ("comment.1","");
		yield return ("icon.1","");
		yield return ("item_cost_id_1","");
		yield return ("item_cost_count_1","");
		yield return ("item_cost_id_2","");
		yield return ("item_cost_count_2","");
		yield return ("item_cost_id_3","");
		yield return ("item_cost_count_3","");
		yield return ("item_cost_id_4","");
		yield return ("item_cost_count_4","");
		yield return ("item_cost_id_5","");
		yield return ("item_cost_count_5","");
		yield return ("attrib_name_1","");
		yield return ("attrib_val_1","");
		yield return ("attrib_name_2","");
		yield return ("attrib_val_2","");
		yield return ("attrib_name_3","");
		yield return ("attrib_val_3","");
		yield return ("attrib_name_4","");
		yield return ("attrib_val_4","");
		yield return ("attrib_name_5","");
		yield return ("attrib_val_5","");
		yield return ("attrib_name_6","");
		yield return ("attrib_val_6","");
		yield return ("point","");
		yield return ("comment.2","");
		yield return ("comment.3","");
		yield return ("comment.4","");
		yield return ("comment.5","");
		yield return ("attrib_name_6.1","");
		yield return ("attrib_val_6.1","");
		yield return ("comment.6","");
		yield return ("attrib_name_7","");
		yield return ("attrib_val_7","");
		yield return ("comment.7","");
		yield return ("attrib_name_7.1","");
		yield return ("attrib_val_7.1","");
		yield return ("comment.8","");
		yield return ("pool","");
		yield return ("cost","");
		yield return ("active","");
		yield return ("locked_icon","");
		yield return ("addition_percent_min","");
		yield return ("addition_percent_max","");
		yield return ("resource","");
		yield return ("startTime","");
		yield return ("endTime","");
		yield return ("probability","");
		yield return ("cd","");
		yield return ("max","");
		yield return ("headIcon","");
		yield return ("background","");
		yield return ("frame","");
		yield return ("head","");
		yield return ("word","");
		yield return ("weapon_parts_info","");
		yield return ("action_type","");
		yield return ("parameter","");
		yield return ("desc","");
		yield return ("itemList","");
		yield return ("skillList","");
		yield return ("view_angle","");
		yield return ("view_radius","");
		yield return ("is_be_assassinated","");
		yield return ("trigger","");
		yield return ("playDeathCamera","");
		yield return ("ai_type_explore","");
		yield return ("ai_name_explore","");
		yield return ("ai_param_explore","");
		yield return ("ai_type_chess","");
		yield return ("ai_name_chess","");
		yield return ("ai_param_chess","");
		yield return ("interactionList","");
		yield return ("head_icon_1","");
		yield return ("head_icon_2","");
		yield return ("drop","");
		yield return ("effect_game_over","");
		yield return ("can_be_skill_target","");
		yield return ("attributeName11","");
		yield return ("attributeValue11","");
		yield return ("attributeName12","");
		yield return ("attributeValue12","");
		yield return ("attributeName13","");
		yield return ("attributeValue13","");
		yield return ("attributeName14","");
		yield return ("attributeValue14","");
		yield return ("unity_scene_name","");
		yield return ("grid_data_file","");
		yield return ("actor_data_file","");
		yield return ("logic_type","");
		yield return ("logic_name","");
		yield return ("skillType","");
		yield return ("probe","");
		yield return ("cast_on_dead","");
		yield return ("can_trigger","");
		yield return ("element_type","");
		yield return ("condition","");
		yield return ("output_energy_bean","");
		yield return ("target_gain_energy_bean","");
		yield return ("cost_ap","");
		yield return ("times_in_battle","");
		yield return ("cost_item_id","");
		yield return ("cost_item_count","");
		yield return ("skill_group_id","");
		yield return ("process1","");
		yield return ("process2","");
		yield return ("process3","");
		yield return ("process4","");
		yield return ("cd_id1","");
		yield return ("cd_time1","");
		yield return ("cd_id2","");
		yield return ("cd_time2","");
		yield return ("cd_id3","");
		yield return ("cd_time3","");
		yield return ("talent_icon","");
		yield return ("bubbletext","");
		yield return ("bubblerage","");
		yield return ("soundname","");
		yield return ("hitSoundName","");
		yield return ("special_efficiency","");
		yield return ("attack_action_id","");
		yield return ("skill_des","");
		yield return ("talent_des","");
		yield return ("cast_pos_type","");
		yield return ("target_select_type","");
		yield return ("ignore_cover","");
		yield return ("target_type","");
		yield return ("show_camera","");
		yield return ("camera_focus_on_target","");
		yield return ("range","");
		yield return ("max_radius","");
		yield return ("width","");
		yield return ("show_expression","");
		yield return ("target_count","");
		yield return ("chance","");
		yield return ("cast_animation","");
		yield return ("blocking","");
		yield return ("impact_id_4","");
		yield return ("impact_chance_4","");
		yield return ("impact_id_5","");
		yield return ("impact_chance_5","");
		yield return ("action","");
		yield return ("effect2","");
		yield return ("effect_y2","");
		yield return ("effect3","");
		yield return ("effect_y3","");
		yield return ("effect4","");
		yield return ("effect_y4","");
		yield return ("buttle_id","");
		yield return ("buttle_speed","");
		yield return ("buttle_blast_effect","");
		yield return ("buttle_hit_effect","");
		yield return ("show_name","");
		yield return ("back_ground","");
		yield return ("trigger_effect","");
		yield return ("trigger_y","");
		yield return ("skill_show","");
		yield return ("skill_show_attack","");
		yield return ("skill_show_hit","");
		yield return ("weapon_type","");
		yield return ("per_skill_client_logic","");
		yield return ("OutTime","");
		yield return ("solo_camera","");
		yield return ("ucc_state","");
		yield return ("ignore_show","");
		yield return ("blindage_type","");
		yield return ("is_walk","");
		yield return ("unlock","");
		yield return ("slot","");
		yield return ("slot_detail","");
		yield return ("active_weapon","");
		yield return ("asset_key","");
		yield return ("color","");
		yield return ("bounds","");
		yield return ("prefab_name","");
		yield return ("commend","");
		yield return ("open_sound","");
		yield return ("close_sound","");
		yield return ("disable_gameplay_input","");
		yield return ("close_delete","");
		yield return ("exclusive","");
		yield return ("top","");
		yield return ("CommonSound","");
		yield return ("SoundGroup","");
		yield return ("decrease_rate","");
		yield return ("parts_type","");
		yield return ("core_weapon_type","");
		yield return ("carry_weight","");
		yield return ("price","");
		yield return ("required","");
		yield return ("icon_bright","");
		yield return ("icon_dark","");
		yield return ("btn_bright","");
		yield return ("btn_dark","");
		yield return ("min","");
		yield return ("weaponType","");
		yield return ("slotIndex","");
		yield return ("apCost","");
		yield return ("skillId","");
		yield return ("useType","");
		yield return ("parts_type_list","");
    }
}