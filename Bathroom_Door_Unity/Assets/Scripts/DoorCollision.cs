using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollision : MonoBehaviour
{
    private Animator _animator;
    private AudioSource _audio;
    private bool _audioPlayed = false;
    public GameObject _water;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _audio = GetComponent<AudioSource>();

        _water.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _animator.SetBool("open", true);
            _water.SetActive(true);

            if (_audioPlayed == false)
            {
                _audioPlayed = true;
                _audio.Play();
            }
            
            
                        
        }
        
    }
}
