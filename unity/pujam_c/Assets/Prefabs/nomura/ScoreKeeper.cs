using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PhotonView))]
public class ScoreKeeper : Photon.MonoBehaviour {
	public GUISkin guiSkin;
	
	[HideInInspector] public int droidPoint = 0;
	[HideInInspector] public int meraiPoint = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void addPoint(string team){
		if( team == "droid" ){
			droidPoint += 1;
		}
		
		if( team == "merai" ){
			meraiPoint += 1;
		}
	}
	
	void OnGUI () {
		int sw = Screen.width;
		int sh = Screen.height;
		string droid_score = "DROID : " + droidPoint;
		string merai_score = "MERAI : " + meraiPoint;
		
		
		GUI.skin = guiSkin;
		
		GUI.Label(new Rect(0, 50, sw / 2, sh / 4), droid_score);
		GUI.Label(new Rect(0, 70, sw / 2, sh / 4), merai_score);
	}
}
