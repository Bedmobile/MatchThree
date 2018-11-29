using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatchTree {
    public class PoolObject : MonoBehaviour {
        private Transform _poolTranform;
        private bool _isUsed = false;
        public bool IsUsed {
            get {
                return _isUsed;
            }
        }

        public void SetPool(Transform poolTransform) {
            _poolTranform = poolTransform;
        }

        public void Spawn(Transform targetTransform) {
            gameObject.SetActive(true);
            transform.parent = targetTransform;
            _isUsed = true;
        }

        public void Despawn() {
            gameObject.SetActive(false);
            transform.parent = _poolTranform;
            transform.localScale = Vector3.one;
            transform.localRotation = Quaternion.identity;
            _isUsed = false;
        }
    }
}