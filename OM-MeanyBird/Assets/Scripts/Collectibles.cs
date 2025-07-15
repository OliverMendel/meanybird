using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    
    private void OntriggerEnter2D(Collider2D collision)
        {
            Score.score++;
            Debug.Log("ScoreTouched");
        }

}
