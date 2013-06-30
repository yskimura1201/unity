using UnityEngine;
using System.Collections;

public class SwitchCamera : MonoBehaviour {
	
	public GameObject[] targets;
	Camera[] cameras_ = new Camera[2];
	private bool cameraFlg = true;

	void Start () {
		cameras_[0] = GameObject.Find("Main Camera").GetComponent<Camera>();
        cameras_[0].enabled = true;
	}

	void SwitchingCamera () {
		Debug.Log("Click");
		targets = GameObject.FindGameObjectsWithTag("Doroid");
		
		if(cameraFlg){
			foreach(GameObject target in targets){
				target.SendMessage("chkRejectCamera"); 
			}
			cameras_[0].transform.position =  new Vector3(0,20,0);
			cameras_[0].transform. rotation =  Quaternion.Euler(89, 0, 0);
			cameraFlg = false;
		}else{
			foreach(GameObject target in targets){
				target.SendMessage("chkAddCamera"); 
			}
			cameraFlg =  true;
        }
	}
}
