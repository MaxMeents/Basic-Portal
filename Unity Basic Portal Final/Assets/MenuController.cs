using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using GG.Infrastructure.Utils.Swipe;

public class MenuController : MonoBehaviour
{
	public List<string> List_Main_Menu_1 = new List<string>();
	public List<string> List_Main_Menu_2 = new List<string>();
	public List<string> List_Main_Menu_3 = new List<string>();
	public List<string> List_Written_Out_1 = new List<string>();
	public List<string> List_Written_Out_2 = new List<string>();
	public List<GameObject> List_Result_1 = new List<GameObject>();
	public List<GameObject> List_Result_1_Text_Gameobject = new List<GameObject>();
	public List<GameObject> List_Result_2 = new List<GameObject>();
	public List<GameObject> List_Result_2_Text_Gameobject = new List<GameObject>();
	public int Current_Menu = 1;
    // Start is called before the first frame update
    void Start()
    {
    	List_Main_Menu_1.Add("Menu 1 item 1");
    	List_Main_Menu_1.Add("Menu 1 item 2");
    	List_Main_Menu_1.Add("Menu 1 item 3");
    	List_Main_Menu_1.Add("Menu 1 item 4");
    	List_Main_Menu_1.Add("Menu 1 item 5");
    	List_Main_Menu_1.Add("Menu 1 item 6");
    	List_Main_Menu_1.Add("Menu 1 item 7");
    	List_Main_Menu_1.Add("Menu 1 item 8");
    	List_Main_Menu_1.Add("Menu 1 item 9");
    	List_Main_Menu_1.Add("Menu 1 item 10");
    	List_Main_Menu_2.Add("Menu 2 item 1");
		List_Main_Menu_2.Add("Menu 2 item 2");
		List_Main_Menu_2.Add("Menu 2 item 3");
		List_Main_Menu_2.Add("Menu 2 item 4");
		List_Main_Menu_2.Add("Menu 2 item 5");
		List_Main_Menu_2.Add("Menu 2 item 6");
		List_Main_Menu_2.Add("Menu 2 item 7");
		List_Main_Menu_2.Add("Menu 2 item 8");
		List_Main_Menu_2.Add("Menu 2 item 9");
		List_Main_Menu_2.Add("Menu 2 item 10");
    	List_Written_Out_1.Add("1");
    	List_Written_Out_1.Add("1.1");
    	List_Written_Out_1.Add("1.2");
    	List_Written_Out_1.Add("1.3");
    	List_Written_Out_1.Add("1.4");
    	List_Written_Out_1.Add("1.5");
    	List_Written_Out_1.Add("1.6");
    	List_Written_Out_2.Add("2");
    	//Two level Trigger Needed
    	List_Written_Out_2.Add("2.1");
    	List_Written_Out_2.Add("2.2");
    	List_Written_Out_2.Add("2.3");
    	List_Written_Out_2.Add("2.4");
    	List_Written_Out_2.Add("2.5");
    	List_Written_Out_2.Add("2.6");


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
        
    	init();
    }
    void init(){
    	var a = 0;
	    for(var i2 = 0; i2 < 5; i2++){	
	    	for(var i = 0; i < 3; i++){
	    		if(i2 <= 2){
	    			List_Result_1_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1[i2];
	    		}
	    		if(i2 == 3){
	    			List_Result_1_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1[List_Main_Menu_1.Count - 2];
	    		}
	    		if(i2 == 4){
	    			List_Result_1_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_1[List_Main_Menu_1.Count - 1];
	    		}
	    		
	    		a++;
	    	}
	    }
	    a = 0;
	    for(var i2 = 0; i2 < 5; i2++){	
	    	for(var i = 0; i < 3; i++){
	    		if(i2 <= 2){
	    			List_Result_2_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_2[i2];
	    		}
	    		if(i2 == 3){
	    			List_Result_2_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_2[List_Main_Menu_2.Count - 2];
	    		}
	    		if(i2 == 4){
	    			List_Result_2_Text_Gameobject[a].GetComponent<UnityEngine.UI.Text>().text = ""+List_Main_Menu_2[List_Main_Menu_2.Count - 1];
	    		}
	    		
	    		a++;
	    	}
	    }
    }

    // Update is called once per frame
    void Update()
    {

    	if(Current_Menu == 1){
    		if(List_Main_Menu_1[0] == "Menu 1 item 1"){
        		List_Main_Menu_2 = List_Written_Out_1;
        		init();
        	}
        	if(List_Main_Menu_1[0] == "Menu 1 item 2"){
        		List_Main_Menu_2 = List_Written_Out_2;
        		init();
        	}
    		if(Input.GetKeyDown(KeyCode.RightArrow)){
	        	//Replace List_Main_Menu_1.Count with a Current List variable and rearange that
	        	string List_Begin = List_Main_Menu_1[0]; 
	        	for(var i = 0; i < List_Main_Menu_1.Count; i++){
	        		if(i == List_Main_Menu_1.Count - 1){
	        			List_Main_Menu_1[i] = List_Begin;	
	        		}else{
	        			List_Main_Menu_1[i] = List_Main_Menu_1[i+1];
	        		}

	        	}
	        		init();
	        }
	        if(Input.GetKeyDown(KeyCode.LeftArrow)){
				
		        
		        	//Replace List_Main_Menu_1.Count with a Current List variable and rearange that
		         	string List_Begin = List_Main_Menu_1[List_Main_Menu_1.Count - 1]; 
		        	for(var i = List_Main_Menu_1.Count - 1; i >= 0; i--){
		        		if(i == 0){
		        			List_Main_Menu_1[i] = List_Begin;	
		        		}else{
		        			List_Main_Menu_1[i] = List_Main_Menu_1[i-1];
		        		}

		        	}
		        	init();
		        }
	    }
	    if(Current_Menu == 2){
    		if(Input.GetKeyDown(KeyCode.RightArrow)){
	        	//Replace List_Main_Menu_2.Count with a Current List variable and rearange that
	        	string List_Begin = List_Main_Menu_2[0]; 
	        	for(var i = 0; i < List_Main_Menu_2.Count; i++){
	        		if(i == List_Main_Menu_2.Count - 1){
	        			List_Main_Menu_2[i] = List_Begin;	
	        		}else{
	        			List_Main_Menu_2[i] = List_Main_Menu_2[i+1];
	        		}

	        	}
	        		init();
	        }
	        if(Input.GetKeyDown(KeyCode.LeftArrow)){
				
		        
		        	//Replace List_Main_Menu_2.Count with a Current List variable and rearange that
		         	string List_Begin = List_Main_Menu_2[List_Main_Menu_2.Count - 1]; 
		        	for(var i = List_Main_Menu_2.Count - 1; i >= 0; i--){
		        		if(i == 0){
		        			List_Main_Menu_2[i] = List_Begin;	
		        		}else{
		        			List_Main_Menu_2[i] = List_Main_Menu_2[i-1];
		        		}

		        	}
		        	init();
		        }
	    }
        
        if(Input.GetKeyDown(KeyCode.DownArrow)){
        	if(Current_Menu == 1){
        		Current_Menu = 2;
        	}
        	if(List_Main_Menu_1[0] == "Menu 1 item 1"){
        		List_Main_Menu_2 = List_Written_Out_1;
        		init();
        	}
        	if(List_Main_Menu_1[0] == "Menu 1 item 2"){
        		List_Main_Menu_2 = List_Written_Out_2;
        		init();
        	}
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
        	if(Current_Menu == 2){
        		Current_Menu = 1;
        	}
        	if(List_Main_Menu_1[0] == "Menu 1 item 1"){
        		
        	}
        }
    }
}
