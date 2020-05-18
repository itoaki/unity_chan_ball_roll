﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalChecker : MonoBehaviour
{
    public GameObject unityChan;
    public AudioSource gameBGM;
    public AudioSource goalBGM;
    public GameObject retryButton;
    // Start is called before the first frame update
    void Start()
    {
      retryButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) {
      other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
      unityChan.transform.LookAt(Camera.main.transform);
      unityChan.GetComponent<Animator>().SetTrigger("Goal");
      retryButton.SetActive(true);
      gameBGM.Stop();
      goalBGM.Play();
    }

    public void RetryStage() {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
