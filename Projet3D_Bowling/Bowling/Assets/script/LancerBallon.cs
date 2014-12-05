using UnityEngine;
using System.Collections;

public class LancerBallon : MonoBehaviour {
	
	public float _Spin;
	public float _Power;
	public float _Throw = 20;
	
	

	void Start () {
	
	}
	

	void Update () {
		if (gameObject.rigidbody.velocity.magnitude > .1)
			return;
		
	if (Input.GetKey(KeyCode.LeftArrow))
		{
			Vector3 addition = Vector3.forward * Time.deltaTime;
			gameObject.transform.position -= addition;
		}
	if (Input.GetKey(KeyCode.RightArrow))
		{
			Vector3 addition = Vector3.forward * Time.deltaTime;
			gameObject.transform.position += addition;
		}
	

			




	if (Input.GetKey(KeyCode.Space))
		{
			_Power += _Throw * 1000 * Time.deltaTime;
		}		
	
	if (Input.GetKeyUp(KeyCode.Space))
	{
		StartCoroutine(Throw());
	}
		
	}

	public IEnumerator Throw()
	{
		gameObject.constantForce.force = new Vector3(_Power * -1,0,0);
		gameObject.constantForce.relativeForce = gameObject.constantForce.force * .1f;
		gameObject.constantForce.torque = new Vector3(-100, _Spin, 0);
		yield return 0;
		gameObject.constantForce.force = Vector3.zero;
		gameObject.constantForce.relativeForce = Vector3.zero;
		gameObject.constantForce.torque =  Vector3.zero;
		
		yield  break;
		
	}
	
	public void Reset(object _ball)
	{
	
		_Power = 0;
		_Spin = Random.Range(-100, 100);
		gameObject.constantForce.force =Vector3.zero;
		gameObject.constantForce.relativeForce = Vector3.zero;
		gameObject.constantForce.torque = Vector3.zero;
		gameObject.rigidbody.velocity = Vector3.zero;
		gameObject.rigidbody.angularVelocity = Vector3.zero;
		
	
	}
		

}


