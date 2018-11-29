using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchTree {
    public abstract class Manager : MonoBehaviour {

        public virtual void Init() {
            CustomDebugLog.Print(this.ToString() + " is Init");
        }
    }
}
