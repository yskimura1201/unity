using UnityEngine;
using System.Collections;

public class Remover : MonoBehaviour
{
   // 当たり判定のイベント
   void OnTriggerEnter (Collider collider)
   {
 	// オブジェクトの消去
    	Destroy (collider.gameObject);
   }
}