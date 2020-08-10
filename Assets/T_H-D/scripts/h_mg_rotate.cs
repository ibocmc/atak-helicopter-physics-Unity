using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class h_mg_rotate : MonoBehaviour {
	private float Scale = 25;
	//public float DownScale = 0;
	//public float maxUp = -10f;
	//public float maxDown = 25f;
	float rotX = 0;
	float rotY = 0;
	// Use this for initialization
	void Start () {
		
	}




		



	
	// Update is called once per frame
	void Update () {


//		transform.localEulerAngles.y = Input.GetAxis ("Mouse X") * Scale;
//		transform.localEulerAngles.x = Input.GetAxis ("Mouse Y") * Scale;


		 rotX += Input.GetAxis ("Mouse X") * Scale * /*Time.deltaTime **/ Mathf.Deg2Rad;
		 rotY += Input.GetAxis ("Mouse Y") * Scale */* Time.deltaTime **/ Mathf.Deg2Rad*-1;
//
//		if(rotX > 20){
//			rotX = 20;
//		}
//		if(rotX < -20){
//			rotX = -20;
//		}
//		if(rotY > 70){
//			rotX = 70;
//		}
//		if(rotY < -70){
//			rotX = -70;
//		}	
//
//
//
		rotY=Mathf.Clamp(rotY,-25,25);
		rotX=Mathf.Clamp(rotX,-40,40);
		transform.localRotation = Quaternion.Euler (rotY,rotX,0);
		//transform.Rotate(rotY,rotX,0);
//		transform.RotateAround (Vector3.up, rotX);
//		transform.RotateAround (Vector3.right, -rotY);
//		transform.RotateAround (Vector3.left, rotY);
//		transform.RotateAround (Vector3.down, -rotX);


//		if(Input.GetKey(KeyCode.DownArrow)){
//
//			Scale += 0.2f;
//
//			if (Scale > 27)
//				Scale = 27;
//
//			transform.localRotation = Quaternion.Euler (Scale, transform.localEulerAngles.y, transform.localEulerAngles.z);
//
//		}
//
//
//		if(Input.GetKey(KeyCode.LeftArrow)){
//
//			Scale -= 0.2f;
//
//			if (Scale < -70)
//				Scale = -70;
//
//			transform.localRotation = Quaternion.Euler ( transform.localEulerAngles.x, Scale, transform.localEulerAngles.z);
//
//		}
//
//
//		if(Input.GetKey(KeyCode.RightArrow)){
//
//			Scale += 0.2f;
//
//			if (Scale > 70)
//				Scale = 70;
//
//			transform.localRotation = Quaternion.Euler ( transform.localEulerAngles.x, Scale, transform.localEulerAngles.z);
//
//		}


		
	}
}
