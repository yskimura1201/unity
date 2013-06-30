using UnityEngine;
using System.Collections;

public class MemberChecker : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int memberCount;
		
		memberCount = PhotonNetwork.playerList.Length;
		Debug.Log("member count : " + memberCount);
		
		if( memberCount >= 2 ){
			BroadcastMessage("Game Start!!");
			Debug.Log("Game Start!");
			
			GameObject.FindWithTag("GameController").SendMessage("startTimeCount");
			enabled = false;
		}
		else{
			BroadcastMessage("Game END!!");
			Debug.Log("Waiting game.");
		}
	}
}
