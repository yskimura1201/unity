using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PhotonView))]
[RequireComponent(typeof(Rigidbody))]

public class PhysicsAffecter : Photon.MonoBehaviour {
	
	public float pushPower = 3.0F;
		
	void OnControllerColliderHit(ControllerColliderHit hit) {
		
		if(photonView.isMine){
			
			GameObject other = hit.gameObject;
			CharacterController controller = GetComponent<CharacterController>();
		
	    	if (other.tag == "Hell") {
				playSe("fall");
				reset();
			}
		
	    	if (other.tag == "Doroid") {
//				Debug.LogWarning("Doroid");
			}
		}
		
		
		
        Rigidbody body = hit.collider.attachedRigidbody;
		
        if (body == null || body.isKinematic)
            return;
        
        Vector3 pushDir = new Vector3(hit.moveDirection.x, hit.moveDirection.y, hit.moveDirection.z).normalized;
        pushDir.x *= -Physics.gravity.x;
        pushDir.y *= -Physics.gravity.y;
        pushDir.z *= -Physics.gravity.z;
        body.AddForceAtPosition(pushDir * pushPower, transform.position);
        //body.velocity = pushDir * pushPower;
	}
	
	void playSe( string name ){
		GameObject so = GameObject.Find("SoundObject");
		SoundManager sm = so.GetComponent<SoundManager>();
		sm.PlaySe(name);
	}
	
	void reset ()
	{
		GameObject target = GameObject.FindGameObjectWithTag("Doroid");
		target.transform.position = new Vector3(0f,10.0f,0);
		
		GameObject.FindWithTag("GameController").SendMessage("addPoint", PhotonNetwork.player.ID);
	}
	
}
