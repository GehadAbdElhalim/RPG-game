using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[Tooltip("The speed of the character")]
	public float MovementSpeed;

	private Animator anim;

	private bool playerMoving;

	private Vector2 lastMove;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		playerMoving = false;

		if (Input.GetAxisRaw("Horizontal") >= 0.5 || Input.GetAxisRaw("Horizontal") <= -0.5){
			transform.Translate(new Vector2(Input.GetAxisRaw("Horizontal")*MovementSpeed*Time.deltaTime,0f));
			playerMoving = true;
			lastMove = new Vector2(Input.GetAxisRaw("Horizontal"),0f);
		}
		if (Input.GetAxisRaw("Vertical") >= 0.5 || Input.GetAxisRaw("Vertical") <= -0.5){
			transform.Translate(new Vector2(0f,Input.GetAxisRaw("Vertical")*MovementSpeed*Time.deltaTime));
			playerMoving = true;
			lastMove = new Vector2(0f,Input.GetAxisRaw("Vertical"));
		}

		anim.SetFloat("MoveX",Input.GetAxisRaw("Horizontal"));
		anim.SetFloat("MoveY",Input.GetAxisRaw("Vertical"));
		anim.SetBool("PlayerMoving",playerMoving);
		anim.SetFloat("LastMoveX",lastMove.x);
		anim.SetFloat("LastMoveY",lastMove.y);
	}
}
