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
		List<List<GameObject>> Lists_Mining_Area_1_Layers = new List<List<GameObject>>();
		public List<GameObject> Mining_Area_1_Layer_0 = new List<GameObject>();
		public List<GameObject> Mining_Area_1_Layer_1 = new List<GameObject>();
		public List<GameObject> Mining_Area_1_Layer_2 = new List<GameObject>();
		public List<GameObject> Mining_Area_1_Layer_3 = new List<GameObject>();
		public List<GameObject> Mining_Area_1_Layer_4 = new List<GameObject>();
		public List<GameObject> Mining_Area_1_Layer_5 = new List<GameObject>();
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
		
		
		
		
		public List<string> List_Written_Out_Coal_Vain = new List<string>();
		public List<string> List_Written_Out_Coal_Vain_Images = new List<string>();
		public List<string> List_Written_Out_Coal_Vain_Images_Texture = new List<string>();
		public List<string> List_Written_Out_Coal_Vain_Info = new List<string>();
		

		public List<string> List_Menu_Blank_Strings = new List<string>();
		public List<GameObject> Mining_Area_1_Mining_Camera = new List<GameObject>();
		public List<GameObject> Mining_Area_1_Main_Camera = new List<GameObject>();
		









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
  public string Stage_Name = "Dirt";
