﻿using UnityEngine;
using UnityEngine.UI;

namespace PuzzlePaint
{
    public class LosePanel : UIPanel
    {
        [SerializeField] private Button _reset;
        
        private Game _game;

        private void OnDisable()
        {
            _reset.onClick.RemoveAllListeners();
        }
        
        public override void Activate()
        {
            if (_game == null)
                _game = Game.Instance;
            
            gameObject.SetActive(true);

            _reset.onClick.AddListener(OnResetClicked);
        }

        public override void UpdatePanel()
        {
        }

        private void OnResetClicked()
        {
            _game.ResetLevel();
        }
    }
}