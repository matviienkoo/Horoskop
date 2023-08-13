using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LoginScript : MonoBehaviour
{
    [Header("Панель выбора даты")]
    public Dropdown myropdown_day;
    private int Int_day;

    public Dropdown myropdown_month;
    private int Int_month;

    [Header("Настройка зодиака")]
    public Text Zodiak;
    public int SelectionGoroskop;
    public int IntZodiac;

    [Header("Панель входа")]
    public GameObject Login_Panel;
    public bool Login_Bool;
    private int Login_Int;

    [Header("Скрипты")]
    public MyGoroskopScript GoroskopScript;
    public WishListScript TranstionScript;
    public PromtScript PromtScript;

    private void Start ()
    {
        myropdown_day.onValueChanged.AddListener(delegate {
        myDropdownDay(myropdown_day);
        });

        myropdown_month.onValueChanged.AddListener(delegate {
        myDropdownMonth(myropdown_month);
        });

        // Выключить сцену входа
        LoginSystem();
    }

    private void myDropdownDay(Dropdown target) 
    {
        Int_day = myropdown_day.value;
        LoginUpdate();
    }

    private void myDropdownMonth(Dropdown target) 
    {
        Int_month = myropdown_month.value;
        LoginUpdate();
    }

    public void LoginGoroskop ()
    {
        // Выключение запуска логин панели
        Login_Int = 1;
        Login_Bool = true;
        PlayerPrefs.SetInt ("Login_Int", Login_Int);

        // Обновить данные о выборе зодиака
        LoginUpdate();

        // Запустить нумерацию гороскопа
        GoroskopScript.OnApplicationStart();
        GoroskopScript.DataSystem();
        SelectionGoroskop = 1;
        PlayerPrefs.SetInt ("SelectionGoroskop", SelectionGoroskop);

        // Запустить подсказки
        PromtScript.StartPromt();

        // Переход на основную панель
        TranstionScript.ClosedLogin();
    }

    private void LoginSystem ()
    {
        Login_Int = PlayerPrefs.GetInt("Login_Int");

        // Включить панель входа
        if (Login_Int == 0)
        {
            Login_Bool = false;
            Login_Panel.SetActive(true);
        }

        // Выключить панель входа
        if (Login_Int == 1)
        {
            Login_Bool = true;
            Login_Panel.SetActive(false);
        }
    }

    private void LoginUpdate ()
    {
        //Овен
        if (Int_month == 2 && Int_day >= 20)
        {
            Zodiak.text = "Овен";
            IntZodiac = 0;
        }
        if (Int_month == 3 && Int_day <= 19)
        {
            Zodiak.text = "Овен";
            IntZodiac = 0;
        }

        //Телец
        if (Int_month == 3 && Int_day >= 20){
            Zodiak.text = "Телец";
            IntZodiac = 1;
        }
        if (Int_month == 4 && Int_day <= 20){
            Zodiak.text = "Телец";
            IntZodiac = 1;
        }

        //Близнецы
        if (Int_month == 4 && Int_day >= 21){
            Zodiak.text = "Близнецы";
            IntZodiac = 2;
        }
        if (Int_month == 5 && Int_day <= 20){
            Zodiak.text = "Близнецы";
            IntZodiac = 2;
        }

        //Рак
        if (Int_month == 5 && Int_day >= 21){
            Zodiak.text = "Рак";
            IntZodiac = 3;
        }
        if (Int_month == 6 && Int_day <= 21){
            Zodiak.text = "Рак";
            IntZodiac = 3;
        }

        //Лев
        if (Int_month == 6 && Int_day >= 22){
            Zodiak.text = "Лев";
            IntZodiac = 4;
        }

        if (Int_month == 7 && Int_day <= 20){
            Zodiak.text = "Лев";
            IntZodiac = 4;
        }

        //Дева
        if (Int_month == 7 && Int_day >= 21){
            Zodiak.text = "Дева";
            IntZodiac = 5;
        }
        if (Int_month == 8 && Int_day <= 22){
            Zodiak.text = "Дева";
            IntZodiac = 5;
        }

        //Веси
        if (Int_month == 8 && Int_day >= 23){
            Zodiak.text = "Весы";
            IntZodiac = 6;
        }
        if (Int_month == 9 && Int_day <= 22){
            Zodiak.text = "Весы";
            IntZodiac = 6;
        }

        //Скорпион
        if (Int_month == 9 && Int_day >= 22){
            Zodiak.text = "Скорпион";
            IntZodiac = 7;
        }
        if (Int_month == 10 && Int_day <= 21){
            Zodiak.text = "Скорпион";
            IntZodiac = 7;
        }

        //Стрелец
        if (Int_month == 10 && Int_day >= 22){
            Zodiak.text = "Стрелец";
            IntZodiac = 8;
        }
        if (Int_month == 11 && Int_day <= 21){
            Zodiak.text = "Стрелец";
            IntZodiac = 8;
        }

        //Козерог
        if (Int_month == 11 && Int_day >= 22){
            Zodiak.text = "Козерог";
            IntZodiac = 9;
        }
        if (Int_month == 0 && Int_day <= 19){
            Zodiak.text = "Козерог";
            IntZodiac = 9;
        }

        //Водолей
        if (Int_month == 0 && Int_day >= 20){
            Zodiak.text = "Водолей";
            IntZodiac = 10;
        }
        if (Int_month == 1 && Int_day <= 1){
            Zodiak.text = "Водолей";
            IntZodiac = 10;
        }

        //Рыба
        if (Int_month == 1 && Int_day >= 19){
            Zodiak.text = "Рыбы";
            IntZodiac = 11;
        }
        if (Int_month == 2 && Int_day <= 19){
            Zodiak.text = "Рыбы";
            IntZodiac = 11;
        }

        PlayerPrefs.SetInt ("IntZodiac", IntZodiac);
    }
}



