﻿using System;
using FrameWork.JianChen.Core;
using Assets.Scripts.Common;
using FrameWork.JianChen.Interfaces;

public class ShopPanel : ReturnablePanel
{
    ShopController _shopmoduleController;

    public override void Init(IModule module)
    {
        base.Init(module);
        var viewScript = (ShopView)InstantiateView<ShopView>("Shop/Prefabs/ShopView");
        _shopmoduleController = new ShopController();
        _shopmoduleController.View = viewScript;
        RegisterView(viewScript);
        RegisterController(_shopmoduleController);
        _shopmoduleController.Start();
    }

    public override void Show(float delay)
    {
        base.Show(delay);
        Main.ChangeMenu(MainUIDisplayState.ShowTopBar);
        ShowBackBtn();
    }

    public override void Hide()
    {
        base.Hide();
    }
}
