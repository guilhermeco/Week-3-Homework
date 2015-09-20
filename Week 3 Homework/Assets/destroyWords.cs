using UnityEngine;
using System.Collections;

public class destroyWords : MonoBehaviour {

	void OnTriggerEnter(Collider otherObject) {
		if(otherObject.gameObject.tag == "word") {
		Destroy(otherObject.gameObject);
		}
	}
}
