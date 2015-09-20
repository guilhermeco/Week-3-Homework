using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed = 10;
	
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + new Vector3 (Input.GetAxis ("Horizontal") * speed * Time.deltaTime, 0, 0);
	}
}
