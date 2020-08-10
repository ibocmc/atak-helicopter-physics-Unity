using UnityEngine;
using System.Collections;

public class bulletMover : MonoBehaviour {

	public AudioSource g_hit;
	public AudioSource s_hit;



	public float speed;
	public float r_speed;
	public Rigidbody rb;

	//public AudioSource missile_sound;




	// Use this for initialization
	void Start () {



	}

	// Update is called once per frame
	void FixedUpdate() {
		//missile_sound.Play ();
		rb.velocity = transform.forward * speed ;
		rb.AddTorque(transform.forward * r_speed,ForceMode.VelocityChange);
	}


	void OnTriggerEnter(Collider other){

		if(other.tag == "surface"){

			s_hit.Play ();

		}



		if (other.tag == "ground") {

			g_hit.Play ();
		}

	}



}
