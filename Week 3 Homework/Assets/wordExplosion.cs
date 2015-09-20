using UnityEngine;
using System.Collections;

public class wordExplosion : MonoBehaviour {

	public GameObject Explosion;
	
	void OnDestroy() {
		Debug.Log ("this is dead!");
		Instantiate(Explosion, transform.position, transform.rotation);
	
	}
}
