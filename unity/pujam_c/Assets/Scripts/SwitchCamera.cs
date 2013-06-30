using UnityEngine;
using System.Collections;

public class SwitchCamera : MonoBehaviour {
	
	Camera[] cameras_ = new Camera[2];
	private bool cameraFlg = true;

	void Start () {
		cameras_[0] = GameObject.Find("Main Camera").GetComponent<Camera>();
        cameras_[1] = GameObject.Find("Sub Camera").GetComponent<Camera>();
        cameras_[0].enabled = true;
        cameras_[1].enabled =  true;
	}

	void SwitchingCamera () {
		Debug.Log("Click");
		if(cameraFlg){
			cameras_[0].transform.position =  new Vector3(0,20,0);
			cameras_[0].transform. rotation =  Quaternion.Euler(90, 0, 0);
			cameras_[1].enabled =  false;
			cameraFlg = false;
		}else{
			cameras_[0].enabled = true;
			cameraFlg = true;
        }
	}
}
