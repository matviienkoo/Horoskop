using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WishListScript : MonoBehaviour 
{
    private float Timer;

    [Header("Основная панель")]
    public GameObject WishSystem;

    [Header("Вторичные панели")]
    public GameObject Panel_Wish_List;
    public Animation Animation_WishList;

    public GameObject Panel_Back;
    public Animation Animation_Blackout;

    [Header("Настройка перехода")]
    public GameObject Transtion_Object;
    public Animation Transtion_Animation;

    public string String_WishList;
    public bool Bool_WishList;

    [Header("Панели на которые совершают переход")]
    public GameObject MyGoroskop_Panel;
    public Button MyGoroskop_Button;

    public GameObject Compatibility_Panel;
    public Button Compatibility_Button;

    public GameObject AllAboutSign_Panel;
    public Button AllAboutSign_Button;

    public GameObject Login_Panel;

    // Открытие основной панели
    public void Open_WishList ()
    {
        Animation_WishList.Play("WishList_Panel (Open)");
        Animation_Blackout.Play("WishList_Blackout (Open)");

        StartCoroutine(Coroutines_WishList_Open());
        Transtion_Object.SetActive(true);

        // Включить панель выбора
        WishSystem.SetActive(true);
    }

    IEnumerator Coroutines_WishList_Open()
    {
        yield return new WaitForSeconds(0.6f);
        Transtion_Object.SetActive(false);
    }

    // Закрытие основной панели
    public void Close_WishList ()
    {
        Animation_WishList.Play("WishList_Panel (Closed)");
        Animation_Blackout.Play("WishList_Blackout (Closed)"); 

        StartCoroutine(Coroutines_WishList_Close());
        Transtion_Object.SetActive(true);
    }

    IEnumerator Coroutines_WishList_Close()
    {
        yield return new WaitForSeconds(0.6f);
        Transtion_Object.SetActive(false);

        // Выключить панель выбора
        WishSystem.SetActive(false);
    }

    // Открытие гороскопа
    public void MyGoroskop ()
    {
        Transtion_Object.SetActive(true);
        Transtion_Animation.Play();

        String_WishList = "My goroskop";
        Bool_WishList = true;
    }

    // Открытие совместимости
    public void Compatibility ()
    {
        Transtion_Object.SetActive(true);
        Transtion_Animation.Play();

        String_WishList = "Compatibility";
        Bool_WishList = true;
    }

    // Открытие о себе
    public void AllAboutSign ()
    {
        Transtion_Object.SetActive(true);
        Transtion_Animation.Play();

        String_WishList = "All about sign";
        Bool_WishList = true;
    }

    // Закрыть панель входа
    public void ClosedLogin ()
    {
        Transtion_Object.SetActive(true);
        Transtion_Animation.Play();

        String_WishList = "Login exit";
        Bool_WishList = true;
    }

    // Закрыть все
    private void ClosedLenght ()
    {
        MyGoroskop_Panel.SetActive(false);
        Compatibility_Panel.SetActive(false);
        AllAboutSign_Panel.SetActive(false);
    }

    private void Update ()
    {
        if (Bool_WishList == true){
        Timer += Time.deltaTime;
        if (Timer >= 0.50)
        {
            if (String_WishList == "My goroskop")
            {
                ClosedLenght();
                MyGoroskop_Panel.SetActive(true);

                WishSystem.SetActive(false);
                String_WishList = "";

                MyGoroskop_Button.interactable = false;
                Compatibility_Button.interactable = true;
                AllAboutSign_Button.interactable = true;
            }

            if (String_WishList == "Compatibility")
            {
                ClosedLenght();
                Compatibility_Panel.SetActive(true);

                WishSystem.SetActive(false);
                String_WishList = "";

                MyGoroskop_Button.interactable = true;
                Compatibility_Button.interactable = false;
                AllAboutSign_Button.interactable = true;
            }

            if (String_WishList == "All about sign")
            {
                ClosedLenght();
                AllAboutSign_Panel.SetActive(true);

                WishSystem.SetActive(false);
                String_WishList = "";

                MyGoroskop_Button.interactable = true;
                Compatibility_Button.interactable = true;
                AllAboutSign_Button.interactable = false;
            }

            if (String_WishList == "Login exit")
            {
                Login_Panel.SetActive(false);
                String_WishList = "";
            }
        }

        if (Timer >= 1)
        {
            Bool_WishList = false;
            Transtion_Object.SetActive(false);
            Timer = 0;
        }
        }
    }
}