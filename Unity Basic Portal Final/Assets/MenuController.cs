using System.Collections;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using GG.Infrastructure.Utils.Swipe;

public class MenuController : MonoBehaviour
{
	public string deletethis = "new delete";
	public List<string> List_Main_Menu_1_Container = new List<string>();
	public List<string> List_Main_Menu_2_Container = new List<string>();
	public List<string> List_Main_Menu_3_Container = new List<string>();
	List<List<string>> Lists_Written_Out = new List<List<string>>();
	List<List<string>> Lists_Written_Out_Saved = new List<List<string>>();
	List<List<string>> Lists_Written_Out_Info = new List<List<string>>();
	public List<string> List_Written_Out_1 = new List<string>();
	public List<string> List_Written_Out_1_Info = new List<string>();
	public List<string> List_Written_Out_2 = new List<string>();
	public List<string> List_Written_Out_2_Info = new List<string>();
	public List<string> List_Written_Out_3 = new List<string>();
	public List<string> List_Written_Out_3_Info = new List<string>();
	public List<string> List_Written_Out_4 = new List<string>();
	public List<string> List_Written_Out_4_Info = new List<string>();
	public List<string> List_Menu_Blank_Strings = new List<string>();
	public List<GameObject> List_Result_1 = new List<GameObject>();
	public List<GameObject> List_Result_1_Text_Gameobject = new List<GameObject>();
	public List<GameObject> List_Result_2 = new List<GameObject>();
	public List<GameObject> List_Result_2_Text_Gameobject = new List<GameObject>();
	public List<GameObject> List_Menus_Breakdown = new List<GameObject>();
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
    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (0)/Text Main"));
    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (0)/Text Shadow 1"));
    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (0)/Text Shadow 2"));
    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (1)"));
    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (1)/Text Main"));
    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (1)/Text Shadow 1"));
    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (1)/Text Shadow 2"));
    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (2)"));
    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (2)/Text Main"));
    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (2)/Text Shadow 1"));
    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (2)/Text Shadow 2"));
    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (3)"));
    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (3)/Text Main"));
    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (3)/Text Shadow 1"));
    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (3)/Text Shadow 2"));
    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (4)"));
    	List_Menus_Breakdown_Text.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (4)/Text Main"));
    	List_Menus_Breakdown_Text_Shadow_1.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (4)/Text Shadow 1"));
    	List_Menus_Breakdown_Text_Shadow_2.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (4)/Text Shadow 2"));
    	List_Menus_Breakdown.Add(GameObject.Find("Menus Breakdown/Menus Breakdown (5)"));
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
		List_Main_Menu_3_Container.Add("");
		List_Main_Menu_3_Container.Add("");
		List_Main_Menu_3_Container.Add("");
		List_Main_Menu_3_Container.Add("");
		List_Main_Menu_3_Container.Add("");
		List_Main_Menu_3_Container.Add("");
		List_Main_Menu_3_Container.Add("");
		List_Main_Menu_3_Container.Add("");
		List_Main_Menu_3_Container.Add("");
		List_Main_Menu_3_Container.Add("");
		List_Written_Out_1_Info.Add("Main Menu");
		List_Written_Out_1_Info.Add("Main Menu");
				
		List_Written_Out_2_Info.Add("Main Menu");
		List_Written_Out_2_Info.Add("Play Game");
		
		
		List_Written_Out_4_Info.Add("Play Game");
		List_Written_Out_4_Info.Add("Mine");
		
		List_Written_Out_3_Info.Add("Play Game");
		List_Written_Out_3_Info.Add("Forge");
		
		List_Written_Out_4.Add("Area 1");
		List_Written_Out_4.Add("Area 2");
		List_Written_Out_4.Add("Area 3");
		List_Written_Out_4.Add("Area 4");
		List_Written_Out_4.Add("Area 5");
		List_Written_Out_4.Add("Area 6");

		List_Written_Out_2.Add("Mine");
		List_Written_Out_2.Add("Farm");
		List_Written_Out_2.Add("Fight");
		List_Written_Out_2.Add("Gather");
		List_Written_Out_2.Add("Alchemy");
		List_Written_Out_2.Add("Forge");
		
		
		
		List_Written_Out_3.Add("Make Bars");
		List_Written_Out_3.Add("Swords");
		List_Written_Out_3.Add("Chest Plate Armor");
		List_Written_Out_3.Add("Waist Amor");
		List_Written_Out_3.Add("Leg Armor");
		List_Written_Out_3.Add("Wrist Armor");
		List_Written_Out_3.Add("Earrings");
		List_Written_Out_3.Add("Necklaces");
		List_Written_Out_3.Add("Rings");
		List_Written_Out_2.Add("Tailor");

