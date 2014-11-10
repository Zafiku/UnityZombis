using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10f;
	public Vector2 maxVelocity = new Vector2(2,3);
	private Animator animator;

	void Start () {

				animator = GetComponent<Animator> ();

		}
	void Update () {

		var absVelX = Mathf.Abs (rigidbody2D.velocity.x);
		var forceX = 0f;
		var forceY = 0f;

		if (Input.GetKey ("right")) {
			if (rigidbody2D.velocity.x < 0){
				rigidbody2D.velocity = new Vector2(0,rigidbody2D.velocity.y);
			}
			if (absVelX < maxVelocity.x)
				forceX = speed;
			this.transform.localScale = new Vector3 (1, 1, 1);
		}
		else if (Input.GetKey ("left")) {
			if (rigidbody2D.velocity.x > 0){
				rigidbody2D.velocity = new Vector2(0,rigidbody2D.velocity.y);
			}
			if (absVelX < maxVelocity.x)
				forceX = -speed;
			this.transform.localScale = new Vector3 (-1, 1, 1);
		}
		if(absVelX > 0)
			animator.SetFloat ("velocity",absVelX);
		rigidbody2D.AddForce (new Vector2 (forceX, forceY));

		if (Input.GetKey ("c")) {
			animator.SetBool ("fire", true);
		}else{
			animator.SetBool ("fire", false);
	
	}
}
}