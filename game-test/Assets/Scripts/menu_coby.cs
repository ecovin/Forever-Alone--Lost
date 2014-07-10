using UnityEngine;
using System.Collections;

public class menu_coby : MonoBehaviour{

	//public Texture2D background;
	public GUISkin my_skin;
	public string my_text = "Default Text";

	private void OnGUI(){

		GUI.skin = my_skin;
		GUILayout.BeginArea(new Rect (50, 50, 400, Screen.width/2));

		GUILayout.BeginHorizontal();
		GUILayout.Label("This is a label");
		if(GUILayout.Button("This is a button")){
			my_text = "You clicked the button!";
		}
		GUILayout.Label(my_text);		
		GUILayout.EndHorizontal();

		GUILayout.EndArea();

		/*
		if(background != null){
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), background);
		}


		GUI.skin = my_skin;

		if(GUI.Button (new Rect((Screen.width/2)-100, (Screen.height/2), 200, 30), "Play Game")){

		}
		*/
	}
}
