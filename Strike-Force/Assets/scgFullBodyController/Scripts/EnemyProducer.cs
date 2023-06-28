using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace scgFullBodyController
{
    public class EnemyProducer : MonoBehaviour
    {
        public bool shouldSpawn;
        public TextMeshProUGUI waveText;



        public HealthController[] enemyPrefabs;

        private Bounds spawnArea;
        private int enemy_count;
        private int wave_num;
        private int enemy_health;
        private GameObject player;

        public void SpawnEnemies(bool shouldSpawn)
        {
            if (shouldSpawn)
            {
                player = GameObject.FindGameObjectWithTag("user");
            }
            this.shouldSpawn = shouldSpawn;
        }

        void Start()
        {
            spawnArea = this.GetComponent<BoxCollider>().bounds;
            SpawnEnemies(shouldSpawn);
            enemy_count = 5;
            wave_num = 1;
            for (int i = 0; i < enemy_count; i++)
            {
                spawnEnemy();
            }
            waveText.text = "wave: " + wave_num.ToString();

        }

        Vector3 randomSpawnPosition()
        {
            float x = Random.Range(spawnArea.min.x, spawnArea.max.x);
            float z = Random.Range(spawnArea.min.z, spawnArea.max.z);
            float y = 0.7f;

            return new Vector3(x, y, z);
        }
        void Update()
        {
            int enemy_alive = 0;
            foreach (GameObject g in GameObject.FindGameObjectsWithTag("Player"))
                enemy_alive++;
            if (enemy_alive == 0)
            {
                enemy_count++;
                wave_num++;
                for (int i = 0; i < enemy_count; i++)
                {
                    spawnEnemy();
                }
            }
            waveText.text = "wave: " + wave_num.ToString();

        }
        void spawnEnemy()
        {
            int index = 0;
            if (shouldSpawn == false || player == null)
            {
                return;
            }
            enemy_health = 100 + 10 * (wave_num - 1);
            index = Random.Range(0, enemyPrefabs.Length);
            var newEnemy = Instantiate(enemyPrefabs[index], randomSpawnPosition(), Quaternion.identity);
            newEnemy.health = enemy_health;

        }

    }
}
