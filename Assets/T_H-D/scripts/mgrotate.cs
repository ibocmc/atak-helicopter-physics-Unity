using UnityEngine;
using System.Collections;

public class mgrotate : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.G)){


			transform.Rotate(0f,Time.deltaTime * 50f,0f);


		}

		if (Input.GetKey (KeyCode.F)) {

			transform.Rotate(0f,-Time.deltaTime * 50f,0f);




		}





	}
}
