using UnityEngine;
using System.Collections;

public class Remover2 : MonoBehaviour
{
   void OnTriggerEnter (Collider collider)
   {
    	Destroy (collider.gameObject);
    	Score.score += 3;
   }
}