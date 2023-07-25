using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_TitleScene : UI_Scene
{
    enum Texts
    {
        TitleText,
    }

    enum Buttons
    {
        StartButton,
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindText(typeof(Texts));
        BindButton(typeof(Buttons));

        GetText((int)Texts.TitleText).text = "hello";
        GetButton((int)Buttons.StartButton).gameObject.BindEvent(OnStartButton); 
        return true;
    }

    private void OnStartButton()
    {
        Managers.Scene.LoadScene(Define.Scene.GameScene);
    }
}
