using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Tooltip("Cantidad de puntos que obtienes al derrotar al enemigo")]
    public int pointsAmount = 1;

    private void Start() {
        EnemyManager.SharedInstance.enemies.Add(this);
    }

    private void OnDestroy() {
        EnemyManager.SharedInstance.enemies.Remove(this);
        ScoreManager.SharedInstance.Amout += pointsAmount; 
    }
}
