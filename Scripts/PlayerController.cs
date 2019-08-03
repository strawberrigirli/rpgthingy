using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float moveSpeed;
	public float jumpForce;
	public float gravityScale;

	private Vector3 moveDirect;

	public CharacterController charControl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	float yStore = moveDirect.y;
	moveDirect = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
	moveDirect.Normalize();
	moveDirect = moveDirect * moveSpeed;
	moveDirect.y = yStore;

	if(charControl.isGrounded){
	moveDirect.y = 0f;

        if(Input.GetButtonDown("Jump")){
	moveDirect.y = jumpForce;
}
}
	moveDirect.y += Physics.gravity.y * Time.deltaTime * gravityScale;

	charControl.Move(moveDirect * Time.deltaTime);
    }
}
