using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance { get; private set; }

    [SerializeField] private TextMeshProUGUI scoreText;
    
     private int score = 0;
    // Start is called before the first frame update
    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    // Update is called once per frame
    private void OnEnable()
    {
        Player.OnScored += HandleScore;
    }
    private void OnDisable()
    {
        Player.OnScored -= HandleScore;
    }

    private void HandleScore()
    {
        ++score;
        UpdateScoreUI();

        AudioManager.Instance?.PlayScoreSound();
    
    }
    private void UpdateScoreUI()
    {
        scoreText.text = score.ToString();
    }
}
