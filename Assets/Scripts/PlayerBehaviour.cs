using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    Vector3 moveAmount;
    Vector3 smoothVelocidade;
    public float velocidade = 10f;
    public Rigidbody2D rb;
    [SerializeField]
    private GameObject quizzUI;

    public bool tocando;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0).normalized;
        Vector3 targetMoveAmount = moveDir * velocidade;
        moveAmount = Vector3.SmoothDamp(moveAmount,targetMoveAmount, ref smoothVelocidade, .15f);
        if(tocando && Input.GetKeyDown(KeyCode.Space))
        {
            quizzUI.SetActive(true);
            Debug.Log("tocou");
        }
    }

    void FixedUpdate()
    {
        // impede que o objeto continue indo na mesma direção no espaço da cena,
        // podendo ser possivel continuar na superfície do planeta mesmo utilizando uma tecla de horizontal.
        rb.MovePosition(rb.position + new Vector2(transform.TransformDirection(moveAmount).x,transform.TransformDirection(moveAmount).y) * Time.fixedDeltaTime);
    }

    public void OnTriggerEnter2D(Collider2D colisao)
    {
        if(colisao.CompareTag("NPC"))
        {
            tocando = true;
        }
    }

    public void OnTriggerExit2D(Collider2D colisao)
    {
        tocando = false;
    }
}
