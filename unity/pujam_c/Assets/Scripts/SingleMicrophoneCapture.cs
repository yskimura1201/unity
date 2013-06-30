using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
//[RequireComponent("AudioSource")] // Other way

public class SingleMicrophoneCapture : MonoBehaviour
{
	//A boolean that flags whether there's a connected microphone
	private bool micConnected = false;

	//The maximum and minimum available recording frequencies
	private int minFreq;
	private int maxFreq;

	//A handle to the attached AudioSource
	private AudioSource goAudioSource;
	
	private PhotonView myPhotonView;
	public GameObject[] targets;
	//Use this for initialization
	void Start() 
	{
		//Check if there is at least one microphone connected
		if(Microphone.devices.Length <= 0)
		{
			//Throw a warning message at the console if there isn't
			Debug.LogWarning("Microphone not connected!");
		}
		else //At least one microphone is present
		{
			//Set 'micConnected' to true
			micConnected = true;

			//Get the default microphone recording capabilities
			Microphone.GetDeviceCaps(null, out minFreq, out maxFreq);

			//According to the documentation, if minFreq and maxFreq are zero, the microphone supports any frequency...
			if(minFreq == 0 && maxFreq == 0)
			{
				//...meaning 44100 Hz can be used as the recording sampling rate
				maxFreq = 44100;
			}

			//Get the attached AudioSource component
			goAudioSource = this.GetComponent<AudioSource>();
		}
	}
	
	
	void OnGUI() 
	{
		//If there is a microphone
		if(micConnected)
		{
			Debug.Log ("mic start");
			//If the audio from any microphone isn't being captured
			if(!Microphone.IsRecording(null))
			{
				//Case the 'Record' button gets pressed
				if(GUI.Button(new Rect(15, Screen.height-120, 100, 50), "mic Shout!"))
				{
					//Start recording and store the audio captured from the microphone at the AudioClip in the AudioSource
					goAudioSource.clip = Microphone.Start(null, true, 30, maxFreq);
				}
			}
			else //Recording is in progress
			{
				//Case the 'Stop and Play' button gets pressed
				if(GUI.Button(new Rect(15, Screen.height-120, 100, 50), "Show Summon!"))
				{
					Debug.Log ("mic end");
					Microphone.End(null); //Stop the audio recording
					goAudioSource.Play(); //Playback the recorded audio
					//Debug.Log (goAudioSource.clip.length);
					
					GameObject target = GameObject.FindGameObjectWithTag("Doroid");
					
					//Debug.Log (target);
					float x = 0;
					x = target.transform.position.x;
					
					float y = 0;
					y = target.transform.position.y;
					
					float z = 0;
					z = target.transform.position.z-5;
					/*
					z = Random.value*15;
					if(Random.value%2==1){
						z = -1 * z;
					}
					*/
					//Debug.Log (x);
					//Debug.Log (z);
					GameObject block    = PhotonNetwork.Instantiate("3Dmodel/primitives.v1/box", new Vector3(x,y,z), Quaternion.identity, 0);
					block.transform.localScale = new Vector3(2,2,2);
					//Debug.Log (goAudioSource.clip.length/15);
					//block.transform.localScale = new Vector3((goAudioSource.clip.length/15),(goAudioSource.clip.length/15),(goAudioSource.clip.length/15));
					//block.transform.localScale = new Vector3(10.0f,1.0f,1.0f);
					myPhotonView = block.GetComponent<PhotonView>();
					//block.transform.Translate(0, -6.0f, 0);
				}
			}
		}
		else // No microphone
		{
			Debug.Log ("no mic");
			//Print a red "Microphone not connected!" message at the center of the screen
			GUI.contentColor = Color.red;
			GUI.Label(new Rect(15, Screen.height/2-25, 100, 50), "Mic not connected!");
		}

	}
}