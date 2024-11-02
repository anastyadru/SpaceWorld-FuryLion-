// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using UnityEngine;
using UnityEngine.UI;

public class ChoicePlayerView : View
{
    // [SerializeField] private Button _choiceleftButton;
    // [SerializeField] private Button _choicerightButton;
    [SerializeField] private Button _playButton;
    
    public override void Initialize()
    {
        _playButton.onClick.AddListener(OnGameButtonClicked);
        // _choiceleftButton.onClick.AddListener(() => ViewManager.Show< >());
        // _choicerightButton.onClick.AddListener(() => ViewManager.Show< >());
    }

    private void OnGameButtonClicked()
    {
        ViewManager.LoadSceneGame();
    }
}