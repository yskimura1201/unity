using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
 
	private string cueSeetName = "CueSheet_pujamC";
	private CriAtomSource atomSourceSe;

	// Use this for initialization
    void GoToGame () {
		atomSourceSe = gameObject.AddComponent<CriAtomSource>();
		atomSourceSe.cueSheet = cueSeetName;
		atomSourceSe.volume = 1;
		atomSourceSe.Play("SE-pipipi");
		
		Application.LoadLevel("GameMain");
	}

}
