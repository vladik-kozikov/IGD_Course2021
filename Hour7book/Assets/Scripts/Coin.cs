using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    static int _coinsCounter = 0;
    private bool _isCollected = false;

    private Vector3 _startPosition;
    // Start is called before the first frame update
    private float _amplitude=0.25f;
    public static event EventHandler OnCoinCollected;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !_isCollected) {
            transform.Translate(5f, 0f, 0f);
            Destroy(gameObject);
            _coinsCounter++;
            print("Collected coins: " + _coinsCounter);
            _isCollected = true;
            OnCoinCollected?.Invoke(this,EventArgs.Empty);
        }
    }

    private void Awake()
    {
        _startPosition = transform.position;
    }

    void FixedUpdate()
    {
        transform.position=Mathf.Cos(1.5f*Time.fixedTime)*_amplitude*Vector3.up+_startPosition;
        transform.Rotate(0f, 1f, 0f);
    }

    public static int GetAmountOfCollectedCoins()
    {
        return _coinsCounter;
    } 
    public static void ResetCollectedCoins()
    { 
        _coinsCounter=0;
    }


}
