using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
	public Transform prefab;
	public Transform prefab1;
	public Transform prefab2;
	public Transform prefab3;
	
	// Update is called once per frame
	void Update ()
	{
     	if (Input.GetButtonDown ("Fire1"))
		{
			//Random rand = new Random();
			int ires = Random.Range (1, 50);
			Vector3 offset = new Vector3 (0 , 4, 0);
			transform.rotation = Quaternion.AngleAxis( 180, Vector3.up);
			if(ires < 2){
				Instantiate (prefab1, transform.position + offset, transform.rotation);
			}else if(ires < 15){
				Instantiate (prefab2, transform.position + offset, transform.rotation);
			}else if(ires < 30){
				Instantiate (prefab3, transform.position + offset, transform.rotation);
			}else{
				Instantiate (prefab, transform.position + offset, transform.rotation);
			}
			Score.score--;
		}       
	}
}