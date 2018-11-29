using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchTree {
    public class IntroScreen : Screen {

        public UnityEngine.UI.Button StartButton;

        public override void Hide() {
            gameObject.SetActive(false);
            StartButton.onClick.RemoveListener(StartButtonHandle);
        }

        public override void Show() {
            StartButton.onClick.AddListener(StartButtonHandle);
            gameObject.SetActive(true);
        }

        private void StartButtonHandle() {
            GameManager.Instance.SetGameState(new SelectLevelGameState());
        }
    }
}
