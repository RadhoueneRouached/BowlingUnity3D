using UnityEngine;
using System.Collections;

public class RetournerBallon : MonoBehaviour {
	
	public int _Ball = 0;
	bool doUpdate = false;


	void Start () {
	
	}
	

	void Update () {
			
		}

	
	void LateUpdate()
	{
		if (doUpdate)
		{
			_Ball += 1;
			_Ball = _Ball % 3;
			StartCoroutine(DelayUpdate());	
		}
		doUpdate = false;
	}
	
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.GetComponent<LancerBallon>() != null)
			{
			doUpdate = true;							
			other.gameObject.SendMessage("Reset", _Ball, SendMessageOptions.DontRequireReceiver);
			}		
		

		}
	
	void ResetFrame()
	{
		Debug.Log("reset pin");
		foreach ( var v in GameObject.FindGameObjectsWithTag("pin"))
		{
			v.SendMessage("ResetPin", (_Ball),SendMessageOptions.DontRequireReceiver);
		}
		_Ball = 0;
	}
	
	public IEnumerator DelayUpdate()
	{

		yield return new WaitForSeconds(1.5f);
		Debug.Log("score"); 
		// mettre a jour le score
		gameObject.SendMessage("UpdateScore", _Ball, SendMessageOptions.RequireReceiver);
		yield return 0;
	}
	
}
