﻿using MobileGame.Controllers;
using MobileGame.Enums;
using Platformer.Player;
using UnityEngine;

namespace MobileGame
{
    public class Root : MonoBehaviour
    {
        [SerializeField] 
        private Transform _placeForUi;

        [SerializeField]
        private UnityAdsTools _unityAdsTools;

        private MainController _mainController;

        private void Start()
        {
            var profilePlayer = new ProfilePlayer(15f, _unityAdsTools);
            profilePlayer.CurrentState.Value = GameState.Start;
            _mainController = new MainController(_placeForUi, profilePlayer);
        }

        protected void OnDestroy()
        {
            _mainController?.Dispose();
        }
    }
}