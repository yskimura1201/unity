using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
	public Transform prefab;
	public Transform prefab2;
	
	// Update is called once per frame
	void Update ()
	{
     	if (Input.GetButtonDown ("Fire1"))
		{
			//Random rand = new Random();
			int ires = Random.Range (1, 5);
			Vector3 offset = new Vector3 (0 , 4, 0);
			if(ires == 1){
				Instantiate (prefab2, transform.position + offset, transform.rotation);
			}else{
				Instantiate (prefab, transform.position + offset, transform.rotation);
			}
			Score.score--;
		}       
	}
}