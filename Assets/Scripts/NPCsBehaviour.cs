using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCsBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject quizzUI;
    public bool tocando;
    [SerializeField]
    private GameObject papai;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(tocando && Input.GetKeyDown(KeyCode.Space))
        {
            papai.SetActive(true);
            quizzUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void OnTriggerEnter2D(Collider2D colisao)
    {
        if(colisao.CompareTag("Player"))
        {
            tocando = true;
        }
    }

    public void OnTriggerExit2D(Collider2D colisao)
    {
        tocando = false;
    }
}
