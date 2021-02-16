using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class collectibleBubbles : MonoBehaviour
    {
        [SerializeField] private GameObject[] moneyBag;
        [SerializeField] private float _bubbleSR = 1;
        private float _moneyBagTimer;
        private void Update()
        {
            SpawnMoneyBag();

        }
        void SpawnMoneyBag()
        {
            _moneyBagTimer += Time.deltaTime;
            if (_moneyBagTimer >= _bubbleSR)
            {
                var bubbleObject = moneyBag[Random.Range(0, moneyBag.Length)];
                _moneyBagTimer = 0;
                Instantiate(bubbleObject, new Vector3(Random.Range(-10, 10), 7, Random.Range(-10, 10)), Quaternion.identity);
            }
        }

        float RandomX(float posX)
        {
            return Random.Range(-20, 20);
        }
    }
