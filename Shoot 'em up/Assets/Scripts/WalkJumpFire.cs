using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class WalkJumpFire : MonoBehaviour {

	public Animator animator;
    Vector2 movement;

    public Joystick joystick;

	Rigidbody2D rb;
	float dirX;

	[SerializeField]
	float moveSpeed = 5f, bulletSpeed = 500f;

	bool facingRight = true;
	Vector3 localScale;

	public Transform barrel;
	public Rigidbody2D bullet;

	// Use this for initialization
	void Start () {
		localScale = transform.localScale;
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;

        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical",movement.y);
        animator.SetFloat("Speed",movement.sqrMagnitude );
		
		if (CrossPlatformInputManager.GetButtonDown ("Fire1"))
			Fire ();

			dirX = movement.x;
	}

	void FixedUpdate()
	{
		//rb.velocity = new Vector2 (dirX * moveSpeed, rb.velocity.y);
		rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
	}

	void LateUpdate()
	{
		CheckWhereToFace ();
	}

	void CheckWhereToFace()
	{
		if (dirX > 0)
			facingRight = true;
		else
			if (dirX < 0) 
				facingRight = false;
		if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
			localScale.x *= -1;
		transform.localScale = localScale;
	}

	// void Jump()
	// {
	// 	if (rb.velocity.y == 0)
	// 		rb.AddForce (Vector2.up * jumpForce);
	// }

	void Fire()
	{
		var firedBullet = Instantiate (bullet, barrel.position, barrel.rotation);
		firedBullet.AddForce (barrel.up * bulletSpeed);
	}
}
