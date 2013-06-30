using UnityEngine;
using System.Collections;

public class TimeKeeper : MonoBehaviour {
	public  bool  startFlg;    //開始フラグ
	public  float gameLength;  //制限時間
	private float elapsed;     //経過時間
	
	// Use this for initialization
	void Start () {
	    startFlg = false;
	}
	
	// Update is called once per frame
	void Update () {
		if( startFlg ){
			elapsed += Time.deltaTime;
		
			if( elapsed >= gameLength ){
				Debug.Log ("Time is over.");
			
				enabled = false;
			}
		}
	}
	
	void startTimeCount(){
		startFlg = true;
	}
}
