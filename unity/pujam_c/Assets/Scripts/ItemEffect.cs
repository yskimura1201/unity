using UnityEngine;
using System.Collections;

public class ItemEffect : MonoBehaviour {

	public float timer;
	public int waitingTime;

	void Update(){
		timer += Time.deltaTime;
		if(timer > waitingTime){
			transform.localScale = new Vector3(1,1,1);
			timer = 0;
		}
	}
	
	void JumboChange(){
		transform.localScale = new Vector3(3,3,3);
		timer = 0;
	}
}