public string currentSetMain = "Dirt";
  public double SetMain = 0;
	    // Start is called before the first frame update
	    void Start()
	    {
        
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
			
			List_Written_Out_Coal_Vain_Info.Add("Mine");
			List_Written_Out_Coal_Vain_Info.Add("Coal Vain");
			Selected_Menu_Title_Background.Add("Coal Vain");
      Selected_Menu_Title_Background.Add("3-DRh");
      Selected_Menu_Title_Background.Add("3-E");
			
			//New List Area AHK
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			

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
	    	InvokeRepeating("Mining_Area_1_Mine_Blocks", 0f,0.01f);
        InvokeRepeating("NewItem_Function", 0f, .001f);
        InvokeRepeating("NewItemsGainedArea", 0f, .01f);
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
        ItemsGained_Item_Name.Add(Item_Name);
        ItemsGained_ItemAmount.Add(ItemAmount);
        ItemsGained_ItemImage_Dir.Add(ItemImage_Dir);
        ItemsGained_ItemRank.Add(ItemRank);  
          NewItem.Add(Instantiate(Resources.Load("Prefabs/New Item") as GameObject));
          GameObject NewItems = GameObject.Find("New Items");
          GameObject NewItem_Position_Holder = GameObject.Find("New Items/New Item Place Holder");

          NewItem[NewItem_Num].transform.parent = NewItems.transform; 
          NewItem[NewItem_Num].transform.position = NewItem_Position_Holder.transform.position;
          NewItem[NewItem_Num].name = "New Object "+NewItem_Num;
          GameObject Name_Text_Shadow_1 = GameObject.Find("New Object "+NewItem_Num+"/Title/Text Shadow 1");
          GameObject Name_Text_Shadow_2 = GameObject.Find("New Object "+NewItem_Num+"/Title/Text Shadow 2");
          GameObject Name_Text_Main = GameObject.Find("New Object "+NewItem_Num+"/Title/Text Main");
          GameObject ItemAmount_Text_Shadow_1 = GameObject.Find("New Object "+NewItem_Num+"/Item Amount/Text Shadow 1");
          GameObject ItemAmount_Text_Shadow_2 = GameObject.Find("New Object "+NewItem_Num+"/Item Amount/Text Shadow 2");
          GameObject ItemAmount_Text_Main = GameObject.Find("New Object "+NewItem_Num+"/Item Amount/Text Main");
          GameObject ItemImage = GameObject.Find("New Object "+NewItem_Num+"/Item Image/Image Of Item");
          GameObject LeftOfItemImage = GameObject.Find("New Object "+NewItem_Num+"/Item Image/Question Mark 1");
          GameObject RightOfItemImage = GameObject.Find("New Object "+NewItem_Num+"/Item Image/Question Mark 2");          
          GameObject ItemRank_Main = GameObject.Find("New Object "+NewItem_Num+"/Rank/Rank Big");
          GameObject ItemRank_Small_1 = GameObject.Find("New Object "+NewItem_Num+"/Rank/Rank Small 1");
          GameObject ItemRank_Small_2 = GameObject.Find("New Object "+NewItem_Num+"/Rank/Rank Small 2");
          GameObject ItemRank_Small_3 = GameObject.Find("New Object "+NewItem_Num+"/Rank/Rank Small 3");          
          for(var rank = 0; rank < Rank_List.Count;rank++){            
            if(ItemRank == rank){
                ItemRank_Main.GetComponent<SpriteRenderer>().sprite = Resources.Load(""+Rank_List[rank], typeof(Sprite)) as Sprite;
                ItemRank_Small_1.GetComponent<SpriteRenderer>().sprite = Resources.Load(""+Rank_List[rank], typeof(Sprite)) as Sprite;
                ItemRank_Small_2.GetComponent<SpriteRenderer>().sprite = Resources.Load(""+Rank_List[rank], typeof(Sprite)) as Sprite;
                ItemRank_Small_3.GetComponent<SpriteRenderer>().sprite = Resources.Load(""+Rank_List[rank], typeof(Sprite)) as Sprite;
            }
          }
          Name_Text_Shadow_1.GetComponent<UnityEngine.UI.Text>().text = ""+Item_Name;
          Name_Text_Shadow_2.GetComponent<UnityEngine.UI.Text>().text = ""+Item_Name;
          Name_Text_Main.GetComponent<UnityEngine.UI.Text>().text = ""+Item_Name;
          ItemAmount_Text_Shadow_1.GetComponent<UnityEngine.UI.Text>().text = ""+ItemAmount;
          ItemAmount_Text_Shadow_2.GetComponent<UnityEngine.UI.Text>().text = ""+ItemAmount;
          ItemAmount_Text_Main.GetComponent<UnityEngine.UI.Text>().text = ""+ItemAmount;
          ItemImage.GetComponent<SpriteRenderer>().sprite = Resources.Load(""+ItemImage_Dir, typeof(Sprite)) as Sprite;
          LeftOfItemImage.GetComponent<SpriteRenderer>().sprite = Resources.Load("", typeof(Sprite)) as Sprite;
          RightOfItemImage.GetComponent<SpriteRenderer>().sprite = Resources.Load("", typeof(Sprite)) as Sprite;
          ItemImage.layer = LayerNum+ 1;
          NewItem[NewItem_Num].layer = LayerNum;
          NewItem_TimeSinceCreated.Add(0);
          NewItem_Num++;
          LayerNum++;
          if(LayerNum == 31){
            LayerNum = 4;
          }
          New_Item_Check = false;
        }   
          
       for(var i = 0; i <= NewItem_Num - 1;i++){
           NewItem_TimeSinceCreated[i]++;
           if(NewItem_TimeSinceCreated[i] >= 300){
              Destroy(NewItem[i]);
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
	    	for(var i = 0; i < Lists_Mining_Area_1_Layers.Count;i++){
	    		for(var i2 = 0;i2 < Lists_Mining_Area_1_Layers[i].Count; i2++){
	    			GenerateNextBlock();
	    			Lists_Mining_Area_1_Layers[i][i2].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Block_Name, typeof(Sprite)) as Sprite;

	    		}
	    	}
	    }
	    void Mining_Area_1_Mine_Blocks(){
	    	
	    	for(var i = Lists_Mining_Area_1_Layers[0].Count -1;i >= 0; i--){
	    		if(Lists_Mining_Area_1_Layers[0][i].activeSelf == true){
	    			
	    			Vector3 CamPos = new Vector3(Lists_Mining_Area_1_Layers[0][i].transform.position.x,Lists_Mining_Area_1_Layers[0][i].transform.position.y,Mining_Area_1_Camera.transform.position.z);
	    			iTween.MoveTo(Mining_Area_1_Camera, iTween.Hash("position", CamPos, "time", .1f));	
	    			x++;
	    			if(x < 50){
	    				break;
	    			}
	    			if(x >= 50){
	    				x = 0;
	    			}
	    			Lists_Mining_Area_1_Layers[0][i].SetActive(false);
            for(var tilenum = 0; tilenum < Tiles_List.Count;tilenum++){
              if(Lists_Mining_Area_1_Layers[0][i].GetComponent<SpriteRenderer>().sprite.name == Tiles_List_NameWithoutUnderscore[tilenum]){                  
                Item_Name = Tiles_List_NameWithoutUnderscore[tilenum];
                ItemImage_Dir = "Tiles/"+Tiles_List_NameWithoutUnderscore[tilenum]+" 256";
                ItemAmount = 1;
                ItemRank = Tiles_List_Rank[tilenum];
                New_Item_Check = true;

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
	    	for(var i = 0; i < Lists_Mining_Area_1_Layers[0].Count;i++){
	    		// Move layer 2 to 1 3 to 2 4 to 3 5 to 4 and generate 5 set active to 1
	    		string Layer_2_Name = Lists_Mining_Area_1_Layers[1][i].GetComponent < SpriteRenderer > ().sprite.name;
	    		
	    		string Layer_3_Name = Lists_Mining_Area_1_Layers[2][i].GetComponent < SpriteRenderer > ().sprite.name;
	    		string Layer_4_Name = Lists_Mining_Area_1_Layers[3][i].GetComponent < SpriteRenderer > ().sprite.name;
	    		string Layer_5_Name = Lists_Mining_Area_1_Layers[4][i].GetComponent < SpriteRenderer > ().sprite.name;
	    		string Layer_6_Name = Lists_Mining_Area_1_Layers[5][i].GetComponent < SpriteRenderer > ().sprite.name;
				Lists_Mining_Area_1_Layers[0][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_2_Name, typeof(Sprite)) as Sprite;	    		
				Lists_Mining_Area_1_Layers[1][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_3_Name, typeof(Sprite)) as Sprite;	    		
				Lists_Mining_Area_1_Layers[2][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_4_Name, typeof(Sprite)) as Sprite;	    		
				Lists_Mining_Area_1_Layers[3][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_5_Name, typeof(Sprite)) as Sprite;	    		
				Lists_Mining_Area_1_Layers[4][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Layer_6_Name, typeof(Sprite)) as Sprite;	    		
				GenerateNextBlock();
				Lists_Mining_Area_1_Layers[5][i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Tiles/" + Block_Name, typeof(Sprite)) as Sprite;	    		
				Lists_Mining_Area_1_Layers[0][i].SetActive(true);

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
	    void Update()
	    {

        Update_Menus_Breakdown();    
        Set_Buttons();
			CastRay();
	    		
	    	 if (Input.GetMouseButtonDown(0)){
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
        string Currently_Selcted = List_Result_1_Text_Gameobject[0].GetComponent<UnityEngine.UI.Text>().text;        
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
          if(Selected_Menu_Title_Background[whichTitle] == Currently_Selcted){
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
	    	if(List_Menus_Breakdown_Text[0].GetComponent<UnityEngine.UI.Text>().text == "Play Game"){
	    		if(List_Menus_Breakdown_Text[1].GetComponent<UnityEngine.UI.Text>().text == "Mine"){
	    			if(List_Menus_Breakdown_Text[2].GetComponent<UnityEngine.UI.Text>().text == "Area 1"){
	    				
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
	    	}
	        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	        RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
	        if (hit)
	        {

	            
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
  public void GenerateNextBlock() {

    double R = UnityEngine.Random.Range(0.0f, 1.0f);

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
    R_Diamond = 0.001;
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
	

