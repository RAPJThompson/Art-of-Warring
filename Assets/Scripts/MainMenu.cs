using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	private string[] tooltip;
	
	public bool useNGUIScene=false;
	private string loadPara="";
	
	// Use this for initialization
	void Start () {
		tooltip=new string[3];
		tooltip[0]="You're ready for a new game?";
		
		tooltip[1]="Do you really think you're ready to continue our game?";
		
		tooltip[2]="Desperate to get out of here, aren't you";

		
		loadPara=useNGUIScene ? "NGUI" : "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI(){
		
		float startY=Screen.height/2-170;
		float spaceY=50;
		
		GUIContent content=new GUIContent("New\nGame", "1");
		if(GUI.Button(new Rect(Screen.width/2-60, startY+=spaceY, 120, 40), content)){
			Application.LoadLevel("NewGame");
		}
		content=new GUIContent("Load\nGame", "2");
		if(GUI.Button(new Rect(Screen.width/2-60, startY+=spaceY, 120, 40), content)){
			Application.LoadLevel("");
		}
		content=new GUIContent("Exit", "3");
		if(GUI.Button(new Rect(Screen.width/2-60, startY+=spaceY, 120, 40), content)){
			Application.Quit();
		}		
		
		if(GUI.tooltip!=""){
			int ID=int.Parse(GUI.tooltip)-1;
			
			GUIStyle style=new GUIStyle();
			style.alignment=TextAnchor.UpperCenter;
			style.fontStyle=FontStyle.Bold;
			style.normal.textColor=Color.white;
			
			GUI.Label(new Rect(0, Screen.height*0.75f+30, Screen.width, 200), tooltip[ID], style);
		}
	}
}
