﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    public float jumpForce = 10;
    public float gravityMod;

    public bool isGrounded = true;

    public bool gameOver = false;

    private Animator playerAnim;

    // Particle effects

    public ParticleSystem explosionParticle;

    public ParticleSystem dirtParticle;
    // Sound Effects
     
    public AudioClip jumpSound;

    public AudioClip crashSound;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityMod;
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true && !gameOver)
        {

            isGrounded = false;
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            isGrounded = true;
            
            
        }
    }

    void OnCollisionEnter(Collision other)
    {
         if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            dirtParticle.Play();
        }

    else if (other.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over Man! -- Game Over");
            explosionParticle.Play();
            playerAudio.PlayOneShot(crashSound, 1.0f);
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            dirtParticle.Stop();
        }
    }
}
