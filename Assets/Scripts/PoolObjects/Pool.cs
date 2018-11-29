using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchTree {
    public class Pool {

        private List<PoolObject> _poolObjects;
        private Transform _cachedTransform;

        public Pool(Transform poolManager, PoolData setupData) {
            InitPool(poolManager, setupData);
            for (int i = 0; i < setupData.AmountInstances; i++) {
                AddPoolObject(_cachedTransform, setupData);
            }
        }

        private void InitPool(Transform parent, PoolData setupData) {
            _poolObjects = new List<PoolObject>();
            GameObject pool = new GameObject(setupData.PoolObjectPrefab.name + "Pool");
            _cachedTransform = pool.transform;
            _cachedTransform.parent = parent;
        }

        private void AddPoolObject(Transform parent, PoolData setupData) {
            GameObject instanceGameObject = GameObject.Instantiate(setupData.PoolObjectPrefab, parent);
            PoolObject poolObject = instanceGameObject.AddComponent<PoolObject>();
            poolObject.SetPool(parent);
            if (_poolObjects != null) {
                _poolObjects.Add(poolObject);
                instanceGameObject.SetActive(false);
            }
            else {
                Debug.LogError("Pool objects list is null");
            }
        }

        private PoolObject ExpandPoolObject() {
            GameObject additionalInstance = GameObject.Instantiate(_poolObjects[0].gameObject);
            PoolObject poolObject = additionalInstance.GetComponent<PoolObject>();
            poolObject.SetPool(_cachedTransform);
            if (_poolObjects != null) {
                _poolObjects.Add(poolObject);
                poolObject.Despawn();
            }
            return poolObject;
        }

        public PoolObject GetFreeObject() {
            for(int i = 0; i < _poolObjects.Count; i++) {
                if (_poolObjects[i].IsUsed == false) {
                    return _poolObjects[i];
                }
            }
            Debug.LogWarning("All ojects is used, pool has been expand!");
            return ExpandPoolObject();
        }
    }
}