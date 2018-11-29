using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchTree {
    public class LoadingScreen : Screen {

        public override void Hide() {
            CustomDebugLog.Print(this.ToString() + "Hide");
            gameObject.SetActive(false);
        }

        public override void Show() {
            CustomDebugLog.Print(this.ToString() + "Show");
            gameObject.SetActive(true);
        }
    }
}
