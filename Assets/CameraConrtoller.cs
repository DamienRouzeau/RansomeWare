using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConrtoller : MonoBehaviour
{
    
    public AudioSource CyberSecExpertSound;
    public float _timer;
    public int _indexAnimation = 0;
    public Animator ransomewareAnim;
    public AudioSource ransomwareSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _timer -= Time.deltaTime;
        if(_indexAnimation == 1)
        {
            if(_timer <= 0)
            {
                _timer = 99999;
                ransomewareAnim.SetTrigger("start");
                ransomwareSound.Play();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CyberSecExpert"))
        {
            CyberSecExpertSound.Play();
            SetTimer(18.3f);
        }
    }

    private void SetTimer(float timer)
    {
        _timer = timer;
        _indexAnimation++;
    }
}
