using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	

	void Update ()
	{
		transform.Rotate (new Vector3 (25, 25, 25)*Time.deltaTime);	
	}
}
