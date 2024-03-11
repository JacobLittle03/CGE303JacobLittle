using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTriggerZone : MonoBehaviour
{

    public AudioClip collectSound;
    private AudioSource playerAudio;

    bool active = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        playerAudio = GetComponent<AudioSource>();

        if (active && collision.gameObject.tag == "Player")
        {
            active = false;
            ScoreManager.score++;
            playerAudio.Play();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
