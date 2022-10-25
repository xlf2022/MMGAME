using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class M_tutu : MonoBehaviour
{
    public Animator tutu;

    private void Start()
    {
        tutu.speed = 0;
    }
    private void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }

    private void OnMouseEnter()
    {
        tutu.speed = 1;
    }
    private void OnMouseExit()
    {
        tutu.speed = 0;
    }

}
