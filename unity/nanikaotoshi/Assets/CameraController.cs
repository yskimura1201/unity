using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void  CameraMove() {
		Debug.Log("click");
		float positionY = this.transform.position.y;
		if(positionY == 1){
			this.transform.position = new Vector3(0, 6, -8);
			this.transform.rotation = Quaternion.Euler(20, 0, 0);
		}else{
			this.transform.position = new Vector3(0, 1, -9);
			this.transform.rotation = Quaternion.Euler(340, 0, 0);
		}
	}
}
