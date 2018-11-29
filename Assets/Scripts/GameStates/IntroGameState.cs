namespace MatchTree {
    public class IntroGameState : GameState {
        public override void InitState() {
            CustomDebugLog.Print(this.ToString() + " init");
            GameManager.Instance.UIManager.ChangeScreen(UIManager.ScreenTypes.IntroScreen);
            GameManager.Instance.UIManager.ShowLoadingScreen(false);
        }

        public override void CloseState() {
            CustomDebugLog.Print(this.ToString() + " close");
            GameManager.Instance.UIManager.ShowLoadingScreen(true);
        }
    }
}
