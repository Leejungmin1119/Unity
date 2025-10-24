using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public enum HUD_Type {Level,Exp,Killcounter,GameTimer,Hp};

    public HUD_Type Type;

    public Slider Exp_Slider;
    public TextMeshProUGUI Textitem;
    void Awake()
    {
        Exp_Slider = GetComponent<Slider>();
        if (Type == HUD_Type.Hp)
        {
            Textitem = GetComponentInChildren<TextMeshProUGUI>();
        }
        else
        {
            Textitem = GetComponent<TextMeshProUGUI>();
        }
    }
    void LateUpdate()
    {
        // 텍스트의 종류에 따라 각기 다른 UI 적용
        switch(Type)
        {
            // 레벨 UI
            case HUD_Type.Level:
                Textitem.text = string.Format("Lv.{0}", Hack_Manager.instance.Player_Level);
                break;

            // 경험치 바 UI
            case HUD_Type.Exp:
                Exp_Slider.value = Hack_Manager.instance.Player_Exp / Hack_Manager.instance.Player_NextExp;
                break;
            // 킬 갯수 UI
            case HUD_Type.Killcounter:
                Textitem.text = string.Format("{0} Kill", Game_Manager.instance.AnermyKill);
                break;
            // 게임 타이머 UI
            case HUD_Type.GameTimer:
                float Timer = Mathf.Floor(Game_Manager.instance.GamePlay_Timer);
                Textitem.text = string.Format("{0}:{1}", Mathf.Floor(Timer / 60), Timer%60);
                break;
            case HUD_Type.Hp:
                Textitem.text = string.Format("{0} / {1}", Hack_Manager.instance.hack.Player_Hp[0], Hack_Manager.instance.hack.Player_Hp[1]);
                Exp_Slider.value = Hack_Manager.instance.hack.Player_Hp[0] / Hack_Manager.instance.hack.Player_Hp[1];
                break;
        }
    }
}
