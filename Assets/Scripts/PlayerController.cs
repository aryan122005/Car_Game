using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public InputAction MoveAction;
    public Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveAction.Enable();

    }

    // Update is called once per frame
    void Update()
    {
        //we are going to bind the move input with the move action button when move action button is pressed move input should be changing the left right
        moveInput=MoveAction.ReadValue<Vector2>();
            //we are going to make the vehicle move
        transform.Translate(Vector3.forward*Time.deltaTime*speed*moveInput.y);
        //we are going to make the vehicle turn
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed*moveInput.x);
        
    }
}
