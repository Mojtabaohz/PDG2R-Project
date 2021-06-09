using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class collectibleBubbles : MonoBehaviour
    {
        [SerializeField] private GameObject[] happinessBubbles = null;
        [SerializeField] private float _bubbleSpawnRate = 4.5f;
        private float _moneyBagTimer;
        private HappinessManager happinessManager;
        private void Start()
        {
            happinessManager = FindObjectOfType<HappinessManager>();
        }

        private void Update()
        {
            SpawnHappinessBubble();

        }
        void SpawnHappinessBubble()
        {
            _moneyBagTimer += Time.deltaTime;
            if (_moneyBagTimer >= _bubbleSpawnRate)
            {
                var bubbleObject = happinessBubbles[happinessManager.happinessValue];
                _moneyBagTimer = 0;
                Instantiate(bubbleObject, new Vector3(Random.Range(-10, 35), 3, Random.Range(-5, -35)), Quaternion.identity);
            }
        }

        
        
    }
