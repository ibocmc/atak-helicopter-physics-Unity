using UnityEngine;
using System.Collections;

public class tankbarrelfire : MonoBehaviour {

	public GameObject dust;
	public Transform dustwave;
	public GameObject ctrlFire;
	public GameObject barrelfire;
	public Transform fireSpawn;
	public AudioSource barrelsound;
	//public AudioSource tankEngine;

	public bool go;
	//public bool fire;

	public float fireRate;
	public float nextFire;

	public Animator anim;


	// Use this for initialization
	void Start () {
		barrelsound = GetComponent<AudioSource> ();
		//tankEngine = GetComponent<AudioSource> ();
		anim = GetComponent<Animator> ();
		anim.enabled = false;
		go = false;

		ctrlFire.SetActive (false);

		//fire = false;
	}

	// Update is called once per frame
	void Update () {
		anim.SetBool ("go", go);
		//anim.SetBool ("fire", fire);

		if (Input.GetKey (KeyCode.W)) {
			//tankEngine.Play ();
			anim.enabled = true;
			go = true;
			//anim.Play ("go", 0, 0);
		} else
			go = false;



		if (Input.GetKeyDown (KeyCode.Mouse1) && Time.time > nextFire) {


			barrelsound.Play ();
			nextFire = Time.time + fireRate;
			Instantiate (barrelfire, fireSpawn.position, fireSpawn.rotation);
			Instantiate (dust, dustwave.position, dustwave.rotation);
			ctrlFire.SetActive (true);
		} else
			ctrlFire.SetActive (false);


//		if (ctrlFire.activeSelf) {
//
//			fire = true;
//
//		} else
//			fire = false;


		if (Input.GetMouseButton(1)) {

			//anim.enabled = true;
			//anim.Play ("tankbarrel", -1, 0);


			//anim.Play ("Basic_Fire", -1, 0);


		} else {
			//anim.enabled = false;
			//mgsound.Stop ();
		}

		if (Input.GetKeyDown (KeyCode.Mouse1) && ctrlFire.activeSelf ) {
			anim.enabled = true;
			anim.Play ("tankbarrel", -1, 0);
			//anim.Play ("tankbarrel", -1, 0);

		} 

//		if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.Mouse1)){
//
//			anim.enabled = true;
//			anim.Play ("tankbarrel", -1, 0);
//			anim.Play ("go", 0, 0);
//		}

//		if (Input.GetKey (KeyCode.Mouse1)) {
//			anim.enabled = true;
//			anim.Play ("tankbarrel_L", -1, 0);
//			//anim.Play ("tankbarrel", -1, 0);
//
//		} 





	}
}
