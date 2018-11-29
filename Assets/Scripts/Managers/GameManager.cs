using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchTree {
    public class GameManager : Manager {

        private static GameManager _instance;
        public static GameManager Instance {
            get {
                return _instance;
            }
        }

        public SoundManager SoundManager;
        public ContentManager ContentManager;
        public PoolManager PoolManager;
        public UIManager UIManager;

        public bool CustomLogIsEnable = true;

        private GameState _activeGameState;

        public int SelectedLevel { get; private set; }
        public List<int> AllLevels { get; private set; }

        void Awake() {
            if (_instance == null) {
                _instance = this;
            }

            Init();
        }

        public override void Init() {
            base.Init();
            CustomDebugLog.Print("StartGame");
            UIManager.Init();
            SoundManager.Init();
            ContentManager.Init();
            PoolManager.Init();
            InitLevels();
            SetGameState(new IntroGameState());
        }

        public void SetGameState(GameState state) {
            if(_activeGameState != null) {
                _activeGameState.CloseState();
            }
            _activeGameState = state;
            _activeGameState.InitState();
        }

        public void SetSelectedLevel(int level) {
            SelectedLevel = level;
            Debug.Log("Current selected level is " + SelectedLevel.ToString());
        }

        private void InitLevels() {
            AllLevels = new List<int>() { 1, 2, 3 };
        }
    }
}
