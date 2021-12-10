using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    private GameObject erradoUI;
    [SerializeField]
    private GameObject corretoUI;
    [SerializeField]
    private GameObject papai;
    
    public void Setup()
    {
        erradoUI.SetActive(false);
        corretoUI.SetActive(false);
    }

    public void QuestionWrong()
    {
        erradoUI.SetActive(true);
        corretoUI.SetActive(false);
        GameObject.Find("Quiz").SetActive(false);
    }

    public void QuestionRight()
    {
        corretoUI.SetActive(true);
        erradoUI.SetActive(false);
        GameObject.Find("Quiz").SetActive(false);
    }

    public void Fechar()
    {
        corretoUI.SetActive(false);
        erradoUI.SetActive(false);
        papai.SetActive(false);
        Time.timeScale = 1f;
    }
}
