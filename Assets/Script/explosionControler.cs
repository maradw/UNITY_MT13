using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionControler : MonoBehaviour
{
    private Animator _compAnimator;
    // Start is called before the first frame update
    void Awake()
    {
        _compAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DestroidObject()
    {
        Destroy(this.gameObject);
    }
}
