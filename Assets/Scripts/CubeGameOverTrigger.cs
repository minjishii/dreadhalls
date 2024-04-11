using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeGameOverTrigger : MonoBehaviour
{
    // Oyuncu bir nesneye temas ettiğinde tetiklenir
    private void OnTriggerEnter(Collider other)
    {
        // Temas eden nesne bir karakter mi kontrol ediyoruz
        if (other.CompareTag("Player"))
        {
            // Game Over sahnesine geçiş yap
            SceneManager.LoadScene("GameOverScene");
        }
    }
}

