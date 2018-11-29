using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchTree {
    public class PoolManager : Manager {

        public PoolData CandyPoolData;
        public Pool CandyPool;

        public PoolData TileMapPoolData;
        public Pool TileMapPool;

        public override void Init() {
            base.Init();
            CandyPool = new Pool(transform, CandyPoolData);
            TileMapPool = new Pool(transform, TileMapPoolData);
        }
    }
}