		List_Written_Out_1.Add("Play Game");
    	List_Written_Out_1.Add("Search the Web");
    	List_Written_Out_1.Add("Save");
    	List_Written_Out_1.Add("Load");
    	List_Written_Out_1.Add("Options");
    	List_Written_Out_1.Add("About");    	
    	Lists_Written_Out.Add(List_Written_Out_1);
    	Lists_Written_Out.Add(List_Written_Out_2);
    	Lists_Written_Out.Add(List_Written_Out_3);
    	Lists_Written_Out.Add(List_Written_Out_4);

    	Lists_Written_Out_Info.Add(List_Written_Out_1_Info);
    	Lists_Written_Out_Info.Add(List_Written_Out_2_Info);
    	Lists_Written_Out_Info.Add(List_Written_Out_3_Info);
    	Lists_Written_Out_Info.Add(List_Written_Out_4_Info);

    	Lists_Written_Out_Saved = Lists_Written_Out;
    	


    	List_Result_1.Add(GameObject.Find("Result 1/Button Main (3)"));
    	List_Result_1.Add(GameObject.Find("Result 1/Button Main (4)"));
    	List_Result_1.Add(GameObject.Find("Result 1/Button Main (5)"));
    	List_Result_1.Add(GameObject.Find("Result 1/Button Main (1)"));
    	List_Result_1.Add(GameObject.Find("Result 1/Button Main (2)"));
        
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
    	Selected_Menu_Title = List_Result_1_Text_Gameobject[0].GetComponent<UnityEngine.UI.Text>().text;
    	if(Current_Menu == 1){
    		List_Menus_Breakdown[0].SetActive(true);
    		List_Menus_Breakdown[1].SetActive(false);
    		List_Menus_Breakdown[2].SetActive(false);
    		List_Menus_Breakdown[3].SetActive(false);
    		List_Menus_Breakdown[4].SetActive(false);
    		List_Menus_Breakdown[5].SetActive(false);
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
    		List_Menus_Breakdown_Text[2].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
    		List_Menus_Breakdown_Text_Shadow_1[2].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
    		List_Menus_Breakdown_Text_Shadow_2[2].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[0];
    	}
    	
