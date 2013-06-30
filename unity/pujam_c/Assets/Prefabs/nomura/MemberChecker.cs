using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PhotonView))]
public class MemberChecker : Photon.MonoBehaviour {
	public GUISkin guiSkin;
	public bool gameStart = false;
	public bool gameEnd   = false;
		
	// Use this for initialization
	void Start(){
		
	}
	
	// Update is called once per frame
	void Update(){
		int memberCount;
		
		memberCount = PhotonNetwork.playerList.Length;
		//Debug.Log("member count : " + memberCount);
		
		if( memberCount >= 2 ){
			Debug.LogError("Game Start!");
			gameStart = true;
			enabled = false;
		}
		else{
			//Debug.Log("Waiting game.");
		}
	}
	
	void OnGUI () {
		int sw = Screen.width;
		int sh = Screen.height;
		
		GUI.skin = guiSkin;
		
		if( gameStart ){
			GUI.Label(new Rect(15, Screen.height/2-25, 100, 50), "GAME START!!");
			StartCoroutine(WaitTime());
			GameObject.FindWithTag("GameController").SendMessage("addPoint", "droid");
			GameObject.FindWithTag("GameController").SendMessage("startTimeCount");
		}
	}
	
	IEnumerator WaitTime () {
    	yield return new WaitForSeconds(5);
	}
}
