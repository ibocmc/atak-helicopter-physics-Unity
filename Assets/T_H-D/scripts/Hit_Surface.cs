using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Surface : MonoBehaviour {


	//public missileMover g_hit;

	public AudioSource s_hit;

	// Use this for initialization
	void Start () {

		//g_hit.GetComponent<AudioSource> ();
		s_hit = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OntriggerEnter(Collider other){
	
		if(other.tag == "bullet"){
	
			//g_hit.GetComponent<AudioSource> ().Play ();
			s_hit.Play();
	
			}
	
//			if (other.tag == "surface") {
//	
//				s_hit.Play ();
//			}

		}
}
