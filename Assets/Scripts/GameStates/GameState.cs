using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchTree {
    public abstract class GameState {
        public abstract void InitState();
        public abstract void CloseState();
    }
}
