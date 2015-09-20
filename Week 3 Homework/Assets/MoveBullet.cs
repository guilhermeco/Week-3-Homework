using UnityEngine;
using System.Collections;

public class MoveBullet : MonoBehaviour {

	public float speed = 1f;
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
	}
}
