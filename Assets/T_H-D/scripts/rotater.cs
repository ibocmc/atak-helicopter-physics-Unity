using UnityEngine;
using System.Collections;

public class rotater : MonoBehaviour {

	public AudioSource turret;

	// Use this for initialization
	void Start () {

		turret = GetComponent<AudioSource> ();
		turret.mute = false;
	}

	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.D)){


		transform.Rotate(Vector3.up * Time.deltaTime * 10f);



		}

		if (Input.GetKey (KeyCode.A)) {
			
			transform.Rotate(Vector3.down * Time.deltaTime * 10f);



		}


		if (Input.GetKeyDown (KeyCode.D)  ) {
			turret.mute = false;
			turret.Play ();
		} 

		if (Input.GetKeyDown (KeyCode.A)  ) {
			turret.mute = false;
			turret.Play ();
		} 


		if(Input.GetKeyUp(KeyCode.D)){
			turret.mute=true;
		}

		if(Input.GetKeyUp(KeyCode.A)){
			turret.mute=true;
		}
	

	}
}
