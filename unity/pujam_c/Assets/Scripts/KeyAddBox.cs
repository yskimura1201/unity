using UnityEngine;
using System.Collections;

public class KeyAddBox : MonoBehaviour
{
	
	private PhotonView myPhotonView;
	public GameObject[] targets;
	//private int locks = 5;
	private int tmp;
	// Use this for initialization
	void Start () {
		tmp = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(tmp==0){
			 if (Input.GetKey(KeyCode.E)) {
						
				 		GameObject target = GameObject.FindGameObjectWithTag("Doroid");
						
						//Debug.Log (target);
						float x = 0;
						x = target.transform.position.x;
						
						float y = 0;
						y = target.transform.position.y;
						
						float z = 0;
						z = target.transform.position.z-5;
						
						GameObject block    = PhotonNetwork.Instantiate("3Dmodel/primitives.v1/box", new Vector3(x,y,z+8), Quaternion.identity, 0);
						
						block.transform.localScale = new Vector3(2,2,2);
						//Debug.Log (goAudioSource.clip.length/15);
						//block.transform.localScale = new Vector3((goAudioSource.clip.length/15),(goAudioSource.clip.length/15),(goAudioSource.clip.length/15));
						//block.transform.localScale = new Vector3(10.0f,1.0f,1.0f);
						myPhotonView = block.GetComponent<PhotonView>();
						//locks = locks-1;
						tmp=100;	
			}
			
		}else{
					tmp--;
		}
	}
}