using UnityEngine;
using System.Collections;

public class ResetPins : MonoBehaviour {
	
	
	public Vector3 _Position;
	public Quaternion _Rotation;
	
	
	// initialiser pin
	void OnEnable () {
		_Position = gameObject.transform.position;
		_Rotation = gameObject.transform.rotation;
	}


	
	// reinitialiser les pin {0,1} 

	public void ResetPin(object _ball)
	{
		
		gameObject.transform.position  = _Position;
		gameObject.transform.rotation = _Rotation;
		gameObject.rigidbody.velocity = Vector3.zero;
		gameObject.rigidbody.angularVelocity = Vector3.zero;
		
	}
}
