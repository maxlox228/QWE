using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInGame : MonoBehaviour
{
    public GameObject platforma1;
    public GameObject platforma2;
    public GameObject platforma3;
    public GameObject platforma4;

    public void ButtonUpLeft()
    {
        platforma1.SetActive(true);
        platforma2.SetActive(false);
        platforma3.SetActive(false);
        platforma4.SetActive(false);
    }

    public void ButtonUpRight()
    {
        platforma2.SetActive(true);
        platforma1.SetActive(false);
        platforma3.SetActive(false);
        platforma4.SetActive(false);
    }

    public void ButtonLeft()
    {
        platforma4.SetActive(true);
        platforma2.SetActive(false);
        platforma3.SetActive(false);
        platforma1.SetActive(false);
    }

    public void ButtonRight()
    {
        platforma3.SetActive(true);
        platforma2.SetActive(false);
        platforma1.SetActive(false);
        platforma4.SetActive(false);
    }
}
