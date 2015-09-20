using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject expPill;
	private bool canShoot;
	
	// Use this for initialization
	void Start () {
		canShoot = true;
		
	}

	void spawnAPill() {
		Instantiate (expPill, transform.position, transform.rotation);
		canShoot = false;
		Invoke("turnOnShooter", .2f);
		
	}
	
	void turnOnShooter () {
		canShoot = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			if (canShoot == true) {	
				spawnAPill();
				
			}
		}
	}
}
