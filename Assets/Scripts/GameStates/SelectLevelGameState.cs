namespace MatchTree {
    public class SelectLevelGameState : GameState {
        public override void InitState() {
            CustomDebugLog.Print(this.ToString() + " init");
            GameManager.Instance.UIManager.ChangeScreen(UIManager.ScreenTypes.LevelSelectionScreen);
            GameManager.Instance.UIManager.ShowLoadingScreen(false);
        }

        public override void CloseState() {
            CustomDebugLog.Print(this.ToString() + " close");
            GameManager.Instance.UIManager.ShowLoadingScreen(true);
        }
    }
}
