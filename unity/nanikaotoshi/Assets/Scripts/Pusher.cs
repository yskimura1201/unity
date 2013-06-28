using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour
{
	private Vector3 origin;
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 offset = new Vector3 (0, 0, Mathf.Sin (Time.time));
		rigidbody.MovePosition (origin + offset);
	}
	
	void Awake ()
	{
		// 起点を保存しておく
		origin = rigidbody.position;
	}
}