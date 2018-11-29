namespace MatchTree {
    public class PlayLevelGameState : GameState {
        public override void InitState() {
            CustomDebugLog.Print(this.ToString() + " init");
            GameManager.Instance.UIManager.ChangeScreen(UIManager.ScreenTypes.GameplayScreen);
            GameManager.Instance.UIManager.ShowLoadingScreen(false);
        }

        public override void CloseState() {
            CustomDebugLog.Print(this.ToString() + " close");
            GameManager.Instance.UIManager.ShowLoadingScreen(true);
        }
    }
}
