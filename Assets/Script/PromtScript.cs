using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class PromtScript : MonoBehaviour
{
    [Header("Посказка кнопки совместимости")]
    public GameObject ObjectCompatibility;
    public Animator AnimatorCompatibility;
    public bool BoolPromtCompatibility;

    [Header("Посказка кнопки поделиться")]
    public GameObject ObjectShare;
    public Animator AnimatorShare;
    public bool BoolPromtShare;

    private float r=1f,g=1f,b=1f,a=0.4313726f;

    public void StartPromt ()
    {
        // Запуск подсказку совместимости
        PromtCompatibility();

        BoolPromtCompatibility = true;
        BoolPromtShare = true;
    }

    // ------------------- Подсказка для кнопки совместимости-------------------
    private void PromtCompatibility ()
    {
        ObjectCompatibility.SetActive(true);
        AnimatorCompatibility.GetComponent<Animator>().enabled = true;
    }

    public void ChangeCompatibility ()
    {
        if (BoolPromtCompatibility == true)
        {
            StartCoroutine(ChangeCompatibilitPromt());
        }
    }

    IEnumerator ChangeCompatibilitPromt()
    {
        yield return new WaitForSeconds(2);

        AnimatorCompatibility.GetComponent<Animator>().enabled = false;
        ObjectCompatibility.SetActive(false);

        ObjectCompatibility.GetComponent<Image>().color = new Color(r,g,b,a);
        BoolPromtCompatibility = false;

        // Запуск подсказку поделиться
        PromtShare();
    }

    // ------------------- Подсказка для кнопки поделиться-------------------
    private void PromtShare ()
    {
        ObjectShare.SetActive(true);
        AnimatorShare.GetComponent<Animator>().enabled = true;
    }

    public void ChangeShare ()
    {
        if (BoolPromtShare == true)
        {
            StartCoroutine(ChangeSharePromt());
        }
    }

    IEnumerator ChangeSharePromt()
    {
        yield return new WaitForSeconds(1);

        AnimatorShare.GetComponent<Animator>().enabled = false;
        ObjectShare.SetActive(false);

        ObjectShare.GetComponent<Image>().color = new Color(r,g,b,a);
        BoolPromtShare = false;
    }

    public void XUI ()
    {
        ObjectShare.GetComponent<Image>().color = new Color(r,g,b,a);
    }
}