    	if(Current_Menu == 1){
    		List_Main_Menu_1_Container = List_Written_Out_1;    		
    	} //Should be Good...
    	/*
    	if(Current_Menu_1 == "Play Game"){
    		List_Main_Menu_1_Container = List_Written_Out_2;    		
    	}
    	if(Current_Menu_1 == "Play Game" && Current_Menu == 1){
    		List_Main_Menu_1_Container = List_Written_Out_1;    		
    	}
    	if(Current_Menu == 1 && Selected_Menu_Title == "Play Game"){
    		List_Main_Menu_2_Container = List_Written_Out_2;    		
    	}
    	if(Current_Menu_2 == "Forge"){
    		List_Main_Menu_2_Container = List_Written_Out_3;    		
    	}
    	*/
    	for(var NumOfList = 0;NumOfList < Lists_Written_Out_Info.Count;NumOfList++){
			if(Selected_Menu_Title != Lists_Written_Out_Info[NumOfList][1]){
    			List_Main_Menu_2_Container = List_Menu_Blank_Strings;    			
    		}
    		if(Current_Menu_1 == Lists_Written_Out_Info[NumOfList][1]){ //Main Menu //Play Game
    			List_Main_Menu_1_Container = Lists_Written_Out[NumOfList];
    			
    		}
    		if(Current_Menu_2 == Lists_Written_Out_Info[NumOfList][1]){ //Play Game //Forge  			    		
    			List_Main_Menu_1_Container = Lists_Written_Out[NumOfList];    			
    			
    		}
    	}
    	for(var NumOfList = 0;NumOfList < Lists_Written_Out_Info.Count;NumOfList++){
    		
    		if(Selected_Menu_Title == Lists_Written_Out_Info[NumOfList][1]){
    			List_Main_Menu_2_Container = Lists_Written_Out[NumOfList];    			
    			
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
	    		}
	    		if(i2 == 3){
	    			List_Result_1_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[List_Main_Menu_1_Container.Count - 2];
	    		}
	    		if(i2 == 4){
	    			List_Result_1_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1_Container[List_Main_Menu_1_Container.Count - 1];
	    		}
	    		
	    		a++;
	    	}
	    }
	    a = 0;
	    for(var i2 = 0; i2 < 5; i2++){	
	    	for(var i = 0; i < 3; i++){
	    		if(i2 <= 2){
	    			List_Result_2_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_2_Container[i2];
	    		}
	    		if(i2 == 3){
	    			List_Result_2_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_2_Container[List_Main_Menu_2_Container.Count - 2];
	    		}
	    		if(i2 == 4){
	    			List_Result_2_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_2_Container[List_Main_Menu_2_Container.Count - 1];
	    		}
	    		
	    		a++;
	    	}
	    }
	    a = 0;
	    for(var i2 = 0; i2 < 5; i2++){	
	    	for(var i = 0; i < 3; i++){
		 	   if(List_Result_2_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text == ""){
		 	   		List_Result_2[i2].SetActive(false);
			    }else{
			    	List_Result_2[i2].SetActive(true);
			    }
			    a++;
			}
		}
		//
    }

    // Update is called once per frame
    void Update()
    {
    	Update_Menus_Breakdown();    	
    	if(Current_Menu == 1){    		
    		if(Input.GetKeyDown(KeyCode.DownArrow)){
	        	//Replace List_Main_Menu_1_Container.Count with a Current List variable and rearange that
	        	Down_Menu_1();

	        	Debug.Log(Selected_Menu_Title);
	        	
	        }
	        if(Input.GetKeyDown(KeyCode.UpArrow)){
				
		        
		        	//Replace List_Main_Menu_1_Container.Count with a Current List variable and rearange that
		     	Up_Menu_1();    	

		     	Debug.Log(Selected_Menu_Title);
		     	
		    }
	    }
	    if(Current_Menu == 2){
    		if(Input.GetKeyDown(KeyCode.DownArrow)){
	        	//Replace List_Main_Menu_2_Container.Count with a Current List variable and rearange that
	        	Down_Menu_1();
	        }
	        if(Input.GetKeyDown(KeyCode.UpArrow)){
				
		        
		        	Up_Menu_1();
		    }
	    }
        if(Current_Menu == 3){
    		if(Input.GetKeyDown(KeyCode.DownArrow)){
	        	//Replace List_Main_Menu_2_Container.Count with a Current List variable and rearange that
	        	Down_Menu_1();
	        }
	        if(Input.GetKeyDown(KeyCode.UpArrow)){
				
		        
		        	//Replace List_Main_Menu_2_Container.Count with a Current List variable and rearange that
		    	Up_Menu_1();     	
		    }
	    }
        
        if(Input.GetKeyDown(KeyCode.RightArrow)){
        	if(Current_Menu == 2){
        		
        		Set_Current_Menu_3();
        		
        	}
        	if(Current_Menu == 1){
        		Set_Current_Menu_2();
        	}
        
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
        	if(Current_Menu == 2){
        		Set_Current_Menu_1();
        	}
        	
        	if(Current_Menu == 3){
        		string Current_Menu_1_save = Current_Menu_1;
        		Set_Current_Menu_2();
        		Current_Menu_1 = Current_Menu_1_save;
        	}
        	
        }
    }
    void Set_Current_Menu_1(){
    	Current_Menu = 1;						
    	Current_Menu_1 = "Main Menu";
    	Current_Menu_2 = ""; 
		for(var i = 0; i < List_Result_1.Count;i++){
			List_Result_1[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("35076", typeof(Sprite)) as Sprite;
			List_Result_2[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("17", typeof(Sprite)) as Sprite;
			
		}
		List_Result_1[0].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Option Blue Resized", typeof(Sprite)) as Sprite;
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
		List_Main_Menu_2_Container = List_Main_Menu_3_Container;
		for(var i = 0; i < List_Result_1.Count;i++){
			List_Result_1[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("17", typeof(Sprite)) as Sprite;
			List_Result_2[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("35_1045", typeof(Sprite)) as Sprite;
			
		}
		List_Result_1[0].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Option Blue Resized", typeof(Sprite)) as Sprite;
		init();
    		Update_Menus_Breakdown();
    		init();
    }
    void Set_Current_Menu_3(){
    	Current_Menu = 3;		    	
    	Current_Menu_2 = Selected_Menu_Title;
		for(var i = 0; i < List_Result_1.Count;i++){
			List_Result_1[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("35_1045", typeof(Sprite)) as Sprite;
			List_Result_2[i].GetComponent < SpriteRenderer > ().sprite = Resources.Load("24", typeof(Sprite)) as Sprite;			
		}
		List_Result_1[0].GetComponent < SpriteRenderer > ().sprite = Resources.Load("Option Blue Resized", typeof(Sprite)) as Sprite;
		init();
    		Update_Menus_Breakdown();
    		init();
    }
    void Down_Menu_1(){
    	string List_Begin = List_Main_Menu_1_Container[0]; 
    	for(var i = 0; i < List_Main_Menu_1_Container.Count; i++){
    		if(i == List_Main_Menu_1_Container.Count - 1){
    			List_Main_Menu_1_Container[i] = List_Begin;	
    		}else{
    			List_Main_Menu_1_Container[i] = List_Main_Menu_1_Container[i+1];
    		}

    	}
    	
    	
    		init();
    		Update_Menus_Breakdown();
    }
    void Up_Menu_1(){
    	string List_Begin = List_Main_Menu_1_Container[List_Main_Menu_1_Container.Count - 1]; 
    	for(var i = List_Main_Menu_1_Container.Count - 1; i >= 0; i--){
    		if(i == 0){
    			List_Main_Menu_1_Container[i] = List_Begin;	
    		}else{
    			List_Main_Menu_1_Container[i] = List_Main_Menu_1_Container[i-1];
    		}

    	}
    	
    	init();
    	Update_Menus_Breakdown();
    }
}
