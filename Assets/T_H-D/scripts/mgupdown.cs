using UnityEngine;
using System.Collections;

public class mgupdown : MonoBehaviour {


	private float xRot = 0;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.T)){



			xRot += 1;
			if (xRot > 50)
				xRot = 50;

			//transform.Rotate( xRot,0f,0f);

			transform.rotation = Quaternion.Euler (xRot, 0, 0);
		}

		if (Input.GetKey (KeyCode.V)) {



			xRot -= 1;
			if (xRot < -5)
				xRot = -5;

			transform.rotation = Quaternion.Euler (xRot, 0, 0);




		}




	
	}
}
