using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BarType{
    healthBar,
    manaBar
}

public class PlayerBar : MonoBehaviour
{
    private Slider slider;
    public BarType type;
    
    void Start(){
        slider = GetComponent<Slider>();
        switch(type){
            case BarType.healthBar:
                slider.maxValue = PlayerControler.MAX_HEALTH;
                break;

            case BarType.manaBar:
                slider.maxValue = PlayerControler.MAX_MANA;
                break;
        }
    }

    void Update(){
        switch(type){
            case BarType.healthBar:
                slider.value = GameObject.Find("Player").GetComponent<PlayerControler>().GetHealth();
                break;

            case BarType.manaBar:
                slider.value = GameObject.Find("Player").GetComponent<PlayerControler>().GetMana();
                break;
        }
    }
}
