using UnityEngine;
using System.Collections;

public class ItemGenerator : MonoBehaviour {

	public float timer;
	public int waitingTime;
	 private Vector3 vec ;
	
	public GameObject prefab;
	
	void Update () {
	
		int posix = Random.Range( -5,5);
		int posiz = Random.Range(-5,5);
		timer += Time.deltaTime;
		if(timer > waitingTime){
			Instantiate(prefab, new Vector3(posix, 0f, posiz), Quaternion.Euler(0,0,323));
			timer = 0;
		}
	}
}
