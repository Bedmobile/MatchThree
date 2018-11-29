using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchTree {
    public class ContentManager : Manager {

        public Sprite TileDarkSprite;
        public Sprite TileCommonSprite;

        public override void Init() {
            base.Init();
            CustomDebugLog.Print("Content");
        }
    }
}
