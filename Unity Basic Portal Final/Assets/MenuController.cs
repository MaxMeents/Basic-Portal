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
	public List<string> List_Main_Menu_2_Container = new List<string>();
	public List<string> List_Main_Menu_2_Container_Images = new List<string>();
	List<List<string>> Lists_Written_Out = new List<List<string>>();
	List<List<string>> Lists_Written_Out_Images = new List<List<string>>();
	List<List<string>> Lists_Written_Out_Saved = new List<List<string>>();
	List<List<string>> Lists_Written_Out_Images_Saved = new List<List<string>>();
	List<List<string>> Lists_Written_Out_Info = new List<List<string>>();
	public List<string> List_Written_Out_1 = new List<string>();
	public List<string> List_Written_Out_1_Images = new List<string>();
	public List<string> List_Written_Out_1_Info = new List<string>();
	public List<string> List_Written_Out_1_2 = new List<string>();
	public List<string> List_Written_Out_1_2_Images = new List<string>();
	public List<string> List_Written_Out_1_2_Info = new List<string>();
	public List<string> List_Written_Out_1_1 = new List<string>();
	public List<string> List_Written_Out_1_1_Images = new List<string>();
	public List<string> List_Written_Out_1_1_Info = new List<string>();
	public List<string> List_Written_Out_1_1_2 = new List<string>();
	public List<string> List_Written_Out_1_1_2_Images = new List<string>();
	public List<string> List_Written_Out_1_1_2_Info = new List<string>();
	public List<string> List_Written_Out_1_1_1 = new List<string>();
	public List<string> List_Written_Out_1_1_1_Images = new List<string>();
	public List<string> List_Written_Out_1_1_1_Info = new List<string>();
	public List<string> List_Menu_Blank_Strings = new List<string>();
	public List<GameObject> List_Result_1 = new List<GameObject>();
	public List<GameObject> List_Result_1_Images = new List<GameObject>();
	public List<GameObject> List_Result_1_Text_Gameobject = new List<GameObject>();
	public List<GameObject> List_Result_2 = new List<GameObject>();
	public List<GameObject> List_Result_2_Images = new List<GameObject>();
	public List<GameObject> List_Result_2_Text_Gameobject = new List<GameObject>();
	public List<GameObject> List_Menus_Breakdown = new List<GameObject>();
	public List<GameObject> List_Menus_Breakdown_Images = new List<GameObject>();
	public List<GameObject> List_Menus_Breakdown_Text = new List<GameObject>();
	public List<GameObject> List_Menus_Breakdown_Text_Shadow_1 = new List<GameObject>();
	public List<GameObject> List_Menus_Breakdown_Text_Shadow_2 = new List<GameObject>();
	public string Selected_Menu_Title = "Main Menu";
	public string Current_Menu_1 = "";
	public string Current_Menu_2 = "";


	public int Current_Menu = 1;
    // Start is called before the first frame update
    void Start()
    {
    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (0)"));
    	List_Menus_Breakdown_Images.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (0)/Image (1)"));
    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (0)/Text Main"));
    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (0)/Text Shadow 1"));
    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (0)/Text Shadow 2"));
    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (1)"));
    	List_Menus_Breakdown_Images.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (1)/Image (1)"));
    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (1)/Text Main"));
    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (1)/Text Shadow 1"));
    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (1)/Text Shadow 2"));
    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (2)"));
    	List_Menus_Breakdown_Images.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (2)/Image (1)"));
    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (2)/Text Main"));
    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (2)/Text Shadow 1"));
    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (2)/Text Shadow 2"));
    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (3)"));
    	List_Menus_Breakdown_Images.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (3)/Image (1)"));
    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (3)/Text Main"));
    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (3)/Text Shadow 1"));
    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (3)/Text Shadow 2"));
    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (4)"));
    	List_Menus_Breakdown_Images.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (4)/Image (1)"));
    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (4)/Text Main"));
    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (4)/Text Shadow 1"));
    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (4)/Text Shadow 2"));
    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (5)"));
    	List_Menus_Breakdown_Images.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (5)/Image (1)"));
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
    	List_Main_Menu_1_Container_Images.Add("");
    	List_Main_Menu_1_Container_Images.Add("");
    	List_Main_Menu_1_Container_Images.Add("");
    	List_Main_Menu_1_Container_Images.Add("");
    	List_Main_Menu_1_Container_Images.Add("");
    	List_Main_Menu_1_Container_Images.Add("");
    	List_Main_Menu_1_Container_Images.Add("");
    	List_Main_Menu_1_Container_Images.Add("");
    	List_Main_Menu_1_Container_Images.Add("");

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
		List_Main_Menu_2_Container_Images.Add("");
		List_Main_Menu_2_Container_Images.Add("");
		List_Main_Menu_2_Container_Images.Add("");
		List_Main_Menu_2_Container_Images.Add("");
		List_Main_Menu_2_Container_Images.Add("");
		List_Main_Menu_2_Container_Images.Add("");
		List_Main_Menu_2_Container_Images.Add("");
		List_Main_Menu_2_Container_Images.Add("");
		List_Main_Menu_2_Container_Images.Add("");
		List_Written_Out_1_Info.Add("Main Menu");
		List_Written_Out_1_Info.Add("Main Menu");
		List_Written_Out_1_2_Info.Add("Main Menu");
		List_Written_Out_1_2_Info.Add("Search the Web");
				
		List_Written_Out_1_1_Info.Add("Main Menu");
		List_Written_Out_1_1_Info.Add("Play Game");
		
		
		List_Written_Out_1_1_1_Info.Add("Play Game");
		List_Written_Out_1_1_1_Info.Add("Mine");
		
		List_Written_Out_1_1_2_Info.Add("Play Game");
		List_Written_Out_1_1_2_Info.Add("Forge");
		
		List_Written_Out_1_1_1.Add("Area 1");
		List_Written_Out_1_1_1_Images.Add("");
		List_Written_Out_1_1_1.Add("Area 2");
		List_Written_Out_1_1_1_Images.Add("");
		List_Written_Out_1_1_1.Add("Area 3");
		List_Written_Out_1_1_1_Images.Add("");
		List_Written_Out_1_1_1.Add(" ");
		List_Written_Out_1_1_1_Images.Add("");
		List_Written_Out_1_1_1.Add(" ");
		List_Written_Out_1_1_1_Images.Add("");
		List_Written_Out_1_1_1.Add(" ");
		List_Written_Out_1_1_1_Images.Add("");

		List_Written_Out_1_1.Add("Mine");
		List_Written_Out_1_1_Images.Add("Mining/darkstone");
		List_Written_Out_1_1.Add("Farm");
		List_Written_Out_1_1_Images.Add("Food/Fruit/Strawbeares");
		List_Written_Out_1_1.Add("Fight");
		List_Written_Out_1_1_Images.Add("Characters/Enemys/Arcane Crystal Magic Circle");
		List_Written_Out_1_1.Add("Gather");
		List_Written_Out_1_1_Images.Add("Food/Herbs/Uta");
		List_Written_Out_1_1.Add("Alchemy");
		List_Written_Out_1_1_Images.Add("Potions/potion_cocktail_bp_09");
		List_Written_Out_1_1.Add("Forge");
		List_Written_Out_1_1_Images.Add("Mining/plate_iron");
		List_Written_Out_1_1.Add("Tailor");
		List_Written_Out_1_1_Images.Add("Tailoring/scissors_02");
		
		
		List_Written_Out_1_1_2.Add("Make Bars");
		List_Written_Out_1_1_2_Images.Add("");
		List_Written_Out_1_1_2.Add("Swords");
		List_Written_Out_1_1_2_Images.Add("");
		List_Written_Out_1_1_2.Add("Helmets");
		List_Written_Out_1_1_2_Images.Add("Equipment/helmet_A_17");
		List_Written_Out_1_1_2.Add("Chest Plate Armor");
		List_Written_Out_1_1_2_Images.Add("Equipment/armor_A_17");
		List_Written_Out_1_1_2.Add("Waist Amor");
		List_Written_Out_1_1_2_Images.Add("Equipment/legArmor_A_17");
		List_Written_Out_1_1_2.Add("Leg Armor");
		List_Written_Out_1_1_2_Images.Add("Equipment/boots_A_17");
		List_Written_Out_1_1_2.Add("Wrist Armor");
		List_Written_Out_1_1_2_Images.Add("Equipment/gloves_A_17");
		List_Written_Out_1_1_2.Add("Earrings");
		List_Written_Out_1_1_2_Images.Add("Equipment/earings_A_17");
		List_Written_Out_1_1_2.Add("Necklaces");
		List_Written_Out_1_1_2_Images.Add("Equipment/necklace_A_17");
		List_Written_Out_1_1_2.Add("Rings");
		List_Written_Out_1_1_2_Images.Add("Equipment/ring_A_17");
		

		List_Written_Out_1.Add("Play Game");
		List_Written_Out_1_Images.Add("Special/ArrowKeys");
    	List_Written_Out_1.Add("Search the Web");
    	List_Written_Out_1_Images.Add("");

    	List_Written_Out_1_2.Add("Movies");
    	List_Written_Out_1_2_Images.Add("");
    	List_Written_Out_1_2.Add("Music");
    	List_Written_Out_1_2_Images.Add("");
    	List_Written_Out_1_2.Add("Social Media");
    	List_Written_Out_1_2_Images.Add("");
    	List_Written_Out_1_2.Add("Youtube");
    	List_Written_Out_1_2_Images.Add("");
    	

    	List_Written_Out_1.Add("Save");
    	List_Written_Out_1_Images.Add("");
    	List_Written_Out_1.Add("Load");
    	List_Written_Out_1_Images.Add("");
    	List_Written_Out_1.Add("Options");
    	List_Written_Out_1_Images.Add("");
    	List_Written_Out_1.Add("About");    	
    	List_Written_Out_1_Images.Add("");
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

    	Lists_Written_Out_Info.Add(List_Written_Out_1_Info);
    	Lists_Written_Out_Info.Add(List_Written_Out_1_1_Info);
    	Lists_Written_Out_Info.Add(List_Written_Out_1_1_2_Info);
    	Lists_Written_Out_Info.Add(List_Written_Out_1_1_1_Info);
    	Lists_Written_Out_Info.Add(List_Written_Out_1_2_Info);

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
    	Set_Current_Menu_2();
    	Set_Current_Menu_1();

    	//ConvertLists();
    }
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
    		List_Menus_Breakdown_Text[2].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
    		List_Menus_Breakdown_Text_Shadow_1[2].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
    		List_Menus_Breakdown_Text_Shadow_2[2].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
    	}
    	
    	if(Current_Menu == 1){
    		List_Main_Menu_1_Container = List_Written_Out_1;    		
    	}
    	
    	for(var NumOfList = 0;NumOfList < Lists_Written_Out_Info.Count;NumOfList++){
			if(Selected_Menu_Title != Lists_Written_Out_Info[NumOfList][1]){
    			List_Main_Menu_2_Container = List_Menu_Blank_Strings;
    			List_Main_Menu_2_Container_Images = List_Menu_Blank_Strings;    			
    		}
    		if(Current_Menu_1 == Lists_Written_Out_Info[NumOfList][1]){ //Main Menu //Play Game
    			List_Main_Menu_1_Container = Lists_Written_Out[NumOfList];
    			List_Main_Menu_1_Container_Images = Lists_Written_Out_Images[NumOfList];
    			
    		}
    		if(Current_Menu_2 == Lists_Written_Out_Info[NumOfList][1]){ //Play Game //Forge  			    		
    			List_Main_Menu_1_Container = Lists_Written_Out[NumOfList];    			
    			List_Main_Menu_1_Container_Images = Lists_Written_Out_Images[NumOfList];    			
    			
    		}
    	}
    	for(var NumOfList = 0;NumOfList < Lists_Written_Out_Info.Count;NumOfList++){
    		
    		if(Selected_Menu_Title == Lists_Written_Out_Info[NumOfList][1]){
    			List_Main_Menu_2_Container = Lists_Written_Out[NumOfList];    			
    			List_Main_Menu_2_Container_Images = Lists_Written_Out_Images[NumOfList];    			
    			
    		}
    		
    		
    		
    	}

    	
    	init();
    }
    void init(){
    	

    	var a = 0;
	    for(var i2 = 0; i2 < 5; i2++){	
	    	for(var i = 0; i < 3; i++){
	    		if(i2 <= 2){
	    			List_Result_1_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[i2];
	    			List_Result_1_Images[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_1_Container_Images[i2], typeof(Sprite)) as Sprite;
	    				
	    		}
	    		if(i2 == 3){
	    			List_Result_1_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[List_Main_Menu_1_Container.Count - 2];
	    			List_Result_1_Images[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_1_Container_Images[List_Main_Menu_1_Container_Images.Count - 2], typeof(Sprite)) as Sprite;	
	    				
	    		}
	    		if(i2 == 4){
	    			List_Result_1_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[List_Main_Menu_1_Container.Count - 1];
	    			List_Result_1_Images[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_1_Container_Images[List_Main_Menu_1_Container_Images.Count - 1], typeof(Sprite)) as Sprite;	
	    			
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
	    			
	    		}
	    		if(i2 == 3){
	    			List_Result_2_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_2_Container[List_Main_Menu_2_Container.Count - 2];
	    			List_Result_2_Images[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_2_Container_Images[List_Main_Menu_2_Container_Images.Count - 2], typeof(Sprite)) as Sprite;	
	    			
	    		}
	    		if(i2 == 4){
	    			List_Result_2_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_2_Container[List_Main_Menu_2_Container.Count - 1];
	    			List_Result_2_Images[i2].GetComponent<SpriteRenderer>().sprite = Resources.Load(""+List_Main_Menu_2_Container_Images[List_Main_Menu_2_Container_Images.Count - 1], typeof(Sprite)) as Sprite;	
	    			
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
		CastRay();
    	Update_Menus_Breakdown();    	
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
    		if(Current_Menu == 2){        		
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
        		string Current_Menu_1_save = Current_Menu_1;
        		Set_Current_Menu_2();
        		Current_Menu_1 = Current_Menu_1_save;
        	}
    }
    void Set_Current_Menu_1(){
    	Current_Menu = 1;						
    	Current_Menu_1 = "Main Menu";
    	Current_Menu_2 = ""; 
		for(var i = 0; i < List_Result_1.Count;i++){
			List_Result_1[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Buttons/Menu 1", typeof(Sprite)) as Sprite;
			List_Result_2[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Buttons/Menu 2", typeof(Sprite)) as Sprite;
			
		}
		List_Result_1[0].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Buttons/Option Blue Resized", typeof(Sprite)) as Sprite;
		init();
    		Update_Menus_Breakdown();
    		init();
    }
    void Set_Current_Menu_2(){
    	Current_Menu_1 = Selected_Menu_Title; 
    	Current_Menu_2 = "";
    	Debug.Log(Current_Menu_1);
    	Current_Menu = 2;								
		List_Main_Menu_1_Container = List_Main_Menu_2_Container;
		List_Main_Menu_1_Container_Images = List_Main_Menu_2_Container_Images;

		for(var i = 0; i < List_Result_1.Count;i++){
			List_Result_1[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Buttons/Menu 2", typeof(Sprite)) as Sprite;
			List_Result_2[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Buttons/Menu 3", typeof(Sprite)) as Sprite;
			
		}
		List_Result_1[0].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Buttons/Option Blue Resized", typeof(Sprite)) as Sprite;
		init();
    		Update_Menus_Breakdown();
    		init();
    }
    void Set_Current_Menu_3(){
    	Current_Menu = 3;		    	
    	Current_Menu_2 = Selected_Menu_Title;
		for(var i = 0; i < List_Result_1.Count;i++){
			List_Result_1[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Buttons/Menu 3", typeof(Sprite)) as Sprite;
			List_Result_2[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Buttons/Menu 4", typeof(Sprite)) as Sprite;			
		}
		List_Result_1[0].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Buttons/Option Blue Resized", typeof(Sprite)) as Sprite;
		init();
    		Update_Menus_Breakdown();
    		init();
    }
    void Down_Menu_1(){
    	string List_Begin = List_Main_Menu_1_Container[0]; 
    	string List_Begin_Images = List_Main_Menu_1_Container_Images[0]; 
    	for(var i = 0; i < List_Main_Menu_1_Container.Count; i++){
    		if(i == List_Main_Menu_1_Container.Count - 1){
    			List_Main_Menu_1_Container[i] = List_Begin;	
    			List_Main_Menu_1_Container_Images[i] = List_Begin_Images;	
    		}else{
    			List_Main_Menu_1_Container[i] = List_Main_Menu_1_Container[i+1];
    			List_Main_Menu_1_Container_Images[i] = List_Main_Menu_1_Container_Images[i+1];
    		}

    	}
    	
    	
    		init();
    		Update_Menus_Breakdown();
    }
    void Up_Menu_1(){
    	string List_Begin = List_Main_Menu_1_Container[List_Main_Menu_1_Container.Count - 1]; 
    	string List_Begin_Images = List_Main_Menu_1_Container_Images[List_Main_Menu_1_Container_Images.Count - 1]; 
    	for(var i = List_Main_Menu_1_Container.Count - 1; i >= 0; i--){
    		if(i == 0){
    			List_Main_Menu_1_Container[i] = List_Begin;	
    			List_Main_Menu_1_Container_Images[i] = List_Begin_Images;	
    		}else{
    			List_Main_Menu_1_Container[i] = List_Main_Menu_1_Container[i-1];
    			List_Main_Menu_1_Container_Images[i] = List_Main_Menu_1_Container_Images[i-1];
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

            //Debug.Log(hit.collider.gameObject.name);
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
}
