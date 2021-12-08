using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject erradoUI;
    [SerializeField]
    private GameObject corretoUI;

    public void Setup()
    {
        erradoUI.SetActive(false);
        corretoUI.SetActive(false);
    }

    // public void RespostaEscolhida(bool isCorrect)
    // {
    //     if(isCorrect)
    //     {
    //         QuestionRight();
    //     }
    //     else
    //     {
    //         QuestionWrong();
    //     }
    // }
    public void QuestionWrong()
    {
        erradoUI.SetActive(true);
    }

    // public void OnButtonPress1()
    // {
    //     erradoUI.SetActive(true);
    // }

    public void QuestionRight()
    {
        corretoUI.SetActive(true);
    }

    // public void OnButtonPress2()
    // {
    //     corretoUI.SetActive(true);
    // }
}
