using UnityEngine;
using System.Collections;

public class back_blades : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKey(KeyCode.W)){


			transform.Rotate (Time.deltaTime * 4000f, 0f, 0f);



		}

	
	}
}
