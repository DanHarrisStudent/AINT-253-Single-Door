using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollision : MonoBehaviour
{
    private Animator _animator;
    private AudioSource _audio;

    private Animator _reverseAnimation;

    

    void Start()
    {
        _animator = GetComponent<Animator>();
        _audio = GetComponent<AudioSource>();
        _reverseAnimation = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _animator.SetBool("open", true);
            _audio.Play();

        }
    }
    void ReverseAnimation()
    {
        
    }
}
