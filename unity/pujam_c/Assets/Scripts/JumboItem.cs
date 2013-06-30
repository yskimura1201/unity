using UnityEngine;
using System.Collections;

public class JumboItem : MonoBehaviour {
	
	void OnTriggerEnter(Collider other){
		
		if(other.gameObject.tag == "Doroid"){
			
			other.gameObject.SendMessage("JumboChange");

			other.SendMessage("CoinGenerate", this.gameObject.transform.position);
			playSe("SE-jump2");
			
			Destroy(this.gameObject);
		}
	}
	
	void playSe( string name ){
		GameObject so = GameObject.Find("SoundObject");
		SoundManager sm = so.GetComponent<SoundManager>();
		sm.PlaySe(name);
	}
	
}
