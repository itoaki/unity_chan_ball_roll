using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPalyer : MonoBehaviour
{
    public GameObject player;
    Vector3 ofset;
    // Start is called before the first frame update
    void Start()
    {
      ofset = this.transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = player.transform.position + ofset;
    }
}
