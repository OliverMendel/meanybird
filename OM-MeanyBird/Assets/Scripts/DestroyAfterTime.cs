using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("Default Obliteration With A Flamethrower Time")]
    public float timeToDestruction;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", timeToDestruction);
    }

    void DestroyMe () {
        Destroy (gameObject);
    }
}

