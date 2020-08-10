using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitTarget : MonoBehaviour {

	public AudioSource bulletHitSound;
	public AudioSource bulletHitSound2;
	//public AudioClip impact;

	// Use this for initialization
	void Start () {
		
	}


	void OnTriggerEnter (Collider other){

		if(other.tag == "bullet"){

			bulletHitSound.Play ();
			//bulletHitSound2.Play ();
			//bulletHitSound.PlayOneShot(impact,0.7f);
			Destroy(GameObject.FindGameObjectWithTag("bullet"),0);
		}

	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
