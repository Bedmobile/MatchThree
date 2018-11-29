using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchTree {
    public class UIManager : Manager {

        public enum ScreenTypes{
            IntroScreen,
            LevelSelectionScreen,
            GameplayScreen,
            LoadingScreen
        }

        public List<ScreenDictionaryItem> Screens;
        private Dictionary<ScreenTypes, Screen> _screenAccess;
        private Screen _activeScreen = null;
        public Screen ActiveScreen {
            get {
                return _activeScreen;
            }
        }

        public override void Init() {
            base.Init();
            _screenAccess = new Dictionary<ScreenTypes, Screen>();
            for(int i = 0; i < Screens.Count; i++) {
                _screenAccess.Add(Screens[i].ScreenType, Screens[i].Screen);
            }
            ShowLoadingScreen(true);
            CustomDebugLog.Print("UI");
        }

        public void SetScreen(Screen screen) {
            if(_activeScreen != null) {
                _activeScreen.Hide();
            }
            _activeScreen = screen;
            _activeScreen.Show();
        }

        public void ChangeScreen(ScreenTypes screenType) {
            SetScreen(GetScreen(screenType));
        }

        public void ShowLoadingScreen(bool show) {
            if (show) {
                GetScreen(ScreenTypes.LoadingScreen).Show();
            }
            else {
                GetScreen(ScreenTypes.LoadingScreen).Hide();
            }
        }

        private Screen GetScreen(ScreenTypes screenType) {
            return _screenAccess[screenType];
        }
    }
}
