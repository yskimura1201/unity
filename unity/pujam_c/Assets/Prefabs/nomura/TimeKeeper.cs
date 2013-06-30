using UnityEngine;
using System.Collections;

public class TimeKeeper : MonoBehaviour {
	public GUISkin guiSkin;
	
	public  bool  startFlg = false;    //開始フラグ
	public  bool  endFlg   = false;    //終了フラグ
	public  float gameLength;  //制限時間
	private float elapsed;     //経過時間
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if( startFlg ){
			elapsed += Time.deltaTime;
		
			if( elapsed >= gameLength ){
				Debug.Log ("Time is over.");
				endFlg = true;
				enabled = false;
			}
		}
	}
	
	void startTimeCount(){
		startFlg = true;
	}
	
	void OnGUI () {
		int sw = Screen.width;
		int sh = Screen.height;
		
		GUI.skin = guiSkin;
		
		if( endFlg ){
			GUI.Label(new Rect(sw/6, sh/3, sw*2/3, sh/3), "GAME END!!");
			
			StartCoroutine(WaitTime(3));
			
			while( !Input.GetButtonDown("Fire1") ){
				StartCoroutine(WaitTime(0));
			}
		}
	}
	
	IEnumerator WaitTime (int time) {
    	yield return new WaitForSeconds(time);
	}
}
