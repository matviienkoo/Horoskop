using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownScript : MonoBehaviour
{
    [Header("Панель выбора знака зодиака")]
    public Dropdown myDropdown;
    public int IntZodiac;

    [Header("Картинка зодиака")]
    public Image Zodiac;

    [Header("Спрайты зодиака")]
    public Sprite Oven;
    public Sprite Telec;
    public Sprite Blizneci;
    public Sprite Rak;
    public Sprite Lev;
    public Sprite Deva;
    public Sprite Vesy;
    public Sprite Skorpion;
    public Sprite Strelec;
    public Sprite Kozeroh;
    public Sprite Vodoley;
    public Sprite Ryby;

    public void Start() 
    {
        myDropdown.onValueChanged.AddListener(delegate {
        myDropdownValueChangedHandler(myDropdown);
        });
    }
    
    private void myDropdownValueChangedHandler(Dropdown target) 
    {   
        // Выбор Зодиака
        IntZodiac = myDropdown.value;
        PlayerPrefs.SetInt ("IntZodiac", IntZodiac);
    }

    private void Update ()
    {
        IntZodiac = PlayerPrefs.GetInt("IntZodiac");
        myDropdown.value = IntZodiac;

        if (IntZodiac == 0){
        Zodiac.sprite = Oven;
        }

        if (IntZodiac == 1){
        Zodiac.sprite = Telec;
        }

        if (IntZodiac == 2){
        Zodiac.sprite = Blizneci;
        }

        if (IntZodiac == 3){
        Zodiac.sprite = Rak;
        }

        if (IntZodiac == 4){
        Zodiac.sprite = Lev;
        }

        if (IntZodiac == 5){
        Zodiac.sprite = Deva;
        }

        if (IntZodiac == 6){
        Zodiac.sprite = Vesy;
        }

        if (IntZodiac == 7){
        Zodiac.sprite = Skorpion;
        }

        if (IntZodiac == 8){
        Zodiac.sprite = Strelec;
        }

        if (IntZodiac == 9){
        Zodiac.sprite = Kozeroh;
        }

        if (IntZodiac == 10){
        Zodiac.sprite = Vodoley;
        }

        if (IntZodiac == 11){
        Zodiac.sprite = Ryby;
        }
    }
}
