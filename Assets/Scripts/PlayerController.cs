using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PlayerController : MonoBehaviour
{
    [SerializeField] int movementSpeed;

    private Vector2 movementInput;
        

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      movementInput.x=  Input.GetAxisRaw("Horizontal");
        Debug.Log(movementInput.x);
        

        movementInput.y = Input.GetAxisRaw("Vertical");
        Debug.Log(movementInput.y);


        Debug.Log("This is Vector2" + movementInput);
    }
}
