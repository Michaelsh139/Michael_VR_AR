using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOverTime : MonoBehaviour {

    [SerializeField] private float lifeTime = 5;

    private void Awake()
    {
        Destroy(this.gameObject, lifeTime);
    }
}
