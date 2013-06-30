using UnityEngine;
using System.Collections;

public class TraceCharactor : MonoBehaviour {
	
	public GameObject prefab {get; set;}
	public Vector3 diffVector = new Vector3(0f,20f,0f);
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = prefab.transform.position + diffVector;
	}
	
}
