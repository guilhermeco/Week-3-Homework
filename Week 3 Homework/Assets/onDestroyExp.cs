using UnityEngine;
using System.Collections;

public class onDestroyExp : MonoBehaviour {

	void Start () {
		Destroy (gameObject, gameObject.GetComponent<ParticleSystem>().duration);

	}
}
