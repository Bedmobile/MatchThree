using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchTree {
    public abstract class Screen : MonoBehaviour {

        public virtual void Init() {
            CustomDebugLog.Print(this.ToString() + " is Init");
        }

        public abstract void Show();
        public abstract void Hide();
    }
}