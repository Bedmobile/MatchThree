using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchTree {
    public class GameplayScreen : Screen {

        public WinWidget WinWidget;

        public override void Hide() {
            gameObject.SetActive(false);
            WinWidget.HomeButton.onClick.RemoveListener(HomeButtonHandle);
        }

        public override void Show() {
            WinWidget.HomeButton.onClick.AddListener(HomeButtonHandle);
            gameObject.SetActive(true);
        }

        private void HomeButtonHandle() {
            GameManager.Instance.SetGameState(new SelectLevelGameState());
        }
    }
}
