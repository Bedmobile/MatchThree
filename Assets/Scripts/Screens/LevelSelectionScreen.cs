using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchTree {
    public class LevelSelectionScreen : Screen {

        public UnityEngine.UI.Button[] LevelButtons;

        public override void Hide() {
            gameObject.SetActive(false);
            for (int i = 0; i < LevelButtons.Length; i++) {
                try {
                    int level = GameManager.Instance.AllLevels[i];
                    LevelButtons[i].onClick.RemoveAllListeners();
                }
                catch (Exception e) {
                    Debug.LogError("This level does not exist");
                    Debug.LogError(e.Message);
                }
            }
        }

        public override void Show() {
            for(int i = 0; i < LevelButtons.Length; i++) {
                try {
                    int level = GameManager.Instance.AllLevels[i];
                    LevelButtons[i].onClick.AddListener(() => { LevelButtonHandle(level); });
                }
                catch(Exception e) {
                    Debug.LogError("This level does not exist");
                    Debug.LogError(e.Message);
                }
            }
            gameObject.SetActive(true);
        }

        private void LevelButtonHandle(int level) {
            GameManager.Instance.SetSelectedLevel(level);
            GameManager.Instance.SetGameState(new PlayLevelGameState());
        }
    }
}