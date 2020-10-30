﻿using System;
using FrameWork.JianChen.Core;
using Assets.Scripts.Common;
using FrameWork.JianChen.Interfaces;
using game.main;

public class SkillPanel : Panel
{
    SkillController _skillmoduleController;

    public override void Init(IModule module)
    {
        base.Init(module);
        var viewScript = (SkillView)InstantiateWindow<SkillView>("Skill/Prefabs/SkillView");
        _skillmoduleController = new SkillController();
        _skillmoduleController.View = viewScript;
        RegisterView(viewScript);
        RegisterController(_skillmoduleController);
        _skillmoduleController.Start();
    }

    public override void Show(float delay)
    {
        base.Show(delay);
//        Main.ChangeMenu(MainUIDisplayState.ShowTopBar);
//        ShowBackBtn();
    }

    public override void Hide()
    {
        base.Hide();
    }
}