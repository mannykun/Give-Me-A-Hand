    using UnityEngine;
    using System.Collections;

    public class SequentialAudioPlayer : MonoBehaviour
    {
        public AudioSource audioSource1;
        public AudioSource audioSource2;

        private AudioSource currentAudioSource;
        private AudioSource nextAudioSource;

        void Start()
        {
            // Initialize the current and next audio sources
            currentAudioSource = audioSource1;
            nextAudioSource = audioSource2;

            // Start playing the first track
            currentAudioSource.Play();

            // Schedule the next track to play when the current one finishes
            StartCoroutine(PlayNextTrackWhenFinished());
        }

        IEnumerator PlayNextTrackWhenFinished()
        {
            while (true)
            {
                // Wait until the current audio source finishes playing
                yield return new WaitForSeconds(currentAudioSource.clip.length - currentAudioSource.time);

                // Swap the current and next audio sources
                AudioSource temp = currentAudioSource;
                currentAudioSource = nextAudioSource;
                nextAudioSource = temp;

                // Play the new current audio source
                currentAudioSource.Play();
            }
        }
    }