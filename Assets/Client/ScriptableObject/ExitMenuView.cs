// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using UnityEngine;
using UnityEngine.UI;

public class ExitMenuView : View
{
    [SerializeField] private Button _backButton;
    [SerializeField] private Button _finishgameButton;
    
    public override void Initialize()
    {
        _backButton.onClick.AddListener(() => ViewManager.ShowLast());
        _finishgameButton.onClick.AddListener(QuitGame);
    }
    
    private void QuitGame()
    {
        Application.Quit();
    }
}