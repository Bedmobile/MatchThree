using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchTree {
    public static class CustomDebugLog {

        public static void Print(string info) {
            if (GameManager.Instance.CustomLogIsEnable) {
                Debug.Log(info);
            }
        }
    }
}
