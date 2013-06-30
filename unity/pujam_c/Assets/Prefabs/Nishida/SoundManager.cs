using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
	
	private string cueSeetName = "CueSheet_pujamC";
	private CriAtomSource atomSourceSe;
	private CriAtomSource atomSourceBgm;
	
	// Use this for initialization
	void Start () {
		atomSourceSe = gameObject.AddComponent<CriAtomSource>();
		atomSourceSe.cueSheet = cueSeetName;

		atomSourceBgm = gameObject.AddComponent<CriAtomSource>();
		atomSourceBgm.cueSheet = cueSeetName;
		
		PlayBgm("BGM");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void PlaySe(string cueName){
		atomSourceSe.volume = 1;
		atomSourceSe.Play(cueName);
	}

	public void PlayBgm(string cueName){
		atomSourceBgm.volume = 1;
		atomSourceBgm.Play(cueName);
	}

}
