using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private AudioSource audio; 
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        audio.Play();
        animator.Play("AnimationExplosion");

    }

    private void Update()
    {
        if (!audio.isPlaying)
        {
            Destroy(gameObject);
        }
    }

}
