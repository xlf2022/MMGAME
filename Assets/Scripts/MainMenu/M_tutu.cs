using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class M_tutu : MonoBehaviour
{
    public Animator tutu;

    public List<SpriteRenderer> splist= new List<SpriteRenderer>();

    private void Start()
    {
        foreach (var sp in splist)
        {
            sp.material.color = new Color((float)118/255, (float)118 / 255, (float)118 / 255);
        }
        tutu.speed = 0;
    }
    private void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }

    private void OnMouseEnter()
    {
        foreach (var sp in splist)
        {
            sp.material.color = new Color(1, 1, 1);
        }
        tutu.speed = 1;
    }
    private void OnMouseExit()
    {
        tutu.speed = 0;
        foreach (var sp in splist)
        {
            sp.material.color = new Color((float)118 / 255, (float)118 / 255, (float)118 / 255);
        }
    }

}
