using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemen : MonoBehaviour
{
    // Init
    public float moveSpeed = 0.2f;

    // Properties
    private Animator myAnimator;
    private SpriteRenderer mySpriteRenderer;

    void Start()
    {
        // Animator
        myAnimator = GetComponent<Animator>();

        // Sprite
        mySpriteRenderer = GetComponent<SpriteRenderer>();
  
    }
}
