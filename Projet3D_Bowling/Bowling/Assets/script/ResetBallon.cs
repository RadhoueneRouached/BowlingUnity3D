using UnityEngine;
using System.Collections;

public class ResetBallon : MonoBehaviour {

	public Vector3 _Position;
	
	
	// initialisation 
	void OnEnable () {
		_Position = gameObject.transform.position;
	}
	
	public void Reset(int _ball)
	{
		// reinitialiser ballon
		StartCoroutine(DelayBallReset(2));
	}
	
	IEnumerator DelayBallReset(float secs)
	{
		gameObject.renderer.enabled = false;
		gameObject.transform.position = _Position;

		yield return new WaitForSeconds(secs);
		gameObject.renderer.enabled = true;

	}
}
