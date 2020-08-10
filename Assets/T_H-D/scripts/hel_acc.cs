using UnityEngine;
using System.Collections;

public class hel_acc : MonoBehaviour {

	public AudioSource hel_engine;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKey(KeyCode.W)){


			transform.Rotate (0f, Time.deltaTime * 2000f, 0f);



		}


		if(Input.GetKeyDown(KeyCode.W)){

			hel_engine.mute = false;
			hel_engine.Play ();


		}


		if(Input.GetKeyUp(KeyCode.W)){


			hel_engine.mute = true;


		}


	
	}
}
