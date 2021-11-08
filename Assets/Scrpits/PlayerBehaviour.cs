using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] float jumpPower = 500;
    // [SerializeField] bool rastejow = false;
    Vector3 moveAmount;
    Vector3 smoothVelocidade;
    public float velocidade = 10f;
    public Rigidbody2D rb;
    bool jump;
    

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0).normalized;
        Vector3 targetMoveAmount = moveDir * velocidade;
        moveAmount = Vector3.SmoothDamp(moveAmount,targetMoveAmount, ref smoothVelocidade, .15f);

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        } 
        
        else if (Input.GetButtonUp("Jump"))
        {
            jump = false;
        }
    }

    void FixedUpdate()
    {
        // impede que o objeto continue indo na mesma direção no espaço da cena,
        // podendo ser possivel continuar na superfície do planeta mesmo utilizando uma tecla de horizontal.
        rb.MovePosition(rb.position + new Vector2(transform.TransformDirection(moveAmount).x,transform.TransformDirection(moveAmount).y) * Time.fixedDeltaTime);
        Jump(jump);
    }

    void Jump(bool jumpFlag)
    {
        if(/*rastejow &&*/ jumpFlag)
        {
            // rastejow = false;
            jumpFlag = false;
            rb.AddForce(new Vector2(0f, jumpPower));
        } 
    }
}
