using UnityEngine;
using System.Collections;

public class PlaySoundWIthKey : MonoBehaviour {
	
	  private CriAtomSource atomSource;

	// Use this for initialization
	void Start () {
		atomSource = GetComponent< CriAtomSource >();
	}
	
	// Update is called once per frame
	void Update () {
		 if (Input.GetKey(KeyCode.Space)) {
			 atomSource.Play();	
		}
	}
}