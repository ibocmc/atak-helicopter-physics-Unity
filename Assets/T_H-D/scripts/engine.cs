using UnityEngine;
using System.Collections;

public class engine : MonoBehaviour {

	public AudioSource tankengine_idle;
	public AudioSource tankengine_acc;

	// Use this for initialization
	void Start () {
		tankengine_idle.mute = false;
		//tankengine = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.W)) {
			tankengine_acc.mute = false;
			tankengine_acc.Play ();
			tankengine_idle.mute = true;
		} 

		if(Input.GetKeyDown(KeyCode.E)){

			tankengine_idle.Play ();


		}

		if(Input.GetKeyUp(KeyCode.W)){
			tankengine_idle.mute=false;
			tankengine_idle.Play ();
			tankengine_acc.mute = true;

		}
	}
}
