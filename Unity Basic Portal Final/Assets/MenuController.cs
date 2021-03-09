using System.Collections;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GG.Infrastructure.Utils.Swipe;
using UnityEngine.EventSystems;
using System;
using System.IO;

	public class MenuController : MonoBehaviour
	{

    public GameObject Lightning_Skill = null;
    public bool Lightning_Button = false;
    public bool LightningActiveTrueOrFalse = false;
    public GameObject Enemy = null;
    public int Stage_Enemy_Num = 1;
    public List<string> List_Enemy_Rank = new List<string>();
    public List<string> List_Map_Rank = new List<string>();
    public List<float> LayerHealth = new List<float>();
    public float LayerHeathFull = 100f;

    public List<string> List_Enemys_Name = new List<string>();
    public List<string> List_Enemys_Image = new List<string>();

    public List<string> Map_Majestic_Volcano_Enemys = new List<string>();
    public List<string> Map_Majestic_Volcano_Enemys_Image = new List<string>();
    public int Map_Majestic_Volcano_Stage_Num = 1;
    public int Map_Majestic_Volcano_Stage_Enemy_Num = 1;
    public int Map_Majestic_Volcano_Stage_Enemy_Max = 25;
    public List<string> Map_Infinite_Sea_World_Enemys = new List<string>();
    public List<string> Map_Infinite_Sea_World_Enemys_Image = new List<string>();
    public int Map_Infinite_Sea_World_Stage_Num = 1;
    public int Map_Infinite_Sea_World_Stage_Enemy_Num = 1;
    public int Map_Infinite_Sea_World_Stage_Enemy_Max = 25;
    public List<string> Map_Odins_Waterfall_Enemys = new List<string>();
    public List<string> Map_Odins_Waterfall_Enemys_Image = new List<string>();
    public int Map_Odins_Waterfall_Stage_Num = 1;
    public int Map_Odins_Waterfall_Stage_Enemy_Num = 1;
    public int Map_Odins_Waterfall_Stage_Enemy_Max = 25;
    public List<string> Map_Book_Of_Knowledge_Enemys = new List<string>();
    public List<string> Map_Book_Of_Knowledge_Enemys_Image = new List<string>();
    public int Map_Book_Of_Knowledge_Stage_Num = 1;
    public int Map_Book_Of_Knowledge_Stage_Enemy_Num = 1;
    public int Map_Book_Of_Knowledge_Stage_Enemy_Max = 25;
    public List<string> Map_Odins_Castle_Enemys = new List<string>();
    public List<string> Map_Odins_Castle_Enemys_Image = new List<string>();
    public int Map_Odins_Castle_Stage_Num = 1;
    public int Map_Odins_Castle_Stage_Enemy_Num = 1;
    public int Map_Odins_Castle_Stage_Enemy_Max = 25;
    List<List<string>> Maps_Enemys = new List<List<string>>();
    List<List<string>> Maps_Enemys_Image = new List<List<string>>();
    List<int> Maps_Enemys_Stage_Num = new List<int>();
    List<int> Maps_Enemys_Stage_Enemy_Num = new List<int>();
    List<int> Maps_Enemys_Stage_Enemy_Max = new List<int>(); 


    public GameObject NewItemsGained_Popup_Camera = null;
    public string Currently_Selected = "";
    public GameObject Mining_Big_Camera = null;
    public GameObject Mining_Small_Camera = null;
    public GameObject ItemsGained_Camera = null;
		public int x = 10;
		public GameObject Mining_Area_1_Camera = null;
		public bool Result_1_Button_1 = false;
		public bool Result_1_Button_2 = false;
		public bool Result_1_Button_3 = false;
		public bool Result_1_Button_4 = false;
		public bool Result_1_Button_5 = false;
		public bool Result_2_Button_1 = false;
		public bool Result_2_Button_2 = false;
		public bool Result_2_Button_3 = false;
		public bool Result_2_Button_4 = false;
		public bool Result_2_Button_5 = false;
		public bool Menus_Breakdown_0 = false;
		public bool Menus_Breakdown_1 = false;
		public bool Menus_Breakdown_2 = false;
		public bool Menus_Breakdown_3 = false;
		public bool Menus_Breakdown_4 = false;
		public bool Menus_Breakdown_5 = false;
		public string deletethis = "new delete";
		public List<string> List_Main_Menu_1_Container = new List<string>();
		public List<string> List_Main_Menu_1_Container_Images = new List<string>();
		public List<string> List_Main_Menu_1_Container_Images_Texture = new List<string>();
		public List<string> List_Main_Menu_2_Container = new List<string>();
		public List<string> List_Main_Menu_2_Container_Images = new List<string>();
		public List<string> List_Main_Menu_2_Container_Images_Texture = new List<string>();
		List<List<string>> Lists_Written_Out = new List<List<string>>();
		List<List<string>> Lists_Written_Out_Images = new List<List<string>>();
		List<List<string>> Lists_Written_Out_Images_Texture = new List<List<string>>();
		List<List<string>> Lists_Written_Out_Saved = new List<List<string>>();
		List<List<string>> Lists_Written_Out_Images_Saved = new List<List<string>>();
		List<List<string>> Lists_Written_Out_Info = new List<List<string>>();
		List<GameObject> Mining_Area_1_Automatons = new List<GameObject>();
    List<GameObject> Mining_Area_1_AutomatonsHit = new List<GameObject>();
    List<List<GameObject>> Lists_Mining_Area_1_Layers = new List<List<GameObject>>();
		public List<GameObject> Mining_Area_1_Layer_0 = new List<GameObject>();
		public List<GameObject> Mining_Area_1_Layer_1 = new List<GameObject>();
		public List<GameObject> Mining_Area_1_Layer_2 = new List<GameObject>();
		public List<GameObject> Mining_Area_1_Layer_3 = new List<GameObject>();
		public List<GameObject> Mining_Area_1_Layer_4 = new List<GameObject>();
		public List<GameObject> Mining_Area_1_Layer_5 = new List<GameObject>();
    List<List<GameObject>> Lists_Mining_Area_1_Layers_Mineral_Overlay = new List<List<GameObject>>();
    public List<GameObject> Mining_Area_1_Layer_0_Mineral_Overlay = new List<GameObject>();
    public List<GameObject> Mining_Area_1_Layer_1_Mineral_Overlay = new List<GameObject>();
    public List<GameObject> Mining_Area_1_Layer_2_Mineral_Overlay = new List<GameObject>();
    public List<GameObject> Mining_Area_1_Layer_3_Mineral_Overlay = new List<GameObject>();
    public List<GameObject> Mining_Area_1_Layer_4_Mineral_Overlay = new List<GameObject>();
    public List<GameObject> Mining_Area_1_Layer_5_Mineral_Overlay = new List<GameObject>();
    List<List<GameObject>> Lists_Mining_Area_1_Layers_Item_Overlay = new List<List<GameObject>>();
    public List<GameObject> Mining_Area_1_Layer_0_Item_Overlay = new List<GameObject>();
    public List<GameObject> Mining_Area_1_Layer_1_Item_Overlay = new List<GameObject>();
    public List<GameObject> Mining_Area_1_Layer_2_Item_Overlay = new List<GameObject>();
    public List<GameObject> Mining_Area_1_Layer_3_Item_Overlay = new List<GameObject>();
    public List<GameObject> Mining_Area_1_Layer_4_Item_Overlay = new List<GameObject>();
    public List<GameObject> Mining_Area_1_Layer_5_Item_Overlay = new List<GameObject>();
		public List<string> List_Written_Out_1 = new List<string>();
		public List<string> List_Written_Out_1_Images = new List<string>();
		public List<string> List_Written_Out_1_Images_Texture = new List<string>();
		public List<string> List_Written_Out_1_Info = new List<string>();
		public List<string> List_Written_Out_1_2 = new List<string>();
		public List<string> List_Written_Out_1_2_Images = new List<string>();
		public List<string> List_Written_Out_1_2_Images_Texture = new List<string>();
		public List<string> List_Written_Out_1_2_Info = new List<string>();
		public List<string> List_Written_Out_1_1 = new List<string>();
		public List<string> List_Written_Out_1_1_Images = new List<string>();
		public List<string> List_Written_Out_1_1_Images_Texture = new List<string>();
		public List<string> List_Written_Out_1_1_Info = new List<string>();
		public List<string> List_Written_Out_1_1_2 = new List<string>();
		public List<string> List_Written_Out_1_1_2_Images = new List<string>();
		public List<string> List_Written_Out_1_1_2_Images_Texture = new List<string>();
		public List<string> List_Written_Out_1_1_2_Info = new List<string>();
		public List<string> List_Written_Out_1_1_1 = new List<string>();
		public List<string> List_Written_Out_1_1_1_Images = new List<string>();
		public List<string> List_Written_Out_1_1_1_Images_Texture = new List<string>();
		public List<string> List_Written_Out_1_1_1_Info = new List<string>();
		//New Public List List_Written_Out Area...
    public List<string> List_Written_Out_Fight = new List<string>();
  public List<string> List_Written_Out_Fight_Images = new List<string>();
  public List<string> List_Written_Out_Fight_Images_Texture = new List<string>();
  public List<string> List_Written_Out_Fight_Info = new List<string>();
		
		
		
		
		public List<string> List_Written_Out_Coal_Vain = new List<string>();
		public List<string> List_Written_Out_Coal_Vain_Images = new List<string>();
		public List<string> List_Written_Out_Coal_Vain_Images_Texture = new List<string>();
		public List<string> List_Written_Out_Coal_Vain_Info = new List<string>();
		

		public List<string> List_Menu_Blank_Strings = new List<string>();
		public List<GameObject> Mining_Area_1_Mining_Camera = new List<GameObject>();
		public List<GameObject> Mining_Area_1_Main_Camera = new List<GameObject>();
		








    public List<string> List_Written_Out_Areas_Name = new List<string>();
    public List<string> List_Written_Out_Areas_Background = new List<string>();
    public List<string> List_Written_Out_Fight_Areas_Name = new List<string>();
    public List<string> List_Written_Out_Fight_Areas_Background = new List<string>();
    public List<string> List_Written_Out_Fight_Areas_Rank = new List<string>();
    public List<string> List_Written_Out_Fight_Areas_Current_Enemy = new List<string>();
    public List<float> List_Written_Out_Fight_Areas_Current_Enemy_Health_Full = new List<float>();
    public List<float> List_Written_Out_Fight_Areas_Current_Enemy_Health_Full_Modified = new List<float>();
    public List<float> List_Written_Out_Fight_Areas_Current_Enemy_Health_Current = new List<float>();
    public List<int> List_Written_Out_Fight_Areas_Rank_Num = new List<int>();














    public List<GameObject> NewItem = new List<GameObject>();
    public int NewItem_Num = 0;
    public List<int> NewItem_TimeSinceCreated = new List<int>();
    public int LayerNum = 0;
    public bool New_Item_Check = true;

    public string Item_Name = "Alpha Centari Earrings";  
    public int ItemAmount = 0;
    public string ItemImage_Dir = "";

    public List<string> Tiles_List_NameWithoutUnderscore = new List<string>();
    public List<string> Tiles_List = new List<string>();



    public List<int> Tiles_List_Rank = new List<int>();
    public List<string> Rank_List = new List<string>();
    public int ItemRank = 5;

    public List<GameObject> NewItemsGainedArea_List_Name_Text_Shadow_1 = new List<GameObject>();
    public List<GameObject> NewItemsGainedArea_List_Name_Text_Shadow_2 = new List<GameObject>();
    public List<GameObject> NewItemsGainedArea_List_Name_Text_Main = new List<GameObject>();
    public List<GameObject> NewItemsGainedArea_List_ItemAmount_Text_Shadow_1 = new List<GameObject>();
    public List<GameObject> NewItemsGainedArea_List_ItemAmount_Text_Shadow_2 = new List<GameObject>();
    public List<GameObject> NewItemsGainedArea_List_ItemAmount_Text_Main = new List<GameObject>();
    public List<GameObject> NewItemsGainedArea_List_ItemImage = new List<GameObject>();
    public List<GameObject> NewItemsGainedArea_List_LeftOfItemImage = new List<GameObject>();
    public List<GameObject> NewItemsGainedArea_List_RightOfItemImage = new List<GameObject>();
    public List<GameObject> NewItemsGainedArea_List_ItemRank_Main = new List<GameObject>();
    public List<GameObject> NewItemsGainedArea_List_ItemRank_Small_1 = new List<GameObject>();
    public List<GameObject> NewItemsGainedArea_List_ItemRank_Small_2 = new List<GameObject>();
    public List<GameObject> NewItemsGainedArea_List_ItemRank_Small_3 = new List<GameObject>();
    public List<string> ItemsGained_Item_Name = new List<string>();
    public List<int> ItemsGained_ItemAmount = new List<int>();
    public List<string> ItemsGained_ItemImage_Dir = new List<string>();
    public List<int> ItemsGained_ItemRank = new List<int>();
    public List<GameObject> NewItemsGainedArea_List_Item = new List<GameObject>();



















		public List<GameObject> List_Result_1 = new List<GameObject>();
		public List<GameObject> List_Result_1_Images = new List<GameObject>();
		public List<GameObject> List_Result_1_Images_Texture = new List<GameObject>();
		public List<GameObject> List_Result_1_Text_Gameobject = new List<GameObject>();
		public List<GameObject> List_Result_2 = new List<GameObject>();
		public List<GameObject> List_Result_2_Images = new List<GameObject>();
		public List<GameObject> List_Result_2_Images_Texture = new List<GameObject>();
		public List<GameObject> List_Result_2_Text_Gameobject = new List<GameObject>();
		public List<GameObject> List_Menus_Breakdown = new List<GameObject>();
		public List<GameObject> List_Menus_Breakdown_Images = new List<GameObject>();
		public List<GameObject> List_Menus_Breakdown_Images_Texture = new List<GameObject>();
		public List<GameObject> List_Menus_Breakdown_Text = new List<GameObject>();
		public List<GameObject> List_Menus_Breakdown_Text_Shadow_1 = new List<GameObject>();
		public List<GameObject> List_Menus_Breakdown_Text_Shadow_2 = new List<GameObject>();
		public string Selected_Menu_Title = "Main Menu";
    public List<string> Selected_Menu_Title_Background = new List<string>();
    public List<string> Selected_Menu_Title_Selected_Background = new List<string>();
		public string Current_Menu_1 = "";
		public string Current_Menu_2 = "";
		public string Current_Menu_3 = "";
		public string Current_Menu_4 = "";
		public string Current_Menu_5 = "";
		public string Current_Menu_6 = "";
		public string Current_Menu_1_save = "";
		public string Current_Menu_2_save = "";
		public string Current_Menu_3_save = "";
		public string Current_Menu_4_save = "";
		public string Current_Menu_5_save = "";
		public string Current_Menu_6_save = "";


		public int Current_Menu = 1;

		 public static double Dirt_Amount = 0;
  public static double Rich_Soil_Amount = 0;
  public static double Very_Rich_Soil_Amount = 0;
  public static double Extremly_rich_soil_Amount = 0;
  public static double Grass_Amount = 0;
  public static double Valunite_Amount = 0;
  public static double Dark_Valunite_Amount = 0;
  public static double Bamboo_Amount = 0;
  public static double Wood_Amount = 0;
  public static double Sandstone_Amount = 0;
  public static double Sand_Amount = 0;
  public static double Packed_Sand_Amount = 0;
  public static double Ice_Amount = 0;
  public static double Packed_Snow_Amount = 0;
  public static double Hardened_Ice_Amount = 0;
  public static double Compressed_Ice_Amount = 0;
  public static double Ugly_Bricks_Amount = 0;
  public static double Brick_Amount = 0;
  public static double Stone_Bricks_Amount = 0;
  public static double Steel_Amount = 0;
  public static double Refined_Steel_Amount = 0;
  public static double Mystery_Steel_Amount = 0;
  public static double Extra_Coins_Amount = 0;
  public static double Bonus_Coins_Amount = 0;
  public static double Boxes_Amount = 0;
  public static double Old_Box_Amount = 0;
  public static double Unknown_Amount = 0;
  public static double Orange_Box_Amount = 0;
  public static double Green_Box_Amount = 0;
  public static double Cyan_Box_Amount = 0;
  public static double Red_Box_Amount = 0;
  public static double Magenta_Box_Amount = 0;
  public static double Purple_Box_Amount = 0;
  public static double Blue_Box_Amount = 0;
  public static double Explosion_Amount = 0;
  public static double Huge_Explosion_Amount = 0;
  public static double Big_Explosion_Amount = 0;
  public static double Timed_Explosion_Amount = 0;
  public static double Enormous_Explosion_Amount = 0;
  public static double Blue_Key_Amount = 0;
  public static double Red_Key_Amount = 0;
  public static double Green_Key_Amount = 0;
  public static double Yellow_Key_Amount = 0;
  public static double Stone_Amount = 0;
  public static double Ruby_Amount = 0;
  public static double Diamond_Amount = 0;
  public static double Gold_Amount = 0;
  public static double Silver_Amount = 0;
  public static double Calcite_Amount = 0;
  public static double Coal_Amount = 0;
  public static double Aquamarine_Amount = 0;
  public static double Pixie_Dust_Amount = 0;
  public static double Emerald_Amount = 0;
  public static double Fossils_Amount = 0;
  public static double Forest_Crystal_Amount = 0;
  public static double Blood_Crystal_Amount = 0;
  public static double Sand_Crystal_Amount = 0;
  public static double Ice_Crystal_Amount = 0;
  public static double Snow_Crystal_Amount = 0;
//Need to replace
  public static double R_Nothing = 0;
  public static double R_Coal_Few = 0;
  public static double R_Coal_Some = 0;
  public static double R_Coal_Lots = 0;

  public static double R_Dirt = 0;
  public static double R_Rich_Soil = 0;
  public static double R_Very_Rich_Soil = 0;
  public static double R_Extremly_Rich_Soil = 0;
  public static double R_Grass = 0;
  public static double R_Valunite = 0;
  public static double R_Dark_Valunite = 0;
  public static double R_Bamboo = 0;
  public static double R_Wood = 1 / 2;
  public static double R_Sandstone = 0;
  public static double R_Sand = 0;
  public static double R_Packed_Sand = 0;
  public static double R_Extra_Coins = 0;
  public static double R_Bonus_Coins = 0;
  public static double R_Orange_Box = 0;
  public static double R_Green_Box = 0;
  public static double R_Cyan_Box = 0;
  public static double R_Red_Box = 0;
  public static double R_Magenta_Box = 0;
  public static double R_Purple_Box = 0;
  public static double R_Blue_Box = 0;
  public static double R_Explosion = 0;
  public static double R_Huge_Explosion = 0;
  public static double R_Big_Explosion = 0;
  public static double R_Timed_Explosion = 0;
  public static double R_Enormous_Explosion = 0;
  public static double R_Blue_Key = 0;
  public static double R_Red_Key = 0;
  public static double R_Green_Key = 0;
  public static double R_Yellow_Key = 0;
  public static double R_Steel = 0;
  public static double R_Refined_Steel = 0;
  public static double R_Mystery_Steel = 0;
  public static double R_Stone = 0;
  public static double R_Ruby = 0;
  public static double R_Diamond = 0;
  public static double R_Gold = 0;
  public static double R_Silver = 0;
  public static double R_Calcite = 0;
  public static double R_Coal = 0;
  public static double R_Aquamarine = 0;
  public static double R_Pixie_Dust = 0;
  public static double R_Emerald = 0;
  public static double R_Fossils = 0;
  public static double R_Boxes = 0;
  public static double R_Old_Box = 0;
  public static double R_Unknown = 0;
  public static double R_Stone_Bricks = 0;
  public static double R_Ugly_Bricks = 0;
  public static double R_Brick = 0;
  public static double R_Forest_Crystal = 0;
  public static double R_Blood_Crystal = 0;
  public static double R_Sand_Crystal = 0;
  public static double R_Ice_Crystal = 0;
  public static double R_Snow_Crystal = 0;
  public static double R_Ice = 0;
  public static double R_Packed_Snow = 0;
  public static double R_Hardened_Ice = 0;
  public static double R_Compressed_Ice = 0;
//Need to replace
  public Sprite Dirt;
  public Sprite Rich_Soil;
  public Sprite Very_Rich_Soil;
  public Sprite Extremly_rich_soil;
  public Sprite Grass;
  public Sprite Valunite;
  public Sprite Dark_Valunite;
  public Sprite Bamboo;
  public Sprite Wood;
  public Sprite Sandstone;
  public Sprite Sand;
  public Sprite Packed_Sand;
  public Sprite Extra_Coins;
  public Sprite Bonus_Coins;
  public Sprite Orange_Box;
  public Sprite Green_Box;
  public Sprite Cyan_Box;
  public Sprite Red_Box;
  public Sprite Magenta_Box;
  public Sprite Purple_Box;
  public Sprite Blue_Box;
  public Sprite Explosion;
  public Sprite Huge_Explosion;
  public Sprite Big_Explosion;
  public Sprite Timed_Explosion;
  public Sprite Enormous_Explosion;
  public Sprite Blue_Key;
  public Sprite Red_Key;
  public Sprite Green_Key;
  public Sprite Yellow_Key;
  public Sprite Steel;
  public Sprite Refined_Steel;
  public Sprite Mystery_Steel;
  public Sprite Stone;
  public Sprite Ruby;
  public Sprite Diamond;
  public Sprite Gold;
  public Sprite Silver;
  public Sprite Calcite;
  public Sprite Coal;
  public Sprite Aquamarine;
  public Sprite Pixie_Dust;
  public Sprite Emerald;
  public Sprite Fossils;
  public Sprite Boxes;
  public Sprite Old_Box;
  public Sprite Unknown;
  public Sprite Stone_Bricks;
  public Sprite Ugly_Bricks;
  public Sprite Brick;
  public Sprite Forest_Crystal;
  public Sprite Blood_Crystal;
  public Sprite Sand_Crystal;
  public Sprite Ice_Crystal;
  public Sprite Snow_Crystal;
  public Sprite Ice;
  public Sprite Packed_Snow;
  public Sprite Hardened_Ice;
  public Sprite Compressed_Ice;
public string Block_Name = "";
public string Mineral_Name = "";
  public string Stage_Name = "Dirt";
public string currentSetMain = "Dirt";
  public double SetMain = 0;
  public double SetMainMineral = 0;
  System.Random RandomMap = new System.Random();
	    // Start is called before the first frame update
	    void Start()
	    {
        UnityEngine.Random.seed = 420; 
        
        
        //Lightning_Skill = GameObject.Find("Lightning Skill");
        Enemy = GameObject.Find("Enemy");      
        Maps_Enemys_Stage_Num.Add(Map_Majestic_Volcano_Stage_Num);
        Maps_Enemys_Stage_Enemy_Num.Add(Map_Majestic_Volcano_Stage_Enemy_Num);
        Maps_Enemys_Stage_Enemy_Max.Add(Map_Majestic_Volcano_Stage_Enemy_Max);
        Maps_Enemys_Stage_Num.Add(Map_Infinite_Sea_World_Stage_Num);
        Maps_Enemys_Stage_Enemy_Num.Add(Map_Infinite_Sea_World_Stage_Enemy_Num);
        Maps_Enemys_Stage_Enemy_Max.Add(Map_Infinite_Sea_World_Stage_Enemy_Max);
        Maps_Enemys_Stage_Num.Add(Map_Odins_Waterfall_Stage_Num);
        Maps_Enemys_Stage_Enemy_Num.Add(Map_Odins_Waterfall_Stage_Enemy_Num);
        Maps_Enemys_Stage_Enemy_Max.Add(Map_Odins_Waterfall_Stage_Enemy_Max);
        Maps_Enemys_Stage_Num.Add(Map_Book_Of_Knowledge_Stage_Num);
        Maps_Enemys_Stage_Enemy_Num.Add(Map_Book_Of_Knowledge_Stage_Enemy_Num);
        Maps_Enemys_Stage_Enemy_Max.Add(Map_Book_Of_Knowledge_Stage_Enemy_Max);
        Maps_Enemys_Stage_Num.Add(Map_Odins_Castle_Stage_Num);
        Maps_Enemys_Stage_Enemy_Num.Add(Map_Odins_Castle_Stage_Enemy_Num);
        Maps_Enemys_Stage_Enemy_Max.Add(Map_Odins_Castle_Stage_Enemy_Max);


        List_Enemys_Name.Add("Ancient Automaton");
        List_Enemys_Image.Add("Characters/Enemys 256/AncientAutomaton");
        List_Enemys_Name.Add("Arcane Crystal Magic Circle");
        List_Enemys_Image.Add("Characters/Enemys 256/Arcane Crystal Magic Circle");
        List_Enemys_Name.Add("Arcane Crystal");
        List_Enemys_Image.Add("Characters/Enemys 256/Arcane Crystal");
        List_Enemys_Name.Add("Arcane Golem");
        List_Enemys_Image.Add("Characters/Enemys 256/Arcane Golem");
        List_Enemys_Name.Add("Arcane Orb Fire");
        List_Enemys_Image.Add("Characters/Enemys 256/Arcane Orb Fire");
        List_Enemys_Name.Add("Arcane Orb Frost");
        List_Enemys_Image.Add("Characters/Enemys 256/Arcane Orb Frost");
        List_Enemys_Name.Add("Arcane Orb Thunder");
        List_Enemys_Image.Add("Characters/Enemys 256/Arcane Orb Thunder");
        List_Enemys_Name.Add("Arcane Orb Wind");
        List_Enemys_Image.Add("Characters/Enemys 256/Arcane Orb Wind");
        List_Enemys_Name.Add("Aspiring Knight Gladius");
        List_Enemys_Image.Add("Characters/Enemys 256/Aspiring Knight Gladius");
        List_Enemys_Name.Add("Aspiring Knight Palazo");
        List_Enemys_Image.Add("Characters/Enemys 256/Aspiring Knight Palazo");
        List_Enemys_Name.Add("Aspiring Knight Valterra");
        List_Enemys_Image.Add("Characters/Enemys 256/Aspiring Knight Valterra");
        List_Enemys_Name.Add("Assasin Garland");
        List_Enemys_Image.Add("Characters/Enemys 256/Assasin Garland");
        List_Enemys_Name.Add("Assembling Automatons Automaton A");
        List_Enemys_Image.Add("Characters/Enemys 256/Assembling Automatons Automaton A");
        List_Enemys_Name.Add("Assembling Automatons Automaton B");
        List_Enemys_Image.Add("Characters/Enemys 256/Assembling Automatons Automaton B");
        List_Enemys_Name.Add("Assembling Automatons Automaton C");
        List_Enemys_Image.Add("Characters/Enemys 256/Assembling Automatons Automaton C");
        List_Enemys_Name.Add("Assembling Automatons Automaton D");
        List_Enemys_Image.Add("Characters/Enemys 256/Assembling Automatons Automaton D");
        List_Enemys_Name.Add("Blood Manipulation Feral");
        List_Enemys_Image.Add("Characters/Enemys 256/Blood Manipulation Feral");
        List_Enemys_Name.Add("Blood Manipulation Mage");
        List_Enemys_Image.Add("Characters/Enemys 256/Blood Manipulation Mage");
        List_Enemys_Name.Add("Blood Manipulation Slime");
        List_Enemys_Image.Add("Characters/Enemys 256/Blood Manipulation Slime");
        List_Enemys_Name.Add("Boss Abomination Aqua");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Abomination Aqua");
        List_Enemys_Name.Add("Boss Abomination Red");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Abomination Red");
        List_Enemys_Name.Add("Boss Alfadriel");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Alfadriel");
        List_Enemys_Name.Add("Boss Ancient Automaton");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Ancient Automaton");
        List_Enemys_Name.Add("Boss Ancient Priestess");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Ancient Priestess");
        List_Enemys_Name.Add("Boss Astral Lich");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Astral Lich");
        List_Enemys_Name.Add("Boss Big Fish");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Big Fish");
        List_Enemys_Name.Add("Boss Black Ant Queen");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Black Ant Queen");
        List_Enemys_Name.Add("Boss Blood Feral");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Blood Feral");
        List_Enemys_Name.Add("Boss Bonemask Shadow Creature");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Bonemask Shadow Creature");
        List_Enemys_Name.Add("Boss Continental Turtle Rukkha");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Continental Turtle Rukkha");
        List_Enemys_Name.Add("Boss Crab King Karkinos");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Crab King Karkinos");
        List_Enemys_Name.Add("Boss Daidarabotchi");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Daidarabotchi");
        List_Enemys_Name.Add("Boss Dark Queen Shaccad Yoggoth");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Dark Queen Shaccad Yoggoth");
        List_Enemys_Name.Add("Boss Darklord Excelsios");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Darklord Excelsios");
        List_Enemys_Name.Add("Boss Darkness Titan Ilnoct");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Darkness Titan Ilnoct");
        List_Enemys_Name.Add("Boss Doppelganger Slime");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Doppelganger Slime");
        List_Enemys_Name.Add("Boss Dragon Emperor");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Dragon Emperor");
        List_Enemys_Name.Add("Boss Dragon Huanglong");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Dragon Huanglong");
        List_Enemys_Name.Add("Boss Dryad Queen Rafflesia");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Dryad Queen Rafflesia");
        List_Enemys_Name.Add("Boss Dryad Yggdrasil");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Dryad Yggdrasil");
        List_Enemys_Name.Add("Boss Earth Dragon");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Earth Dragon");
        List_Enemys_Name.Add("Boss Eldritch God Shaccad'Yoggoth");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Eldritch God Shaccad'Yoggoth");
        List_Enemys_Name.Add("Boss Eldritch Slime Overmind");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Eldritch Slime Overmind");
        List_Enemys_Name.Add("Boss Feral Kitsune");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Feral Kitsune");
        List_Enemys_Name.Add("Boss Flynn The Original Slime");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Flynn The Original Slime");
        List_Enemys_Name.Add("Boss God Jupiter");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss God Jupiter");
        List_Enemys_Name.Add("Boss God Novus");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss God Novus");
        List_Enemys_Name.Add("Boss God Warrior Dagon");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss God Warrior Dagon");
        List_Enemys_Name.Add("Boss God Warrior Isis");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss God Warrior Isis");
        List_Enemys_Name.Add("Boss God Warrior Osiris");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss God Warrior Osiris");
        List_Enemys_Name.Add("Boss God Warrior Poseidon");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss God Warrior Poseidon");
        List_Enemys_Name.Add("Boss God Warrior Skoll");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss God Warrior Skoll");
        List_Enemys_Name.Add("Boss Goddess Aphrodite");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Goddess Aphrodite");
        List_Enemys_Name.Add("Boss Goddess Innova");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Goddess Innova");
        List_Enemys_Name.Add("Boss Grand Sorceress Duessa");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Grand Sorceress Duessa");
        List_Enemys_Name.Add("Boss Hades");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Hades");
        List_Enemys_Name.Add("Boss Hellhound Garm");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Hellhound Garm");
        List_Enemys_Name.Add("Boss Ice Titan Demeres");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Ice Titan Demeres");
        List_Enemys_Name.Add("Boss Insect Queen");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Insect Queen");
        List_Enemys_Name.Add("Boss Jubokko");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Jubokko");
        List_Enemys_Name.Add("Boss Khronos");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Khronos");
        List_Enemys_Name.Add("Boss Legendary Knight Remment");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Legendary Knight Remment");
        List_Enemys_Name.Add("Boss Lich King");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Lich King");
        List_Enemys_Name.Add("Boss Life Titan Aphylia");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Life Titan Aphylia");
        List_Enemys_Name.Add("Boss Light Titan Alfadriel");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Light Titan Alfadriel");
        List_Enemys_Name.Add("Boss Living Hoard Midas");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Living Hoard Midas");
        List_Enemys_Name.Add("Boss Mecha Rattlesnake");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Mecha Rattlesnake");
        List_Enemys_Name.Add("Boss Mecha-Dragon Ladon");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Mecha-Dragon Ladon");
        List_Enemys_Name.Add("Boss Mecha-Scorpion");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Mecha-Scorpion");
        List_Enemys_Name.Add("Boss Mythical Knight Goldnharl");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Mythical Knight Goldnharl");
        List_Enemys_Name.Add("Boss Nature Titan Tellia");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Nature Titan Tellia");
        List_Enemys_Name.Add("Boss Nuckelavee");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Nuckelavee");
        List_Enemys_Name.Add("Boss Orc Chief Grunt");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Orc Chief Grunt");
        List_Enemys_Name.Add("Boss Parrot King");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Parrot King");
        List_Enemys_Name.Add("Boss Radulac The Voidvod");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Radulac The Voidvod");
        List_Enemys_Name.Add("Boss Reaper Nihilo");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Reaper Nihilo");
        List_Enemys_Name.Add("Boss Runic Stone Golem Goliath");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Runic Stone Golem Goliath");
        List_Enemys_Name.Add("Boss Sea Calamity Urmica");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Sea Calamity Urmica");
        List_Enemys_Name.Add("Boss Sea Dragon Leviathan");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Sea Dragon Leviathan");
        List_Enemys_Name.Add("Boss Sea Mermaid Warrior Undeen");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Sea Mermaid Warrior Undeen");
        List_Enemys_Name.Add("Boss Skull Knight Xoer");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Skull Knight Xoer");
        List_Enemys_Name.Add("Boss Slime Golem");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Slime Golem");
        List_Enemys_Name.Add("Boss Son Of Valhalla");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Son Of Valhalla");
        List_Enemys_Name.Add("Boss Spirit Fighter");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Spirit Fighter");
        List_Enemys_Name.Add("Boss Sun Goddess");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Sun Goddess");
        List_Enemys_Name.Add("Boss Tantalus");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Tantalus");
        List_Enemys_Name.Add("Boss Thanatos");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Thanatos");
        List_Enemys_Name.Add("Boss The Fallen");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss The Fallen");
        List_Enemys_Name.Add("Boss The Horde");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss The Horde");
        List_Enemys_Name.Add("Boss The Originator");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss The Originator");
        List_Enemys_Name.Add("Boss Thunder Titan Dynamo");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Thunder Titan Dynamo");
        List_Enemys_Name.Add("Boss Tiamat Unleashed");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Tiamat Unleashed");
        List_Enemys_Name.Add("Boss Tiamat");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Tiamat");
        List_Enemys_Name.Add("Boss Twin Gods");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Twin Gods");
        List_Enemys_Name.Add("Boss Void Gargoyle Sabre");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Void Gargoyle Sabre");
        List_Enemys_Name.Add("Boss Wind Titan Ventoss");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Wind Titan Ventoss");
        List_Enemys_Name.Add("Boss Zeograth");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Zeograth");
        List_Enemys_Name.Add("Boss Zodiac Cancer");
        List_Enemys_Image.Add("Characters/Enemys 256/Boss Zodiac Cancer");
        List_Enemys_Name.Add("Breakfast Nightmares Bacon Beast");
        List_Enemys_Image.Add("Characters/Enemys 256/Breakfast Nightmares Bacon Beast");
        List_Enemys_Name.Add("Breakfast Nightmares Bread Loaf");
        List_Enemys_Image.Add("Characters/Enemys 256/Breakfast Nightmares Bread Loaf");
        List_Enemys_Name.Add("Breakfast Nightmares Egg Slime");
        List_Enemys_Image.Add("Characters/Enemys 256/Breakfast Nightmares Egg Slime");
        List_Enemys_Name.Add("Cave Dweller Blind Dragon");
        List_Enemys_Image.Add("Characters/Enemys 256/Cave Dweller Blind Dragon");
        List_Enemys_Name.Add("Cave Dweller Rock Mimic");
        List_Enemys_Image.Add("Characters/Enemys 256/Cave Dweller Rock Mimic");
        List_Enemys_Name.Add("Cave Dweller Worm");
        List_Enemys_Image.Add("Characters/Enemys 256/Cave Dweller Worm");
        List_Enemys_Name.Add("Celestial Beatrix");
        List_Enemys_Image.Add("Characters/Enemys 256/Celestial Beatrix");
        List_Enemys_Name.Add("Cerberus Ptolemaios");
        List_Enemys_Image.Add("Characters/Enemys 256/Cerberus Ptolemaios");
        List_Enemys_Name.Add("Clockwork Abomination");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Abomination");
        List_Enemys_Name.Add("Clockwork Aerial");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Aerial");
        List_Enemys_Name.Add("Clockwork Dragon Juggernaut");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Dragon Juggernaut");
        List_Enemys_Name.Add("Clockwork Dragon");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Dragon");
        List_Enemys_Name.Add("Clockwork Gigas");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Gigas");
        List_Enemys_Name.Add("Clockwork Iron Maiden");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Iron Maiden");
        List_Enemys_Name.Add("Clockwork Juggernaut");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Juggernaut");
        List_Enemys_Name.Add("Clockwork King");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork King");
        List_Enemys_Name.Add("Clockwork Knight B");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Knight B");
        List_Enemys_Name.Add("Clockwork Knight C");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Knight C");
        List_Enemys_Name.Add("Clockwork Knight D");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Knight D");
        List_Enemys_Name.Add("Clockwork Mini A");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Mini A");
        List_Enemys_Name.Add("Clockwork Mini B");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Mini B");
        List_Enemys_Name.Add("Clockwork Mini C");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Mini C");
        List_Enemys_Name.Add("Clockwork Prototype");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Prototype");
        List_Enemys_Name.Add("Clockwork Queen");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Queen");
        List_Enemys_Name.Add("Clockwork Reaper");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Reaper");
        List_Enemys_Name.Add("Clockwork Skull");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Skull");
        List_Enemys_Name.Add("Clockwork Slime");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Slime");
        List_Enemys_Name.Add("Clockwork Spider Mini");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Spider Mini");
        List_Enemys_Name.Add("Clockwork Spider");
        List_Enemys_Image.Add("Characters/Enemys 256/Clockwork Spider");
        List_Enemys_Name.Add("Colossal Bat");
        List_Enemys_Image.Add("Characters/Enemys 256/Colossal Bat");
        List_Enemys_Name.Add("Colossal Dark Crow");
        List_Enemys_Image.Add("Characters/Enemys 256/Colossal Dark Crow");
        List_Enemys_Name.Add("Colossal Hydra 1");
        List_Enemys_Image.Add("Characters/Enemys 256/Colossal Hydra 1");
        List_Enemys_Name.Add("Colossal Hydra 2");
        List_Enemys_Image.Add("Characters/Enemys 256/Colossal Hydra 2");
        List_Enemys_Name.Add("Colossal Hydra 3");
        List_Enemys_Image.Add("Characters/Enemys 256/Colossal Hydra 3");
        List_Enemys_Name.Add("Colossal Scorpion");
        List_Enemys_Image.Add("Characters/Enemys 256/Colossal Scorpion");
        List_Enemys_Name.Add("Colossal Snake Black");
        List_Enemys_Image.Add("Characters/Enemys 256/Colossal Snake Black");
        List_Enemys_Name.Add("Colossal Snake Red");
        List_Enemys_Image.Add("Characters/Enemys 256/Colossal Snake Red");
        List_Enemys_Name.Add("Colossal Snake");
        List_Enemys_Image.Add("Characters/Enemys 256/Colossal Snake");
        List_Enemys_Name.Add("Colossal T-Rex Black");
        List_Enemys_Image.Add("Characters/Enemys 256/Colossal T-Rex Black");
        List_Enemys_Name.Add("Colossal T-Rex Orange");
        List_Enemys_Image.Add("Characters/Enemys 256/Colossal T-Rex Orange");
        List_Enemys_Name.Add("Colossal T-Rex Red");
        List_Enemys_Image.Add("Characters/Enemys 256/Colossal T-Rex Red");
        List_Enemys_Name.Add("Corrupted Fire Wolf");
        List_Enemys_Image.Add("Characters/Enemys 256/Corrupted Fire Wolf");
        List_Enemys_Name.Add("Corrupted Ice Mantis B");
        List_Enemys_Image.Add("Characters/Enemys 256/Corrupted Ice Mantis B");
        List_Enemys_Name.Add("Corrupted Ice Mantis");
        List_Enemys_Image.Add("Characters/Enemys 256/Corrupted Ice Mantis");
        List_Enemys_Name.Add("Corrupted Stone Bear");
        List_Enemys_Image.Add("Characters/Enemys 256/Corrupted Stone Bear");
        List_Enemys_Name.Add("Corrupted Void Fire Wolf");
        List_Enemys_Image.Add("Characters/Enemys 256/Corrupted Void Fire Wolf");
        List_Enemys_Name.Add("Crocodile Warriors Mage");
        List_Enemys_Image.Add("Characters/Enemys 256/Crocodile Warriors Mage");
        List_Enemys_Name.Add("Crocodile Warriors Paladin");
        List_Enemys_Image.Add("Characters/Enemys 256/Crocodile Warriors Paladin");
        List_Enemys_Name.Add("Crocodile Warriors Rogue");
        List_Enemys_Image.Add("Characters/Enemys 256/Crocodile Warriors Rogue");
        List_Enemys_Name.Add("Crystal Golem");
        List_Enemys_Image.Add("Characters/Enemys 256/Crystal Golem");
        List_Enemys_Name.Add("Cyber Blader");
        List_Enemys_Image.Add("Characters/Enemys 256/Cyber Blader");
        List_Enemys_Name.Add("Cyber Hawk");
        List_Enemys_Image.Add("Characters/Enemys 256/Cyber Hawk");
        List_Enemys_Name.Add("Cyber Ogre");
        List_Enemys_Image.Add("Characters/Enemys 256/Cyber Ogre");
        List_Enemys_Name.Add("Cyber Pegasus");
        List_Enemys_Image.Add("Characters/Enemys 256/Cyber Pegasus");
        List_Enemys_Name.Add("Cyber Slime");
        List_Enemys_Image.Add("Characters/Enemys 256/Cyber Slime");
        List_Enemys_Name.Add("Cybermancer");
        List_Enemys_Image.Add("Characters/Enemys 256/Cybermancer");
        List_Enemys_Name.Add("Dark Elves Axe Warrior");
        List_Enemys_Image.Add("Characters/Enemys 256/Dark Elves Axe Warrior");
        List_Enemys_Name.Add("Dark Elves Crystal Mage");
        List_Enemys_Image.Add("Characters/Enemys 256/Dark Elves Crystal Mage");
        List_Enemys_Name.Add("Dark Elves Healer Priestess");
        List_Enemys_Image.Add("Characters/Enemys 256/Dark Elves Healer Priestess");
        List_Enemys_Name.Add("Darkness Angel Reaper");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Angel Reaper");
        List_Enemys_Name.Add("Darkness Angel");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Angel");
        List_Enemys_Name.Add("Darkness Banshee");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Banshee");
        List_Enemys_Name.Add("Darkness Behemoth");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Behemoth");
        List_Enemys_Name.Add("Darkness Blade Colossus");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Blade Colossus");
        List_Enemys_Name.Add("Darkness Blade Reaper");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Blade Reaper");
        List_Enemys_Name.Add("Darkness Cultist Mage");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Cultist Mage");
        List_Enemys_Name.Add("Darkness Devilimp");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Devilimp");
        List_Enemys_Name.Add("Darkness Drakenvamp");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Drakenvamp");
        List_Enemys_Name.Add("Darkness Dullahan");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Dullahan");
        List_Enemys_Name.Add("Darkness Flame");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Flame");
        List_Enemys_Name.Add("Darkness Gargoyle Atrox");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Gargoyle Atrox");
        List_Enemys_Name.Add("Darkness Hound Inferni");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Hound Inferni");
        List_Enemys_Name.Add("Darkness Imp");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Imp");
        List_Enemys_Name.Add("Darkness Knight Magellan");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Knight Magellan");
        List_Enemys_Name.Add("Darkness Lord Knight");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Lord Knight");
        List_Enemys_Name.Add("Darkness Oculus");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Oculus");
        List_Enemys_Name.Add("Darkness Ogre");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Ogre");
        List_Enemys_Name.Add("Darkness Reaper");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Reaper");
        List_Enemys_Name.Add("Darkness Seeker");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Seeker");
        List_Enemys_Name.Add("Darkness Slime GhastMallow");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Slime GhastMallow");
        List_Enemys_Name.Add("Darkness Slime");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Slime");
        List_Enemys_Name.Add("Darkness Succubus Lariatt");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Succubus Lariatt");
        List_Enemys_Name.Add("Darkness Succubus");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Succubus");
        List_Enemys_Name.Add("Darkness Wisp");
        List_Enemys_Image.Add("Characters/Enemys 256/Darkness Wisp");
        List_Enemys_Name.Add("Desert Cactus Triple");
        List_Enemys_Image.Add("Characters/Enemys 256/Desert Cactus Triple");
        List_Enemys_Name.Add("Desert Feral Cactus");
        List_Enemys_Image.Add("Characters/Enemys 256/Desert Feral Cactus");
        List_Enemys_Name.Add("Desert Parasand");
        List_Enemys_Image.Add("Characters/Enemys 256/Desert Parasand");
        List_Enemys_Name.Add("Desert Rock Bunny");
        List_Enemys_Image.Add("Characters/Enemys 256/Desert Rock Bunny");
        List_Enemys_Name.Add("Desert Rock Lizard");
        List_Enemys_Image.Add("Characters/Enemys 256/Desert Rock Lizard");
        List_Enemys_Name.Add("Desert Sand Snake");
        List_Enemys_Image.Add("Characters/Enemys 256/Desert Sand Snake");
        List_Enemys_Name.Add("Desert Sand Tentacle");
        List_Enemys_Image.Add("Characters/Enemys 256/Desert Sand Tentacle");
        List_Enemys_Name.Add("Dragon Black");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Black");
        List_Enemys_Name.Add("Dragon Dark King");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Dark King");
        List_Enemys_Name.Add("Dragon Egg A");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Egg A");
        List_Enemys_Name.Add("Dragon Egg B");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Egg B");
        List_Enemys_Name.Add("Dragon Egg C");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Egg C");
        List_Enemys_Name.Add("Dragon Egg D");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Egg D");
        List_Enemys_Name.Add("Dragon Egg E");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Egg E");
        List_Enemys_Name.Add("Dragon Emperor Zalaras");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Emperor Zalaras");
        List_Enemys_Name.Add("Dragon Green");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Green");
        List_Enemys_Name.Add("Dragon King Blue");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon King Blue");
        List_Enemys_Name.Add("Dragon King Brown");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon King Brown");
        List_Enemys_Name.Add("Dragon King Green");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon King Green");
        List_Enemys_Name.Add("Dragon King Red");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon King Red");
        List_Enemys_Name.Add("Dragon Lord A");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Lord A");
        List_Enemys_Name.Add("Dragon Lord B");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Lord B");
        List_Enemys_Name.Add("Dragon Oriental Dragon");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Oriental Dragon");
        List_Enemys_Name.Add("Dragon Red");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Red");
        List_Enemys_Name.Add("Dragon Triple Head Darkness");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Triple Head Darkness");
        List_Enemys_Name.Add("Dragon Triple Head Venom");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Triple Head Venom");
        List_Enemys_Name.Add("Dragon White King");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon White King");
        List_Enemys_Name.Add("Dragon Wyrm");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Wyrm");
        List_Enemys_Name.Add("Dragon Wyvern Blue");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Wyvern Blue");
        List_Enemys_Name.Add("Dragon Wyvern Brown");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Wyvern Brown");
        List_Enemys_Name.Add("Dragon Wyvern Green");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Wyvern Green");
        List_Enemys_Name.Add("Dragon Wyvern Red");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragon Wyvern Red");
        List_Enemys_Name.Add("Dragons Hydra");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragons Hydra");
        List_Enemys_Name.Add("Dragons Scarlet Wyrm");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragons Scarlet Wyrm");
        List_Enemys_Name.Add("Dragons Sea Dragon");
        List_Enemys_Image.Add("Characters/Enemys 256/Dragons Sea Dragon");
        List_Enemys_Name.Add("Dryads Archer");
        List_Enemys_Image.Add("Characters/Enemys 256/Dryads Archer");
        List_Enemys_Name.Add("Dryads Mage");
        List_Enemys_Image.Add("Characters/Enemys 256/Dryads Mage");
        List_Enemys_Name.Add("Dryads Warrior");
        List_Enemys_Image.Add("Characters/Enemys 256/Dryads Warrior");
        List_Enemys_Name.Add("Dwarf Axe Warrior");
        List_Enemys_Image.Add("Characters/Enemys 256/Dwarf Axe Warrior");
        List_Enemys_Name.Add("Dwarf Dragon Slayer");
        List_Enemys_Image.Add("Characters/Enemys 256/Dwarf Dragon Slayer");
        List_Enemys_Name.Add("Dwarf Drill Knight");
        List_Enemys_Image.Add("Characters/Enemys 256/Dwarf Drill Knight");
        List_Enemys_Name.Add("Earth Bull");
        List_Enemys_Image.Add("Characters/Enemys 256/Earth Bull");
        List_Enemys_Name.Add("Earth Bush Wisp");
        List_Enemys_Image.Add("Characters/Enemys 256/Earth Bush Wisp");
        List_Enemys_Name.Add("Earth Gemstone Golem");
        List_Enemys_Image.Add("Characters/Enemys 256/Earth Gemstone Golem");
        List_Enemys_Name.Add("Earth Leaf Imp");
        List_Enemys_Image.Add("Characters/Enemys 256/Earth Leaf Imp");
        List_Enemys_Name.Add("Earth Lion");
        List_Enemys_Image.Add("Characters/Enemys 256/Earth Lion");
        List_Enemys_Name.Add("Earth Mandrake");
        List_Enemys_Image.Add("Characters/Enemys 256/Earth Mandrake");
        List_Enemys_Name.Add("Earth Rock Golem");
        List_Enemys_Image.Add("Characters/Enemys 256/Earth Rock Golem");
        List_Enemys_Name.Add("Earth Snake");
        List_Enemys_Image.Add("Characters/Enemys 256/Earth Snake");
        List_Enemys_Name.Add("Earth Spawn");
        List_Enemys_Image.Add("Characters/Enemys 256/Earth Spawn");
        List_Enemys_Name.Add("Earth Turtle");
        List_Enemys_Image.Add("Characters/Enemys 256/Earth Turtle");
        List_Enemys_Name.Add("Earth Wisp");
        List_Enemys_Image.Add("Characters/Enemys 256/Earth Wisp");
        List_Enemys_Name.Add("Egypt Archer");
        List_Enemys_Image.Add("Characters/Enemys 256/Egypt Archer");
        List_Enemys_Name.Add("Egypt Axe");
        List_Enemys_Image.Add("Characters/Enemys 256/Egypt Axe");
        List_Enemys_Name.Add("Egypt Chariot");
        List_Enemys_Image.Add("Characters/Enemys 256/Egypt Chariot");
        List_Enemys_Name.Add("Egypt Cobra");
        List_Enemys_Image.Add("Characters/Enemys 256/Egypt Cobra");
        List_Enemys_Name.Add("Egypt Crocodile");
        List_Enemys_Image.Add("Characters/Enemys 256/Egypt Crocodile");
        List_Enemys_Name.Add("Egypt Hieracosphinx");
        List_Enemys_Image.Add("Characters/Enemys 256/Egypt Hieracosphinx");
        List_Enemys_Name.Add("Egypt Knight");
        List_Enemys_Image.Add("Characters/Enemys 256/Egypt Knight");
        List_Enemys_Name.Add("Egypt Mage");
        List_Enemys_Image.Add("Characters/Enemys 256/Egypt Mage");
        List_Enemys_Name.Add("Egypt Mummy A");
        List_Enemys_Image.Add("Characters/Enemys 256/Egypt Mummy A");
        List_Enemys_Name.Add("Egypt Mummy B");
        List_Enemys_Image.Add("Characters/Enemys 256/Egypt Mummy B");
        List_Enemys_Name.Add("Egypt Mummy C");
        List_Enemys_Image.Add("Characters/Enemys 256/Egypt Mummy C");
        List_Enemys_Name.Add("Egypt Sphinx Big");
        List_Enemys_Image.Add("Characters/Enemys 256/Egypt Sphinx Big");
        List_Enemys_Name.Add("Egypt Sphinx Small");
        List_Enemys_Image.Add("Characters/Enemys 256/Egypt Sphinx Small");
        List_Enemys_Name.Add("Eldritch Abomination Gazer");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Abomination Gazer");
        List_Enemys_Name.Add("Eldritch Abomination Hound");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Abomination Hound");
        List_Enemys_Name.Add("Eldritch Abomination Tyrant");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Abomination Tyrant");
        List_Enemys_Name.Add("Eldritch Abominations Abyss Denizen");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Abominations Abyss Denizen");
        List_Enemys_Name.Add("Eldritch Abominations Scout");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Abominations Scout");
        List_Enemys_Name.Add("Eldritch Abominations Ultimate");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Abominations Ultimate");
        List_Enemys_Name.Add("Eldritch Fire Slimei");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Fire Slimei");
        List_Enemys_Name.Add("Eldritch Fire Slimeii");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Fire Slimeii");
        List_Enemys_Name.Add("Eldritch Fire Slimeiii");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Fire Slimeiii");
        List_Enemys_Name.Add("Eldritch Gazer Merem");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Gazer Merem");
        List_Enemys_Name.Add("Eldritch Gazer Velz");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Gazer Velz");
        List_Enemys_Name.Add("Eldritch God ShacadYoggoth");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch God ShacadYoggoth");
        List_Enemys_Name.Add("Eldritch Ice Slimei");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Ice Slimei");
        List_Enemys_Name.Add("Eldritch Ice Slimeii");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Ice Slimeii");
        List_Enemys_Name.Add("Eldritch Ice Slimeiii");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Ice Slimeiii");
        List_Enemys_Name.Add("Eldritch Slime A");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Slime A");
        List_Enemys_Name.Add("Eldritch Slime B");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Slime B");
        List_Enemys_Name.Add("Eldritch Slime Cerulean");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Slime Cerulean");
        List_Enemys_Name.Add("Eldritch Slime Spawn A");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Slime Spawn A");
        List_Enemys_Name.Add("Eldritch Slime Spawn B");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Slime Spawn B");
        List_Enemys_Name.Add("Eldritch Slime Spawn C");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Slime Spawn C");
        List_Enemys_Name.Add("Eldritch Slime Spawn D");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Slime Spawn D");
        List_Enemys_Name.Add("Eldritch Slime Spawn E");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Slime Spawn E");
        List_Enemys_Name.Add("Eldritch Slime Vermillion");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Slime Vermillion");
        List_Enemys_Name.Add("Eldritch Slime Viridian");
        List_Enemys_Image.Add("Characters/Enemys 256/Eldritch Slime Viridian");
        List_Enemys_Name.Add("Elemental Earth Spirit Tellia");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Earth Spirit Tellia");
        List_Enemys_Name.Add("Elemental Gemstone Earth");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Gemstone Earth");
        List_Enemys_Name.Add("Elemental Gemstone Fire");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Gemstone Fire");
        List_Enemys_Name.Add("Elemental Gemstone Thunder");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Gemstone Thunder");
        List_Enemys_Name.Add("Elemental Gemstone Water");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Gemstone Water");
        List_Enemys_Name.Add("Elemental Gemstone Wind");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Gemstone Wind");
        List_Enemys_Name.Add("Elemental Goddess Forest Flora");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Goddess Forest Flora");
        List_Enemys_Name.Add("Elemental Goddess Ice Yukia");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Goddess Ice Yukia");
        List_Enemys_Name.Add("Elemental Goddess Wind Airi");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Goddess Wind Airi");
        List_Enemys_Name.Add("Elemental Ice Spirit Helida");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Ice Spirit Helida");
        List_Enemys_Name.Add("Elemental Spirit Fire Blazia");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Spirit Fire Blazia");
        List_Enemys_Name.Add("Elemental Titan Aphylia");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Titan Aphylia");
        List_Enemys_Name.Add("Elemental Titan Aquos");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Titan Aquos");
        List_Enemys_Name.Add("Elemental Titan Ignis");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Titan Ignis");
        List_Enemys_Name.Add("Elemental Titan Tellia");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Titan Tellia");
        List_Enemys_Name.Add("Elemental Titan Terran");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Titan Terran");
        List_Enemys_Name.Add("Elemental Titan Ventoss");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Titan Ventoss");
        List_Enemys_Name.Add("Elemental Wind Spirit Tempestia");
        List_Enemys_Image.Add("Characters/Enemys 256/Elemental Wind Spirit Tempestia");
        List_Enemys_Name.Add("Elf_Archer");
        List_Enemys_Image.Add("Characters/Enemys 256/Elf_Archer");
        List_Enemys_Name.Add("Elf_Assasin");
        List_Enemys_Image.Add("Characters/Enemys 256/Elf_Assasin");
        List_Enemys_Name.Add("Elf_Knight_Crossbow");
        List_Enemys_Image.Add("Characters/Enemys 256/Elf_Knight_Crossbow");
        List_Enemys_Name.Add("Elf_Knight_Dual");
        List_Enemys_Image.Add("Characters/Enemys 256/Elf_Knight_Dual");
        List_Enemys_Name.Add("Elf_Knight_Mage");
        List_Enemys_Image.Add("Characters/Enemys 256/Elf_Knight_Mage");
        List_Enemys_Name.Add("Elf_Knight_Spear");
        List_Enemys_Image.Add("Characters/Enemys 256/Elf_Knight_Spear");
        List_Enemys_Name.Add("Elf_Knight_Sword");
        List_Enemys_Image.Add("Characters/Enemys 256/Elf_Knight_Sword");
        List_Enemys_Name.Add("Elves Nature Linker");
        List_Enemys_Image.Add("Characters/Enemys 256/Elves Nature Linker");
        List_Enemys_Name.Add("Elves Rogue Elf");
        List_Enemys_Image.Add("Characters/Enemys 256/Elves Rogue Elf");
        List_Enemys_Name.Add("Elves Spellcaster");
        List_Enemys_Image.Add("Characters/Enemys 256/Elves Spellcaster");
        List_Enemys_Name.Add("Fallen Dragon Knight");
        List_Enemys_Image.Add("Characters/Enemys 256/Fallen Dragon Knight");
        List_Enemys_Name.Add("Fallen Great Sword");
        List_Enemys_Image.Add("Characters/Enemys 256/Fallen Great Sword");
        List_Enemys_Name.Add("Fallen Winged Sword");
        List_Enemys_Image.Add("Characters/Enemys 256/Fallen Winged Sword");
        List_Enemys_Name.Add("Fire Bull");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Bull");
        List_Enemys_Name.Add("Fire Dragonspawn");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Dragonspawn");
        List_Enemys_Name.Add("Fire Elemental  Imp");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Elemental  Imp");
        List_Enemys_Name.Add("Fire Elemental Angel");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Elemental Angel");
        List_Enemys_Name.Add("Fire Elemental Bat");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Elemental Bat");
        List_Enemys_Name.Add("Fire Kindred Flame");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Kindred Flame");
        List_Enemys_Name.Add("Fire Lava Spawn");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Lava Spawn");
        List_Enemys_Name.Add("Fire Lava Worm");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Lava Worm");
        List_Enemys_Name.Add("Fire Lion");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Lion");
        List_Enemys_Name.Add("Fire Minivolcano");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Minivolcano");
        List_Enemys_Name.Add("Fire Ogre");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Ogre");
        List_Enemys_Name.Add("Fire Pumice Rock");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Pumice Rock");
        List_Enemys_Name.Add("Fire Pumice Sheep");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Pumice Sheep");
        List_Enemys_Name.Add("Fire Sabretooth");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Sabretooth");
        List_Enemys_Name.Add("Fire Salamander");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Salamander");
        List_Enemys_Name.Add("Fire Snake");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Snake");
        List_Enemys_Name.Add("FIre Toad");
        List_Enemys_Image.Add("Characters/Enemys 256/FIre Toad");
        List_Enemys_Name.Add("Fire Turtle");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Turtle");
        List_Enemys_Name.Add("Fire Volcanic Golem");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Volcanic Golem");
        List_Enemys_Name.Add("Fire Volcanic Maiden");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Volcanic Maiden");
        List_Enemys_Name.Add("Fire Vulture");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Vulture");
        List_Enemys_Name.Add("Fire Wisp");
        List_Enemys_Image.Add("Characters/Enemys 256/Fire Wisp");
        List_Enemys_Name.Add("Flame Knight");
        List_Enemys_Image.Add("Characters/Enemys 256/Flame Knight");
        List_Enemys_Name.Add("Forest Blue Flower");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Blue Flower");
        List_Enemys_Name.Add("Forest Catermoth");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Catermoth");
        List_Enemys_Name.Add("Forest Darkluff");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Darkluff");
        List_Enemys_Name.Add("Forest Deer");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Deer");
        List_Enemys_Name.Add("Forest Fairy Dragon Xinbal");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Fairy Dragon Xinbal");
        List_Enemys_Name.Add("Forest Fairy Filia");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Fairy Filia");
        List_Enemys_Name.Add("Forest Fangrot");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Fangrot");
        List_Enemys_Name.Add("Forest Golem");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Golem");
        List_Enemys_Name.Add("Forest Grasshopper");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Grasshopper");
        List_Enemys_Name.Add("Forest Green Spider");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Green Spider");
        List_Enemys_Name.Add("Forest Imperial Widow");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Imperial Widow");
        List_Enemys_Name.Add("Forest Kawabun");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Kawabun");
        List_Enemys_Name.Add("Forest Mobun");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Mobun");
        List_Enemys_Name.Add("Forest Mothy");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Mothy");
        List_Enemys_Name.Add("Forest Noxluff");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Noxluff");
        List_Enemys_Name.Add("Forest Ogre Orkgre");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Ogre Orkgre");
        List_Enemys_Name.Add("Forest Panda");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Panda");
        List_Enemys_Name.Add("Forest Pink Flower");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Pink Flower");
        List_Enemys_Name.Add("Forest Red Flower");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Red Flower");
        List_Enemys_Name.Add("Forest Red Spider");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Red Spider");
        List_Enemys_Name.Add("Forest Shroom");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Shroom");
        List_Enemys_Name.Add("Forest Shroomy");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Shroomy");
        List_Enemys_Name.Add("Forest Spider");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Spider");
        List_Enemys_Name.Add("Forest Spora");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Spora");
        List_Enemys_Name.Add("Forest Sprout");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Sprout");
        List_Enemys_Name.Add("Forest Tree");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Tree");
        List_Enemys_Name.Add("Forest Uzu");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest Uzu");
        List_Enemys_Name.Add("Forest White Flower");
        List_Enemys_Image.Add("Characters/Enemys 256/Forest White Flower");
        List_Enemys_Name.Add("Gargoyle Grifos");
        List_Enemys_Image.Add("Characters/Enemys 256/Gargoyle Grifos");
        List_Enemys_Name.Add("Garuda Garunix");
        List_Enemys_Image.Add("Characters/Enemys 256/Garuda Garunix");
        List_Enemys_Name.Add("Gazers Eyewing");
        List_Enemys_Image.Add("Characters/Enemys 256/Gazers Eyewing");
        List_Enemys_Name.Add("Gazers Skull");
        List_Enemys_Image.Add("Characters/Enemys 256/Gazers Skull");
        List_Enemys_Name.Add("Gazers Tenteye");
        List_Enemys_Image.Add("Characters/Enemys 256/Gazers Tenteye");
        List_Enemys_Name.Add("Ghost Ghostus");
        List_Enemys_Image.Add("Characters/Enemys 256/Ghost Ghostus");
        List_Enemys_Name.Add("Ghost Knight Destrand");
        List_Enemys_Image.Add("Characters/Enemys 256/Ghost Knight Destrand");
        List_Enemys_Name.Add("Ghost Knight Galpha");
        List_Enemys_Image.Add("Characters/Enemys 256/Ghost Knight Galpha");
        List_Enemys_Name.Add("Ghost Knight Goliath");
        List_Enemys_Image.Add("Characters/Enemys 256/Ghost Knight Goliath");
        List_Enemys_Name.Add("Ghost Puppet Pailo");
        List_Enemys_Image.Add("Characters/Enemys 256/Ghost Puppet Pailo");
        List_Enemys_Name.Add("Ghost Revelator");
        List_Enemys_Image.Add("Characters/Enemys 256/Ghost Revelator");
        List_Enemys_Name.Add("Goblin Archer");
        List_Enemys_Image.Add("Characters/Enemys 256/Goblin Archer");
        List_Enemys_Name.Add("Goblin Elite");
        List_Enemys_Image.Add("Characters/Enemys 256/Goblin Elite");
        List_Enemys_Name.Add("Goblin Grunt");
        List_Enemys_Image.Add("Characters/Enemys 256/Goblin Grunt");
        List_Enemys_Name.Add("Goblin Mage");
        List_Enemys_Image.Add("Characters/Enemys 256/Goblin Mage");
        List_Enemys_Name.Add("Goblin Raider");
        List_Enemys_Image.Add("Characters/Enemys 256/Goblin Raider");
        List_Enemys_Name.Add("God Novus");
        List_Enemys_Image.Add("Characters/Enemys 256/God Novus");
        List_Enemys_Name.Add("Goddess Innova");
        List_Enemys_Image.Add("Characters/Enemys 256/Goddess Innova");
        List_Enemys_Name.Add("Gunblin Gibson");
        List_Enemys_Image.Add("Characters/Enemys 256/Gunblin Gibson");
        List_Enemys_Name.Add("Gunblin Jackson");
        List_Enemys_Image.Add("Characters/Enemys 256/Gunblin Jackson");
        List_Enemys_Name.Add("Gunblin Schecter");
        List_Enemys_Image.Add("Characters/Enemys 256/Gunblin Schecter");
        List_Enemys_Name.Add("Halloween Bat");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Bat");
        List_Enemys_Name.Add("Halloween Black Cat");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Black Cat");
        List_Enemys_Name.Add("Halloween Dagger skeleton");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Dagger skeleton");
        List_Enemys_Name.Add("Halloween Lick O Wisp");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Lick O Wisp");
        List_Enemys_Name.Add("Halloween Pumpkin Chariot Minion A");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Pumpkin Chariot Minion A");
        List_Enemys_Name.Add("Halloween Pumpkin Chariot Minion B");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Pumpkin Chariot Minion B");
        List_Enemys_Name.Add("Halloween Pumpkin Chariot No Minion");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Pumpkin Chariot No Minion");
        List_Enemys_Name.Add("Halloween Pumpkin Chariot");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Pumpkin Chariot");
        List_Enemys_Name.Add("Halloween Pumpkin Gentleman");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Pumpkin Gentleman");
        List_Enemys_Name.Add("Halloween Pumpkin");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Pumpkin");
        List_Enemys_Name.Add("Halloween Skeleton");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Skeleton");
        List_Enemys_Name.Add("Halloween Spirit Mumpkin");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Spirit Mumpkin");
        List_Enemys_Name.Add("Halloween Stein Monster");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Stein Monster");
        List_Enemys_Name.Add("Halloween Stein's Monster MK2");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Stein's Monster MK2");
        List_Enemys_Name.Add("Halloween Vampire");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Vampire");
        List_Enemys_Name.Add("Halloween Witch Baba");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Witch Baba");
        List_Enemys_Name.Add("Halloween Witch");
        List_Enemys_Image.Add("Characters/Enemys 256/Halloween Witch");
        List_Enemys_Name.Add("Ice Avian");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Avian");
        List_Enemys_Name.Add("Ice Bull");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Bull");
        List_Enemys_Name.Add("Ice Cave Bat");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Cave Bat");
        List_Enemys_Name.Add("Ice Glacier SPawn");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Glacier SPawn");
        List_Enemys_Name.Add("Ice Golem");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Golem");
        List_Enemys_Name.Add("Ice Kindred Glacier");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Kindred Glacier");
        List_Enemys_Name.Add("Ice Lion");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Lion");
        List_Enemys_Name.Add("Ice Ogre");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Ogre");
        List_Enemys_Name.Add("Ice Snake");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Snake");
        List_Enemys_Name.Add("Ice Snobros");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Snobros");
        List_Enemys_Name.Add("Ice Snowball");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Snowball");
        List_Enemys_Name.Add("Ice Snowman");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Snowman");
        List_Enemys_Name.Add("Ice Spike");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Spike");
        List_Enemys_Name.Add("Ice Turtle");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Turtle");
        List_Enemys_Name.Add("Ice Whisp");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Whisp");
        List_Enemys_Name.Add("Ice Yeti Whisp");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Yeti Whisp");
        List_Enemys_Name.Add("Ice Yeti");
        List_Enemys_Image.Add("Characters/Enemys 256/Ice Yeti");
        List_Enemys_Name.Add("Insect Red Ant Knight");
        List_Enemys_Image.Add("Characters/Enemys 256/Insect Red Ant Knight");
        List_Enemys_Name.Add("Insects Ant Lion");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Ant Lion");
        List_Enemys_Name.Add("Insects Bee");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Bee");
        List_Enemys_Name.Add("Insects Black Ant Archer");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Black Ant Archer");
        List_Enemys_Name.Add("Insects Black Ant Berserker");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Black Ant Berserker");
        List_Enemys_Name.Add("Insects Black Ant Knight");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Black Ant Knight");
        List_Enemys_Name.Add("Insects Black Ant Mage");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Black Ant Mage");
        List_Enemys_Name.Add("Insects Black Ant Protector");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Black Ant Protector");
        List_Enemys_Name.Add("Insects Caterpillar A");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Caterpillar A");
        List_Enemys_Name.Add("Insects Caterpillar B");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Caterpillar B");
        List_Enemys_Name.Add("Insects Dragon");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Dragon");
        List_Enemys_Name.Add("Insects Dragonfly B");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Dragonfly B");
        List_Enemys_Name.Add("Insects Dragonfly");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Dragonfly");
        List_Enemys_Name.Add("Insects eyehopper");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects eyehopper");
        List_Enemys_Name.Add("Insects Fire Ant");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Fire Ant");
        List_Enemys_Name.Add("Insects Giant Bug Centipede");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Giant Bug Centipede");
        List_Enemys_Name.Add("Insects Giant Bug Death Worm A");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Giant Bug Death Worm A");
        List_Enemys_Name.Add("Insects Giant Bug Death Worm B");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Giant Bug Death Worm B");
        List_Enemys_Name.Add("Insects Giant Bug Hercules");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Giant Bug Hercules");
        List_Enemys_Name.Add("Insects Hell Mantis");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Hell Mantis");
        List_Enemys_Name.Add("Insects Lunar Butterfly");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Lunar Butterfly");
        List_Enemys_Name.Add("Insects Roach");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Roach");
        List_Enemys_Name.Add("Insects Scarab");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Scarab");
        List_Enemys_Name.Add("Insects Sickle Mantis");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Sickle Mantis");
        List_Enemys_Name.Add("Insects Swarm");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Swarm");
        List_Enemys_Name.Add("Insects Tick");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Tick");
        List_Enemys_Name.Add("Insects Tridentpupa");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Tridentpupa");
        List_Enemys_Name.Add("Insects Waterstrider");
        List_Enemys_Image.Add("Characters/Enemys 256/Insects Waterstrider");
        List_Enemys_Name.Add("Knight Axe Common");
        List_Enemys_Image.Add("Characters/Enemys 256/Knight Axe Common");
        List_Enemys_Name.Add("Knight Axe Elite");
        List_Enemys_Image.Add("Characters/Enemys 256/Knight Axe Elite");
        List_Enemys_Name.Add("Knight Blunderbuss Common");
        List_Enemys_Image.Add("Characters/Enemys 256/Knight Blunderbuss Common");
        List_Enemys_Name.Add("Knight Blunderbuss Elite");
        List_Enemys_Image.Add("Characters/Enemys 256/Knight Blunderbuss Elite");
        List_Enemys_Name.Add("Knight Spear Elite");
        List_Enemys_Image.Add("Characters/Enemys 256/Knight Spear Elite");
        List_Enemys_Name.Add("Knight Sword Elite");
        List_Enemys_Image.Add("Characters/Enemys 256/Knight Sword Elite");
        List_Enemys_Name.Add("Knights Spear Common");
        List_Enemys_Image.Add("Characters/Enemys 256/Knights Spear Common");
        List_Enemys_Name.Add("Knights Sword Common");
        List_Enemys_Image.Add("Characters/Enemys 256/Knights Sword Common");
        List_Enemys_Name.Add("Kobolds Dagger Kobold");
        List_Enemys_Image.Add("Characters/Enemys 256/Kobolds Dagger Kobold");
        List_Enemys_Name.Add("Kobolds Mage Kobold");
        List_Enemys_Image.Add("Characters/Enemys 256/Kobolds Mage Kobold");
        List_Enemys_Name.Add("Kobolds Spear Kobold");
        List_Enemys_Image.Add("Characters/Enemys 256/Kobolds Spear Kobold");
        List_Enemys_Name.Add("Lamia");
        List_Enemys_Image.Add("Characters/Enemys 256/Lamia");
        List_Enemys_Name.Add("Legendary Knight Ansellus");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Ansellus");
        List_Enemys_Name.Add("Legendary Knight Arriete");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Arriete");
        List_Enemys_Name.Add("Legendary Knight Arriette F");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Arriette F");
        List_Enemys_Name.Add("Legendary Knight Croix");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Croix");
        List_Enemys_Name.Add("Legendary Knight Dalton");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Dalton");
        List_Enemys_Name.Add("Legendary Knight Dante");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Dante");
        List_Enemys_Name.Add("Legendary Knight Jeanne");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Jeanne");
        List_Enemys_Name.Add("Legendary Knight King Archial");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight King Archial");
        List_Enemys_Name.Add("Legendary Knight Michael");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Michael");
        List_Enemys_Name.Add("Legendary Knight Pizarro B");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Pizarro B");
        List_Enemys_Name.Add("Legendary Knight Pizarro");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Pizarro");
        List_Enemys_Name.Add("Legendary Knight Regulus");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Regulus");
        List_Enemys_Name.Add("Legendary Knight Remment");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Remment");
        List_Enemys_Name.Add("Legendary Knight Sen");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Sen");
        List_Enemys_Name.Add("Legendary Knight Serat");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Serat");
        List_Enemys_Name.Add("Legendary Knight Zidh B");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Zidh B");
        List_Enemys_Name.Add("Legendary Knight Zidh");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knight Zidh");
        List_Enemys_Name.Add("Legendary Knights Blacksmith Remment");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knights Blacksmith Remment");
        List_Enemys_Name.Add("Legendary Knights Dancer Zidh");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knights Dancer Zidh");
        List_Enemys_Name.Add("Legendary Knights Disciple Chain");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knights Disciple Chain");
        List_Enemys_Name.Add("Legendary Knights Disciple Moonblade");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knights Disciple Moonblade");
        List_Enemys_Name.Add("Legendary Knights Disciple Pike");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knights Disciple Pike");
        List_Enemys_Name.Add("Legendary Knights Huntress Arriette");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knights Huntress Arriette");
        List_Enemys_Name.Add("Legendary Knights Minion Axe");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knights Minion Axe");
        List_Enemys_Name.Add("Legendary Knights Minion Claymore");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knights Minion Claymore");
        List_Enemys_Name.Add("Legendary Knights Minion Spear");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knights Minion Spear");
        List_Enemys_Name.Add("Legendary Knights Nobleman Ansellus");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knights Nobleman Ansellus");
        List_Enemys_Name.Add("Legendary Knights Scholar Jeanne");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knights Scholar Jeanne");
        List_Enemys_Name.Add("Legendary Knights Summoner Dante A");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knights Summoner Dante A");
        List_Enemys_Name.Add("Legendary Knights Summoner Dante B");
        List_Enemys_Image.Add("Characters/Enemys 256/Legendary Knights Summoner Dante B");
        List_Enemys_Name.Add("Library Book Golem");
        List_Enemys_Image.Add("Characters/Enemys 256/Library Book Golem");
        List_Enemys_Name.Add("Library Book Master");
        List_Enemys_Image.Add("Characters/Enemys 256/Library Book Master");
        List_Enemys_Name.Add("Library Book Swarm B");
        List_Enemys_Image.Add("Characters/Enemys 256/Library Book Swarm B");
        List_Enemys_Name.Add("Library Book Swarm");
        List_Enemys_Image.Add("Characters/Enemys 256/Library Book Swarm");
        List_Enemys_Name.Add("Light Angel Heavy Knight");
        List_Enemys_Image.Add("Characters/Enemys 256/Light Angel Heavy Knight");
        List_Enemys_Name.Add("Light Angel Knight");
        List_Enemys_Image.Add("Characters/Enemys 256/Light Angel Knight");
        List_Enemys_Name.Add("Light Angel Maiden");
        List_Enemys_Image.Add("Characters/Enemys 256/Light Angel Maiden");
        List_Enemys_Name.Add("Light Creatures Throne");
        List_Enemys_Image.Add("Characters/Enemys 256/Light Creatures Throne");
        List_Enemys_Name.Add("Light Dragon");
        List_Enemys_Image.Add("Characters/Enemys 256/Light Dragon");
        List_Enemys_Name.Add("Light Gemstone A");
        List_Enemys_Image.Add("Characters/Enemys 256/Light Gemstone A");
        List_Enemys_Name.Add("Light Gemstone B");
        List_Enemys_Image.Add("Characters/Enemys 256/Light Gemstone B");
        List_Enemys_Name.Add("Light Gemstone C");
        List_Enemys_Image.Add("Characters/Enemys 256/Light Gemstone C");
        List_Enemys_Name.Add("Light Holy Orb");
        List_Enemys_Image.Add("Characters/Enemys 256/Light Holy Orb");
        List_Enemys_Name.Add("Light Scholar Angel");
        List_Enemys_Image.Add("Characters/Enemys 256/Light Scholar Angel");
        List_Enemys_Name.Add("Light Slime");
        List_Enemys_Image.Add("Characters/Enemys 256/Light Slime");
        List_Enemys_Name.Add("Light Snake");
        List_Enemys_Image.Add("Characters/Enemys 256/Light Snake");
        List_Enemys_Name.Add("Light Summoned Angel");
        List_Enemys_Image.Add("Characters/Enemys 256/Light Summoned Angel");
        List_Enemys_Name.Add("Light Wisp");
        List_Enemys_Image.Add("Characters/Enemys 256/Light Wisp");
        List_Enemys_Name.Add("Light Wolf");
        List_Enemys_Image.Add("Characters/Enemys 256/Light Wolf");
        List_Enemys_Name.Add("Machines Airship");
        List_Enemys_Image.Add("Characters/Enemys 256/Machines Airship");
        List_Enemys_Name.Add("Machines Cannon");
        List_Enemys_Image.Add("Characters/Enemys 256/Machines Cannon");
        List_Enemys_Name.Add("Machines Fantasy Tank A");
        List_Enemys_Image.Add("Characters/Enemys 256/Machines Fantasy Tank A");
        List_Enemys_Name.Add("Machines Fantasy Tank B");
        List_Enemys_Image.Add("Characters/Enemys 256/Machines Fantasy Tank B");
        List_Enemys_Name.Add("MAchines Fantasy Tank C");
        List_Enemys_Image.Add("Characters/Enemys 256/MAchines Fantasy Tank C");
        List_Enemys_Name.Add("Machines Fantasy Tank D");
        List_Enemys_Image.Add("Characters/Enemys 256/Machines Fantasy Tank D");
        List_Enemys_Name.Add("Machines Zeppellin");
        List_Enemys_Image.Add("Characters/Enemys 256/Machines Zeppellin");
        List_Enemys_Name.Add("Mage Garrintan");
        List_Enemys_Image.Add("Characters/Enemys 256/Mage Garrintan");
        List_Enemys_Name.Add("Medieval Bandit Child");
        List_Enemys_Image.Add("Characters/Enemys 256/Medieval Bandit Child");
        List_Enemys_Name.Add("Medieval Bandit Dagger Gun");
        List_Enemys_Image.Add("Characters/Enemys 256/Medieval Bandit Dagger Gun");
        List_Enemys_Name.Add("Medieval Bandit Great Sword");
        List_Enemys_Image.Add("Characters/Enemys 256/Medieval Bandit Great Sword");
        List_Enemys_Name.Add("Megapack II Avian A");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Avian A");
        List_Enemys_Name.Add("Megapack II Avian Elephant");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Avian Elephant");
        List_Enemys_Name.Add("Megapack II Betafish");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Betafish");
        List_Enemys_Name.Add("Megapack II Biofish");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Biofish");
        List_Enemys_Name.Add("Megapack II Black Lance Knight");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Black Lance Knight");
        List_Enemys_Name.Add("Megapack II Blue Seeker");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Blue Seeker");
        List_Enemys_Name.Add("Megapack II Bug Originator");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Bug Originator");
        List_Enemys_Name.Add("Megapack II Colossal Mummy");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Colossal Mummy");
        List_Enemys_Name.Add("Megapack II Crocoknight");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Crocoknight");
        List_Enemys_Name.Add("Megapack II Diamond Dog");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Diamond Dog");
        List_Enemys_Name.Add("Megapack II Dryad Mini");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Dryad Mini");
        List_Enemys_Name.Add("Megapack II Electroctopus");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Electroctopus");
        List_Enemys_Name.Add("Megapack II Feathered Snake");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Feathered Snake");
        List_Enemys_Name.Add("Megapack II Flame Monkey");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Flame Monkey");
        List_Enemys_Name.Add("Megapack II Forest Six-Wing Fairy");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Forest Six-Wing Fairy");
        List_Enemys_Name.Add("Megapack II Frost Gorilla");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Frost Gorilla");
        List_Enemys_Name.Add("Megapack II Horn Willow");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Horn Willow");
        List_Enemys_Name.Add("MEgapack II Hornet Warrior");
        List_Enemys_Image.Add("Characters/Enemys 256/MEgapack II Hornet Warrior");
        List_Enemys_Name.Add("Megapack II Mountain Razortail Eagle");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Mountain Razortail Eagle");
        List_Enemys_Name.Add("Megapack II Red Shroom A");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Red Shroom A");
        List_Enemys_Name.Add("MEgapack II Red Shroom B");
        List_Enemys_Image.Add("Characters/Enemys 256/MEgapack II Red Shroom B");
        List_Enemys_Name.Add("Megapack II Roaming Salamander");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Roaming Salamander");
        List_Enemys_Name.Add("Megapack II Rocktail Demolisher");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Rocktail Demolisher");
        List_Enemys_Name.Add("Megapack II Samurai Skeleton");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Samurai Skeleton");
        List_Enemys_Name.Add("Megapack II Shadow Knight");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Shadow Knight");
        List_Enemys_Name.Add("Megapack II Silver Avian");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Silver Avian");
        List_Enemys_Name.Add("Megapack II Spike Hopper");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Spike Hopper");
        List_Enemys_Name.Add("Megapack II Spiked Caterpillar");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Spiked Caterpillar");
        List_Enemys_Name.Add("Megapack II Toucan Panther");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Toucan Panther");
        List_Enemys_Name.Add("Megapack II Void Demon B");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Void Demon B");
        List_Enemys_Name.Add("Megapack II White Minotaur");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II White Minotaur");
        List_Enemys_Name.Add("Megapack II Wingless Dragon");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack II Wingless Dragon");
        List_Enemys_Name.Add("Megapack III Axe Warrior Dwarf");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Axe Warrior Dwarf");
        List_Enemys_Name.Add("Megapack III Behemoth");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Behemoth");
        List_Enemys_Name.Add("Megapack III Black Iron Minotaur Beef");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Black Iron Minotaur Beef");
        List_Enemys_Name.Add("Megapack III Cerberus Ptolemaios");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Cerberus Ptolemaios");
        List_Enemys_Name.Add("Megapack III Dragonslayer Dwarf");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Dragonslayer Dwarf");
        List_Enemys_Name.Add("Megapack III Elemental Lords Fire Lord");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Elemental Lords Fire Lord");
        List_Enemys_Name.Add("Megapack III Elemental Lords Ice Maiden");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Elemental Lords Ice Maiden");
        List_Enemys_Name.Add("Megapack III Fallen Kings Arcane King Jeffroy");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Fallen Kings Arcane King Jeffroy");
        List_Enemys_Name.Add("Megapack III Fallen Kings King Of Dwarves Skor");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Fallen Kings King Of Dwarves Skor");
        List_Enemys_Name.Add("Megapack III Fallen Kings King Of Elves Dreyel");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Fallen Kings King Of Elves Dreyel");
        List_Enemys_Name.Add("Megapack III Fallen Kings King Of Giants Goken");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Fallen Kings King Of Giants Goken");
        List_Enemys_Name.Add("Megapack III Hellhound Inferni");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Hellhound Inferni");
        List_Enemys_Name.Add("Megapack III Red Guard A");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Red Guard A");
        List_Enemys_Name.Add("Megapack III Red Guard B");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Red Guard B");
        List_Enemys_Name.Add("Megapack III Red Guard C");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Red Guard C");
        List_Enemys_Name.Add("Megapack III Undead Warrior Benkei");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Undead Warrior Benkei");
        List_Enemys_Name.Add("Megapack III Void Gargoyle");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Void Gargoyle");
        List_Enemys_Name.Add("Megapack III Zodiac Aries");
        List_Enemys_Image.Add("Characters/Enemys 256/Megapack III Zodiac Aries");
        List_Enemys_Name.Add("Megpack III Drill Dwarf");
        List_Enemys_Image.Add("Characters/Enemys 256/Megpack III Drill Dwarf");
        List_Enemys_Name.Add("Megpack III Fallen Kings Undead King Berthelot");
        List_Enemys_Image.Add("Characters/Enemys 256/Megpack III Fallen Kings Undead King Berthelot");
        List_Enemys_Name.Add("Mimic Armor");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Armor");
        List_Enemys_Name.Add("Mimic Barrel");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Barrel");
        List_Enemys_Name.Add("Mimic Book");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Book");
        List_Enemys_Name.Add("Mimic Bow");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Bow");
        List_Enemys_Name.Add("Mimic Bush");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Bush");
        List_Enemys_Name.Add("Mimic Chest");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Chest");
        List_Enemys_Name.Add("Mimic Cloak");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Cloak");
        List_Enemys_Name.Add("Mimic Crystal");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Crystal");
        List_Enemys_Name.Add("Mimic Door");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Door");
        List_Enemys_Name.Add("Mimic Humanoid");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Humanoid");
        List_Enemys_Name.Add("Mimic Jar");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Jar");
        List_Enemys_Name.Add("Mimic Paper Plane");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Paper Plane");
        List_Enemys_Name.Add("Mimic Potion");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Potion");
        List_Enemys_Name.Add("Mimic Sarcophagus");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Sarcophagus");
        List_Enemys_Name.Add("Mimic Shield");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Shield");
        List_Enemys_Name.Add("Mimic Slime");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Slime");
        List_Enemys_Name.Add("Mimic Sword");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic Sword");
        List_Enemys_Name.Add("Mimic");
        List_Enemys_Image.Add("Characters/Enemys 256/Mimic");
        List_Enemys_Name.Add("Minotaur Beef");
        List_Enemys_Image.Add("Characters/Enemys 256/Minotaur Beef");
        List_Enemys_Name.Add("Minotaur BloodshotBeef");
        List_Enemys_Image.Add("Characters/Enemys 256/Minotaur BloodshotBeef");
        List_Enemys_Name.Add("Mirror Mimic");
        List_Enemys_Image.Add("Characters/Enemys 256/Mirror Mimic");
        List_Enemys_Name.Add("Mountain Bat");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Bat");
        List_Enemys_Name.Add("Mountain Black Wolf");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Black Wolf");
        List_Enemys_Name.Add("Mountain Bull Dragon");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Bull Dragon");
        List_Enemys_Name.Add("Mountain Bunny");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Bunny");
        List_Enemys_Name.Add("Mountain Chimera");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Chimera");
        List_Enemys_Name.Add("Mountain Dodo");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Dodo");
        List_Enemys_Name.Add("Mountain Fetero");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Fetero");
        List_Enemys_Name.Add("Mountain Goat");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Goat");
        List_Enemys_Name.Add("Mountain Greathorn Goat");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Greathorn Goat");
        List_Enemys_Name.Add("Mountain Griffon");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Griffon");
        List_Enemys_Name.Add("Mountain Harpy");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Harpy");
        List_Enemys_Name.Add("Mountain Hornette");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Hornette");
        List_Enemys_Name.Add("Mountain Nanjo");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Nanjo");
        List_Enemys_Name.Add("Mountain Owl");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Owl");
        List_Enemys_Name.Add("Mountain Peacock");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Peacock");
        List_Enemys_Name.Add("Mountain Rock Mimic");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Rock Mimic");
        List_Enemys_Name.Add("Mountain Scorpion Scopus");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Scorpion Scopus");
        List_Enemys_Name.Add("Mountain Serpens");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Serpens");
        List_Enemys_Name.Add("Mountain Snail");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Snail");
        List_Enemys_Name.Add("Mountain Warthog");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Warthog");
        List_Enemys_Name.Add("Mountain Werebear Martz");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Werebear Martz");
        List_Enemys_Name.Add("Mountain Winter Wolf");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Winter Wolf");
        List_Enemys_Name.Add("Mountain Wolf");
        List_Enemys_Image.Add("Characters/Enemys 256/Mountain Wolf");
        List_Enemys_Name.Add("MountainScarbear");
        List_Enemys_Image.Add("Characters/Enemys 256/MountainScarbear");
        List_Enemys_Name.Add("Moutain Behemoth");
        List_Enemys_Image.Add("Characters/Enemys 256/Moutain Behemoth");
        List_Enemys_Name.Add("Mushroom Don");
        List_Enemys_Image.Add("Characters/Enemys 256/Mushroom Don");
        List_Enemys_Name.Add("Mushroom Shroomslinger");
        List_Enemys_Image.Add("Characters/Enemys 256/Mushroom Shroomslinger");
        List_Enemys_Name.Add("Objects Ace Club");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects Ace Club");
        List_Enemys_Name.Add("Objects Ace Diamond");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects Ace Diamond");
        List_Enemys_Name.Add("Objects Ace Heart");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects Ace Heart");
        List_Enemys_Name.Add("Objects Ace Spade");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects Ace Spade");
        List_Enemys_Name.Add("Objects Assault Station");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects Assault Station");
        List_Enemys_Name.Add("Objects bBishop");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects bBishop");
        List_Enemys_Name.Add("Objects bHorse");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects bHorse");
        List_Enemys_Name.Add("Objects bKing");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects bKing");
        List_Enemys_Name.Add("Objects bPawnA");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects bPawnA");
        List_Enemys_Name.Add("Objects bPawnB");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects bPawnB");
        List_Enemys_Name.Add("Objects bQueen");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects bQueen");
        List_Enemys_Name.Add("Objects bTower");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects bTower");
        List_Enemys_Name.Add("Objects Dorian");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects Dorian");
        List_Enemys_Name.Add("Objects Driller");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects Driller");
        List_Enemys_Name.Add("Objects Madpill");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects Madpill");
        List_Enemys_Name.Add("Objects Madsule");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects Madsule");
        List_Enemys_Name.Add("Objects Mainframe");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects Mainframe");
        List_Enemys_Name.Add("Objects Medibros");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects Medibros");
        List_Enemys_Name.Add("Objects Twin handheld");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects Twin handheld");
        List_Enemys_Name.Add("Objects wBishop");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects wBishop");
        List_Enemys_Name.Add("Objects wHorse");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects wHorse");
        List_Enemys_Name.Add("Objects wKing");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects wKing");
        List_Enemys_Name.Add("Objects wPawnA");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects wPawnA");
        List_Enemys_Name.Add("Objects wPawnB");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects wPawnB");
        List_Enemys_Name.Add("Objects wQueen");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects wQueen");
        List_Enemys_Name.Add("Objects wTower");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects wTower");
        List_Enemys_Name.Add("Objects YBox");
        List_Enemys_Image.Add("Characters/Enemys 256/Objects YBox");
        List_Enemys_Name.Add("Orc Archer Weak");
        List_Enemys_Image.Add("Characters/Enemys 256/Orc Archer Weak");
        List_Enemys_Name.Add("Orc Archer");
        List_Enemys_Image.Add("Characters/Enemys 256/Orc Archer");
        List_Enemys_Name.Add("Orc Axe Warrior Weak");
        List_Enemys_Image.Add("Characters/Enemys 256/Orc Axe Warrior Weak");
        List_Enemys_Name.Add("Orc Axe Warrior");
        List_Enemys_Image.Add("Characters/Enemys 256/Orc Axe Warrior");
        List_Enemys_Name.Add("Orc Axe Warrior_W");
        List_Enemys_Image.Add("Characters/Enemys 256/Orc Axe Warrior_W");
        List_Enemys_Name.Add("Orc Sword Warrior Weak");
        List_Enemys_Image.Add("Characters/Enemys 256/Orc Sword Warrior Weak");
        List_Enemys_Name.Add("Orc Sword Warrior");
        List_Enemys_Image.Add("Characters/Enemys 256/Orc Sword Warrior");
        List_Enemys_Name.Add("Orc War Drummer Weak");
        List_Enemys_Image.Add("Characters/Enemys 256/Orc War Drummer Weak");
        List_Enemys_Name.Add("Orc War Drummer");
        List_Enemys_Image.Add("Characters/Enemys 256/Orc War Drummer");
        List_Enemys_Name.Add("Orc Warlock Weak");
        List_Enemys_Image.Add("Characters/Enemys 256/Orc Warlock Weak");
        List_Enemys_Name.Add("Orc Warlock");
        List_Enemys_Image.Add("Characters/Enemys 256/Orc Warlock");
        List_Enemys_Name.Add("Pirate Bandit");
        List_Enemys_Image.Add("Characters/Enemys 256/Pirate Bandit");
        List_Enemys_Name.Add("Pirate Captain");
        List_Enemys_Image.Add("Characters/Enemys 256/Pirate Captain");
        List_Enemys_Name.Add("Pirate Magic Scimitar");
        List_Enemys_Image.Add("Characters/Enemys 256/Pirate Magic Scimitar");
        List_Enemys_Name.Add("Pirate Monkey");
        List_Enemys_Image.Add("Characters/Enemys 256/Pirate Monkey");
        List_Enemys_Name.Add("Pirate Parrot");
        List_Enemys_Image.Add("Characters/Enemys 256/Pirate Parrot");
        List_Enemys_Name.Add("Pirate Skeleton");
        List_Enemys_Image.Add("Characters/Enemys 256/Pirate Skeleton");
        List_Enemys_Name.Add("Plant Warriors Cape Sundew");
        List_Enemys_Image.Add("Characters/Enemys 256/Plant Warriors Cape Sundew");
        List_Enemys_Name.Add("Plant Warriors Rose Knight");
        List_Enemys_Image.Add("Characters/Enemys 256/Plant Warriors Rose Knight");
        List_Enemys_Name.Add("Plant Warriors Screamer Mandrake");
        List_Enemys_Image.Add("Characters/Enemys 256/Plant Warriors Screamer Mandrake");
        List_Enemys_Name.Add("Possessed Knights Axe");
        List_Enemys_Image.Add("Characters/Enemys 256/Possessed Knights Axe");
        List_Enemys_Name.Add("Possessed Knights Gun");
        List_Enemys_Image.Add("Characters/Enemys 256/Possessed Knights Gun");
        List_Enemys_Name.Add("Possessed Knights Saber");
        List_Enemys_Image.Add("Characters/Enemys 256/Possessed Knights Saber");
        List_Enemys_Name.Add("Post-Modern Machinery Assault");
        List_Enemys_Image.Add("Characters/Enemys 256/Post-Modern Machinery Assault");
        List_Enemys_Name.Add("Post-Modern Machinery Heavy");
        List_Enemys_Image.Add("Characters/Enemys 256/Post-Modern Machinery Heavy");
        List_Enemys_Name.Add("Post-Modern Machinery Scout");
        List_Enemys_Image.Add("Characters/Enemys 256/Post-Modern Machinery Scout");
        List_Enemys_Name.Add("Post-Modern Soldier A");
        List_Enemys_Image.Add("Characters/Enemys 256/Post-Modern Soldier A");
        List_Enemys_Name.Add("Post-Modern Soldier B");
        List_Enemys_Image.Add("Characters/Enemys 256/Post-Modern Soldier B");
        List_Enemys_Name.Add("Post-Modern Soldier C");
        List_Enemys_Image.Add("Characters/Enemys 256/Post-Modern Soldier C");
        List_Enemys_Name.Add("Pre-Legendary Knights Cursed Swordsman Michael");
        List_Enemys_Image.Add("Characters/Enemys 256/Pre-Legendary Knights Cursed Swordsman Michael");
        List_Enemys_Name.Add("Pre-legendary Knights Inventor Sen");
        List_Enemys_Image.Add("Characters/Enemys 256/Pre-legendary Knights Inventor Sen");
        List_Enemys_Name.Add("Pre-Legendary Knights Onna-bugeisha Croix");
        List_Enemys_Image.Add("Characters/Enemys 256/Pre-Legendary Knights Onna-bugeisha Croix");
        List_Enemys_Name.Add("Rabbit Warriors Archer");
        List_Enemys_Image.Add("Characters/Enemys 256/Rabbit Warriors Archer");
        List_Enemys_Name.Add("Rabbit Warriors Bandit");
        List_Enemys_Image.Add("Characters/Enemys 256/Rabbit Warriors Bandit");
        List_Enemys_Name.Add("Rabbit Warriors Knight");
        List_Enemys_Image.Add("Characters/Enemys 256/Rabbit Warriors Knight");
        List_Enemys_Name.Add("Robot Dracozord");
        List_Enemys_Image.Add("Characters/Enemys 256/Robot Dracozord");
        List_Enemys_Name.Add("Rock golem");
        List_Enemys_Image.Add("Characters/Enemys 256/Rock golem");
        List_Enemys_Name.Add("Rogue Bastard Sword");
        List_Enemys_Image.Add("Characters/Enemys 256/Rogue Bastard Sword");
        List_Enemys_Name.Add("Rogue Dagger Monk");
        List_Enemys_Image.Add("Characters/Enemys 256/Rogue Dagger Monk");
        List_Enemys_Name.Add("Rogue Twin Dagger");
        List_Enemys_Image.Add("Characters/Enemys 256/Rogue Twin Dagger");
        List_Enemys_Name.Add("Sea Abismos");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Abismos");
        List_Enemys_Name.Add("Sea Arman");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Arman");
        List_Enemys_Name.Add("Sea Armes");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Armes");
        List_Enemys_Name.Add("Sea Armon");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Armon");
        List_Enemys_Name.Add("Sea Beach Dark Shell");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Dark Shell");
        List_Enemys_Name.Add("Sea Beach Dark Star");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Dark Star");
        List_Enemys_Name.Add("Sea Beach Emperor Crab A");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Emperor Crab A");
        List_Enemys_Name.Add("Sea Beach Emperor Crab B");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Emperor Crab B");
        List_Enemys_Name.Add("Sea Beach Hermit Crab");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Hermit Crab");
        List_Enemys_Name.Add("Sea Beach Pelican");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Pelican");
        List_Enemys_Name.Add("Sea Beach Seagull");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Seagull");
        List_Enemys_Name.Add("Sea Beach Shell Claw A");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Shell Claw A");
        List_Enemys_Name.Add("Sea Beach Shell Claw B");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Shell Claw B");
        List_Enemys_Name.Add("Sea Beach Spider Crab A");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Spider Crab A");
        List_Enemys_Name.Add("Sea Beach Spider Crab B");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Spider Crab B");
        List_Enemys_Name.Add("Sea Beach Spikestar ");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Spikestar ");
        List_Enemys_Name.Add("Sea Beach Spore");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Spore");
        List_Enemys_Name.Add("Sea Beach Star Shell");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Star Shell");
        List_Enemys_Name.Add("Sea Beach Stars");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Stars");
        List_Enemys_Name.Add("Sea Beach Turtle Golem");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Turtle Golem");
        List_Enemys_Name.Add("Sea Beach Turtle");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Turtle");
        List_Enemys_Name.Add("Sea Beach Urchin");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach Urchin");
        List_Enemys_Name.Add("Sea Beach War Lobster A");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach War Lobster A");
        List_Enemys_Name.Add("Sea Beach War Lobster B");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Beach War Lobster B");
        List_Enemys_Name.Add("Sea Blue Dragon");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Blue Dragon");
        List_Enemys_Name.Add("Sea Crab");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Crab");
        List_Enemys_Name.Add("Sea Fatoad");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Fatoad");
        List_Enemys_Name.Add("Sea Fish A");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Fish A");
        List_Enemys_Name.Add("Sea Fish B");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Fish B");
        List_Enemys_Name.Add("Sea Fish C");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Fish C");
        List_Enemys_Name.Add("Sea Horntle");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Horntle");
        List_Enemys_Name.Add("Sea Horse");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Horse");
        List_Enemys_Name.Add("Sea Jellyfish");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Jellyfish");
        List_Enemys_Name.Add("Sea Lickitoad");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Lickitoad");
        List_Enemys_Name.Add("Sea Lurker");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Lurker");
        List_Enemys_Name.Add("Sea Mermaid Warrior Arliette");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Mermaid Warrior Arliette");
        List_Enemys_Name.Add("Sea Mermaid Warrior Sasha");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Mermaid Warrior Sasha");
        List_Enemys_Name.Add("Sea Mermaid Warrior Sion");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Mermaid Warrior Sion");
        List_Enemys_Name.Add("Sea Mermaid");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Mermaid");
        List_Enemys_Name.Add("Sea Octi");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Octi");
        List_Enemys_Name.Add("Sea Octopus");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Octopus");
        List_Enemys_Name.Add("Sea Piranos");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Piranos");
        List_Enemys_Name.Add("Sea Seaweed Cannon");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Seaweed Cannon");
        List_Enemys_Name.Add("Sea Shark");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Shark");
        List_Enemys_Name.Add("Sea Shelltacke");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Shelltacke");
        List_Enemys_Name.Add("Sea Spheria");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Spheria");
        List_Enemys_Name.Add("Sea Tortoad");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Tortoad");
        List_Enemys_Name.Add("Sea Turtle");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Turtle");
        List_Enemys_Name.Add("Sea Vamphibian");
        List_Enemys_Image.Add("Characters/Enemys 256/Sea Vamphibian");
        List_Enemys_Name.Add("Secondary Elementals Acid Elemental");
        List_Enemys_Image.Add("Characters/Enemys 256/Secondary Elementals Acid Elemental");
        List_Enemys_Name.Add("Secondary Elementals Time Elemental");
        List_Enemys_Image.Add("Characters/Enemys 256/Secondary Elementals Time Elemental");
        List_Enemys_Name.Add("Secondary Elementals War Elemental");
        List_Enemys_Image.Add("Characters/Enemys 256/Secondary Elementals War Elemental");
        List_Enemys_Name.Add("Seven Sins Gluttony");
        List_Enemys_Image.Add("Characters/Enemys 256/Seven Sins Gluttony");
        List_Enemys_Name.Add("Seven Sins Greed");
        List_Enemys_Image.Add("Characters/Enemys 256/Seven Sins Greed");
        List_Enemys_Name.Add("Seven Sins Lust");
        List_Enemys_Image.Add("Characters/Enemys 256/Seven Sins Lust");
        List_Enemys_Name.Add("Seven Sins Pride");
        List_Enemys_Image.Add("Characters/Enemys 256/Seven Sins Pride");
        List_Enemys_Name.Add("Seven Sins Sloth");
        List_Enemys_Image.Add("Characters/Enemys 256/Seven Sins Sloth");
        List_Enemys_Name.Add("Seven Sins Wrath");
        List_Enemys_Image.Add("Characters/Enemys 256/Seven Sins Wrath");
        List_Enemys_Name.Add("Skeleton Archer Sisbon");
        List_Enemys_Image.Add("Characters/Enemys 256/Skeleton Archer Sisbon");
        List_Enemys_Name.Add("Skeleton Archer");
        List_Enemys_Image.Add("Characters/Enemys 256/Skeleton Archer");
        List_Enemys_Name.Add("Skeleton Dragon");
        List_Enemys_Image.Add("Characters/Enemys 256/Skeleton Dragon");
        List_Enemys_Name.Add("Skeleton Hare");
        List_Enemys_Image.Add("Characters/Enemys 256/Skeleton Hare");
        List_Enemys_Name.Add("Skeleton Knight Alstreim");
        List_Enemys_Image.Add("Characters/Enemys 256/Skeleton Knight Alstreim");
        List_Enemys_Name.Add("Skeleton Knight Baron");
        List_Enemys_Image.Add("Characters/Enemys 256/Skeleton Knight Baron");
        List_Enemys_Name.Add("Skeleton Knight Debon");
        List_Enemys_Image.Add("Characters/Enemys 256/Skeleton Knight Debon");
        List_Enemys_Name.Add("Skeleton Knight Debons");
        List_Enemys_Image.Add("Characters/Enemys 256/Skeleton Knight Debons");
        List_Enemys_Name.Add("Skeleton Mage Mabon");
        List_Enemys_Image.Add("Characters/Enemys 256/Skeleton Mage Mabon");
        List_Enemys_Name.Add("Skeleton Mage");
        List_Enemys_Image.Add("Characters/Enemys 256/Skeleton Mage");
        List_Enemys_Name.Add("Skull Knight Xoer");
        List_Enemys_Image.Add("Characters/Enemys 256/Skull Knight Xoer");
        List_Enemys_Name.Add("Slime Blue");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Blue");
        List_Enemys_Name.Add("Slime Darki");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Darki");
        List_Enemys_Name.Add("Slime Darkii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Darkii");
        List_Enemys_Name.Add("Slime Darkiii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Darkiii");
        List_Enemys_Name.Add("Slime Earthi");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Earthi");
        List_Enemys_Name.Add("Slime Earthii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Earthii");
        List_Enemys_Name.Add("Slime Earthiii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Earthiii");
        List_Enemys_Name.Add("Slime Firei");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Firei");
        List_Enemys_Name.Add("Slime Fireii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Fireii");
        List_Enemys_Name.Add("Slime Fireiii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Fireiii");
        List_Enemys_Name.Add("Slime Holyi");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Holyi");
        List_Enemys_Name.Add("Slime Holyii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Holyii");
        List_Enemys_Name.Add("Slime Holyiii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Holyiii");
        List_Enemys_Name.Add("Slime Icei");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Icei");
        List_Enemys_Name.Add("Slime Iceii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Iceii");
        List_Enemys_Name.Add("Slime Iceiii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Iceiii");
        List_Enemys_Name.Add("Slime RPG Attacker");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime RPG Attacker");
        List_Enemys_Name.Add("Slime RPG Basic");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime RPG Basic");
        List_Enemys_Name.Add("Slime RPG Buffer");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime RPG Buffer");
        List_Enemys_Name.Add("Slime RPG Caster");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime RPG Caster");
        List_Enemys_Name.Add("Slime RPG Debuffer");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime RPG Debuffer");
        List_Enemys_Name.Add("Slime RPG Defender");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime RPG Defender");
        List_Enemys_Name.Add("Slime RPG Healer");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime RPG Healer");
        List_Enemys_Name.Add("Slime RPG King");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime RPG King");
        List_Enemys_Name.Add("Slime Thunderi");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Thunderi");
        List_Enemys_Name.Add("Slime Thunderii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Thunderii");
        List_Enemys_Name.Add("Slime Thunderiii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Thunderiii");
        List_Enemys_Name.Add("Slime Wateri");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Wateri");
        List_Enemys_Name.Add("Slime Waterii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Waterii");
        List_Enemys_Name.Add("Slime Wateriii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Wateriii");
        List_Enemys_Name.Add("Slime Windi");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Windi");
        List_Enemys_Name.Add("Slime Windii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Windii");
        List_Enemys_Name.Add("Slime Windiii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slime Windiii");
        List_Enemys_Name.Add("Slimei");
        List_Enemys_Image.Add("Characters/Enemys 256/Slimei");
        List_Enemys_Name.Add("Slimeii");
        List_Enemys_Image.Add("Characters/Enemys 256/Slimeii");
        List_Enemys_Name.Add("slimeiii");
        List_Enemys_Image.Add("Characters/Enemys 256/slimeiii");
        List_Enemys_Name.Add("Special Spiders Dragon Spider");
        List_Enemys_Image.Add("Characters/Enemys 256/Special Spiders Dragon Spider");
        List_Enemys_Name.Add("Special Spiders Fire Spider");
        List_Enemys_Image.Add("Characters/Enemys 256/Special Spiders Fire Spider");
        List_Enemys_Name.Add("Special Spiders Ghost Spider");
        List_Enemys_Image.Add("Characters/Enemys 256/Special Spiders Ghost Spider");
        List_Enemys_Name.Add("Summon Alicorn");
        List_Enemys_Image.Add("Characters/Enemys 256/Summon Alicorn");
        List_Enemys_Name.Add("Summon Carbuncle");
        List_Enemys_Image.Add("Characters/Enemys 256/Summon Carbuncle");
        List_Enemys_Name.Add("Summon Ifrit");
        List_Enemys_Image.Add("Characters/Enemys 256/Summon Ifrit");
        List_Enemys_Name.Add("Summon Odin");
        List_Enemys_Image.Add("Characters/Enemys 256/Summon Odin");
        List_Enemys_Name.Add("Summon Shiva");
        List_Enemys_Image.Add("Characters/Enemys 256/Summon Shiva");
        List_Enemys_Name.Add("Titan Alfadriel");
        List_Enemys_Image.Add("Characters/Enemys 256/Titan Alfadriel");
        List_Enemys_Name.Add("Titan Aquos");
        List_Enemys_Image.Add("Characters/Enemys 256/Titan Aquos");
        List_Enemys_Name.Add("Titan Darkness Ilnoct");
        List_Enemys_Image.Add("Characters/Enemys 256/Titan Darkness Ilnoct");
        List_Enemys_Name.Add("Titan Earth Terran");
        List_Enemys_Image.Add("Characters/Enemys 256/Titan Earth Terran");
        List_Enemys_Name.Add("Titan Fire Ignis");
        List_Enemys_Image.Add("Characters/Enemys 256/Titan Fire Ignis");
        List_Enemys_Name.Add("Titan Ice Demeres");
        List_Enemys_Image.Add("Characters/Enemys 256/Titan Ice Demeres");
        List_Enemys_Name.Add("Titan Wind Ventoss");
        List_Enemys_Image.Add("Characters/Enemys 256/Titan Wind Ventoss");
        List_Enemys_Name.Add("Titans Thunder Dynamo");
        List_Enemys_Image.Add("Characters/Enemys 256/Titans Thunder Dynamo");
        List_Enemys_Name.Add("Toxic Cactus A");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Cactus A");
        List_Enemys_Name.Add("Toxic Cactus B");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Cactus B");
        List_Enemys_Name.Add("Toxic Cactus C");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Cactus C");
        List_Enemys_Name.Add("Toxic Carnivorous Plant A");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Carnivorous Plant A");
        List_Enemys_Name.Add("Toxic Carnivorous Plant B");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Carnivorous Plant B");
        List_Enemys_Name.Add("Toxic Carnivorous Plant C");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Carnivorous Plant C");
        List_Enemys_Name.Add("Toxic Frog A");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Frog A");
        List_Enemys_Name.Add("Toxic FRog A2");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic FRog A2");
        List_Enemys_Name.Add("Toxic Frog B");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Frog B");
        List_Enemys_Name.Add("Toxic Frog B2");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Frog B2");
        List_Enemys_Name.Add("Toxic Frog C");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Frog C");
        List_Enemys_Name.Add("Toxic Frog C2");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Frog C2");
        List_Enemys_Name.Add("Toxic Maneater Plan A");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Maneater Plan A");
        List_Enemys_Name.Add("Toxic Maneater Plant B");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Maneater Plant B");
        List_Enemys_Name.Add("Toxic Maneater Plant C");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Maneater Plant C");
        List_Enemys_Name.Add("Toxic Root A");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Root A");
        List_Enemys_Name.Add("Toxic Root B");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Root B");
        List_Enemys_Name.Add("Toxic Shroom A");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Shroom A");
        List_Enemys_Name.Add("Toxic Shroom B");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Shroom B");
        List_Enemys_Name.Add("Toxic Shroom C");
        List_Enemys_Image.Add("Characters/Enemys 256/Toxic Shroom C");
        List_Enemys_Name.Add("Tribal Elves Bastard Sword");
        List_Enemys_Image.Add("Characters/Enemys 256/Tribal Elves Bastard Sword");
        List_Enemys_Name.Add("Tribal Elves Dagger");
        List_Enemys_Image.Add("Characters/Enemys 256/Tribal Elves Dagger");
        List_Enemys_Name.Add("Tribal Elves Rapier");
        List_Enemys_Image.Add("Characters/Enemys 256/Tribal Elves Rapier");
        List_Enemys_Name.Add("Undead Benkei");
        List_Enemys_Image.Add("Characters/Enemys 256/Undead Benkei");
        List_Enemys_Name.Add("Undead Claw Knight");
        List_Enemys_Image.Add("Characters/Enemys 256/Undead Claw Knight");
        List_Enemys_Name.Add("Undead Gigaraven");
        List_Enemys_Image.Add("Characters/Enemys 256/Undead Gigaraven");
        List_Enemys_Name.Add("Undead Jiangshi");
        List_Enemys_Image.Add("Characters/Enemys 256/Undead Jiangshi");
        List_Enemys_Name.Add("Undead Skull Slime");
        List_Enemys_Image.Add("Characters/Enemys 256/Undead Skull Slime");
        List_Enemys_Name.Add("Undead Skull Tree");
        List_Enemys_Image.Add("Characters/Enemys 256/Undead Skull Tree");
        List_Enemys_Name.Add("Undead Slime");
        List_Enemys_Image.Add("Characters/Enemys 256/Undead Slime");
        List_Enemys_Name.Add("Undead Walker");
        List_Enemys_Image.Add("Characters/Enemys 256/Undead Walker");
        List_Enemys_Name.Add("Undead Wolf");
        List_Enemys_Image.Add("Characters/Enemys 256/Undead Wolf");        
        List_Enemys_Name.Add("Vampiric Creature Dragon Lamprey");
        List_Enemys_Image.Add("Characters/Enemys 256/Vampiric Creature Dragon Lamprey");
        List_Enemys_Name.Add("Vampiric Creatures Flying Leech");
        List_Enemys_Image.Add("Characters/Enemys 256/Vampiric Creatures Flying Leech");
        List_Enemys_Name.Add("Vampiric Creatures Giant Mosquito");
        List_Enemys_Image.Add("Characters/Enemys 256/Vampiric Creatures Giant Mosquito");
        List_Enemys_Name.Add("Voidoll Erabos");
        List_Enemys_Image.Add("Characters/Enemys 256/Voidoll Erabos");
        List_Enemys_Name.Add("Voidoll Erebia");
        List_Enemys_Image.Add("Characters/Enemys 256/Voidoll Erebia");
        List_Enemys_Name.Add("Voidoll Erebus");
        List_Enemys_Image.Add("Characters/Enemys 256/Voidoll Erebus");
        List_Enemys_Name.Add("Weretiger Maxima");
        List_Enemys_Image.Add("Characters/Enemys 256/Weretiger Maxima");
        List_Enemys_Name.Add("Werewolf Rigel");
        List_Enemys_Image.Add("Characters/Enemys 256/Werewolf Rigel");
        List_Enemys_Name.Add("Whisp Wispia");
        List_Enemys_Image.Add("Characters/Enemys 256/Whisp Wispia");
        List_Enemys_Name.Add("Wind Avian");
        List_Enemys_Image.Add("Characters/Enemys 256/Wind Avian");
        List_Enemys_Name.Add("Wind Bunny");
        List_Enemys_Image.Add("Characters/Enemys 256/Wind Bunny");
        List_Enemys_Name.Add("Wind Fairy");
        List_Enemys_Image.Add("Characters/Enemys 256/Wind Fairy");
        List_Enemys_Name.Add("Wind Feathered Golem");
        List_Enemys_Image.Add("Characters/Enemys 256/Wind Feathered Golem");
        List_Enemys_Name.Add("Wind Feathered Razor");
        List_Enemys_Image.Add("Characters/Enemys 256/Wind Feathered Razor");
        List_Enemys_Name.Add("Wind Harpy");
        List_Enemys_Image.Add("Characters/Enemys 256/Wind Harpy");
        List_Enemys_Name.Add("Wind Lion");
        List_Enemys_Image.Add("Characters/Enemys 256/Wind Lion");
        List_Enemys_Name.Add("Wind Mantis");
        List_Enemys_Image.Add("Characters/Enemys 256/Wind Mantis");
        List_Enemys_Name.Add("Wind Snake");
        List_Enemys_Image.Add("Characters/Enemys 256/Wind Snake");
        List_Enemys_Name.Add("Wind Spawn");
        List_Enemys_Image.Add("Characters/Enemys 256/Wind Spawn");
        List_Enemys_Name.Add("Wind Wisp");
        List_Enemys_Image.Add("Characters/Enemys 256/Wind Wisp");
        List_Enemys_Name.Add("Witch Hunters Healer");
        List_Enemys_Image.Add("Characters/Enemys 256/Witch Hunters Healer");
        List_Enemys_Name.Add("Witch Hunters Leader");
        List_Enemys_Image.Add("Characters/Enemys 256/Witch Hunters Leader");
        List_Enemys_Name.Add("Witch Hunters Noble");
        List_Enemys_Image.Add("Characters/Enemys 256/Witch Hunters Noble");
        List_Enemys_Name.Add("Xmas Bear");
        List_Enemys_Image.Add("Characters/Enemys 256/Xmas Bear");
        List_Enemys_Name.Add("Xmas Cookie");
        List_Enemys_Image.Add("Characters/Enemys 256/Xmas Cookie");
        List_Enemys_Name.Add("Xmas Penguin");
        List_Enemys_Image.Add("Characters/Enemys 256/Xmas Penguin");
        List_Enemys_Name.Add("Xmas Snowman");
        List_Enemys_Image.Add("Characters/Enemys 256/Xmas Snowman");
        List_Enemys_Name.Add("Xmas Tree");
        List_Enemys_Image.Add("Characters/Enemys 256/Xmas Tree");
        List_Enemys_Name.Add("Zodiac Aquarius B");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Aquarius B");
        List_Enemys_Name.Add("Zodiac Aquarius");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Aquarius");
        List_Enemys_Name.Add("Zodiac Aries B");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Aries B");
        List_Enemys_Name.Add("Zodiac Aries");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Aries");
        List_Enemys_Name.Add("Zodiac Capricorn");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Capricorn");
        List_Enemys_Name.Add("Zodiac Creatures Cancer");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Creatures Cancer");
        List_Enemys_Name.Add("Zodiac Creatures Libra");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Creatures Libra");
        List_Enemys_Name.Add("Zodiac Creatures Ophichus");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Creatures Ophichus");
        List_Enemys_Name.Add("Zodiac Creatures Pisces");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Creatures Pisces");
        List_Enemys_Name.Add("Zodiac Creatures Saggitarius");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Creatures Saggitarius");
        List_Enemys_Name.Add("Zodiac Creatures Scorpion");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Creatures Scorpion");
        List_Enemys_Name.Add("Zodiac Gemini");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Gemini");
        List_Enemys_Name.Add("Zodiac Leo B");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Leo B");
        List_Enemys_Name.Add("Zodiac Leo");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Leo");
        List_Enemys_Name.Add("Zodiac Taurus");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Taurus");
        List_Enemys_Name.Add("Zodiac Virgo B");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Virgo B");
        List_Enemys_Name.Add("Zodiac Virgo");
        List_Enemys_Image.Add("Characters/Enemys 256/Zodiac Virgo");
        Map_Majestic_Volcano_Enemys.Add(List_Enemys_Name[10]);
        Map_Majestic_Volcano_Enemys_Image.Add(List_Enemys_Image[10]);
        Map_Majestic_Volcano_Enemys.Add(List_Enemys_Name[20]);
        Map_Majestic_Volcano_Enemys_Image.Add(List_Enemys_Image[20]);
        Map_Majestic_Volcano_Enemys.Add(List_Enemys_Name[30]);
        Map_Majestic_Volcano_Enemys_Image.Add(List_Enemys_Image[30]);
        Map_Majestic_Volcano_Enemys.Add(List_Enemys_Name[40]);
        Map_Majestic_Volcano_Enemys_Image.Add(List_Enemys_Image[40]);
        Map_Majestic_Volcano_Enemys.Add(List_Enemys_Name[41]);
        Map_Majestic_Volcano_Enemys_Image.Add(List_Enemys_Image[41]);
        Map_Majestic_Volcano_Enemys.Add(List_Enemys_Name[32]);
        Map_Majestic_Volcano_Enemys_Image.Add(List_Enemys_Image[32]);
        Map_Majestic_Volcano_Enemys.Add(List_Enemys_Name[33]);
        Map_Majestic_Volcano_Enemys_Image.Add(List_Enemys_Image[33]);
        Map_Infinite_Sea_World_Enemys.Add(List_Enemys_Name[1]);
        Map_Infinite_Sea_World_Enemys_Image.Add(List_Enemys_Image[1]);
        Map_Odins_Waterfall_Enemys.Add(List_Enemys_Name[2]);
        Map_Odins_Waterfall_Enemys_Image.Add(List_Enemys_Image[2]);
        Map_Book_Of_Knowledge_Enemys.Add(List_Enemys_Name[3]);
        Map_Book_Of_Knowledge_Enemys_Image.Add(List_Enemys_Image[3]);
        Map_Odins_Castle_Enemys.Add(List_Enemys_Name[4]);
        Map_Odins_Castle_Enemys_Image.Add(List_Enemys_Image[4]);


        Maps_Enemys.Add(Map_Majestic_Volcano_Enemys);
        Maps_Enemys.Add(Map_Infinite_Sea_World_Enemys);
        Maps_Enemys.Add(Map_Odins_Waterfall_Enemys);
        Maps_Enemys.Add(Map_Book_Of_Knowledge_Enemys);
        Maps_Enemys.Add(Map_Odins_Castle_Enemys);

        Maps_Enemys_Image.Add(Map_Majestic_Volcano_Enemys_Image);
        Maps_Enemys_Image.Add(Map_Infinite_Sea_World_Enemys_Image);
        Maps_Enemys_Image.Add(Map_Odins_Waterfall_Enemys_Image);
        Maps_Enemys_Image.Add(Map_Book_Of_Knowledge_Enemys_Image);
        Maps_Enemys_Image.Add(Map_Odins_Castle_Enemys_Image);
        List_Enemy_Rank.Add("Ranks/style_3_01");
        List_Enemy_Rank.Add("Ranks/style_3_02");
        List_Enemy_Rank.Add("Ranks/style_3_03");
        List_Enemy_Rank.Add("Ranks/style_3_04");
        List_Enemy_Rank.Add("Ranks/style_3_05");
        List_Enemy_Rank.Add("Ranks/style_3_06");
        List_Enemy_Rank.Add("Ranks/style_3_07");
        List_Enemy_Rank.Add("Ranks/style_3_08");
        List_Enemy_Rank.Add("Ranks/style_3_09");
        List_Enemy_Rank.Add("Ranks/style_3_10");
        List_Enemy_Rank.Add("Ranks/style_3_11");
        List_Enemy_Rank.Add("Ranks/style_3_12");
        List_Enemy_Rank.Add("Ranks/style_3_13");
        List_Enemy_Rank.Add("Ranks/style_3_14");
        List_Enemy_Rank.Add("Ranks/style_3_15");
        List_Enemy_Rank.Add("Ranks/style_3_16");
        List_Enemy_Rank.Add("Ranks/style_3_17");
        List_Enemy_Rank.Add("Ranks/style_3_18");
        List_Enemy_Rank.Add("Ranks/style_3_19");
        List_Enemy_Rank.Add("Ranks/style_3_20");
        List_Enemy_Rank.Add("Ranks/style_3_21");
        List_Enemy_Rank.Add("Ranks/style_3_22");
        List_Enemy_Rank.Add("Ranks/style_3_23");
        List_Enemy_Rank.Add("Ranks/style_3_24");
        List_Enemy_Rank.Add("Ranks/style_4_25");        
        List_Map_Rank.Add("Ranks/style_4_01");
        List_Map_Rank.Add("Ranks/style_4_02");
        List_Map_Rank.Add("Ranks/style_4_03");
        List_Map_Rank.Add("Ranks/style_4_04");
        List_Map_Rank.Add("Ranks/style_4_05");
        List_Map_Rank.Add("Ranks/style_4_06");
        List_Map_Rank.Add("Ranks/style_4_07");
        List_Map_Rank.Add("Ranks/style_4_08");
        List_Map_Rank.Add("Ranks/style_4_09");
        List_Map_Rank.Add("Ranks/style_4_10");
        List_Map_Rank.Add("Ranks/style_4_11");
        List_Map_Rank.Add("Ranks/style_4_12");
        List_Map_Rank.Add("Ranks/style_4_13");
        List_Map_Rank.Add("Ranks/style_4_14");
        List_Map_Rank.Add("Ranks/style_4_15");
        List_Map_Rank.Add("Ranks/style_4_16");
        List_Map_Rank.Add("Ranks/style_4_17");
        List_Map_Rank.Add("Ranks/style_4_18");
        List_Map_Rank.Add("Ranks/style_4_19");
        List_Map_Rank.Add("Ranks/style_4_20");
        List_Map_Rank.Add("Ranks/style_4_21");
        List_Map_Rank.Add("Ranks/style_4_22");
        List_Map_Rank.Add("Ranks/style_4_23");
        List_Map_Rank.Add("Ranks/style_4_24");
        List_Map_Rank.Add("Ranks/style_4_25");

        Mining_Big_Camera = GameObject.Find("Big Camera Viewport");
        Mining_Small_Camera = GameObject.Find("Small Camera Viewport");
        ItemsGained_Camera = GameObject.Find("Items Gained Viewport");
        NewItemsGained_Popup_Camera = GameObject.Find("New Items Gained Popup Viewport");
        Rank_List.Add("Item Rank/coin-bronze");
        Rank_List.Add("Item Rank/coin-silver");
        Rank_List.Add("Item Rank/coin-plat");
        Rank_List.Add("Item Rank/coin-gold");
        Rank_List.Add("Item Rank/gold-ingot-1");
        Rank_List.Add("Item Rank/diamond-1");
        Rank_List.Add("Item Rank/diamond-stack");
        Rank_List.Add("Item Rank/heart-1");

	    	Dirt = Resources.Load("Tiles/Dirt", typeof(Sprite)) as Sprite;
    Rich_Soil = Resources.Load("Tiles/Rich_Soil", typeof(Sprite)) as Sprite;
    Very_Rich_Soil = Resources.Load("Tiles/Very_Rich_Soil", typeof(Sprite)) as Sprite;
    Extremly_rich_soil = Resources.Load("Tiles/Extremly_rich_soil", typeof(Sprite)) as Sprite;
    Grass = Resources.Load("Tiles/Grass", typeof(Sprite)) as Sprite;
    Valunite = Resources.Load("Tiles/Valunite", typeof(Sprite)) as Sprite;
    Dark_Valunite = Resources.Load("Tiles/Dark_Valunite", typeof(Sprite)) as Sprite;
    Bamboo = Resources.Load("Tiles/Bamboo", typeof(Sprite)) as Sprite;
    Wood = Resources.Load("Tiles/Wood", typeof(Sprite)) as Sprite;
    Sandstone = Resources.Load("Tiles/Sandstone", typeof(Sprite)) as Sprite;
    Sand = Resources.Load("Tiles/Sand", typeof(Sprite)) as Sprite;
    Packed_Sand = Resources.Load("Tiles/Packed_Sand", typeof(Sprite)) as Sprite;
    Extra_Coins = Resources.Load("Tiles/Extra_Coins", typeof(Sprite)) as Sprite;
    Bonus_Coins = Resources.Load("Tiles/Bonus_Coins", typeof(Sprite)) as Sprite;
    Orange_Box = Resources.Load("Tiles/Orange_Box", typeof(Sprite)) as Sprite;
    Green_Box = Resources.Load("Tiles/Green_Box", typeof(Sprite)) as Sprite;
    Cyan_Box = Resources.Load("Tiles/Cyan_Box", typeof(Sprite)) as Sprite;
    Red_Box = Resources.Load("Tiles/Red_Box", typeof(Sprite)) as Sprite;
    Magenta_Box = Resources.Load("Tiles/Magenta_Box", typeof(Sprite)) as Sprite;
    Purple_Box = Resources.Load("Tiles/Purple_Box", typeof(Sprite)) as Sprite;
    Blue_Box = Resources.Load("Tiles/Blue_Box", typeof(Sprite)) as Sprite;
    Explosion = Resources.Load("Tiles/Explosion", typeof(Sprite)) as Sprite;
    Huge_Explosion = Resources.Load("Tiles/Huge_Explosion", typeof(Sprite)) as Sprite;
    Big_Explosion = Resources.Load("Tiles/Big_Explosion", typeof(Sprite)) as Sprite;
    Timed_Explosion = Resources.Load("Tiles/Timed_Explosion", typeof(Sprite)) as Sprite;
    Enormous_Explosion = Resources.Load("Tiles/Enormous_Explosion", typeof(Sprite)) as Sprite;
    Blue_Key = Resources.Load("Tiles/Blue_Key", typeof(Sprite)) as Sprite;
    Red_Key = Resources.Load("Tiles/Red_Key", typeof(Sprite)) as Sprite;
    Green_Key = Resources.Load("Tiles/Green_Key", typeof(Sprite)) as Sprite;
    Yellow_Key = Resources.Load("Tiles/Yellow_Key", typeof(Sprite)) as Sprite;
    Steel = Resources.Load("Tiles/Steel", typeof(Sprite)) as Sprite;
    Refined_Steel = Resources.Load("Tiles/Refined_Steel", typeof(Sprite)) as Sprite;
    Mystery_Steel = Resources.Load("Tiles/Mystery_Steel", typeof(Sprite)) as Sprite;
    Stone = Resources.Load("Tiles/Stone", typeof(Sprite)) as Sprite;
    Ruby = Resources.Load("Tiles/Ruby", typeof(Sprite)) as Sprite;
    Diamond = Resources.Load("Tiles/Diamond", typeof(Sprite)) as Sprite;
    Gold = Resources.Load("Tiles/Gold", typeof(Sprite)) as Sprite;
    Silver = Resources.Load("Tiles/Silver", typeof(Sprite)) as Sprite;
    Calcite = Resources.Load("Tiles/Calcite", typeof(Sprite)) as Sprite;
    Coal = Resources.Load("Tiles/Coal", typeof(Sprite)) as Sprite;
    Aquamarine = Resources.Load("Tiles/Aquamarine", typeof(Sprite)) as Sprite;
    Pixie_Dust = Resources.Load("Tiles/Pixie_Dust", typeof(Sprite)) as Sprite;
    Emerald = Resources.Load("Tiles/Emerald", typeof(Sprite)) as Sprite;
    Fossils = Resources.Load("Tiles/Fossils", typeof(Sprite)) as Sprite;
    Boxes = Resources.Load("Tiles/Boxes", typeof(Sprite)) as Sprite;
    Old_Box = Resources.Load("Tiles/Old_Box", typeof(Sprite)) as Sprite;
    Unknown = Resources.Load("Tiles/Unknown", typeof(Sprite)) as Sprite;
    Stone_Bricks = Resources.Load("Tiles/Stone_Bricks", typeof(Sprite)) as Sprite;
    Ugly_Bricks = Resources.Load("Tiles/Ugly_Bricks", typeof(Sprite)) as Sprite;
    Brick = Resources.Load("Tiles/Brick", typeof(Sprite)) as Sprite;
    Forest_Crystal = Resources.Load("Tiles/Forest_Crystal", typeof(Sprite)) as Sprite;
    Blood_Crystal = Resources.Load("Tiles/Blood_Crystal", typeof(Sprite)) as Sprite;
    Sand_Crystal = Resources.Load("Tiles/Sand_Crystal", typeof(Sprite)) as Sprite;
    Ice_Crystal = Resources.Load("Tiles/Ice_Crystal", typeof(Sprite)) as Sprite;
    Snow_Crystal = Resources.Load("Tiles/Snow_Crystal", typeof(Sprite)) as Sprite;
    Ice = Resources.Load("Tiles/Ice", typeof(Sprite)) as Sprite;
    Packed_Snow = Resources.Load("Tiles/Packed_Snow", typeof(Sprite)) as Sprite;
    Hardened_Ice = Resources.Load("Tiles/Hardened_Ice", typeof(Sprite)) as Sprite;
    Compressed_Ice = Resources.Load("Tiles/Compressed_Ice", typeof(Sprite)) as Sprite;
        Tiles_List.Add("Dirt");
        Tiles_List_Rank.Add(0);
        Tiles_List.Add("Rich_Soil");
        Tiles_List_Rank.Add(2);
        Tiles_List.Add("Very_Rich_Soil");
        Tiles_List_Rank.Add(4);
        Tiles_List.Add("Extremly_rich_soil");
        Tiles_List_Rank.Add(6);
        Tiles_List.Add("Grass");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Valunite");
        Tiles_List_Rank.Add(1);
        Tiles_List.Add("Dark_Valunite");
        Tiles_List_Rank.Add(2);
        Tiles_List.Add("Bamboo");
        Tiles_List_Rank.Add(3);
        Tiles_List.Add("Wood");
        Tiles_List_Rank.Add(1);
        Tiles_List.Add("Sandstone");
        Tiles_List_Rank.Add(3);
        Tiles_List.Add("Sand");
        Tiles_List_Rank.Add(1);
        Tiles_List.Add("Packed_Sand");
        Tiles_List_Rank.Add(4);
        Tiles_List.Add("Extra_Coins");
        Tiles_List_Rank.Add(1);
        Tiles_List.Add("Bonus_Coins");
        Tiles_List_Rank.Add(1);
        Tiles_List.Add("Orange_Box");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Green_Box");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Cyan_Box");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Red_Box");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Magenta_Box");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Purple_Box");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Blue_Box");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Explosion");
        Tiles_List_Rank.Add(1);
        Tiles_List.Add("Huge_Explosion");
        Tiles_List_Rank.Add(1);
        Tiles_List.Add("Big_Explosion");
        Tiles_List_Rank.Add(1);
        Tiles_List.Add("Timed_Explosion");
        Tiles_List_Rank.Add(1);
        Tiles_List.Add("Enormous_Explosion");
        Tiles_List_Rank.Add(1);
        Tiles_List.Add("Blue_Key");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Red_Key");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Green_Key");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Yellow_Key");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Steel");
        Tiles_List_Rank.Add(3);
        Tiles_List.Add("Refined_Steel");
        Tiles_List_Rank.Add(4);
        Tiles_List.Add("Mystery_Steel");
        Tiles_List_Rank.Add(6);
        Tiles_List.Add("Stone");
        Tiles_List_Rank.Add(2);
        Tiles_List.Add("Ruby");
        Tiles_List_Rank.Add(5);
        Tiles_List.Add("Diamond");
        Tiles_List_Rank.Add(6);
        Tiles_List.Add("Gold");
        Tiles_List_Rank.Add(3);
        Tiles_List.Add("Silver");
        Tiles_List_Rank.Add(2);
        Tiles_List.Add("Calcite");
        Tiles_List_Rank.Add(3);
        Tiles_List.Add("Coal");
        Tiles_List_Rank.Add(2);
        Tiles_List.Add("Aquamarine");
        Tiles_List_Rank.Add(4);
        Tiles_List.Add("Pixie_Dust");
        Tiles_List_Rank.Add(5);
        Tiles_List.Add("Emerald");
        Tiles_List_Rank.Add(6);
        Tiles_List.Add("Fossils");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Boxes");
        Tiles_List_Rank.Add(3);
        Tiles_List.Add("Old_Box");
        Tiles_List_Rank.Add(5);
        Tiles_List.Add("Unknown");
        Tiles_List_Rank.Add(1);
        Tiles_List.Add("Stone_Bricks");
        Tiles_List_Rank.Add(1);
        Tiles_List.Add("Ugly_Bricks");
        Tiles_List_Rank.Add(1);
        Tiles_List.Add("Brick");
        Tiles_List_Rank.Add(1);
        Tiles_List.Add("Forest_Crystal");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Blood_Crystal");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Sand_Crystal");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Ice_Crystal");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Snow_Crystal");
        Tiles_List_Rank.Add(7);
        Tiles_List.Add("Ice");
        Tiles_List_Rank.Add(1);
        Tiles_List.Add("Packed_Snow");
        Tiles_List_Rank.Add(3);
        Tiles_List.Add("Hardened_Ice");
        Tiles_List_Rank.Add(4);
        Tiles_List.Add("Compressed_Ice");
        Tiles_List_Rank.Add(5);


        Tiles_List_NameWithoutUnderscore.Add("Dirt");
        Tiles_List_NameWithoutUnderscore.Add("Rich Soil");
        Tiles_List_NameWithoutUnderscore.Add("Very Rich Soil");
        Tiles_List_NameWithoutUnderscore.Add("Extremly rich soil");
        Tiles_List_NameWithoutUnderscore.Add("Grass");
        Tiles_List_NameWithoutUnderscore.Add("Valunite");
        Tiles_List_NameWithoutUnderscore.Add("Dark Valunite");
        Tiles_List_NameWithoutUnderscore.Add("Bamboo");
        Tiles_List_NameWithoutUnderscore.Add("Wood");
        Tiles_List_NameWithoutUnderscore.Add("Sandstone");
        Tiles_List_NameWithoutUnderscore.Add("Sand");
        Tiles_List_NameWithoutUnderscore.Add("Packed Sand");
        Tiles_List_NameWithoutUnderscore.Add("Extra Coins");
        Tiles_List_NameWithoutUnderscore.Add("Bonus Coins");
        Tiles_List_NameWithoutUnderscore.Add("Orange Box");
        Tiles_List_NameWithoutUnderscore.Add("Green Box");
        Tiles_List_NameWithoutUnderscore.Add("Cyan Box");
        Tiles_List_NameWithoutUnderscore.Add("Red Box");
        Tiles_List_NameWithoutUnderscore.Add("Magenta Box");
        Tiles_List_NameWithoutUnderscore.Add("Purple Box");
        Tiles_List_NameWithoutUnderscore.Add("Blue Box");
        Tiles_List_NameWithoutUnderscore.Add("Explosion");
        Tiles_List_NameWithoutUnderscore.Add("Huge Explosion");
        Tiles_List_NameWithoutUnderscore.Add("Big Explosion");
        Tiles_List_NameWithoutUnderscore.Add("Timed Explosion");
        Tiles_List_NameWithoutUnderscore.Add("Enormous Explosion");
        Tiles_List_NameWithoutUnderscore.Add("Blue Key");
        Tiles_List_NameWithoutUnderscore.Add("Red Key");
        Tiles_List_NameWithoutUnderscore.Add("Green Key");
        Tiles_List_NameWithoutUnderscore.Add("Yellow Key");
        Tiles_List_NameWithoutUnderscore.Add("Steel");
        Tiles_List_NameWithoutUnderscore.Add("Refined Steel");
        Tiles_List_NameWithoutUnderscore.Add("Mystery Steel");
        Tiles_List_NameWithoutUnderscore.Add("Stone");
        Tiles_List_NameWithoutUnderscore.Add("Ruby");
        Tiles_List_NameWithoutUnderscore.Add("Diamond");
        Tiles_List_NameWithoutUnderscore.Add("Gold");
        Tiles_List_NameWithoutUnderscore.Add("Silver");
        Tiles_List_NameWithoutUnderscore.Add("Calcite");
        Tiles_List_NameWithoutUnderscore.Add("Coal");
        Tiles_List_NameWithoutUnderscore.Add("Aquamarine");
        Tiles_List_NameWithoutUnderscore.Add("Pixie Dust");
        Tiles_List_NameWithoutUnderscore.Add("Emerald");
        Tiles_List_NameWithoutUnderscore.Add("Fossils");
        Tiles_List_NameWithoutUnderscore.Add("Boxes");
        Tiles_List_NameWithoutUnderscore.Add("Old Box");
        Tiles_List_NameWithoutUnderscore.Add("Unknown");
        Tiles_List_NameWithoutUnderscore.Add("Stone Bricks");
        Tiles_List_NameWithoutUnderscore.Add("Ugly Bricks");
        Tiles_List_NameWithoutUnderscore.Add("Brick");
        Tiles_List_NameWithoutUnderscore.Add("Forest Crystal");
        Tiles_List_NameWithoutUnderscore.Add("Blood Crystal");
        Tiles_List_NameWithoutUnderscore.Add("Sand Crystal");
        Tiles_List_NameWithoutUnderscore.Add("Ice Crystal");
        Tiles_List_NameWithoutUnderscore.Add("Snow Crystal");
        Tiles_List_NameWithoutUnderscore.Add("Ice");
        Tiles_List_NameWithoutUnderscore.Add("Packed_Snow");
        Tiles_List_NameWithoutUnderscore.Add("Hardened_Ice");
        Tiles_List_NameWithoutUnderscore.Add("Compressed_Ice");
	    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (0)"));
	    	List_Menus_Breakdown_Images.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (0)/Image (1)"));
	    	List_Menus_Breakdown_Images_Texture.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (0)/RawImage (1)"));
	    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (0)/Text Main"));
	    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (0)/Text Shadow 1"));
	    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (0)/Text Shadow 2"));
	    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (1)"));
	    	List_Menus_Breakdown_Images.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (1)/Image (1)"));
	    	List_Menus_Breakdown_Images_Texture.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (1)/RawImage (1)"));
	    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (1)/Text Main"));
	    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (1)/Text Shadow 1"));
	    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (1)/Text Shadow 2"));
	    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (2)"));
	    	List_Menus_Breakdown_Images.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (2)/Image (1)"));
	    	List_Menus_Breakdown_Images_Texture.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (2)/RawImage (1)"));
	    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (2)/Text Main"));
	    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (2)/Text Shadow 1"));
	    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (2)/Text Shadow 2"));
	    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (3)"));
	    	List_Menus_Breakdown_Images.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (3)/Image (1)"));
	    	List_Menus_Breakdown_Images_Texture.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (3)/RawImage (1)"));
	    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (3)/Text Main"));
	    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (3)/Text Shadow 1"));
	    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (3)/Text Shadow 2"));
	    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (4)"));
	    	List_Menus_Breakdown_Images.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (4)/Image (1)"));
	    	List_Menus_Breakdown_Images_Texture.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (4)/RawImage (1)"));
	    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (4)/Text Main"));
	    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (4)/Text Shadow 1"));
	    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (4)/Text Shadow 2"));
	    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (5)"));
	    	List_Menus_Breakdown_Images.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (5)/Image (1)"));
	    	List_Menus_Breakdown_Images_Texture.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (5)/RawImage (1)"));
	    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (5)/Text Main"));
	    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (5)/Text Shadow 1"));
	    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (5)/Text Shadow 2"));
	    	List_Menu_Blank_Strings.Add("");
	    	List_Menu_Blank_Strings.Add("");
	    	List_Menu_Blank_Strings.Add("");
	    	List_Menu_Blank_Strings.Add("");
	    	List_Menu_Blank_Strings.Add("");
	    	List_Menu_Blank_Strings.Add("");
	    	List_Menu_Blank_Strings.Add("");
	    	List_Main_Menu_1_Container.Add("");
	    	List_Main_Menu_1_Container.Add("");
	    	List_Main_Menu_1_Container.Add("");
	    	List_Main_Menu_1_Container.Add("");
	    	List_Main_Menu_1_Container.Add("");
	    	List_Main_Menu_1_Container.Add("");
	    	List_Main_Menu_1_Container.Add("");
	    	List_Main_Menu_1_Container.Add("");
	    	List_Main_Menu_1_Container.Add("");
	    	List_Main_Menu_1_Container.Add("");

	    	List_Main_Menu_1_Container_Images.Add("");
	    	List_Main_Menu_1_Container_Images_Texture.Add("Transparent");
	    	List_Main_Menu_1_Container_Images.Add("");
	    	List_Main_Menu_1_Container_Images_Texture.Add("Transparent");
	    	List_Main_Menu_1_Container_Images.Add("");
	    	List_Main_Menu_1_Container_Images_Texture.Add("Transparent");
	    	List_Main_Menu_1_Container_Images.Add("");
	    	List_Main_Menu_1_Container_Images_Texture.Add("Transparent");
	    	List_Main_Menu_1_Container_Images.Add("");
	    	List_Main_Menu_1_Container_Images_Texture.Add("Transparent");
	    	List_Main_Menu_1_Container_Images.Add("");
	    	List_Main_Menu_1_Container_Images_Texture.Add("Transparent");
	    	List_Main_Menu_1_Container_Images.Add("");
	    	List_Main_Menu_1_Container_Images_Texture.Add("Transparent");
	    	List_Main_Menu_1_Container_Images.Add("");
	    	List_Main_Menu_1_Container_Images_Texture.Add("Transparent");
	    	List_Main_Menu_1_Container_Images.Add("");
	    	List_Main_Menu_1_Container_Images_Texture.Add("Transparent");
	    	List_Main_Menu_1_Container_Images.Add("");
	    	List_Main_Menu_1_Container_Images_Texture.Add("Transparent");

	    	List_Main_Menu_2_Container.Add("");
			List_Main_Menu_2_Container.Add("");
			List_Main_Menu_2_Container.Add("");
			List_Main_Menu_2_Container.Add("");
			List_Main_Menu_2_Container.Add("");
			List_Main_Menu_2_Container.Add("");
			List_Main_Menu_2_Container.Add("");
			List_Main_Menu_2_Container.Add("");
			List_Main_Menu_2_Container.Add("");
			List_Main_Menu_2_Container.Add("");

			List_Main_Menu_2_Container_Images.Add("");
			List_Main_Menu_2_Container_Images_Texture.Add("Transparent");
			List_Main_Menu_2_Container_Images.Add("");
			List_Main_Menu_2_Container_Images_Texture.Add("Transparent");
			List_Main_Menu_2_Container_Images.Add("");
			List_Main_Menu_2_Container_Images_Texture.Add("Transparent");
			List_Main_Menu_2_Container_Images.Add("");
			List_Main_Menu_2_Container_Images_Texture.Add("Transparent");
			List_Main_Menu_2_Container_Images.Add("");
			List_Main_Menu_2_Container_Images_Texture.Add("Transparent");
			List_Main_Menu_2_Container_Images.Add("");
			List_Main_Menu_2_Container_Images_Texture.Add("Transparent");
			List_Main_Menu_2_Container_Images.Add("");
			List_Main_Menu_2_Container_Images_Texture.Add("Transparent");
			List_Main_Menu_2_Container_Images.Add("");
			List_Main_Menu_2_Container_Images_Texture.Add("Transparent");
			List_Main_Menu_2_Container_Images.Add("");
			List_Main_Menu_2_Container_Images_Texture.Add("Transparent");
			List_Main_Menu_2_Container_Images.Add("");
			List_Main_Menu_2_Container_Images_Texture.Add("Transparent");
			List_Written_Out_1_Info.Add("Main Menu");
			List_Written_Out_1_Info.Add("Main Menu");
      Selected_Menu_Title_Background.Add("Main Menu");
      Selected_Menu_Title_Background.Add("3-PUh");
      Selected_Menu_Title_Background.Add("3-Bh");
			List_Written_Out_1_2_Info.Add("Main Menu");
			List_Written_Out_1_2_Info.Add("Search the Web");
			Selected_Menu_Title_Background.Add("Search the Web");
      Selected_Menu_Title_Background.Add("3-PUh");
      Selected_Menu_Title_Background.Add("3-E");		
			List_Written_Out_1_1_Info.Add("Main Menu");
			List_Written_Out_1_1_Info.Add("Play Game");
      Selected_Menu_Title_Background.Add("Play Game");
      Selected_Menu_Title_Background.Add("3-SB");
      Selected_Menu_Title_Background.Add("3-E");
			
			
			List_Written_Out_1_1_1_Info.Add("Play Game");
			List_Written_Out_1_1_1_Info.Add("Mine");
      Selected_Menu_Title_Background.Add("Mine");
      Selected_Menu_Title_Background.Add("3-SBLh");
      Selected_Menu_Title_Background.Add("3-Bh");

			
			List_Written_Out_1_1_2_Info.Add("Play Game");
			List_Written_Out_1_1_2_Info.Add("Forge");
      Selected_Menu_Title_Background.Add("Forge");
      Selected_Menu_Title_Background.Add("3-Bh");
      Selected_Menu_Title_Background.Add("3-Oh");
			//New Info List List_Written_Out
      List_Written_Out_Fight_Info.Add("Play Game");
    List_Written_Out_Fight_Info.Add("Fight");
    Selected_Menu_Title_Background.Add("Fight");
			Selected_Menu_Title_Background.Add("3-DRh");
      Selected_Menu_Title_Background.Add("3-E");

			List_Written_Out_Coal_Vain_Info.Add("Mine");
			List_Written_Out_Coal_Vain_Info.Add("Coal Vain");
			Selected_Menu_Title_Background.Add("Coal Vain");
      Selected_Menu_Title_Background.Add("3-DRh");
      Selected_Menu_Title_Background.Add("3-E");
			
			//New List Area AHK
    List_Written_Out_Areas_Name.Add("Majestic Volcano");
    List_Written_Out_Areas_Background.Add("Backgrounds/backgrounds_62");  
    List_Written_Out_Areas_Name.Add("Infinite Sea World");
    List_Written_Out_Areas_Background.Add("Backgrounds/backgrounds_61");
    List_Written_Out_Areas_Name.Add("Odin's Waterfall");
    List_Written_Out_Areas_Background.Add("Backgrounds/backgrounds_59");
    List_Written_Out_Areas_Name.Add("Book Of Knowledge");
    List_Written_Out_Areas_Background.Add("Backgrounds/backgrounds_51");
    List_Written_Out_Areas_Name.Add("Odin's Castle");
    List_Written_Out_Areas_Background.Add("Backgrounds/backgrounds_44");

    List_Written_Out_Fight_Areas_Name.Add("Majestic Volcano");
    List_Written_Out_Fight_Areas_Background.Add("Backgrounds/backgrounds_62"); 
    List_Written_Out_Fight_Areas_Rank_Num.Add(0);
    List_Written_Out_Fight_Areas_Rank.Add(List_Map_Rank[List_Written_Out_Fight_Areas_Rank_Num[0]]);
    List_Written_Out_Fight_Areas_Current_Enemy.Add("No Enemy");
    List_Written_Out_Fight_Areas_Current_Enemy_Health_Full.Add(100);
    List_Written_Out_Fight_Areas_Current_Enemy_Health_Full_Modified.Add(100);
    List_Written_Out_Fight_Areas_Current_Enemy_Health_Current.Add(100); 
    List_Written_Out_Fight_Areas_Name.Add("Infinite Sea World");
    List_Written_Out_Fight_Areas_Background.Add("Backgrounds/backgrounds_61");
    List_Written_Out_Fight_Areas_Rank_Num.Add(1);
    List_Written_Out_Fight_Areas_Rank.Add(List_Map_Rank[List_Written_Out_Fight_Areas_Rank_Num[1]]);
    List_Written_Out_Fight_Areas_Current_Enemy.Add("No Enemy");
    List_Written_Out_Fight_Areas_Current_Enemy_Health_Full.Add(1000);
    List_Written_Out_Fight_Areas_Current_Enemy_Health_Full_Modified.Add(1000);
    List_Written_Out_Fight_Areas_Current_Enemy_Health_Current.Add(1000);
    List_Written_Out_Fight_Areas_Name.Add("Odin's Waterfall");
    List_Written_Out_Fight_Areas_Background.Add("Backgrounds/backgrounds_59");
    List_Written_Out_Fight_Areas_Rank_Num.Add(2);
    List_Written_Out_Fight_Areas_Rank.Add(List_Map_Rank[List_Written_Out_Fight_Areas_Rank_Num[2]]);
    List_Written_Out_Fight_Areas_Current_Enemy.Add("No Enemy");
    List_Written_Out_Fight_Areas_Current_Enemy_Health_Full.Add(10000);
    List_Written_Out_Fight_Areas_Current_Enemy_Health_Full_Modified.Add(10000);
    List_Written_Out_Fight_Areas_Current_Enemy_Health_Current.Add(10000);
    List_Written_Out_Fight_Areas_Name.Add("Book Of Knowledge");
    List_Written_Out_Fight_Areas_Background.Add("Backgrounds/backgrounds_51");
    List_Written_Out_Fight_Areas_Rank_Num.Add(3);
    List_Written_Out_Fight_Areas_Rank.Add(List_Map_Rank[List_Written_Out_Fight_Areas_Rank_Num[3]]);
    List_Written_Out_Fight_Areas_Current_Enemy.Add("No Enemy");
    List_Written_Out_Fight_Areas_Current_Enemy_Health_Full.Add(100000);
    List_Written_Out_Fight_Areas_Current_Enemy_Health_Full_Modified.Add(100000);
    List_Written_Out_Fight_Areas_Current_Enemy_Health_Current.Add(100000);
    List_Written_Out_Fight_Areas_Name.Add("Odin's Castle");
    List_Written_Out_Fight_Areas_Background.Add("Backgrounds/backgrounds_44");
    List_Written_Out_Fight_Areas_Rank_Num.Add(4);
    List_Written_Out_Fight_Areas_Rank.Add(List_Map_Rank[List_Written_Out_Fight_Areas_Rank_Num[4]]);
    List_Written_Out_Fight_Areas_Current_Enemy.Add("No Enemy");
    List_Written_Out_Fight_Areas_Current_Enemy_Health_Full.Add(1000000);
    List_Written_Out_Fight_Areas_Current_Enemy_Health_Full_Modified.Add(1000000);
    List_Written_Out_Fight_Areas_Current_Enemy_Health_Current.Add(1000000);
    
    List_Written_Out_Fight.Add(List_Written_Out_Fight_Areas_Name[0]);
    List_Written_Out_Fight_Images.Add(List_Written_Out_Fight_Areas_Background[0]+" 256");
    List_Written_Out_Fight_Images_Texture.Add("Transparent");
    List_Written_Out_Fight.Add(List_Written_Out_Fight_Areas_Name[1]);
    List_Written_Out_Fight_Images.Add(List_Written_Out_Fight_Areas_Background[1]+" 256");
    List_Written_Out_Fight_Images_Texture.Add("Transparent");
    List_Written_Out_Fight.Add(List_Written_Out_Fight_Areas_Name[2]);
    List_Written_Out_Fight_Images.Add(List_Written_Out_Fight_Areas_Background[2]+" 256");
    List_Written_Out_Fight_Images_Texture.Add("Transparent");
    List_Written_Out_Fight.Add(List_Written_Out_Fight_Areas_Name[3]);
    List_Written_Out_Fight_Images.Add(List_Written_Out_Fight_Areas_Background[3]+" 256");
    List_Written_Out_Fight_Images_Texture.Add("Transparent");
    List_Written_Out_Fight.Add(List_Written_Out_Fight_Areas_Name[4]);
    List_Written_Out_Fight_Images.Add(List_Written_Out_Fight_Areas_Background[4]+" 256");
    List_Written_Out_Fight_Images_Texture.Add("Transparent");
    List_Written_Out_Fight.Add(" ");
    List_Written_Out_Fight_Images.Add("");
    List_Written_Out_Fight_Images_Texture.Add("Transparent");
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			

			List_Written_Out_Coal_Vain.Add("Coal Vain : On");
			List_Written_Out_Coal_Vain_Images.Add("");
			List_Written_Out_Coal_Vain_Images_Texture.Add("Mining Close Up");
			List_Written_Out_Coal_Vain.Add("Coal Vain : Off");
			List_Written_Out_Coal_Vain_Images.Add("");
			List_Written_Out_Coal_Vain_Images_Texture.Add("Transparent");
			List_Written_Out_Coal_Vain.Add(" ");
			List_Written_Out_Coal_Vain_Images.Add("");
			List_Written_Out_Coal_Vain_Images_Texture.Add("Transparent");
			List_Written_Out_Coal_Vain.Add(" ");
			List_Written_Out_Coal_Vain_Images.Add("");
			List_Written_Out_Coal_Vain_Images_Texture.Add("Transparent");
			List_Written_Out_Coal_Vain.Add(" ");
			List_Written_Out_Coal_Vain_Images.Add("");
			List_Written_Out_Coal_Vain_Images_Texture.Add("Transparent");
			List_Written_Out_Coal_Vain.Add(" ");
			List_Written_Out_Coal_Vain_Images.Add("");
			List_Written_Out_Coal_Vain_Images_Texture.Add("Transparent");
			List_Written_Out_1_1_1.Add("Coal Vain");
			List_Written_Out_1_1_1_Images.Add("");
			List_Written_Out_1_1_1_Images_Texture.Add("Mining Close Up");
			List_Written_Out_1_1_1.Add("Area 2");
			List_Written_Out_1_1_1_Images.Add("");
			List_Written_Out_1_1_1_Images_Texture.Add("Transparent");
			List_Written_Out_1_1_1.Add("Area 3");
			List_Written_Out_1_1_1_Images.Add("");
			List_Written_Out_1_1_1_Images_Texture.Add("Transparent");
			List_Written_Out_1_1_1.Add(" ");
			List_Written_Out_1_1_1_Images.Add("");
			List_Written_Out_1_1_1_Images_Texture.Add("Transparent");
			List_Written_Out_1_1_1.Add(" ");
			List_Written_Out_1_1_1_Images.Add("");
			List_Written_Out_1_1_1_Images_Texture.Add("Transparent");
			List_Written_Out_1_1_1.Add(" ");
			List_Written_Out_1_1_1_Images.Add("");
			List_Written_Out_1_1_1_Images_Texture.Add("Transparent");

			List_Written_Out_1_1.Add("Mine");
			List_Written_Out_1_1_Images.Add("Mining/darkstone");
			List_Written_Out_1_1_Images_Texture.Add("Transparent");
			List_Written_Out_1_1.Add("Farm");
			List_Written_Out_1_1_Images.Add("Food/Fruit/Strawbeares");
			List_Written_Out_1_1_Images_Texture.Add("Transparent");
			List_Written_Out_1_1.Add("Fight");
			List_Written_Out_1_1_Images.Add("Characters/Enemys/Arcane Crystal Magic Circle");
			List_Written_Out_1_1_Images_Texture.Add("Transparent");
			List_Written_Out_1_1.Add("Gather");
			List_Written_Out_1_1_Images.Add("Food/Herbs/Uta");
			List_Written_Out_1_1_Images_Texture.Add("Transparent");
			List_Written_Out_1_1.Add("Alchemy");
			List_Written_Out_1_1_Images.Add("Potions/potion_cocktail_bp_09");
			List_Written_Out_1_1_Images_Texture.Add("Transparent");
			List_Written_Out_1_1.Add("Forge");
			List_Written_Out_1_1_Images.Add("Mining/plate_iron");
			List_Written_Out_1_1_Images_Texture.Add("Transparent");
			List_Written_Out_1_1.Add("Tailor");
			List_Written_Out_1_1_Images.Add("Tailoring/scissors_02");
			List_Written_Out_1_1_Images_Texture.Add("Transparent");
			
			
			List_Written_Out_1_1_2.Add("Make Bars");
			List_Written_Out_1_1_2_Images.Add("");
			List_Written_Out_1_1_2_Images_Texture.Add("Transparent");
			List_Written_Out_1_1_2.Add("Swords");
			List_Written_Out_1_1_2_Images.Add("");
			List_Written_Out_1_1_2_Images_Texture.Add("Transparent");
			List_Written_Out_1_1_2.Add("Helmets");
			List_Written_Out_1_1_2_Images.Add("Equipment/helmet_A_17");
			List_Written_Out_1_1_2_Images_Texture.Add("Transparent");
			List_Written_Out_1_1_2.Add("Chest Plate Armor");
			List_Written_Out_1_1_2_Images.Add("Equipment/armor_A_17");
			List_Written_Out_1_1_2_Images_Texture.Add("Transparent");
			List_Written_Out_1_1_2.Add("Waist Amor");
			List_Written_Out_1_1_2_Images.Add("Equipment/legArmor_A_17");
			List_Written_Out_1_1_2_Images_Texture.Add("Transparent");
			List_Written_Out_1_1_2.Add("Leg Armor");
			List_Written_Out_1_1_2_Images.Add("Equipment/boots_A_17");
			List_Written_Out_1_1_2_Images_Texture.Add("Transparent");
			List_Written_Out_1_1_2.Add("Wrist Armor");
			List_Written_Out_1_1_2_Images.Add("Equipment/gloves_A_17");
			List_Written_Out_1_1_2_Images_Texture.Add("Transparent");
			List_Written_Out_1_1_2.Add("Earrings");
			List_Written_Out_1_1_2_Images.Add("Equipment/earings_A_17");
			List_Written_Out_1_1_2_Images_Texture.Add("Transparent");
			List_Written_Out_1_1_2.Add("Necklaces");
			List_Written_Out_1_1_2_Images.Add("Equipment/necklace_A_17");
			List_Written_Out_1_1_2_Images_Texture.Add("Transparent");
			List_Written_Out_1_1_2.Add("Rings");
			List_Written_Out_1_1_2_Images.Add("Equipment/ring_A_17");
			List_Written_Out_1_1_2_Images_Texture.Add("Transparent");
			

			List_Written_Out_1.Add("Play Game");
			List_Written_Out_1_Images.Add("Special/ArrowKeys");
			List_Written_Out_1_Images_Texture.Add("Transparent");
	    	List_Written_Out_1.Add("Search the Web");
	    	List_Written_Out_1_Images.Add("");
	    	List_Written_Out_1_Images_Texture.Add("Transparent");

	    	List_Written_Out_1_2.Add("Movies");
	    	List_Written_Out_1_2_Images.Add("");
	    	List_Written_Out_1_2_Images_Texture.Add("Transparent");
	    	List_Written_Out_1_2.Add("Music");
	    	List_Written_Out_1_2_Images.Add("");
	    	List_Written_Out_1_2_Images_Texture.Add("Transparent");
	    	List_Written_Out_1_2.Add("Social Media");
	    	List_Written_Out_1_2_Images.Add("");
	    	List_Written_Out_1_2_Images_Texture.Add("Transparent");
	    	List_Written_Out_1_2.Add("Youtube");
	    	List_Written_Out_1_2_Images.Add("");
	    	List_Written_Out_1_2_Images_Texture.Add("Transparent");
        List_Written_Out_1_2.Add("Blank Space");
        List_Written_Out_1_2_Images.Add("");
        List_Written_Out_1_2_Images_Texture.Add("Transparent");
        List_Written_Out_1_2.Add("Blank Space");
        List_Written_Out_1_2_Images.Add("");
        List_Written_Out_1_2_Images_Texture.Add("Transparent");
	    	

	    	List_Written_Out_1.Add("Save");
	    	List_Written_Out_1_Images.Add("");
	    	List_Written_Out_1_Images_Texture.Add("Transparent");
	    	List_Written_Out_1.Add("Load");
	    	List_Written_Out_1_Images.Add("");
	    	List_Written_Out_1_Images_Texture.Add("Transparent");
	    	List_Written_Out_1.Add("Options");
	    	List_Written_Out_1_Images.Add("");
	    	List_Written_Out_1_Images_Texture.Add("Transparent");
	    	List_Written_Out_1.Add("About");    	
	    	List_Written_Out_1_Images.Add("");
	    	List_Written_Out_1_Images_Texture.Add("Transparent");
	    	Lists_Written_Out.Add(List_Written_Out_1);
	    	Lists_Written_Out.Add(List_Written_Out_1_1);
	    	Lists_Written_Out.Add(List_Written_Out_1_1_2);
	    	Lists_Written_Out.Add(List_Written_Out_1_1_1);
	    	Lists_Written_Out.Add(List_Written_Out_1_2);

	    	Lists_Written_Out_Images.Add(List_Written_Out_1_Images);
	    	Lists_Written_Out_Images.Add(List_Written_Out_1_1_Images);
	    	Lists_Written_Out_Images.Add(List_Written_Out_1_1_2_Images);
	    	Lists_Written_Out_Images.Add(List_Written_Out_1_1_1_Images);
	    	Lists_Written_Out_Images.Add(List_Written_Out_1_2_Images);

	    	Lists_Written_Out_Images_Texture.Add(List_Written_Out_1_Images_Texture);
	    	Lists_Written_Out_Images_Texture.Add(List_Written_Out_1_1_Images_Texture);
	    	Lists_Written_Out_Images_Texture.Add(List_Written_Out_1_1_2_Images_Texture);
	    	Lists_Written_Out_Images_Texture.Add(List_Written_Out_1_1_1_Images_Texture);
	    	Lists_Written_Out_Images_Texture.Add(List_Written_Out_1_2_Images_Texture);

	    	Lists_Written_Out_Info.Add(List_Written_Out_1_Info);
	    	Lists_Written_Out_Info.Add(List_Written_Out_1_1_Info);
	    	Lists_Written_Out_Info.Add(List_Written_Out_1_1_2_Info);
	    	Lists_Written_Out_Info.Add(List_Written_Out_1_1_1_Info);
	    	Lists_Written_Out_Info.Add(List_Written_Out_1_2_Info);
	    	//Lists_Witten_Out Add To Lists AHK Area...
        Lists_Written_Out.Add(List_Written_Out_Fight);
    Lists_Written_Out_Images.Add(List_Written_Out_Fight_Images);
    Lists_Written_Out_Images_Texture.Add(List_Written_Out_Fight_Images_Texture);
    Lists_Written_Out_Info.Add(List_Written_Out_Fight_Info);
	    	//Items must be added in order that they appear
	    	
			
			
			
	    	Lists_Written_Out.Add(List_Written_Out_Coal_Vain);
			Lists_Written_Out_Images.Add(List_Written_Out_Coal_Vain_Images);
			Lists_Written_Out_Images_Texture.Add(List_Written_Out_Coal_Vain_Images_Texture);
			Lists_Written_Out_Info.Add(List_Written_Out_Coal_Vain_Info);
	    	

	    	Lists_Written_Out_Saved = Lists_Written_Out;
	    	Lists_Written_Out_Images_Saved = Lists_Written_Out_Images;
	    	


	    	List_Result_1.Add(GameObject.Find("Result 1/Button Main (3)"));
	    	List_Result_1.Add(GameObject.Find("Result 1/Button Main (4)"));
	    	List_Result_1.Add(GameObject.Find("Result 1/Button Main (5)"));
	    	List_Result_1.Add(GameObject.Find("Result 1/Button Main (1)"));
	    	List_Result_1.Add(GameObject.Find("Result 1/Button Main (2)"));

	    	List_Result_1_Images.Add(GameObject.Find("Result 1/Button Main (3)/Image (1)"));
	    	List_Result_1_Images.Add(GameObject.Find("Result 1/Button Main (4)/Image (1)"));
	    	List_Result_1_Images.Add(GameObject.Find("Result 1/Button Main (5)/Image (1)"));
	    	List_Result_1_Images.Add(GameObject.Find("Result 1/Button Main (1)/Image (1)"));
	    	List_Result_1_Images.Add(GameObject.Find("Result 1/Button Main (2)/Image (1)"));
	    	List_Result_1_Images_Texture.Add(GameObject.Find("Result 1/Button Main (3)/RawImage (1)"));
	    	List_Result_1_Images_Texture.Add(GameObject.Find("Result 1/Button Main (4)/RawImage (1)"));
	    	List_Result_1_Images_Texture.Add(GameObject.Find("Result 1/Button Main (5)/RawImage (1)"));
	    	List_Result_1_Images_Texture.Add(GameObject.Find("Result 1/Button Main (1)/RawImage (1)"));
	    	List_Result_1_Images_Texture.Add(GameObject.Find("Result 1/Button Main (2)/RawImage (1)"));
	        
	        	List_Result_1_Text_Gameobject.Add(GameObject.Find("Result 1/Button Main (3)/Text Shadow 1"));
	        	List_Result_1_Text_Gameobject.Add(GameObject.Find("Result 1/Button Main (3)/Text Shadow 2"));
	        	List_Result_1_Text_Gameobject.Add(GameObject.Find("Result 1/Button Main (3)/Text Main"));
	    		List_Result_1_Text_Gameobject.Add(GameObject.Find("Result 1/Button Main (4)/Text Shadow 1"));
	    		List_Result_1_Text_Gameobject.Add(GameObject.Find("Result 1/Button Main (4)/Text Shadow 2"));
	    		List_Result_1_Text_Gameobject.Add(GameObject.Find("Result 1/Button Main (4)/Text Main"));
	    		List_Result_1_Text_Gameobject.Add(GameObject.Find("Result 1/Button Main (5)/Text Shadow 1"));
	    		List_Result_1_Text_Gameobject.Add(GameObject.Find("Result 1/Button Main (5)/Text Shadow 2"));
	    		List_Result_1_Text_Gameobject.Add(GameObject.Find("Result 1/Button Main (5)/Text Main"));
	    		List_Result_1_Text_Gameobject.Add(GameObject.Find("Result 1/Button Main (1)/Text Shadow 1"));
	    		List_Result_1_Text_Gameobject.Add(GameObject.Find("Result 1/Button Main (1)/Text Shadow 2"));
	    		List_Result_1_Text_Gameobject.Add(GameObject.Find("Result 1/Button Main (1)/Text Main"));
	    		List_Result_1_Text_Gameobject.Add(GameObject.Find("Result 1/Button Main (2)/Text Shadow 1"));
	    		List_Result_1_Text_Gameobject.Add(GameObject.Find("Result 1/Button Main (2)/Text Shadow 2"));
	    		List_Result_1_Text_Gameobject.Add(GameObject.Find("Result 1/Button Main (2)/Text Main"));
	    	List_Result_2.Add(GameObject.Find("Result 2/Button Main (3)"));
	    	List_Result_2.Add(GameObject.Find("Result 2/Button Main (4)"));
	    	List_Result_2.Add(GameObject.Find("Result 2/Button Main (5)"));
	    	List_Result_2.Add(GameObject.Find("Result 2/Button Main (1)"));
	    	List_Result_2.Add(GameObject.Find("Result 2/Button Main (2)"));

	    	List_Result_2_Images.Add(GameObject.Find("Result 2/Button Main (3)/Image (1)"));
			List_Result_2_Images.Add(GameObject.Find("Result 2/Button Main (4)/Image (1)"));
			List_Result_2_Images.Add(GameObject.Find("Result 2/Button Main (5)/Image (1)"));
			List_Result_2_Images.Add(GameObject.Find("Result 2/Button Main (1)/Image (1)"));
			List_Result_2_Images.Add(GameObject.Find("Result 2/Button Main (2)/Image (1)"));
			List_Result_2_Images_Texture.Add(GameObject.Find("Result 2/Button Main (3)/RawImage (1)"));
			List_Result_2_Images_Texture.Add(GameObject.Find("Result 2/Button Main (4)/RawImage (1)"));
			List_Result_2_Images_Texture.Add(GameObject.Find("Result 2/Button Main (5)/RawImage (1)"));
			List_Result_2_Images_Texture.Add(GameObject.Find("Result 2/Button Main (1)/RawImage (1)"));
			List_Result_2_Images_Texture.Add(GameObject.Find("Result 2/Button Main (2)/RawImage (1)"));
	        
	        	List_Result_2_Text_Gameobject.Add(GameObject.Find("Result 2/Button Main (3)/Text Shadow 1"));
	        	List_Result_2_Text_Gameobject.Add(GameObject.Find("Result 2/Button Main (3)/Text Shadow 2"));
	        	List_Result_2_Text_Gameobject.Add(GameObject.Find("Result 2/Button Main (3)/Text Main"));
	    		List_Result_2_Text_Gameobject.Add(GameObject.Find("Result 2/Button Main (4)/Text Shadow 1"));
	    		List_Result_2_Text_Gameobject.Add(GameObject.Find("Result 2/Button Main (4)/Text Shadow 2"));
	    		List_Result_2_Text_Gameobject.Add(GameObject.Find("Result 2/Button Main (4)/Text Main"));
	    		List_Result_2_Text_Gameobject.Add(GameObject.Find("Result 2/Button Main (5)/Text Shadow 1"));
	    		List_Result_2_Text_Gameobject.Add(GameObject.Find("Result 2/Button Main (5)/Text Shadow 2"));
	    		List_Result_2_Text_Gameobject.Add(GameObject.Find("Result 2/Button Main (5)/Text Main"));
	    		List_Result_2_Text_Gameobject.Add(GameObject.Find("Result 2/Button Main (1)/Text Shadow 1"));
	    		List_Result_2_Text_Gameobject.Add(GameObject.Find("Result 2/Button Main (1)/Text Shadow 2"));
	    		List_Result_2_Text_Gameobject.Add(GameObject.Find("Result 2/Button Main (1)/Text Main"));
	    		List_Result_2_Text_Gameobject.Add(GameObject.Find("Result 2/Button Main (2)/Text Shadow 1"));
	    		List_Result_2_Text_Gameobject.Add(GameObject.Find("Result 2/Button Main (2)/Text Shadow 2"));
	    		List_Result_2_Text_Gameobject.Add(GameObject.Find("Result 2/Button Main (2)/Text Main"));	
	        


	    	Update_Menus_Breakdown();
	    	init();
	    	Set_Current_Menu_5();
	    	Set_Current_Menu_4();
	    	Set_Current_Menu_3();
	    	Set_Current_Menu_2();
	    	Set_Current_Menu_1();
	    	
			Lists_Mining_Area_1_Layers.Add(Mining_Area_1_Layer_0);
			Lists_Mining_Area_1_Layers.Add(Mining_Area_1_Layer_1);
			Lists_Mining_Area_1_Layers.Add(Mining_Area_1_Layer_2);
			Lists_Mining_Area_1_Layers.Add(Mining_Area_1_Layer_3);
			Lists_Mining_Area_1_Layers.Add(Mining_Area_1_Layer_4);
			Lists_Mining_Area_1_Layers.Add(Mining_Area_1_Layer_5);

      Lists_Mining_Area_1_Layers_Mineral_Overlay.Add(Mining_Area_1_Layer_0_Mineral_Overlay);
      Lists_Mining_Area_1_Layers_Mineral_Overlay.Add(Mining_Area_1_Layer_1_Mineral_Overlay);
      Lists_Mining_Area_1_Layers_Mineral_Overlay.Add(Mining_Area_1_Layer_2_Mineral_Overlay);
      Lists_Mining_Area_1_Layers_Mineral_Overlay.Add(Mining_Area_1_Layer_3_Mineral_Overlay);
      Lists_Mining_Area_1_Layers_Mineral_Overlay.Add(Mining_Area_1_Layer_4_Mineral_Overlay);
      Lists_Mining_Area_1_Layers_Mineral_Overlay.Add(Mining_Area_1_Layer_5_Mineral_Overlay);

      Lists_Mining_Area_1_Layers_Item_Overlay.Add(Mining_Area_1_Layer_0_Item_Overlay);
      Lists_Mining_Area_1_Layers_Item_Overlay.Add(Mining_Area_1_Layer_1_Item_Overlay);
      Lists_Mining_Area_1_Layers_Item_Overlay.Add(Mining_Area_1_Layer_2_Item_Overlay);
      Lists_Mining_Area_1_Layers_Item_Overlay.Add(Mining_Area_1_Layer_3_Item_Overlay);
      Lists_Mining_Area_1_Layers_Item_Overlay.Add(Mining_Area_1_Layer_4_Item_Overlay);
      Lists_Mining_Area_1_Layers_Item_Overlay.Add(Mining_Area_1_Layer_5_Item_Overlay);
      for(var i = 0; i < 16; i++){
        ItemsGained_Item_Name.Add("Blank");
        ItemsGained_ItemAmount.Add(0);
        ItemsGained_ItemImage_Dir.Add("Blank");
        ItemsGained_ItemRank.Add(0);
        
      }
      for(var i = 0; i < 16; i++){
          NewItemsGainedArea_List_Name_Text_Shadow_1.Add(GameObject.Find("New Items Gained Area/New Item ("+i+")/Title/Text Shadow 1"));
          NewItemsGainedArea_List_Name_Text_Shadow_2.Add(GameObject.Find("New Items Gained Area/New Item ("+i+")/Title/Text Shadow 2"));
          NewItemsGainedArea_List_Name_Text_Main.Add(GameObject.Find("New Items Gained Area/New Item ("+i+")/Title/Text Main"));
          
          NewItemsGainedArea_List_ItemAmount_Text_Shadow_1.Add(GameObject.Find("New Items Gained Area/New Item ("+i+")/Item Amount/Text Shadow 1"));
          NewItemsGainedArea_List_ItemAmount_Text_Shadow_2.Add(GameObject.Find("New Items Gained Area/New Item ("+i+")/Item Amount/Text Shadow 2"));
          NewItemsGainedArea_List_ItemAmount_Text_Main.Add(GameObject.Find("New Items Gained Area/New Item ("+i+")/Item Amount/Text Main"));
          NewItemsGainedArea_List_ItemImage.Add(GameObject.Find("New Items Gained Area/New Item ("+i+")/Item Image/Image Of Item"));
          NewItemsGainedArea_List_LeftOfItemImage.Add(GameObject.Find("New Items Gained Area/New Item ("+i+")/Item Image/Question Mark 1"));
          NewItemsGainedArea_List_RightOfItemImage.Add(GameObject.Find("New Items Gained Area/New Item ("+i+")/Item Image/Question Mark 2"));
          NewItemsGainedArea_List_ItemRank_Main.Add(GameObject.Find("New Items Gained Area/New Item ("+i+")/Rank/Rank Big"));
          NewItemsGainedArea_List_ItemRank_Small_1.Add(GameObject.Find("New Items Gained Area/New Item ("+i+")/Rank/Rank Small 1"));
          NewItemsGainedArea_List_ItemRank_Small_2.Add(GameObject.Find("New Items Gained Area/New Item ("+i+")/Rank/Rank Small 2"));
          NewItemsGainedArea_List_ItemRank_Small_3.Add(GameObject.Find("New Items Gained Area/New Item ("+i+")/Rank/Rank Small 3"));
          
          NewItemsGainedArea_List_Item.Add(GameObject.Find("New Items Gained Area/New Item ("+i+")"));
        }
			Get_Mining_Area_1_Variables();
			 Mining_Area_1_Generate_All_Blocks();
	    	Mining_Area_1_Camera = GameObject.Find("MiningCamera");
	    	//Mining_Area_1_Function();
	    	InvokeRepeating("Mining_Area_1_Mine_Blocks", 0f,0.001f);
        InvokeRepeating("NewItem_Function", 0f, .001f);
        InvokeRepeating("NewItemsGainedArea", 0f, .001f);
        InvokeRepeating("Fight", 0f, .01f);
	    	//ConvertLists();

	    }

      void NewItemsGainedArea(){
        /*we want to change item 1 to last item in list*/
        
        for(var i2 = 0; i2 < 16; i2++){
          int whichIteminList = ItemsGained_Item_Name.Count - i2 - 1;
          
          if(ItemsGained_Item_Name[ItemsGained_Item_Name.Count - i2 - 1] == "Blank"){
             NewItemsGainedArea_List_Item[i2].SetActive(false); 
          }else{
            NewItemsGainedArea_List_Item[i2].SetActive(true);  
            for(var rank = 0; rank < Rank_List.Count;rank++){            
              if(ItemsGained_ItemRank[whichIteminList] == rank){
                  NewItemsGainedArea_List_ItemRank_Main[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+Rank_List[rank], typeof(Sprite)) as Sprite;
                  NewItemsGainedArea_List_ItemRank_Small_1[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+Rank_List[rank], typeof(Sprite)) as Sprite;
                  NewItemsGainedArea_List_ItemRank_Small_2[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+Rank_List[rank], typeof(Sprite)) as Sprite;
                  NewItemsGainedArea_List_ItemRank_Small_3[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+Rank_List[rank], typeof(Sprite)) as Sprite;
              }
            }
            
            NewItemsGainedArea_List_Name_Text_Shadow_1[i2].GetComponent<UnityEngine.UI.Text>().text = ""+ItemsGained_Item_Name[whichIteminList];
            NewItemsGainedArea_List_Name_Text_Shadow_2[i2].GetComponent<UnityEngine.UI.Text>().text = ""+ItemsGained_Item_Name[whichIteminList];
            NewItemsGainedArea_List_Name_Text_Main[i2].GetComponent<UnityEngine.UI.Text>().text = ""+ItemsGained_Item_Name[whichIteminList];
            NewItemsGainedArea_List_ItemAmount_Text_Shadow_1[i2].GetComponent<UnityEngine.UI.Text>().text = ""+ItemsGained_ItemAmount[whichIteminList];
            NewItemsGainedArea_List_ItemAmount_Text_Shadow_2[i2].GetComponent<UnityEngine.UI.Text>().text = ""+ItemsGained_ItemAmount[whichIteminList];
            NewItemsGainedArea_List_ItemAmount_Text_Main[i2].GetComponent<UnityEngine.UI.Text>().text = ""+ItemsGained_ItemAmount[whichIteminList];
            NewItemsGainedArea_List_ItemImage[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+ItemsGained_ItemImage_Dir[whichIteminList], typeof(Sprite)) as Sprite;
            NewItemsGainedArea_List_LeftOfItemImage[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load("", typeof(Sprite)) as Sprite;
            NewItemsGainedArea_List_RightOfItemImage[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load("", typeof(Sprite)) as Sprite;
            
          }
          
        }

      }
      void NewItem_Function(){
        
        if(New_Item_Check == true){
          if(ItemRank > 4){
        ItemsGained_Item_Name.Add(Item_Name);
        ItemsGained_ItemAmount.Add(ItemAmount);
        ItemsGained_ItemImage_Dir.Add(ItemImage_Dir);
        ItemsGained_ItemRank.Add(ItemRank);  
        New_Item_Check = false;
        }
        }
          //NewItem.Add(Instantiate(Resources.Load("Prefabs/New Item") as GameObject));
          //GameObject NewItems = GameObject.Find("New Items");
          //GameObject NewItem_Position_Holder = GameObject.Find("New Items/New Item Place Holder");
//
          //NewItem[NewItem_Num].transform.parent = NewItems.transform; 
          //NewItem[NewItem_Num].transform.position = NewItem_Position_Holder.transform.position;
          //NewItem[NewItem_Num].name = "New Object "+NewItem_Num;
          //GameObject Name_Text_Shadow_1 = GameObject.Find("New Object "+NewItem_Num+"/New Item/Title/Text Shadow 1");
          //GameObject Name_Text_Shadow_2 = GameObject.Find("New Object "+NewItem_Num+"/New Item/Title/Text Shadow 2");
          //GameObject Name_Text_Main = GameObject.Find("New Object "+NewItem_Num+"/New Item/Title/Text Main");
          //GameObject ItemAmount_Text_Shadow_1 = GameObject.Find("New Object "+NewItem_Num+"/New Item/Item Amount/Text Shadow 1");
          //GameObject ItemAmount_Text_Shadow_2 = GameObject.Find("New Object "+NewItem_Num+"/New Item/Item Amount/Text Shadow 2");
          //GameObject ItemAmount_Text_Main = GameObject.Find("New Object "+NewItem_Num+"/New Item/Item Amount/Text Main");
          //GameObject ItemImage = GameObject.Find("New Object "+NewItem_Num+"/New Item/Item Image/Image Of Item");
          //GameObject LeftOfItemImage = GameObject.Find("New Object "+NewItem_Num+"/New Item/Item Image/Question Mark 1");
          //GameObject RightOfItemImage = GameObject.Find("New Object "+NewItem_Num+"/New Item/Item Image/Question Mark 2");          
          //GameObject ItemRank_Main = GameObject.Find("New Object "+NewItem_Num+"/New Item/Rank/Rank Big");
          //GameObject ItemRank_Small_1 = GameObject.Find("New Object "+NewItem_Num+"/New Item/Rank/Rank Small 1");
          //GameObject ItemRank_Small_2 = GameObject.Find("New Object "+NewItem_Num+"/New Item/Rank/Rank Small 2");
          //GameObject ItemRank_Small_3 = GameObject.Find("New Object "+NewItem_Num+"/New Item/Rank/Rank Small 3");          
          //for(var rank = 0; rank < Rank_List.Count;rank++){            
            //if(ItemRank == rank){
                //ItemRank_Main.GetComponent<SpriteRenderer>().sprite = Resources.Load(""+Rank_List[rank], typeof(Sprite)) as Sprite;
                //ItemRank_Small_1.GetComponent<SpriteRenderer>().sprite = Resources.Load(""+Rank_List[rank], typeof(Sprite)) as Sprite;
                //ItemRank_Small_2.GetComponent<SpriteRenderer>().sprite = Resources.Load(""+Rank_List[rank], typeof(Sprite)) as Sprite;
                //ItemRank_Small_3.GetComponent<SpriteRenderer>().sprite = Resources.Load(""+Rank_List[rank], typeof(Sprite)) as Sprite;
            //}
          //}
          //Name_Text_Shadow_1.GetComponent<UnityEngine.UI.Text>().text = ""+Item_Name;
          //Name_Text_Shadow_2.GetComponent<UnityEngine.UI.Text>().text = ""+Item_Name;
          //Name_Text_Main.GetComponent<UnityEngine.UI.Text>().text = ""+Item_Name;
          //ItemAmount_Text_Shadow_1.GetComponent<UnityEngine.UI.Text>().text = ""+ItemAmount;
          //ItemAmount_Text_Shadow_2.GetComponent<UnityEngine.UI.Text>().text = ""+ItemAmount;
          //ItemAmount_Text_Main.GetComponent<UnityEngine.UI.Text>().text = ""+ItemAmount;
          //ItemImage.GetComponent<SpriteRenderer>().sprite = Resources.Load(""+ItemImage_Dir, typeof(Sprite)) as Sprite;
          //LeftOfItemImage.GetComponent<SpriteRenderer>().sprite = Resources.Load("", typeof(Sprite)) as Sprite;
          //RightOfItemImage.GetComponent<SpriteRenderer>().sprite = Resources.Load("", typeof(Sprite)) as Sprite;
          //ItemImage.layer = LayerNum+ 1;
          //NewItem[NewItem_Num].layer = LayerNum;
          //NewItem_TimeSinceCreated.Add(0);
          //NewItem_Num++;
          //LayerNum++;
          //if(LayerNum == 31){
            //LayerNum = 4;
          //}
          //New_Item_Check = false;
        //}   
          //
       for(var i = NewItem_Num - 50; i <= NewItem_Num - 1;i++){
            if(i < 0){

            }else{
               NewItem_TimeSinceCreated[i]++;
               if(NewItem_TimeSinceCreated[i] >= 2500){
                  Destroy(NewItem[i]);
               } 
            }
       }
      }
	    /*
	    void Mining_Area_1_Function(){
	    	var i = 0; 
	    	SetBlockValue();//Change this depending on the mine
	    	Set_Main();
	    	Calculate_Next();
		    for(var b5 = 1;b5 <= 4; b5++){
		    	for(var b4 = 1;b4 <= 4; b4++){
			    	for(var b3 = 1;b3 <= 4; b3++){
				    	for(var b2 = 1;b2 <= 4; b2++){
					    	for(var b1 = 1;b1 <= 4; b1++){
					    		for(var b = 1;b <= 4; b++){

					    			Mining_Area_1_Mining_Camera.Add(GameObject.Find("Mining Camera/Mining Canvas Mining Camera/GameObject ("+b5+")/1024 Block/256 Block "+b4+"/64 Block "+b3+"/16 Block "+b2+"/4 Block "+b1+"/Block "+b));			    						    			
					    			Mining_Area_1_Main_Camera.Add(GameObject.Find("Mining Camera/Mining Canvas Main Camera/GameObject ("+b5+")/1024 Block/256 Block "+b4+"/64 Block "+b3+"/16 Block "+b2+"/4 Block "+b1+"/Block "+b));			    						    			
					    			GenerateNextBlock();
					    			Debug.Log(Block_Name);
					    			Mining_Area_1_Mining_Camera[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Block_Name, typeof(Sprite)) as Sprite;
					    			Mining_Area_1_Main_Camera[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Block_Name, typeof(Sprite)) as Sprite;
					    			Mining_Area_1_Mining_Camera[i].SetActive(true);
					    			Mining_Area_1_Main_Camera[i].SetActive(true);
					    			i++;
					    		}
					    	}
				    	}
				    }	
				}
			}    
	    }
	    */
	    void Get_Mining_Area_1_Variables(){
	    	
		    	for(var b4 = 0;b4 <= 5; b4++){
			    	for(var b3 = 1;b3 <= 4; b3++){
				    	for(var b2 = 1;b2 <= 4; b2++){
					    	for(var b1 = 1;b1 <= 4; b1++){
					    		for(var b = 1;b <= 4; b++){
					    			Lists_Mining_Area_1_Layers[b4].Add(GameObject.Find("Mining Camera/Mining Canvas Mining Camera/All Blocks Container/All Blocks/256 Block ("+b4+")/64 Block "+b3+"/16 Block "+b2+"/4 Block "+b1+"/Block "+b));			    						    								    								    							    			
                    Lists_Mining_Area_1_Layers_Mineral_Overlay[b4].Add(GameObject.Find("Mining Camera/Mining Canvas Mining Camera/All Blocks Container Mineral Overlay/All Blocks/256 Block ("+b4+")/64 Block "+b3+"/16 Block "+b2+"/4 Block "+b1+"/Block "+b));                                                                                          
                    Lists_Mining_Area_1_Layers_Item_Overlay[b4].Add(GameObject.Find("Mining Camera/Mining Canvas Mining Camera/All Blocks Container Item Overlay/All Blocks/256 Block ("+b4+")/64 Block "+b3+"/16 Block "+b2+"/4 Block "+b1+"/Block "+b));                                                                                          

					    		}
					    	}
				    	}
				    }	
				}
			

	    }
	    void Mining_Area_1_Generate_All_Blocks(){
	    	SetBlockValue();//Change this depending on the mine
	    	Set_Main();
	    	Calculate_Next();
        SetBlockValueMineral();//Change this depending on the mine
        Set_Main_Mineral();
        Calculate_Next_Mineral();
	    	GameObject AutomatonParent = GameObject.Find("Mining Canvas Mining Camera");
        for(var i = 0; i < Lists_Mining_Area_1_Layers.Count;i++){
	    		for(var i2 = 0;i2 < Lists_Mining_Area_1_Layers[i].Count; i2++){
	    			GenerateNextBlock();
            GenerateNextMineral();
	    			Lists_Mining_Area_1_Layers[i][i2].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Block_Name+" 256", typeof(Sprite)) as Sprite;
            if(Block_Name == "Dirt"||Block_Name == "Rich Soil"||Block_Name == "Stone"){
              
              
              Lists_Mining_Area_1_Layers_Mineral_Overlay[i][i2].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/"+Mineral_Name, typeof(Sprite)) as Sprite;
            }else{
              Lists_Mining_Area_1_Layers_Mineral_Overlay[i][i2].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/Nothing", typeof(Sprite)) as Sprite;
            }
            Lists_Mining_Area_1_Layers_Item_Overlay[i][i2].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Items/Nothing", typeof(Sprite)) as Sprite;


	    		}
          

          
	    	}
        for(var i3 = 0;i3 < Lists_Mining_Area_1_Layers[0].Count; i3++){
          Mining_Area_1_Automatons.Add(Instantiate(Resources.Load("Characters/DragonBones Characters/AncientAutomaton") as GameObject));
          Mining_Area_1_Automatons[i3].transform.parent = AutomatonParent.transform;                                                  
          Mining_Area_1_Automatons[i3].transform.position = Lists_Mining_Area_1_Layers[0][i3].transform.position;    
          Mining_Area_1_Automatons[i3].transform.localPosition += new Vector3(40f,50f,0);
          Mining_Area_1_Automatons[i3].transform.localScale = new Vector3(26f,45f,26f);
          Mining_Area_1_Automatons[i3].name = "Automaton "+ i3;
          Mining_Area_1_Automatons[i3].SetActive(false);
          Mining_Area_1_AutomatonsHit.Add(Instantiate(Resources.Load("Characters/DragonBones Characters/AutomatonHit") as GameObject));
          Mining_Area_1_AutomatonsHit[i3].transform.parent = AutomatonParent.transform;                                                  
          Mining_Area_1_AutomatonsHit[i3].transform.position = Lists_Mining_Area_1_Layers[0][i3].transform.position;    
          Mining_Area_1_AutomatonsHit[i3].transform.localPosition += new Vector3(0f,30f,0);
          Mining_Area_1_AutomatonsHit[i3].transform.localScale = new Vector3(150f,150f,150f);
          Mining_Area_1_AutomatonsHit[i3].name = "AutomatonHit "+ i3;
          Mining_Area_1_AutomatonsHit[i3].SetActive(false);
          LayerHealth.Add(LayerHeathFull);
          }
        
	    }
	    void Mining_Area_1_Mine_Blocks(){
	    	
	    	for(var i = Lists_Mining_Area_1_Layers[0].Count -1;i >= 0; i--){
	    		if(Lists_Mining_Area_1_Layers[0][i].activeSelf == true){
	    			Mining_Area_1_Automatons[i].SetActive(true);
            Mining_Area_1_AutomatonsHit[i].SetActive(true);
	    			//Vector3 CamPos = new Vector3(Lists_Mining_Area_1_Layers[0][i].transform.position.x,Lists_Mining_Area_1_Layers[0][i].transform.position.y,Mining_Area_1_Camera.transform.position.z);
	    			//iTween.MoveTo(Mining_Area_1_Camera, iTween.Hash("position", CamPos, "time", 0f));	
	    			x++;
	    			if(LayerHealth[i] > 0){
              LayerHealth[i] -= 1f;
              break;
            }else{
              Mining_Area_1_Automatons[i].SetActive(false);
              Mining_Area_1_AutomatonsHit[i].SetActive(false);
  	    			Lists_Mining_Area_1_Layers[0][i].SetActive(false);
              Lists_Mining_Area_1_Layers_Mineral_Overlay[0][i].SetActive(false);
              Lists_Mining_Area_1_Layers_Item_Overlay[0][i].SetActive(false);
              for(var tilenum = 0; tilenum < Tiles_List.Count;tilenum++){
                if(Lists_Mining_Area_1_Layers[0][i].GetComponent<SpriteRenderer>().sprite.name == Tiles_List_NameWithoutUnderscore[tilenum]+" 256"){                  
                  Item_Name = Tiles_List_NameWithoutUnderscore[tilenum];
                  ItemImage_Dir = "Tiles/"+Tiles_List_NameWithoutUnderscore[tilenum]+" 256";
                  ItemAmount = 1;
                  ItemRank = Tiles_List_Rank[tilenum];
                  New_Item_Check = true;

                }
              
                
              }
            }
	    		}
	    	}
	    	if(Lists_Mining_Area_1_Layers[0][0].activeSelf == false){
	    		Mining_Area_1_Move_Up_One();		
	    	}
	    }
	    void Mining_Area_1_Move_Up_One(){
	    	SetBlockValue();//Change this depending on the mine
	    	Set_Main();
	    	Calculate_Next();
        SetBlockValueMineral();//Change this depending on the mine
        Set_Main_Mineral();
        Calculate_Next_Mineral();
	    	for(var i = 0; i < Lists_Mining_Area_1_Layers[0].Count;i++){
          LayerHealth[i] = LayerHeathFull;
	    		// Move layer 2 to 1 3 to 2 4 to 3 5 to 4 and generate 5 set active to 1
	    		string Layer_2_Name = Lists_Mining_Area_1_Layers[1][i].GetComponent < SpriteRenderer > ().sprite.name;
	    		string Layer_3_Name = Lists_Mining_Area_1_Layers[2][i].GetComponent < SpriteRenderer > ().sprite.name;
	    		string Layer_4_Name = Lists_Mining_Area_1_Layers[3][i].GetComponent < SpriteRenderer > ().sprite.name;
	    		string Layer_5_Name = Lists_Mining_Area_1_Layers[4][i].GetComponent < SpriteRenderer > ().sprite.name;
	    		string Layer_6_Name = Lists_Mining_Area_1_Layers[5][i].GetComponent < SpriteRenderer > ().sprite.name;

          string Layer_2_Name_Mineral_Overlay = Lists_Mining_Area_1_Layers_Mineral_Overlay[1][i].GetComponent < SpriteRenderer > ().sprite.name;
          string Layer_3_Name_Mineral_Overlay = Lists_Mining_Area_1_Layers_Mineral_Overlay[2][i].GetComponent < SpriteRenderer > ().sprite.name;
          string Layer_4_Name_Mineral_Overlay = Lists_Mining_Area_1_Layers_Mineral_Overlay[3][i].GetComponent < SpriteRenderer > ().sprite.name;
          string Layer_5_Name_Mineral_Overlay = Lists_Mining_Area_1_Layers_Mineral_Overlay[4][i].GetComponent < SpriteRenderer > ().sprite.name;
          string Layer_6_Name_Mineral_Overlay = Lists_Mining_Area_1_Layers_Mineral_Overlay[5][i].GetComponent < SpriteRenderer > ().sprite.name;

          string Layer_2_Name_Item_Overlay = Lists_Mining_Area_1_Layers_Item_Overlay[1][i].GetComponent < SpriteRenderer > ().sprite.name;
          string Layer_3_Name_Item_Overlay = Lists_Mining_Area_1_Layers_Item_Overlay[2][i].GetComponent < SpriteRenderer > ().sprite.name;
          string Layer_4_Name_Item_Overlay = Lists_Mining_Area_1_Layers_Item_Overlay[3][i].GetComponent < SpriteRenderer > ().sprite.name;
          string Layer_5_Name_Item_Overlay = Lists_Mining_Area_1_Layers_Item_Overlay[4][i].GetComponent < SpriteRenderer > ().sprite.name;
          string Layer_6_Name_Item_Overlay = Lists_Mining_Area_1_Layers_Item_Overlay[5][i].GetComponent < SpriteRenderer > ().sprite.name;
        
				Lists_Mining_Area_1_Layers[0][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_2_Name, typeof(Sprite)) as Sprite;	    		
				Lists_Mining_Area_1_Layers[1][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_3_Name, typeof(Sprite)) as Sprite;	    		
				Lists_Mining_Area_1_Layers[2][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_4_Name, typeof(Sprite)) as Sprite;	    		
				Lists_Mining_Area_1_Layers[3][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_5_Name, typeof(Sprite)) as Sprite;	    		
				Lists_Mining_Area_1_Layers[4][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_6_Name, typeof(Sprite)) as Sprite;	    		

        Lists_Mining_Area_1_Layers_Mineral_Overlay[0][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_2_Name_Mineral_Overlay, typeof(Sprite)) as Sprite;         
        Lists_Mining_Area_1_Layers_Mineral_Overlay[1][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_3_Name_Mineral_Overlay, typeof(Sprite)) as Sprite;         
        Lists_Mining_Area_1_Layers_Mineral_Overlay[2][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_4_Name_Mineral_Overlay, typeof(Sprite)) as Sprite;         
        Lists_Mining_Area_1_Layers_Mineral_Overlay[3][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_5_Name_Mineral_Overlay, typeof(Sprite)) as Sprite;         
        Lists_Mining_Area_1_Layers_Mineral_Overlay[4][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_6_Name_Mineral_Overlay, typeof(Sprite)) as Sprite;         

        Lists_Mining_Area_1_Layers_Item_Overlay[0][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Items/" + Layer_2_Name_Item_Overlay, typeof(Sprite)) as Sprite;         
        Lists_Mining_Area_1_Layers_Item_Overlay[1][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Items/" + Layer_3_Name_Item_Overlay, typeof(Sprite)) as Sprite;         
        Lists_Mining_Area_1_Layers_Item_Overlay[2][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Items/" + Layer_4_Name_Item_Overlay, typeof(Sprite)) as Sprite;         
        Lists_Mining_Area_1_Layers_Item_Overlay[3][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Items/" + Layer_5_Name_Item_Overlay, typeof(Sprite)) as Sprite;         
        Lists_Mining_Area_1_Layers_Item_Overlay[4][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Items/" + Layer_6_Name_Item_Overlay, typeof(Sprite)) as Sprite;         
				GenerateNextBlock();
        GenerateNextMineral();
				Lists_Mining_Area_1_Layers[5][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Block_Name + " 256", typeof(Sprite)) as Sprite;	    		
        if(Block_Name == "Dirt"||Block_Name == "Rich Soil"||Block_Name == "Stone"){
              Lists_Mining_Area_1_Layers_Mineral_Overlay[5][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/"+Mineral_Name, typeof(Sprite)) as Sprite;
            }else{
              Lists_Mining_Area_1_Layers_Mineral_Overlay[5][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/Nothing", typeof(Sprite)) as Sprite;
            }
				Lists_Mining_Area_1_Layers[0][i].SetActive(true);
        Lists_Mining_Area_1_Layers_Mineral_Overlay[0][i].SetActive(true);
        Lists_Mining_Area_1_Layers_Item_Overlay[0][i].SetActive(true);

	    	}

	    }
	    /*
	    void Mine_Area_1_Mining(){
	    	SetBlockValue();//Change this depending on the mine
	    	Set_Main();
	    	Calculate_Next();
	    	if(Mining_Area_1_Mining_Camera[0].activeSelf == false){	
	    		
	    		Debug.Log("Active Self 1023 : "+Mining_Area_1_Mining_Camera[Mining_Area_1_Mining_Camera.Count/4 - 1].activeSelf);
	    		for(var i = 0; i <= (Mining_Area_1_Mining_Camera.Count/4) - 1;i++){
	    				GenerateNextBlock();
	    				Debug.Log(i);
	    				Debug.Log("Layer 2 : "+(i+(Mining_Area_1_Mining_Camera.Count/4)));
	    				//string Layer_2_Block_Name = Mining_Area_1_Mining_Camera[i+(Mining_Area_1_Mining_Camera.Count/4)].GetComponent < SpriteRenderer > ().name;
	    				
	    				//string Layer_3_Block_Name = Mining_Area_1_Mining_Camera[i+((Mining_Area_1_Mining_Camera.Count/4)*2-1)].GetComponent < SpriteRenderer > ().name;
	    				//string Layer_4_Block_Name = Mining_Area_1_Mining_Camera[i+((Mining_Area_1_Mining_Camera.Count/4)*3)-1].GetComponent < SpriteRenderer > ().name;
	    				//Mining_Area_1_Mining_Camera[i+((Mining_Area_1_Mining_Camera.Count/4)*3)-1].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Block_Name, typeof(Sprite)) as Sprite;
						//Mining_Area_1_Mining_Camera[i+((Mining_Area_1_Mining_Camera.Count/4)*2)-1].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_4_Block_Name, typeof(Sprite)) as Sprite;	    					    				
	    				//Mining_Area_1_Mining_Camera[i+(Mining_Area_1_Mining_Camera.Count/4)-1].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_3_Block_Name, typeof(Sprite)) as Sprite;
	    				//Mining_Area_1_Mining_Camera[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_2_Block_Name, typeof(Sprite)) as Sprite;
	    				
	    				
	    				//Mining_Area_1_Mining_Camera[i].SetActive(true);
	    				

	    				//Mining_Area_1_Mining_Camera[i+((Mining_Area_1_Mining_Camera.Count/4)*3-1)].SetActive(true);
						//Mining_Area_1_Mining_Camera[i+((Mining_Area_1_Mining_Camera.Count/4)*2-1)].SetActive(true);
						//Mining_Area_1_Mining_Camera[i+(Mining_Area_1_Mining_Camera.Count/4)-1].SetActive(true);

	    				//Mining_Area_1_Main_Camera[i+((Mining_Area_1_Mining_Camera.Count/4)*3-1)].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Block_Name, typeof(Sprite)) as Sprite;
	    				//Mining_Area_1_Main_Camera[i+((Mining_Area_1_Mining_Camera.Count/4)*2-1)].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_4_Block_Name, typeof(Sprite)) as Sprite;	    				
	    				//Mining_Area_1_Main_Camera[i+(Mining_Area_1_Mining_Camera.Count/4)-1].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_3_Block_Name, typeof(Sprite)) as Sprite;
	    				//Mining_Area_1_Main_Camera[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_2_Block_Name, typeof(Sprite)) as Sprite;
	    				
	    				//Mining_Area_1_Main_Camera[i].SetActive(true);
						//Mining_Area_1_Main_Camera[i+((Mining_Area_1_Mining_Camera.Count/4)*3-1)].SetActive(true);
						//Mining_Area_1_Main_Camera[i+((Mining_Area_1_Mining_Camera.Count/4)*2-1)].SetActive(true);
						//Mining_Area_1_Main_Camera[i+(Mining_Area_1_Mining_Camera.Count/4)-1].SetActive(true);
						

	    		}
	    	}
	    	for(var i = Mining_Area_1_Mining_Camera.Count/4 - 1; i >= 0;i--){
	    		if(Mining_Area_1_Mining_Camera[i].activeSelf == true){
	    			Vector3 CamPos = new Vector3(Mining_Area_1_Mining_Camera[i].transform.position.x,Mining_Area_1_Mining_Camera[i].transform.position.y,Mining_Area_1_Camera.transform.position.z);
	    			iTween.MoveTo(Mining_Area_1_Camera, iTween.Hash("position", CamPos, "time", .1f));
	    			x++;
	    			if(x < 2){
	    				break;
	    			}
	    			if(x >= 2){
	    				x = 0;
	    			}
	    			
	    			Mining_Area_1_Mining_Camera[i].SetActive(false);
	    			Mining_Area_1_Main_Camera[i].SetActive(false);
	    			
	    			break;
	    		}
	    	}
	    }
	    */
	    //void ConvertLists(){
	    	//string pattern = @"_`_1_`_(.*)_`_1_`_";
	        //string input = List_Written_Out_1[0];
	        //RegexOptions options = RegexOptions.Multiline;
	//        
	        //foreach (Match m in Regex.Matches(input, pattern, options))
	        //{
	//
	        	//string Level_1 = m.Captures[0].Value;
	        	//Level_1 = Level_1.Remove(Level_1.Length - 7, 7); 
	        	//Level_1 = Level_1.Remove(0, 7); 
	        	//Debug.Log(Level_1);
	            ////List_Written_Out_1_Levels.Add(Level_1);
	        //}
	    //}
      void Lightning_Button_Click(){
        if(LightningActiveTrueOrFalse == false){
          GameObject.Find("Lightning Skill/Background Image").GetComponent<SpriteRenderer>().color = new Color (255f, 255f, 255f, 0.5f); ;
          GameObject.Find("Lightning Skill/Skill Image").GetComponent<SpriteRenderer>().color = new Color (255f, 255f, 255f, 0.5f);
        }
        Debug.Log("clicked");
        
      }
	    void Update_Menus_Breakdown(){
	    	Lists_Written_Out = Lists_Written_Out_Saved;
	    	Lists_Written_Out_Images = Lists_Written_Out_Images_Saved;
	    	Selected_Menu_Title = List_Result_1_Text_Gameobject[0].GetComponent<UnityEngine.UI.Text>().text;
	    	if(Current_Menu == 1){
	    		List_Menus_Breakdown[0].SetActive(true);
	    		List_Menus_Breakdown[1].SetActive(false);
	    		List_Menus_Breakdown[2].SetActive(false);
	    		List_Menus_Breakdown[3].SetActive(false);
	    		List_Menus_Breakdown[4].SetActive(false);
	    		List_Menus_Breakdown[5].SetActive(false);
	    		List_Menus_Breakdown_Images[0].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_1_Container_Images[0], typeof(Sprite)) as Sprite;
	    		List_Menus_Breakdown_Images_Texture[0].GetComponent<RawImage>().texture = Resources.Load(""+List_Main_Menu_1_Container_Images_Texture[0], typeof(Texture)) as Texture;
	    		List_Menus_Breakdown_Text[0].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    		List_Menus_Breakdown_Text_Shadow_1[0].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    		List_Menus_Breakdown_Text_Shadow_2[0].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    	}
	    	if(Current_Menu == 2){
	    		List_Menus_Breakdown[0].SetActive(true);
	    		List_Menus_Breakdown[1].SetActive(true);
	    		List_Menus_Breakdown[2].SetActive(false);
	    		List_Menus_Breakdown[3].SetActive(false);
	    		List_Menus_Breakdown[4].SetActive(false);
	    		List_Menus_Breakdown[5].SetActive(false);
	    		List_Menus_Breakdown_Images[1].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_1_Container_Images[0], typeof(Sprite)) as Sprite;
	    		List_Menus_Breakdown_Images_Texture[1].GetComponent<RawImage>().texture = Resources.Load(""+List_Main_Menu_1_Container_Images_Texture[0], typeof(Texture)) as Texture;
	    		List_Menus_Breakdown_Text[1].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    		List_Menus_Breakdown_Text_Shadow_1[1].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    		List_Menus_Breakdown_Text_Shadow_2[1].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    	}
	    	if(Current_Menu == 3){
	    		List_Menus_Breakdown[0].SetActive(true);
	    		List_Menus_Breakdown[1].SetActive(true);
	    		List_Menus_Breakdown[2].SetActive(true);
	    		List_Menus_Breakdown[3].SetActive(false);
	    		List_Menus_Breakdown[4].SetActive(false);
	    		List_Menus_Breakdown[5].SetActive(false);
	    		List_Menus_Breakdown_Images[2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_1_Container_Images[0], typeof(Sprite)) as Sprite;
	    		List_Menus_Breakdown_Images_Texture[2].GetComponent<RawImage>().texture = Resources.Load(""+List_Main_Menu_1_Container_Images_Texture[0], typeof(Texture)) as Texture;
	    		List_Menus_Breakdown_Text[2].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    		List_Menus_Breakdown_Text_Shadow_1[2].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    		List_Menus_Breakdown_Text_Shadow_2[2].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    	}
	    	if(Current_Menu == 4){
	    		List_Menus_Breakdown[0].SetActive(true);
	    		List_Menus_Breakdown[1].SetActive(true);
	    		List_Menus_Breakdown[2].SetActive(true);
	    		List_Menus_Breakdown[3].SetActive(true);
	    		List_Menus_Breakdown[4].SetActive(false);
	    		List_Menus_Breakdown[5].SetActive(false);
	    		List_Menus_Breakdown_Images[3].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_1_Container_Images[0], typeof(Sprite)) as Sprite;
	    		List_Menus_Breakdown_Images_Texture[3].GetComponent<RawImage>().texture = Resources.Load(""+List_Main_Menu_1_Container_Images_Texture[0], typeof(Texture)) as Texture;
	    		List_Menus_Breakdown_Text[3].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    		List_Menus_Breakdown_Text_Shadow_1[3].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    		List_Menus_Breakdown_Text_Shadow_2[3].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    	}
	    	if(Current_Menu == 5){
	    		List_Menus_Breakdown[0].SetActive(true);
	    		List_Menus_Breakdown[1].SetActive(true);
	    		List_Menus_Breakdown[2].SetActive(true);
	    		List_Menus_Breakdown[3].SetActive(true);
	    		List_Menus_Breakdown[4].SetActive(true);
	    		List_Menus_Breakdown[5].SetActive(false);
	    		List_Menus_Breakdown_Images[4].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_1_Container_Images[0], typeof(Sprite)) as Sprite;
	    		List_Menus_Breakdown_Images_Texture[4].GetComponent<RawImage>().texture = Resources.Load(""+List_Main_Menu_1_Container_Images_Texture[0], typeof(Texture)) as Texture;
	    		List_Menus_Breakdown_Text[4].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    		List_Menus_Breakdown_Text_Shadow_1[4].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    		List_Menus_Breakdown_Text_Shadow_2[4].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    	}
	    	if(Current_Menu == 6){
	    		List_Menus_Breakdown[0].SetActive(true);
	    		List_Menus_Breakdown[1].SetActive(true);
	    		List_Menus_Breakdown[2].SetActive(true);
	    		List_Menus_Breakdown[3].SetActive(true);
	    		List_Menus_Breakdown[4].SetActive(true);
	    		List_Menus_Breakdown[5].SetActive(true);
	    		List_Menus_Breakdown_Images[5].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_1_Container_Images[0], typeof(Sprite)) as Sprite;
	    		List_Menus_Breakdown_Images_Texture[5].GetComponent<RawImage>().texture = Resources.Load(""+List_Main_Menu_1_Container_Images_Texture[0], typeof(Texture)) as Texture;
	    		List_Menus_Breakdown_Text[5].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    		List_Menus_Breakdown_Text_Shadow_1[5].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    		List_Menus_Breakdown_Text_Shadow_2[5].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
	    	}
	    	
	    	if(Current_Menu == 1){
	    		List_Main_Menu_1_Container = List_Written_Out_1;    		
	    	}
	    	
	    	for(var NumOfList = 0;NumOfList < Lists_Written_Out_Info.Count;NumOfList++){
				if(Selected_Menu_Title != Lists_Written_Out_Info[NumOfList][1]){
	    			List_Main_Menu_2_Container = List_Menu_Blank_Strings;
	    			List_Main_Menu_2_Container_Images = List_Menu_Blank_Strings;    			
	    			List_Main_Menu_2_Container_Images_Texture = List_Menu_Blank_Strings;    			
	    		}
	    	}	
	    	for(var NumOfList = 0;NumOfList < Lists_Written_Out_Info.Count;NumOfList++){
	    		if(Current_Menu_1 == Lists_Written_Out_Info[NumOfList][1]){ //Main Menu //Play Game
	    			List_Main_Menu_1_Container = Lists_Written_Out[NumOfList];
	    			List_Main_Menu_1_Container_Images = Lists_Written_Out_Images[NumOfList];
	    			List_Main_Menu_1_Container_Images_Texture = Lists_Written_Out_Images_Texture[NumOfList];
	    			//Debug.Log("Menu 1:"+Lists_Written_Out_Info[NumOfList][1]);
	    			//Debug.Log("Selected_Menu_Title : "+Selected_Menu_Title);
	    		}
	    	}
	    	for(var NumOfList = 0;NumOfList < Lists_Written_Out_Info.Count;NumOfList++){
	    		if(Current_Menu_2 == Lists_Written_Out_Info[NumOfList][1]){ //Play Game //Forge  			    		
	    			List_Main_Menu_1_Container = Lists_Written_Out[NumOfList];    			
	    			List_Main_Menu_1_Container_Images = Lists_Written_Out_Images[NumOfList];    			
	    			List_Main_Menu_1_Container_Images_Texture = Lists_Written_Out_Images_Texture[NumOfList];    			
	    			//Debug.Log("Menu 2:"+Lists_Written_Out_Info[NumOfList][1]);
	    			//Debug.Log("Selected_Menu_Title : "+Selected_Menu_Title);
	    		}
	    	}
	    	for(var NumOfList = 0;NumOfList < Lists_Written_Out_Info.Count;NumOfList++){
	    		if(Current_Menu_3 == Lists_Written_Out_Info[NumOfList][1]){ //Play Game //Forge  			    		
	    			List_Main_Menu_1_Container = Lists_Written_Out[NumOfList];    			
	    			List_Main_Menu_1_Container_Images = Lists_Written_Out_Images[NumOfList];    			
	    			List_Main_Menu_1_Container_Images_Texture = Lists_Written_Out_Images_Texture[NumOfList];    			
	    			//Debug.Log("Menu 3:"+Lists_Written_Out_Info[NumOfList][1]);
	    			//Debug.Log("Selected_Menu_Title : "+Selected_Menu_Title);
	    		}
	    	}
	    	for(var NumOfList = 0;NumOfList < Lists_Written_Out_Info.Count;NumOfList++){
	    		if(Current_Menu_4 == Lists_Written_Out_Info[NumOfList][1]){ //Play Game //Forge  			    		
	    			List_Main_Menu_1_Container = Lists_Written_Out[NumOfList];    			
	    			List_Main_Menu_1_Container_Images = Lists_Written_Out_Images[NumOfList];    			
	    			List_Main_Menu_1_Container_Images_Texture = Lists_Written_Out_Images_Texture[NumOfList];    			
	    		//Debug.Log("Menu 4:"+Lists_Written_Out_Info[NumOfList][1]);	
	    		//Debug.Log("Selected_Menu_Title : "+Selected_Menu_Title);
	    		}
	    	}
	    	for(var NumOfList = 0;NumOfList < Lists_Written_Out_Info.Count;NumOfList++){
	    		if(Current_Menu_5 == Lists_Written_Out_Info[NumOfList][1]){ //Play Game //Forge  			    		
	    			List_Main_Menu_1_Container = Lists_Written_Out[NumOfList];    			
	    			List_Main_Menu_1_Container_Images = Lists_Written_Out_Images[NumOfList];    			
	    			List_Main_Menu_1_Container_Images_Texture = Lists_Written_Out_Images_Texture[NumOfList];    			
	    		//Debug.Log("Menu 5:"+Lists_Written_Out_Info[NumOfList][1]);	
	    		//Debug.Log("Selected_Menu_Title : "+Selected_Menu_Title);
	    		}
	    	}
	    	for(var NumOfList = 0;NumOfList < Lists_Written_Out_Info.Count;NumOfList++){
	    		if(Current_Menu_6 == Lists_Written_Out_Info[NumOfList][1]){ //Play Game //Forge  			    		
	    			List_Main_Menu_1_Container = Lists_Written_Out[NumOfList];    			
	    			List_Main_Menu_1_Container_Images = Lists_Written_Out_Images[NumOfList];    			
	    			List_Main_Menu_1_Container_Images_Texture = Lists_Written_Out_Images_Texture[NumOfList];    			
	    		//Debug.Log("Menu 6:"+Lists_Written_Out_Info[NumOfList][1]);	
	    		//Debug.Log("Selected_Menu_Title : "+Selected_Menu_Title);
	    		}
	    	}	
	    		
	    		
	    		
	    		
	    	
	    		
	    		
	    		
	    		
	    	
	    	for(var NumOfList = 0;NumOfList < Lists_Written_Out_Info.Count;NumOfList++){
	    		
	    		if(Selected_Menu_Title == Lists_Written_Out_Info[NumOfList][1]){
	    			List_Main_Menu_2_Container = Lists_Written_Out[NumOfList];    			
	    			List_Main_Menu_2_Container_Images = Lists_Written_Out_Images[NumOfList];    			
	    			List_Main_Menu_2_Container_Images_Texture = Lists_Written_Out_Images_Texture[NumOfList];    			
	    			////Debug.Log("List_Main_Menu_2_Container : "+Lists_Written_Out[NumOfList][0]);	
	    			////Debug.Log("Selected_Menu_Title : "+Selected_Menu_Title);	
	    		}//

	    		
	    		
	    		
	    	}
	    	//for(var NumOfList = 0;NumOfList < Lists_Written_Out_Images.Count;NumOfList++){
	    		//for(var NumOfItem = 0;NumOfItem < Lists_Written_Out_Images[NumOfList].Count;NumOfItem++){
	    			//if(Lists_Written_Out_Images[NumOfList][NumOfItem] == ""){
	    				//List_Result_2_Images_Texture[NumOfList].SetActive(false);
	    			//}else{
	    				//List_Result_2_Images_Texture[NumOfList].SetActive(true);
	    			//}
	    		//}
	    	//}

	    	
	    	init();
	    }
	    void init(){
	    	

	    	var a = 0;
		    for(var i2 = 0; i2 < 5; i2++){	
		    	for(var i = 0; i < 3; i++){
		    		if(i2 <= 2){
		    			List_Result_1_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[i2];
		    			List_Result_1_Images[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_1_Container_Images[i2], typeof(Sprite)) as Sprite;
		    			List_Result_1_Images_Texture[i2].GetComponent<RawImage>().texture = Resources.Load(""+List_Main_Menu_1_Container_Images_Texture[i2], typeof(Texture)) as Texture;

		    				
		    		}
		    		if(i2 == 3){
		    			List_Result_1_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[List_Main_Menu_1_Container.Count - 2];
		    			List_Result_1_Images[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_1_Container_Images[List_Main_Menu_1_Container_Images.Count - 2], typeof(Sprite)) as Sprite;	
		    			List_Result_1_Images_Texture[i2].GetComponent<RawImage>().texture = Resources.Load(""+List_Main_Menu_1_Container_Images_Texture[List_Main_Menu_1_Container_Images_Texture.Count - 2], typeof(Texture)) as Texture;	
		    				
		    		}
		    		if(i2 == 4){
		    			List_Result_1_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[List_Main_Menu_1_Container.Count - 1];
		    			List_Result_1_Images[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_1_Container_Images[List_Main_Menu_1_Container_Images.Count - 1], typeof(Sprite)) as Sprite;	
		    			List_Result_1_Images_Texture[i2].GetComponent<RawImage>().texture = Resources.Load(""+List_Main_Menu_1_Container_Images_Texture[List_Main_Menu_1_Container_Images_Texture.Count - 1], typeof(Texture)) as Texture;	
		    			
		    		}

		    		
		    		
		    		a++;
		    	}
		    }
		    a = 0;
		    for(var i2 = 0; i2 < 5; i2++){	
		    	for(var i = 0; i < 3; i++){
		    		if(i2 <= 2){
		    			List_Result_2_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_2_Container[i2];
		    			List_Result_2_Images[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_2_Container_Images[i2], typeof(Sprite)) as Sprite;
		    			List_Result_2_Images_Texture[i2].GetComponent<RawImage>().texture = Resources.Load(""+List_Main_Menu_2_Container_Images_Texture[i2], typeof(Texture)) as Texture;
		    			
		    		}
		    		if(i2 == 3){
		    			List_Result_2_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_2_Container[List_Main_Menu_2_Container.Count - 2];
		    			List_Result_2_Images[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_2_Container_Images[List_Main_Menu_2_Container_Images.Count - 2], typeof(Sprite)) as Sprite;	
		    			List_Result_2_Images_Texture[i2].GetComponent<RawImage>().texture = Resources.Load(""+List_Main_Menu_2_Container_Images_Texture[List_Main_Menu_2_Container_Images_Texture.Count - 2], typeof(Texture)) as Texture;	
		    			
		    		}
		    		if(i2 == 4){
		    			List_Result_2_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_2_Container[List_Main_Menu_2_Container.Count - 1];
		    			List_Result_2_Images[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_2_Container_Images[List_Main_Menu_2_Container_Images.Count - 1], typeof(Sprite)) as Sprite;	
		    			List_Result_2_Images_Texture[i2].GetComponent<RawImage>().texture = Resources.Load(""+List_Main_Menu_2_Container_Images_Texture[List_Main_Menu_2_Container_Images_Texture.Count - 1], typeof(Texture)) as Texture;	
		    			
		    		}
		    		
		    		a++;
		    	}
		    }
		    a = 0;
		    for(var i2 = 0; i2 < 5; i2++){	
		    	for(var i = 0; i < 3; i++){
			 	   if(List_Result_2_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text == ""||List_Result_2_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text == " "){
			 	   		List_Result_2[i2].SetActive(false);
				    }else{
				    	List_Result_2[i2].SetActive(true);
				    }
				    if(List_Result_1_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text == ""||List_Result_1_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text == " "){
			 	   		List_Result_1[i2].SetActive(false);
				    }else{
				    	List_Result_1[i2].SetActive(true);
				    }
				    a++;
				}
			}
			//
	    }

	    // Update is called once per frame
	      public void OnSwipeHandler(string id){
	    	switch(id){
	    		case DirectionId.ID_UP:
	    			Up();
	    			break;
	    		case DirectionId.ID_DOWN:
	    			Down();
	    			break;	
	    		case DirectionId.ID_LEFT:
	    			Left();
	    			break;		
	    		case DirectionId.ID_RIGHT:
	    			Right();
	    			break;			
	    	}

	    }
       void ViewportOn_ItemsPopup(){
        NewItemsGained_Popup_Camera.SetActive(true);
      }
      void ViewportOff_ItemsPopup(){
        NewItemsGained_Popup_Camera.SetActive(false);
      }
      void ViewportOn_Mining(){
        Mining_Big_Camera.SetActive(true);
            Mining_Small_Camera.SetActive(true);
      }
      void ViewportOff_Mining(){
        Mining_Big_Camera.SetActive(false);
            Mining_Small_Camera.SetActive(false);
      }
      void ViewportOn_ItemsGained(){
        ItemsGained_Camera.SetActive(true);
      }
      void ViewportOff_ItemsGained(){
        ItemsGained_Camera.SetActive(false);
      }
      void Fight(){
        for(var area = 0; area < List_Written_Out_Fight_Areas_Name.Count;area++){
          float Damage = 100;
          
          if(List_Written_Out_Fight_Areas_Current_Enemy_Health_Current[area] - Damage <= 0){
            Maps_Enemys_Stage_Enemy_Num[area]++;
            if(Maps_Enemys_Stage_Enemy_Num[area] >= Maps_Enemys_Stage_Enemy_Max[area]){
                Maps_Enemys_Stage_Enemy_Num[area] = 1;
                Maps_Enemys_Stage_Num[area]++; 
            }
            
           List_Written_Out_Fight_Areas_Current_Enemy[area] = "No Enemy"; 
          }
          List_Written_Out_Fight_Areas_Current_Enemy_Health_Current[area] -= Damage;
          if(List_Written_Out_Fight_Areas_Current_Enemy[area] == "No Enemy"){               
               var EnemyNum = UnityEngine.Random.Range(0, Maps_Enemys[area].Count - 1);
               List_Written_Out_Fight_Areas_Current_Enemy[area] = ""+Maps_Enemys[area][EnemyNum];
                List_Written_Out_Fight_Areas_Current_Enemy_Health_Current[area] = List_Written_Out_Fight_Areas_Current_Enemy_Health_Full[area] * (Maps_Enemys_Stage_Num[area]) * (List_Written_Out_Fight_Areas_Rank_Num[area] * List_Written_Out_Fight_Areas_Rank_Num[area] * List_Written_Out_Fight_Areas_Rank_Num[area] + 1);
                List_Written_Out_Fight_Areas_Current_Enemy_Health_Full_Modified[area] = List_Written_Out_Fight_Areas_Current_Enemy_Health_Current[area];
                
          }
        }
      }
	    void Update()
  	  {
        Debug.Log(Lists_Mining_Area_1_Layers[1].Count);
        Debug.Log(Lists_Mining_Area_1_Layers_Mineral_Overlay[1].Count);
        Debug.Log(Lists_Mining_Area_1_Layers_Mineral_Overlay[3].Count);
        Debug.Log(Lists_Mining_Area_1_Layers_Mineral_Overlay[4].Count);
        Debug.Log(Lists_Mining_Area_1_Layers_Mineral_Overlay[5].Count);
        int FightIsActive = 0;
        Update_Menus_Breakdown();    
        Set_Buttons();
        if(Currently_Selected == "Coal Vain"||Currently_Selected == "Coal Vain : On"){
            ViewportOn_Mining();
            ViewportOn_ItemsPopup();
            ViewportOff_ItemsGained();
        }else{
            ViewportOff_Mining();
            ViewportOff_ItemsPopup();
            ViewportOn_ItemsGained();
            GameObject.Find("Fighting Camera/Canvas/Background").GetComponent<SpriteRenderer>().sprite = Resources.Load("Backgrounds/backgrounds_20", typeof(Sprite)) as Sprite;
        }
        for(var area = 0; area < List_Written_Out_Fight_Areas_Name.Count;area++){
          if(Currently_Selected == List_Written_Out_Fight_Areas_Name[area]){
            FightIsActive++;
            if(FightIsActive > 0){
              Enemy.SetActive(true);
              //Lightning_Skill.SetActive(true);
            }else{
              Enemy.SetActive(false);
              //Lightning_Skill.SetActive(false);
            }
            float Health = List_Written_Out_Fight_Areas_Current_Enemy_Health_Current[area] /  List_Written_Out_Fight_Areas_Current_Enemy_Health_Full_Modified[area];
            GameObject.Find("Enemy/Health Bar Fill").GetComponent<Image>().fillAmount = Health;
            ViewportOff_ItemsGained();
            GameObject.Find("Enemy/Stage Num/Text Main").GetComponent<UnityEngine.UI.Text>().text = "Stage "+Maps_Enemys_Stage_Num[area];
            GameObject.Find("Enemy/Stage Num/Text Shadow 1").GetComponent<UnityEngine.UI.Text>().text = "Stage "+Maps_Enemys_Stage_Num[area];
            GameObject.Find("Enemy/Stage Num/Text Shadow 2").GetComponent<UnityEngine.UI.Text>().text = "Stage "+Maps_Enemys_Stage_Num[area];
            GameObject.Find("Enemy/Enemy Num/Text Main").GetComponent<UnityEngine.UI.Text>().text = "Enemy "+Maps_Enemys_Stage_Enemy_Num[area] + " of "  + Maps_Enemys_Stage_Enemy_Max[area];
            GameObject.Find("Enemy/Enemy Num/Text Shadow 1").GetComponent<UnityEngine.UI.Text>().text = "Enemy "+Maps_Enemys_Stage_Enemy_Num[area] + " of "  + Maps_Enemys_Stage_Enemy_Max[area];
            GameObject.Find("Enemy/Enemy Num/Text Shadow 2").GetComponent<UnityEngine.UI.Text>().text = "Enemy "+Maps_Enemys_Stage_Enemy_Num[area] + " of "  + Maps_Enemys_Stage_Enemy_Max[area];

            GameObject.Find("Fighting Camera/Canvas/Background").GetComponent<SpriteRenderer>().sprite = Resources.Load(List_Written_Out_Fight_Areas_Background[area], typeof(Sprite)) as Sprite;
            GameObject.Find("Map Rank").GetComponent<SpriteRenderer>().sprite = Resources.Load(List_Written_Out_Fight_Areas_Rank[area], typeof(Sprite)) as Sprite;
            GameObject.Find("Enemy/Text Main").GetComponent<UnityEngine.UI.Text>().text = ""+List_Written_Out_Fight_Areas_Current_Enemy[area];
            GameObject.Find("Enemy/Text Shadow 1").GetComponent<UnityEngine.UI.Text>().text = ""+List_Written_Out_Fight_Areas_Current_Enemy[area];
            GameObject.Find("Enemy/Text Shadow 2").GetComponent<UnityEngine.UI.Text>().text = ""+List_Written_Out_Fight_Areas_Current_Enemy[area];
            for(var enemy = 0; enemy < List_Enemys_Name.Count; enemy++){
              if(List_Enemys_Name[enemy] == List_Written_Out_Fight_Areas_Current_Enemy[area]){
                GameObject.Find("Enemy/Enemy Image").GetComponent<SpriteRenderer>().sprite = Resources.Load(List_Enemys_Image[enemy], typeof(Sprite)) as Sprite;
              }
            }
          }

        }  
         if(FightIsActive > 0){
              Enemy.SetActive(true);
              //Lightning_Skill.SetActive(true);
            }else{
              Enemy.SetActive(false);
              //Lightning_Skill.SetActive(false);
            }
        if(List_Menus_Breakdown_Text[0].GetComponent<UnityEngine.UI.Text>().text == "Play Game"){
          if(List_Menus_Breakdown_Text[1].GetComponent<UnityEngine.UI.Text>().text == "Mine"){
              if(List_Menus_Breakdown_Text[2].GetComponent<UnityEngine.UI.Text>().text == "Coal Vain"){
                
              }else{
                Mining_Big_Camera.SetActive(false);
                Mining_Small_Camera.SetActive(false);
              } 
          }
          if(List_Menus_Breakdown_Text[1].GetComponent<UnityEngine.UI.Text>().text == "Forge"){
            
          }
          if(List_Menus_Breakdown_Text[1].GetComponent<UnityEngine.UI.Text>().text == "Forge"){
            
          }
          if(List_Menus_Breakdown_Text[1].GetComponent<UnityEngine.UI.Text>().text == "Forge"){
            
          }
          if(List_Menus_Breakdown_Text[1].GetComponent<UnityEngine.UI.Text>().text == "Forge"){
            
          }
        }else{
          
        }
			CastRay();
	    		
	    	 if (Input.GetMouseButtonDown(0)){
          Debug.Log(Lightning_Button);
          if(Lightning_Button == true){
            Lightning_Button_Click();
          }
	    	 	if(Result_1_Button_1 == true){
	    	 		Up();
	    	 		Up();
	    	 	}
	    	 	if(Result_1_Button_2 == true){
	    	 		Up();
	    	 	}
	    	 	if(Result_1_Button_3 == true){

	    	 	}
	    	 	if(Result_1_Button_4 == true){
	    	 		Down();
	    	 	}
	    	 	if(Result_1_Button_5 == true){
	    	 		Down();
	    	 		Down();
	    	 	}


	    	 	if(Result_2_Button_1 == true){
	    	 		Right();
	    	 		Up();
	    	 		Up();
	    	 	}
	    	 	if(Result_2_Button_2 == true){
	    	 		Right();
	    	 		Up();
	    	 	}
	    	 	if(Result_2_Button_3 == true){
	    	 		Right();
	    	 	}
	    	 	if(Result_2_Button_4 == true){
	    	 		Right();
	    	 		Down();
	    	 	}
	    	 	if(Result_2_Button_5 == true){
	    	 		Right();
	    	 		Down();
	    	 		Down();
	    	 	}

	    	 	if(Menus_Breakdown_0 == true){
	    	 		if(Current_Menu == 1){

	    	 		}
	    	 		if(Current_Menu == 2){
	    	 			Left();
	    	 		}
	    	 		if(Current_Menu == 3){
	    	 			Left();
	    	 			Left();
	    	 		}
	    	 		if(Current_Menu == 4){
	    	 			Left();
	    	 			Left();
	    	 			Left();

	    	 		}
	    	 		if(Current_Menu == 5){
	    	 			Left();
	    	 			Left();
	    	 			Left();
	    	 			Left();
	    	 		}
	    	 		if(Current_Menu == 6){
	    	 			Left();
	    	 			Left();
	    	 			Left();
	    	 			Left();
	    	 			Left();
	    	 		}
	    	 	}
	    	 	if(Menus_Breakdown_1 == true){
	    	 		if(Current_Menu == 1){

	    	 		}
	    	 		if(Current_Menu == 2){
	    	 			
	    	 		}
	    	 		if(Current_Menu == 3){
	    	 			Left();
	    	 			
	    	 		}
	    	 		if(Current_Menu == 4){
	    	 			Left();
	    	 			Left();
	    	 			

	    	 		}
	    	 		if(Current_Menu == 5){
	    	 			Left();
	    	 			Left();
	    	 			Left();
	    	 			
	    	 		}
	    	 		if(Current_Menu == 6){
	    	 			Left();
	    	 			Left();
	    	 			Left();
	    	 			Left();
	    	 			
	    	 		}
	    	 	}
	    	 	if(Menus_Breakdown_2 == true){
	    	 		if(Current_Menu == 1){

	    	 		}
	    	 		if(Current_Menu == 2){
	    	 			
	    	 		}
	    	 		if(Current_Menu == 3){
	    	 			
	    	 			
	    	 		}
	    	 		if(Current_Menu == 4){
	    	 			Left();
	    	 			
	    	 			

	    	 		}
	    	 		if(Current_Menu == 5){
	    	 			Left();
	    	 			Left();    	 		    	 			
	    	 		}
	    	 		if(Current_Menu == 6){
	    	 			Left();
	    	 			Left();    	 	
	    	 			Left();    	 		    	 			
	    	 		}
	    	 	}
	    	 	if(Menus_Breakdown_3 == true){
	    	 		if(Current_Menu == 1){

	    	 		}
	    	 		if(Current_Menu == 2){
	    	 			
	    	 		}
	    	 		if(Current_Menu == 3){
	    	 			
	    	 			
	    	 		}
	    	 		if(Current_Menu == 4){
	    	 	
	    	 			
	    	 			

	    	 		}
	    	 		if(Current_Menu == 5){
	    	 			Left();
	    	 	
	    	 			
	    	 			
	    	 		}
	    	 		if(Current_Menu == 6){
	    	 			Left();
	    	 			Left();
	    	 	
	    	 			
	    	 			
	    	 		}
	    	 	}
	    	 	if(Menus_Breakdown_4 == true){
	    	 		if(Current_Menu == 1){

	    	 		}
	    	 		if(Current_Menu == 2){
	    	 			
	    	 		}
	    	 		if(Current_Menu == 3){
	    	 			
	    	 			
	    	 		}
	    	 		if(Current_Menu == 4){
	    	 	
	    	 			
	    	 			

	    	 		}
	    	 		if(Current_Menu == 5){
	    	 			
	    	 	
	    	 			
	    	 			
	    	 		}
	    	 		if(Current_Menu == 6){
	    	 			Left();
	    	 			
	    	 	
	    	 			
	    	 			
	    	 		}
	    	 	}
	//Test



	    	 }
			if(Input.GetKeyDown(KeyCode.DownArrow)){	                	
	        	Down();
	        }
	        if(Input.GetKeyDown(KeyCode.S)){	                	
	        	Down();
	        }
	        if(Input.GetKeyDown(KeyCode.W)){	                	
	        	Up();
	        }
	        if(Input.GetKeyDown(KeyCode.UpArrow)){						        		        	
		     	Up();
		    }
		    if (Input.GetAxis("Mouse ScrollWheel") < 0f ){
				Down();
			}
			if (Input.GetAxis("Mouse ScrollWheel") > 0f ){
				Up();
			}

		    
	        if(Input.GetKeyDown(KeyCode.RightArrow)){
	        	Right();
	        }
	        if(Input.GetKeyDown(KeyCode.D)){
	        	Right();
	        }
	        if(Input.GetKeyDown(KeyCode.LeftArrow)){
	        	Left();
	        	
	        }
	        if(Input.GetKeyDown(KeyCode.A)){
	        	Left();
	        	
	        }
	    }
	    void ShowOrNotShow(){

	    }
	    void Up(){
	    	if(List_Main_Menu_1_Container[5] == " "){

	    		}else{
	    			Up_Menu_1();    			     			     			
	    		}
	    	

	    }
	    void Down(){
	    	if(List_Main_Menu_1_Container[1] == " "){

	    		}else{
	    			Down_Menu_1();	        	
	    		}
	    	
	    }
	    void Right(){
	    	if(List_Main_Menu_2_Container[0] == ""){

	    	}else{
	    		if(Current_Menu == 5){        		
	    			Current_Menu_4_save = Current_Menu_4;
	        		Set_Current_Menu_6();        		
	        	}
	    		if(Current_Menu == 4){        		
	    			Current_Menu_3_save = Current_Menu_3;
	        		Set_Current_Menu_5();        		
	        	}
	        	if(Current_Menu == 3){
	        		Current_Menu_2_save = Current_Menu_2;
	        		Set_Current_Menu_4();
	        	}  
	        	if(Current_Menu == 2){        		
	        		Current_Menu_1_save = Current_Menu_1;
	        		Set_Current_Menu_3();        		
	        	}
	        	if(Current_Menu == 1){
	        		Set_Current_Menu_2();
	        	}     
	        }	   
	    }
	    void Left(){
	    	if(Current_Menu == 2){
	        		Set_Current_Menu_1();
	        	}        	
	        	if(Current_Menu == 3){
	        		Current_Menu_1_save = Current_Menu_1;
	        		Set_Current_Menu_2();
	        		Current_Menu_1 = Current_Menu_1_save;
	        	}
	        	if(Current_Menu == 4){
	        		Debug.Log("Current_Menu == 4 switching to one below it");
	        		Current_Menu_1_save = Current_Menu_1;
	        		Current_Menu_2_save = Current_Menu_2;
	        		Set_Current_Menu_3();
	        		//Debug.Log("Current_Menu_2"+Current_Menu_2);
	        		//Debug.Log("Current_Menu_1"+Current_Menu_1);
	        		Current_Menu_2 = Current_Menu_2_save;
	        		Current_Menu_1 = Current_Menu_1_save;
	        	}
	        	if(Current_Menu == 5){
	        		Debug.Log("Current_Menu == 5 switching to one below it");
	        		Current_Menu_1_save = Current_Menu_1;
	        		Current_Menu_2_save = Current_Menu_2;        		
	        		Current_Menu_3_save = Current_Menu_3;
	        		Set_Current_Menu_4();
	        		Current_Menu_3 = Current_Menu_3_save;
	        		Current_Menu_2 = Current_Menu_2_save;
	        		Current_Menu_1 = Current_Menu_1_save;
	        	}
	        	if(Current_Menu == 6){
	        		Debug.Log("Current_Menu == 6 switching to one below it");
	        		Current_Menu_1_save = Current_Menu_1;
	        		Current_Menu_2_save = Current_Menu_2;        		
	        		Current_Menu_3_save = Current_Menu_3;
	        		Current_Menu_4_save = Current_Menu_4;
	        		Set_Current_Menu_5();
	        		Current_Menu_4 = Current_Menu_4_save;
	        		Current_Menu_3 = Current_Menu_3_save;
	        		Current_Menu_2 = Current_Menu_2_save;
	        		Current_Menu_1 = Current_Menu_1_save;
	        	}
	        	
	    }
      void Set_Buttons(){
        Currently_Selected = List_Result_1_Text_Gameobject[0].GetComponent<UnityEngine.UI.Text>().text;        
        int ThisButton_Menu_1 = 0;
        int ThisButton_Menu_2 = 0;
      List_Menus_Breakdown[0].GetComponent<SpriteRenderer>().sprite = Resources.Load("Buttons/"+Selected_Menu_Title_Background[0+1], typeof(Sprite)) as Sprite;            
      for(var whichTitle = 0; whichTitle < Selected_Menu_Title_Background.Count; whichTitle++){
          if(Selected_Menu_Title_Background[whichTitle] == Current_Menu_1){
              ThisButton_Menu_1 = whichTitle;
              List_Menus_Breakdown[1].GetComponent<SpriteRenderer>().sprite = Resources.Load("Buttons/"+Selected_Menu_Title_Background[ThisButton_Menu_1+1], typeof(Sprite)) as Sprite;          
          }
          
      }
      for(var whichTitle = 0; whichTitle < Selected_Menu_Title_Background.Count; whichTitle++){
          if(Selected_Menu_Title_Background[whichTitle] == Current_Menu_2){
              ThisButton_Menu_1 = whichTitle;
              List_Menus_Breakdown[2].GetComponent<SpriteRenderer>().sprite = Resources.Load("Buttons/"+Selected_Menu_Title_Background[ThisButton_Menu_1+1], typeof(Sprite)) as Sprite;
          }
          
      }
      for(var whichTitle = 0; whichTitle < Selected_Menu_Title_Background.Count; whichTitle++){
          if(Selected_Menu_Title_Background[whichTitle] == Current_Menu_3){
              ThisButton_Menu_1 = whichTitle;
              List_Menus_Breakdown[3].GetComponent<SpriteRenderer>().sprite = Resources.Load("Buttons/"+Selected_Menu_Title_Background[ThisButton_Menu_1+1], typeof(Sprite)) as Sprite;
          }
          
      }
      for(var whichTitle = 0; whichTitle < Selected_Menu_Title_Background.Count; whichTitle++){
          if(Selected_Menu_Title_Background[whichTitle] == Current_Menu_4){
              ThisButton_Menu_1 = whichTitle;
              List_Menus_Breakdown[4].GetComponent<SpriteRenderer>().sprite = Resources.Load("Buttons/"+Selected_Menu_Title_Background[ThisButton_Menu_1+1], typeof(Sprite)) as Sprite;
          }
          
      }
      for(var whichTitle = 0; whichTitle < Selected_Menu_Title_Background.Count; whichTitle++){
          if(Selected_Menu_Title_Background[whichTitle] == Current_Menu_5){
              ThisButton_Menu_1 = whichTitle;
              List_Menus_Breakdown[5].GetComponent<SpriteRenderer>().sprite = Resources.Load("Buttons/"+Selected_Menu_Title_Background[ThisButton_Menu_1+1], typeof(Sprite)) as Sprite;
          }
          
      }
      for(var whichTitle = 0; whichTitle < Selected_Menu_Title_Background.Count; whichTitle++){
          if(Selected_Menu_Title_Background[whichTitle] == Current_Menu_6){
              ThisButton_Menu_1 = whichTitle;
              List_Menus_Breakdown[6].GetComponent<SpriteRenderer>().sprite = Resources.Load("Buttons/"+Selected_Menu_Title_Background[ThisButton_Menu_1+1], typeof(Sprite)) as Sprite;
          }
          
      }
      for(var whichTitle = 0; whichTitle < Selected_Menu_Title_Background.Count; whichTitle++){
          if(Selected_Menu_Title_Background[whichTitle] == Currently_Selected){
              ThisButton_Menu_2 = whichTitle;
          }
      }  
      
          
        for(var i = 0; i < List_Result_1.Count;i++){
          List_Result_1[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Buttons/"+Selected_Menu_Title_Background[ThisButton_Menu_1+1], typeof(Sprite)) as Sprite;
          List_Result_2[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Buttons/"+Selected_Menu_Title_Background[ThisButton_Menu_2+1], typeof(Sprite)) as Sprite;
        
      }
      List_Result_1[0].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Buttons/"+Selected_Menu_Title_Background[ThisButton_Menu_1+2], typeof(Sprite)) as Sprite;
        
      }
	    void Set_Current_Menu_1(){
	    	Current_Menu = 1;						
	    	Current_Menu_1 = "Main Menu";
	    	Current_Menu_2 = ""; 
			
			init();
	    		Update_Menus_Breakdown();
	    		init();
	    }
	    void Set_Current_Menu_2(){
	    	Current_Menu_1 = Selected_Menu_Title; 
	    	Current_Menu_2 = "";
	    	
	    	Current_Menu = 2;								
			List_Main_Menu_1_Container = List_Main_Menu_2_Container;
			List_Main_Menu_1_Container_Images = List_Main_Menu_2_Container_Images;
			List_Main_Menu_1_Container_Images_Texture = List_Main_Menu_2_Container_Images_Texture;

			
			List_Result_1[0].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Buttons/Option Blue Resized", typeof(Sprite)) as Sprite;
			init();
	    		Update_Menus_Breakdown();
	    		init();
	    }
	    void Set_Current_Menu_3(){    	
	    	Current_Menu_2 = Selected_Menu_Title;
	    	Current_Menu_3 = "";
	    	
	    	Current_Menu = 3;								
			List_Main_Menu_1_Container = List_Main_Menu_2_Container;
			List_Main_Menu_1_Container_Images = List_Main_Menu_2_Container_Images;
			List_Main_Menu_1_Container_Images_Texture = List_Main_Menu_2_Container_Images_Texture;
			Debug.Log(List_Main_Menu_1_Container[0]);
			
			init();
	    		Update_Menus_Breakdown();
	    		init();
	    }
	    void Set_Current_Menu_4(){
	    	Current_Menu_3 = Selected_Menu_Title;
	    	Current_Menu_4 = "";
	    	Current_Menu = 4;								
			List_Main_Menu_1_Container = List_Main_Menu_2_Container;
			List_Main_Menu_1_Container_Images = List_Main_Menu_2_Container_Images;
			List_Main_Menu_1_Container_Images_Texture = List_Main_Menu_2_Container_Images_Texture;
			Debug.Log(List_Main_Menu_1_Container[0]);
			
			init();
	    		Update_Menus_Breakdown();
	    		init();
	    }
	    void Set_Current_Menu_5(){
	    	Current_Menu_4 = Selected_Menu_Title;
	    	Current_Menu_5 = "";
	    	Current_Menu = 5;								
			List_Main_Menu_1_Container = List_Main_Menu_2_Container;
			List_Main_Menu_1_Container_Images = List_Main_Menu_2_Container_Images;
			List_Main_Menu_1_Container_Images_Texture = List_Main_Menu_2_Container_Images_Texture;
			Debug.Log(List_Main_Menu_1_Container[0]);
			
			init();
	    		Update_Menus_Breakdown();
	    		init();
	    }
	    void Set_Current_Menu_6(){
	    	Current_Menu_5 = Selected_Menu_Title;
	    	Current_Menu_6 = "";
	    	Current_Menu = 5;								
			List_Main_Menu_1_Container = List_Main_Menu_2_Container;
			List_Main_Menu_1_Container_Images = List_Main_Menu_2_Container_Images;
			List_Main_Menu_1_Container_Images_Texture = List_Main_Menu_2_Container_Images_Texture;

			
			init();
	    		Update_Menus_Breakdown();
	    		init();
	    }

	    void Down_Menu_1(){
	    	string List_Begin = List_Main_Menu_1_Container[0]; 
	    	string List_Begin_Images = List_Main_Menu_1_Container_Images[0]; 
	    	string List_Begin_Images_Texture = List_Main_Menu_1_Container_Images_Texture[0]; 
	    	for(var i = 0; i < List_Main_Menu_1_Container.Count; i++){
	    		if(i == List_Main_Menu_1_Container.Count - 1){
	    			List_Main_Menu_1_Container[i] = List_Begin;	
	    			List_Main_Menu_1_Container_Images[i] = List_Begin_Images;	
	    			List_Main_Menu_1_Container_Images_Texture[i] = List_Begin_Images_Texture;	
	    		}else{
	    			List_Main_Menu_1_Container[i] = List_Main_Menu_1_Container[i+1];
	    			List_Main_Menu_1_Container_Images[i] = List_Main_Menu_1_Container_Images[i+1];
	    			List_Main_Menu_1_Container_Images_Texture[i] = List_Main_Menu_1_Container_Images_Texture[i+1];
	    		}

	    	}
	    	
	    	
	    		init();
	    		Update_Menus_Breakdown();
	    }
	    void Up_Menu_1(){
	    	string List_Begin = List_Main_Menu_1_Container[List_Main_Menu_1_Container.Count - 1]; 
	    	string List_Begin_Images = List_Main_Menu_1_Container_Images[List_Main_Menu_1_Container_Images.Count - 1]; 
	    	string List_Begin_Images_Texture = List_Main_Menu_1_Container_Images_Texture[List_Main_Menu_1_Container_Images_Texture.Count - 1]; 
	    	for(var i = List_Main_Menu_1_Container.Count - 1; i >= 0; i--){
	    		if(i == 0){
	    			List_Main_Menu_1_Container[i] = List_Begin;	
	    			List_Main_Menu_1_Container_Images[i] = List_Begin_Images;	
	    			List_Main_Menu_1_Container_Images_Texture[i] = List_Begin_Images_Texture;	
	    		}else{
	    			List_Main_Menu_1_Container[i] = List_Main_Menu_1_Container[i-1];
	    			List_Main_Menu_1_Container_Images[i] = List_Main_Menu_1_Container_Images[i-1];
	    			List_Main_Menu_1_Container_Images_Texture[i] = List_Main_Menu_1_Container_Images_Texture[i-1];
	    		}

	    	}
	    	
	    	init();
	    	Update_Menus_Breakdown();
	    }
	    void CastRay()
	    {
	    	
	        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	        RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
	        if (hit)
	        {
              Debug.Log(hit.collider.gameObject.name);
	            if(hit.collider.gameObject.name == "Lightning Skill")
              {
                Lightning_Button = true;
              }
              else
              {
                Lightning_Button = false;   
              }
	            if(hit.collider.gameObject.tag == "Result 1" && hit.collider.gameObject.name == "Button Main (1)")
	            {
	              Result_1_Button_1 = true;
	            }
	            else
	            {
	              Result_1_Button_1 = false;   
	            }
	            if(hit.collider.gameObject.tag == "Result 1" && hit.collider.gameObject.name == "Button Main (2)")
	            {
	              Result_1_Button_2 = true;
	            }
	            else
	            {
	              Result_1_Button_2 = false;   
	            }
	            if(hit.collider.gameObject.tag == "Result 1" && hit.collider.gameObject.name == "Button Main (3)")
	            {
	              Result_1_Button_3 = true;
	            }
	            else
	            {
	              Result_1_Button_3 = false;   
	            }
	            if(hit.collider.gameObject.tag == "Result 1" && hit.collider.gameObject.name == "Button Main (4)")
	            {
	              Result_1_Button_4 = true;
	            }
	            else
	            {
	              Result_1_Button_4 = false;   
	            }
	            if(hit.collider.gameObject.tag == "Result 1" && hit.collider.gameObject.name == "Button Main (5)")
	            {
	              Result_1_Button_5 = true;
	            }
	            else
	            {
	              Result_1_Button_5 = false;   
	            }









	            if(hit.collider.gameObject.tag == "Result 2" && hit.collider.gameObject.name == "Button Main (1)")
	            {
	              Result_2_Button_1 = true;
	            }
	            else
	            {
	              Result_2_Button_1 = false;   
	            }
	            if(hit.collider.gameObject.tag == "Result 2" && hit.collider.gameObject.name == "Button Main (2)")
	            {
	              Result_2_Button_2 = true;
	            }
	            else
	            {
	              Result_2_Button_2 = false;   
	            }
	            if(hit.collider.gameObject.tag == "Result 2" && hit.collider.gameObject.name == "Button Main (3)")
	            {
	              Result_2_Button_3 = true;
	            }
	            else
	            {
	              Result_2_Button_3 = false;   
	            }
	            if(hit.collider.gameObject.tag == "Result 2" && hit.collider.gameObject.name == "Button Main (4)")
	            {
	              Result_2_Button_4 = true;
	            }
	            else
	            {
	              Result_2_Button_4 = false;   
	            }
	            if(hit.collider.gameObject.tag == "Result 2" && hit.collider.gameObject.name == "Button Main (5)")
	            {
	              Result_2_Button_5 = true;
	            }
	            else
	            {
	              Result_2_Button_5 = false;   
	            }
	            
	            
	            if(hit.collider.gameObject.name == "Menus Breakdown (0)")
	            {
	              Menus_Breakdown_0 = true;
	            }
	            else
	            {
	              Menus_Breakdown_0 = false;   
	            }
	            if(hit.collider.gameObject.name == "Menus Breakdown (1)")
	            {
	              Menus_Breakdown_1 = true;
	            }
	            else
	            {
	              Menus_Breakdown_1 = false;   
	            }
	            if(hit.collider.gameObject.name == "Menus Breakdown (2)")
	            {
	              Menus_Breakdown_2 = true;
	            }
	            else
	            {
	              Menus_Breakdown_2 = false;   
	            }
	            if(hit.collider.gameObject.name == "Menus Breakdown (3)")
	            {
	              Menus_Breakdown_3 = true;
	            }
	            else
	            {
	              Menus_Breakdown_3 = false;   
	            }
	            if(hit.collider.gameObject.name == "Menus Breakdown (4)")
	            {
	              Menus_Breakdown_4 = true;
	            }
	            else
	            {
	              Menus_Breakdown_4 = false;   
	            }
	            if(hit.collider.gameObject.name == "Menus Breakdown (5)")
	            {
	              Menus_Breakdown_5 = true;
	            }
	            else
	            {
	              Menus_Breakdown_5 = false;   
	            }
	            
	            

	            
	    }
		}
		void CalculateArea(double C_Dirt, double C_Rich_Soil, double C_Very_Rich_Soil, double C_Extremly_rich_soil, double C_Grass, double C_Valunite, double C_Dark_Valunite, double C_Bamboo, double C_Wood, double C_Sandstone, double C_Sand, double C_Packed_Sand, double C_Extra_Coins, double C_Bonus_Coins, double C_Orange_Box, double C_Green_Box, double C_Cyan_Box, double C_Red_Box, double C_Magenta_Box, double C_Purple_Box, double C_Blue_Box, double C_Explosion, double C_Huge_Explosion, double C_Big_Explosion, double C_Timed_Explosion, double C_Enormous_Explosion, double C_Blue_Key, double C_Red_Key, double C_Green_Key, double C_Yellow_Key, double C_Steel, double C_Refined_Steel, double C_Mystery_Steel, double C_Stone, double C_Ruby, double C_Diamond, double C_Gold, double C_Silver, double C_Calcite, double C_Coal, double C_Aquamarine, double C_Pixie_Dust, double C_Emerald, double C_Fossils, double C_Boxes, double C_Old_Box, double C_Unknown, double C_Stone_Bricks, double C_Ugly_Bricks, double C_Brick, double C_Forest_Crystal, double C_Blood_Crystal, double C_Sand_Crystal, double C_Ice_Crystal, double C_Snow_Crystal, double C_Ice, double C_Packed_Snow, double C_Hardened_Ice, double C_Compressed_Ice) {

    R_Dirt = 1 - C_Dirt;
    R_Rich_Soil = R_Dirt - C_Rich_Soil;
    R_Very_Rich_Soil = R_Rich_Soil - C_Very_Rich_Soil;
    R_Extremly_Rich_Soil = R_Very_Rich_Soil - C_Extremly_rich_soil;
    R_Grass = R_Extremly_Rich_Soil - C_Grass;
    R_Valunite = R_Grass - C_Valunite;
    R_Dark_Valunite = R_Valunite - C_Dark_Valunite;
    R_Bamboo = R_Dark_Valunite - C_Bamboo;
    R_Wood = R_Bamboo - C_Wood;
    R_Sandstone = R_Wood - C_Sandstone;
    R_Sand = R_Sandstone - C_Sand;
    R_Packed_Sand = R_Sand - C_Packed_Sand;
    R_Extra_Coins = R_Packed_Sand - C_Extra_Coins;
    R_Bonus_Coins = R_Extra_Coins - C_Bonus_Coins;
    R_Orange_Box = R_Bonus_Coins - C_Orange_Box;
    R_Green_Box = R_Orange_Box - C_Green_Box;
    R_Cyan_Box = R_Green_Box - C_Cyan_Box;
    R_Red_Box = R_Cyan_Box - C_Red_Box;
    R_Magenta_Box = R_Red_Box - C_Magenta_Box;
    R_Purple_Box = R_Magenta_Box - C_Purple_Box;
    R_Blue_Box = R_Purple_Box - C_Blue_Box;
    R_Explosion = R_Blue_Box - C_Explosion;
    R_Huge_Explosion = R_Explosion - C_Huge_Explosion;
    R_Big_Explosion = R_Huge_Explosion - C_Big_Explosion;
    R_Timed_Explosion = R_Big_Explosion - C_Timed_Explosion;
    R_Enormous_Explosion = R_Timed_Explosion - C_Enormous_Explosion;
    R_Blue_Key = R_Enormous_Explosion - C_Blue_Key;
    R_Red_Key = R_Blue_Key - C_Red_Key;
    R_Green_Key = R_Red_Key - C_Green_Key;
    R_Yellow_Key = R_Green_Key - C_Yellow_Key;
    R_Steel = R_Yellow_Key - C_Steel;
    R_Refined_Steel = R_Steel - C_Refined_Steel;
    R_Mystery_Steel = R_Refined_Steel - C_Mystery_Steel;
    R_Stone = R_Mystery_Steel - C_Stone;
    R_Ruby = R_Stone - C_Ruby;
    R_Diamond = R_Ruby - C_Diamond;
    R_Gold = R_Diamond - C_Gold;
    R_Silver = R_Gold - C_Silver;
    R_Calcite = R_Silver - C_Calcite;
    R_Coal = R_Calcite - C_Coal;
    R_Aquamarine = R_Coal - C_Aquamarine;
    R_Pixie_Dust = R_Aquamarine - C_Pixie_Dust;
    R_Emerald = R_Pixie_Dust - C_Emerald;
    R_Fossils = R_Emerald - C_Fossils;
    R_Boxes = R_Fossils - C_Boxes;
    R_Old_Box = R_Boxes - C_Old_Box;
    R_Unknown = R_Old_Box - C_Unknown;
    R_Stone_Bricks = R_Unknown - C_Stone_Bricks;
    R_Ugly_Bricks = R_Stone_Bricks - C_Ugly_Bricks;
    R_Brick = R_Ugly_Bricks - C_Brick;
    R_Forest_Crystal = R_Brick - C_Forest_Crystal;
    R_Blood_Crystal = R_Forest_Crystal - C_Blood_Crystal;
    R_Sand_Crystal = R_Blood_Crystal - C_Sand_Crystal;
    R_Ice_Crystal = R_Sand_Crystal - C_Ice_Crystal;
    R_Snow_Crystal = R_Ice_Crystal - C_Snow_Crystal;
    R_Ice = R_Snow_Crystal - C_Ice;
    R_Packed_Snow = R_Ice - C_Packed_Snow;
    R_Hardened_Ice = R_Packed_Snow - C_Hardened_Ice;
    R_Compressed_Ice = R_Hardened_Ice - C_Compressed_Ice;
  }
  public void Calculate_Next() {
    CalculateArea(
    /*Dirt*/
    R_Dirt,
    /*Rich_Soil*/
    R_Rich_Soil,
    /*Very_Rich_Soil*/
    R_Very_Rich_Soil,
    /*Extremly_rich_soil*/
    R_Extremly_Rich_Soil,
    /*Grass*/
    R_Grass,
    /*Valunite*/
    R_Valunite,
    /*Dark_Valunite*/
    R_Dark_Valunite,
    /*Bamboo*/
    R_Bamboo,
    /*Wood*/
    R_Wood,
    /*Sandstone*/
    R_Sandstone,
    /*Sand*/
    R_Sand,
    /*Packed_Sand*/
    R_Packed_Sand,
    /*Extra_Coins*/
    R_Extra_Coins,
    /*Bonus_Coins*/
    R_Bonus_Coins,
    /*Orange_Box*/
    R_Orange_Box,
    /*Green_Box*/
    R_Green_Box,
    /*Cyan_Box*/
    R_Cyan_Box,
    /*Red_Box*/
    R_Red_Box,
    /*Magenta_Box*/
    R_Magenta_Box,
    /*Purple_Box*/
    R_Purple_Box,
    /*Blue_Box*/
    R_Blue_Box,
    /*Explosion*/
    R_Explosion,
    /*Huge_Explosion*/
    R_Huge_Explosion,
    /*Big_Explosion*/
    R_Big_Explosion,
    /*Timed_Explosion*/
    R_Timed_Explosion,
    /*Enormous_Explosion*/
    R_Enormous_Explosion,
    /*Blue_Key*/
    R_Blue_Key,
    /*Red_Key*/
    R_Red_Key,
    /*Green_Key*/
    R_Green_Key,
    /*Yellow_Key*/
    R_Yellow_Key,
    /*Steel*/
    R_Steel,
    /*Refined_Steel*/
    R_Refined_Steel,
    /*Mystery_Steel*/
    R_Mystery_Steel,
    /*Stone*/
    R_Stone,
    /*Ruby*/
    R_Ruby,
    /*Diamond*/
    R_Diamond,
    /*Gold*/
    R_Gold,
    /*Silver*/
    R_Silver,
    /*Calcite*/
    R_Calcite,
    /*Coal*/
    R_Coal,
    /*Aquamarine*/
    R_Aquamarine,
    /*Pixie_Dust*/
    R_Pixie_Dust,
    /*Emerald*/
    R_Emerald,
    /*Fossils*/
    R_Fossils,
    /*Boxes*/
    R_Boxes,
    /*Old_Box*/
    R_Old_Box,
    /*Unknown*/
    R_Unknown,
    /*Stone_Bricks*/
    R_Stone_Bricks,
    /*Ugly_Bricks*/
    R_Ugly_Bricks,
    /*Brick*/
    R_Brick,
    /*Forest_Crystal*/
    R_Forest_Crystal,
    /*Blood_Crystal*/
    R_Blood_Crystal,
    /*Sand_Crystal*/
    R_Sand_Crystal,
    /*Ice_Crystal*/
    R_Ice_Crystal,
    /*Snow_Crystal*/
    R_Snow_Crystal,
    /*Ice*/
    R_Ice,
    /*Packed_Snow*/
    R_Packed_Snow,
    /*Hardened_Ice*/
    R_Hardened_Ice,
    /*Compressed_Ice*/
    R_Compressed_Ice);
  }
  void CalculateAreaMineral(double R_Nothing,double C_Coal_Few, double C_Coal_Some, double C_Coal_Lots) {
    R_Nothing = 1 - R_Nothing;
    R_Coal_Few = R_Nothing - C_Coal_Few;
    R_Coal_Some = R_Coal_Few - C_Coal_Some;
    R_Coal_Lots = R_Coal_Some - R_Coal_Lots;
  }  
  public void Calculate_Next_Mineral() {
    CalculateAreaMineral(
      R_Nothing,
      R_Coal_Few,
      R_Coal_Some,
      R_Coal_Lots
    );
  }
  public void GenerateNextMineral() {

    double R = RandomMap.Next(0, 100000000);
    R = (float)R/100000000;
    int R_Num = RandomMap.Next(1,4);
    if(R > R_Nothing){
      Mineral_Name = "Nothing";
    }
    else if (R > R_Coal_Few) {
      Mineral_Name = "Few Coal "+R_Num.ToString();
    }
    else if (R > R_Coal_Some) {
      Mineral_Name = "Some Coal "+R_Num.ToString();
    }
    else if (R > R_Coal_Lots) {
      Mineral_Name = "Lots of Coal "+R_Num.ToString();
    }
  }
  public void GenerateNextBlock() {
    double R = RandomMap.Next(0, 100000000);
    R = (float)R/100000000;
    if (R > R_Dirt) {
      Block_Name = "Dirt";
    }
    else if (R > R_Rich_Soil) {
      Block_Name = "Rich Soil";
    }
    else if (R > R_Very_Rich_Soil) {
      Block_Name = "Very Rich Soil";
    }
    else if (R > R_Extremly_Rich_Soil) {
      Block_Name = "Extremly rich soil";
    }
    else if (R > R_Grass) {
      Block_Name = "Grass";
    }
    else if (R > R_Valunite) {
      Block_Name = "Valunite";
    }
    else if (R > R_Dark_Valunite) {
      Block_Name = "Dark Valunite";
    }
    else if (R > R_Bamboo) {
      Block_Name = "Bamboo";
    }
    else if (R > R_Wood) {
      Block_Name = "Wood";
    }
    else if (R > R_Sandstone) {
      Block_Name = "Sandstone";
    }
    else if (R > R_Sand) {
      Block_Name = "Sand";
    }
    else if (R > R_Packed_Sand) {
      Block_Name = "Packed Sand";
    }
    else if (R > R_Extra_Coins) {
      Block_Name = "Extra Coins";
    }
    else if (R > R_Bonus_Coins) {
      Block_Name = "Bonus Coins";
    }
    else if (R > R_Orange_Box) {
      Block_Name = "Orange Box";
    }
    else if (R > R_Green_Box) {
      Block_Name = "Green Box";
    }
    else if (R > R_Cyan_Box) {
      Block_Name = "Cyan Box";
    }
    else if (R > R_Red_Box) {
      Block_Name = "Red Box";
    }
    else if (R > R_Magenta_Box) {
      Block_Name = "Magenta Box";
    }
    else if (R > R_Purple_Box) {
      Block_Name = "Purple Box";
    }
    else if (R > R_Blue_Box) {
      Block_Name = "Blue Box";
    }
    else if (R > R_Explosion) {
      Block_Name = "Explosion";
    }
    else if (R > R_Huge_Explosion) {
      Block_Name = "Huge Explosion";
    }
    else if (R > R_Big_Explosion) {
      Block_Name = "Big Explosion";
    }
    else if (R > R_Timed_Explosion) {
      Block_Name = "Timed Explosion";
    }
    else if (R > R_Enormous_Explosion) {
      Block_Name = "Enormous Explosion";
    }
    else if (R > R_Blue_Key) {
      Block_Name = "Blue Key";
    }
    else if (R > R_Red_Key) {
      Block_Name = "Red Key";
    }
    else if (R > R_Green_Key) {
      Block_Name = "Green Key";
    }
    else if (R > R_Yellow_Key) {
      Block_Name = "Yellow Key";
    }
    else if (R > R_Steel) {
      Block_Name = "Steel";
    }
    else if (R > R_Refined_Steel) {
      Block_Name = "Refined Steel";
    }
    else if (R > R_Mystery_Steel) {
      Block_Name = "Mystery Steel";
    }
    else if (R > R_Stone) {
      Block_Name = "Stone";
    }
    else if (R > R_Ruby) {
      Block_Name = "Ruby";
    }
    else if (R > R_Diamond) {
      Block_Name = "Diamond";
    }
    else if (R > R_Gold) {
      Block_Name = "Gold";
    }
    else if (R > R_Silver) {
      Block_Name = "Silver";
    }
    else if (R > R_Calcite) {
      Block_Name = "Calcite";
    }
    else if (R > R_Coal) {
      Block_Name = "Coal";
    }
    else if (R > R_Aquamarine) {
      Block_Name = "Aquamarine";
    }
    else if (R > R_Pixie_Dust) {
      Block_Name = "Pixie Dust";
    }
    else if (R > R_Emerald) {
      Block_Name = "Emerald";
    }
    else if (R > R_Fossils) {
      Block_Name = "Fossils";
    }
    else if (R > R_Boxes) {
      Block_Name = "Boxes";
    }
    else if (R > R_Old_Box) {
      Block_Name = "Old Box";
    }
    else if (R > R_Unknown) {
      Block_Name = "Unknown";
    }
    else if (R > R_Stone_Bricks) {
      Block_Name = "Stone Bricks";
    }
    else if (R > R_Ugly_Bricks) {
      Block_Name = "Ugly Bricks";
    }
    else if (R > R_Brick) {
      Block_Name = "Brick";
    }
    else if (R > R_Forest_Crystal) {
      Block_Name = "Forest Crystal";
    }
    else if (R > R_Blood_Crystal) {
      Block_Name = "Blood Crystal";
    }
    else if (R > R_Sand_Crystal) {
      Block_Name = "Sand Crystal";
    }
    else if (R > R_Ice_Crystal) {
      Block_Name = "Ice Crystal";
    }
    else if (R > R_Snow_Crystal) {
      Block_Name = "Snow Crystal";
    }
    else if (R > R_Ice) {
      Block_Name = "Ice";
    }
    else if (R > R_Packed_Snow) {
      Block_Name = "Packed Snow";
    }
    else if (R > R_Hardened_Ice) {
      Block_Name = "Hardened Ice";
    }
    else if (R > R_Compressed_Ice) {
      Block_Name = "Compressed Ice";
    }
  }
  public void Set_Main_Mineral() {
    SetMainMineral = 1 - (R_Nothing + R_Coal_Few + R_Coal_Some + R_Coal_Lots);
    R_Nothing = SetMainMineral;
  }
  public void setVarsT0Mineral(){
    R_Nothing = 0f;
    R_Coal_Few = 0f;
    R_Coal_Some = 0f;
    R_Coal_Lots = 0f;
  }
  public void SetBlockValueMineral(){
    R_Nothing = 0f;
    R_Coal_Few = 0.3f;
    R_Coal_Some = 0.1f;
    R_Coal_Lots = 0.05f; 
  }
  public void setVarsT0() {
    R_Dirt = 0f;
    R_Rich_Soil = 0f;
    R_Very_Rich_Soil = 0f;
    R_Extremly_Rich_Soil = 0f;
    R_Grass = 0f;
    R_Valunite = 0f;
    R_Dark_Valunite = 0f;
    R_Bamboo = 0f;
    R_Wood = 0f;
    R_Sandstone = 0f;
    R_Sand = 0f;
    R_Packed_Sand = 0f;
    R_Extra_Coins = 0f;
    R_Bonus_Coins = 0f;
    R_Orange_Box = 0f;
    R_Green_Box = 0f;
    R_Cyan_Box = 0f;
    R_Red_Box = 0f;
    R_Magenta_Box = 0f;
    R_Purple_Box = 0f;
    R_Blue_Box = 0f;
    R_Explosion = 0f;
    R_Huge_Explosion = 0f;
    R_Big_Explosion = 0f;
    R_Timed_Explosion = 0f;
    R_Enormous_Explosion = 0f;
    R_Blue_Key = 0f;
    R_Red_Key = 0f;
    R_Green_Key = 0f;
    R_Yellow_Key = 0f;
    R_Steel = 0f;
    R_Refined_Steel = 0f;
    R_Mystery_Steel = 0f;
    R_Stone = 0f;
    R_Ruby = 0f;
    R_Diamond = 0f;
    R_Gold = 0f;
    R_Silver = 0f;
    R_Calcite = 0f;
    R_Coal = 0f;
    R_Aquamarine = 0f;
    R_Pixie_Dust = 0f;
    R_Emerald = 0f;
    R_Fossils = 0f;
    R_Boxes = 0f;
    R_Old_Box = 0f;
    R_Unknown = 0f;
    R_Stone_Bricks = 0f;
    R_Ugly_Bricks = 0f;
    R_Brick = 0f;
    R_Forest_Crystal = 0f;
    R_Blood_Crystal = 0f;
    R_Sand_Crystal = 0f;
    R_Ice_Crystal = 0f;
    R_Snow_Crystal = 0f;
    R_Ice = 0f;
    R_Packed_Snow = 0f;
    R_Hardened_Ice = 0f;
    R_Compressed_Ice = 0f;
  }
  
  public void SetBlockValue() {
    R_Dirt = 0.0;
    R_Rich_Soil = 0.05;
    R_Very_Rich_Soil = 0.1;
    R_Extremly_Rich_Soil = 0.005;
    R_Grass = 0.0;
    R_Valunite = 0.0;
    R_Dark_Valunite = 0.0;
    R_Bamboo = 0.0;
    R_Wood = 0.0;
    R_Sandstone = 0.0;
    R_Sand = 0.0;
    R_Packed_Sand = 0.0;
    R_Extra_Coins = 0.0;
    R_Bonus_Coins = 0.0;
    R_Orange_Box = 0.001;
    R_Green_Box = 0.001;
    R_Cyan_Box = 0.001;
    R_Red_Box = 0.001;
    R_Magenta_Box = 0.001;
    R_Purple_Box = 0.001;
    R_Blue_Box = 0.001;
    R_Explosion = 0.0;
    R_Huge_Explosion = 0.0;
    R_Big_Explosion = 0.0;
    R_Timed_Explosion = 0.0;
    R_Enormous_Explosion = 0.0;
    R_Blue_Key = 0.0001;
    R_Red_Key = 0.0001;
    R_Green_Key = 0.0001;
    R_Yellow_Key = 0.0001;
    R_Steel = 0.0;
    R_Refined_Steel = 0.0;
    R_Mystery_Steel = 0.0;
    R_Stone = 0.01;
    R_Ruby = 0.005;
    R_Diamond = 0.02;
    R_Gold = 0.01;
    R_Silver = 0.03;
    R_Calcite = 0.02;
    R_Coal = 0.05;
    R_Aquamarine = 0.005;
    R_Pixie_Dust = 0.0001;
    R_Emerald = 0.001;
    R_Fossils = 0.0001;
    R_Boxes = 0.0;
    R_Old_Box = 0.0;
    R_Unknown = 0.0;
    R_Stone_Bricks = 0.0;
    R_Ugly_Bricks = 0.0;
    R_Brick = 0.0;
    R_Forest_Crystal = 0.0001;
    R_Blood_Crystal = 0.0001;
    R_Sand_Crystal = 0.0001;
    R_Ice_Crystal = 0.0001;
    R_Snow_Crystal = 0.0001;
    R_Ice = 0.0;
    R_Packed_Snow = 0.0;
    R_Hardened_Ice = 0.0;
    R_Compressed_Ice = 0.0;
  }
  
  public void Set_Main() {
    SetMain = 1 - (R_Dirt + R_Rich_Soil + R_Very_Rich_Soil + R_Extremly_Rich_Soil + R_Grass + R_Valunite + R_Dark_Valunite + R_Bamboo + R_Wood + R_Sandstone + R_Sand + R_Packed_Sand + R_Extra_Coins + R_Bonus_Coins + R_Orange_Box + R_Green_Box + R_Cyan_Box + R_Red_Box + R_Magenta_Box + R_Purple_Box + R_Blue_Box + R_Explosion + R_Huge_Explosion + R_Big_Explosion + R_Timed_Explosion + R_Enormous_Explosion + R_Blue_Key + R_Red_Key + R_Green_Key + R_Yellow_Key + R_Steel + R_Refined_Steel + R_Mystery_Steel + R_Stone + R_Ruby + R_Diamond + R_Gold + R_Silver + R_Calcite + R_Coal + R_Aquamarine + R_Pixie_Dust + R_Emerald + R_Fossils + R_Boxes + R_Old_Box + R_Unknown + R_Stone_Bricks + R_Ugly_Bricks + R_Brick + R_Forest_Crystal + R_Blood_Crystal + R_Sand_Crystal + R_Ice_Crystal + R_Snow_Crystal + R_Ice + R_Packed_Snow + R_Hardened_Ice + R_Compressed_Ice);

    if (Stage_Name == "Dirt") {
      currentSetMain = "Dirt";
      R_Dirt = SetMain;
    }
    if (Stage_Name == "Rich Soil") {
      currentSetMain = "Rich Soil";
      R_Rich_Soil = SetMain;
    }
    if (Stage_Name == "Very Rich Soil") {
      currentSetMain = "Very Rich Soil";
      R_Very_Rich_Soil = SetMain;
    }
    if (Stage_Name == "Extremly Rich Soil") {
      currentSetMain = "Extremly Rich Soil";
      R_Extremly_Rich_Soil = SetMain;
    }
    if (Stage_Name == "Grass") {
      currentSetMain = "Grass";
      R_Grass = SetMain;
    }
    if (Stage_Name == "Valunite") {
      currentSetMain = "Valunite";
      setVarsT0();
      R_Valunite = SetMain;
    }
    if (Stage_Name == "Dark Valunite") {
      currentSetMain = "Dark Valunite";
      setVarsT0();
      R_Dark_Valunite = SetMain;
    }
    if (Stage_Name == "Bamboo") {
      currentSetMain = "Bamboo";
      setVarsT0();
      R_Bamboo = SetMain;
    }
    if (Stage_Name == "Wood") {
      currentSetMain = "Wood";
      setVarsT0();
      R_Wood = SetMain;
    }
    if (Stage_Name == "Sandstone") {
      currentSetMain = "Sandstone";
      R_Sandstone = SetMain;
    }
    if (Stage_Name == "Sand") {
      currentSetMain = "Sand";
      R_Sand = SetMain;
    }
    if (Stage_Name == "Packed Sand") {
      currentSetMain = "Packed Sand";
      R_Packed_Sand = SetMain;
    }
    if (Stage_Name == "Ice") {
      currentSetMain = "Ice";
      R_Ice = SetMain;
    }
    if (Stage_Name == "Packed Snow") {
      currentSetMain = "Packed Snow";
      R_Packed_Snow = SetMain;
    }
    if (Stage_Name == "Hardened Ice") {
      currentSetMain = "Hardened Ice";
      R_Hardened_Ice = SetMain;
    }
    if (Stage_Name == "Compressed Ice") {
      currentSetMain = "Compressed Ice";
      R_Compressed_Ice = SetMain;
    }
    if (Stage_Name == "Brick") {
      currentSetMain = "Brick";
      R_Brick = SetMain;
    }
    if (Stage_Name == "Stone") {
      currentSetMain = "Stone";
      R_Stone = SetMain;
    }
    if (Stage_Name == "Coal") {
      currentSetMain = "Coal";
      R_Coal = SetMain;
    }
    if (Stage_Name == "Calcite") {
      currentSetMain = "Calcite";
      R_Calcite = SetMain;
    }
    if (Stage_Name == "Silver") {
      currentSetMain = "Silver";
      R_Silver = SetMain;
    }
    if (Stage_Name == "Aquamarine") {
      currentSetMain = "Aquamarine";
      R_Aquamarine = SetMain;
    }
    if (Stage_Name == "Gold") {
      currentSetMain = "Gold";
      R_Gold = SetMain;
    }
    if (Stage_Name == "Diamond") {
      currentSetMain = "Diamond";
      R_Diamond = SetMain;
    }
    if (Stage_Name == "Ruby") {
      currentSetMain = "Ruby";
      R_Ruby = SetMain;
    }
    if (Stage_Name == "Emerald") {
      R_Stone = 0f;
      R_Coal = 0f;
      R_Calcite = 0f;
      R_Silver = 0f;
      R_Aquamarine = 0f;
      R_Gold = 0f;
      currentSetMain = "Emerald";
      R_Emerald = SetMain;
    }
    if (Stage_Name == "Steel") {
      currentSetMain = "Steel";
      R_Steel = SetMain;
    }
    if (Stage_Name == "Crystal") {
      currentSetMain = "Explosion";
      R_Forest_Crystal = 0.2f;
      R_Blood_Crystal = 0.2f;
      R_Sand_Crystal = 0.2f;
      R_Ice_Crystal = 0.2f;
      R_Snow_Crystal = 0.2f;
    }

  }

	}
	

