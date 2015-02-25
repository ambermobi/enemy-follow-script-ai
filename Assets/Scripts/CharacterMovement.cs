using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CharacterMovement : MonoBehaviour {
	
	public float moveSpeed=10.0F;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Get Input From User
		Vector3 input = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));

		//Apply Force as per requirement
		rigidbody.AddForce (input*moveSpeed);


}
	void Update()
	{
		//To Give a Jump Effect
		if (Input.GetKey (KeyCode.Space)) {
			rigidbody.AddForce(Vector3.up,ForceMode.Impulse);		
		}
	}

}
