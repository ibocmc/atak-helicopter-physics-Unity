using System;
using UnityEngine;

//rename
public class HeliRotorController : MonoBehaviour
{
	public enum Axis
	{
		X,
		Y,
		Z,
	}
	public Axis RotateAxis;
    private float _rotarSpeed;
    public float RotarSpeed
    {
        get { return _rotarSpeed; }
        set { _rotarSpeed = Mathf.Clamp(value,0,2000); }
    }

    private float rotateDegree;
    private Vector3 OriginalRotate;

    void Start ()
	{
        OriginalRotate = transform.localEulerAngles;
	}

	void Update ()
	{
		//rotateDegree += _rotarSpeed * Time.deltaTime;
        rotateDegree += RotarSpeed * Time.deltaTime;
		//rotateDegree = RotarSpeed;

		switch (RotateAxis)
		{
		    case Axis.Y:
		        transform.localRotation = Quaternion.Euler(OriginalRotate.x, rotateDegree, OriginalRotate.z);
		        break;
		    case Axis.Z:
		        transform.localRotation = Quaternion.Euler(OriginalRotate.x, OriginalRotate.y, rotateDegree);
		        break;
		    default:
		        transform.localRotation = Quaternion.Euler(rotateDegree, OriginalRotate.y, OriginalRotate.z);
		        break;
		}
	}
}
