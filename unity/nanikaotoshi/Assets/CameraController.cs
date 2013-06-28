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
		}else if(positionY == 6){
			this.transform.position = new Vector3(1, 5, -5);
			this.transform.rotation = Quaternion.Euler(386, -15, -7);
		}else if(positionY == 5){
			this.transform.position = new Vector3(-2, 0, -4);
			this.transform.rotation = Quaternion.Euler(331, 23, 14);
		}else if(positionY ==  0){
			this.transform.position = new Vector3(0, 7, 2);
			this.transform.rotation = Quaternion.Euler(409, -178, 1);
		}else{
			this.transform.position = new Vector3(0, 1, -9);
			this.transform.rotation = Quaternion.Euler(340, 0, 0);
		}
	}
}
