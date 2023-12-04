using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                                                                           // a

public enum GameMode                                                                                // b
{
    idle,
    playing,
    levelEnd
}

public class MissionDemolition : MonoBehaviour
{
    static private MissionDemolition S; // a private Singleton                      // c

    [Header("Inscribed")]
    public Text uitLevel; // The UIText_Level Text
    public Text uitShots; // The UIText_Shots Text
    public Text uitBest;
    public Vector3 castlePos; // The place to put castles
    public GameObject[] castles; // An array of the castles

    [Header("Dynamic")]
    public int level; // The current level
    public int levelMax; // The number of levels
    public int shotsTaken;
    public GameObject castle; // The current castle
    public GameMode mode = GameMode.idle;
    public string showing = "Show Slingshot"; // FollowCam mode

    [SerializeField]
    private int bestScore = 100; // The best score variable with a default value

    void Start()
    {
        S = this; // Define the Singleton                                                   // c

        level = 0;
        shotsTaken = 0;
        levelMax = castles.Length;

        if (!PlayerPrefs.HasKey("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", bestScore);
            PlayerPrefs.Save();
        }
        bestScore = PlayerPrefs.GetInt("BestScore", 100);

        StartLevel();
    }

    void StartLevel()
    {
        // Get rid of the old castle if one exists
        if (castle != null)
        {
            Destroy(castle);
        }

        Projectile.DESTROY_PROJECTILES(); // This will be underlined in red         // d

        // Instantiate the new castle
        castle = Instantiate<GameObject>(castles[level]);
        castle.transform.position = castlePos;

        // Reset the goal
        Goal.goalMet = false;

        UpdateGUI();

        mode = GameMode.playing;

        // Zoom out to show both
        FollowCam.SWITCH_VIEW(FollowCam.eView.both);
    }

    void UpdateGUI()
    {
        // Show the data in the GUITexts
        uitLevel.text = "Level: " + (level + 1) + " of " + levelMax;
        uitShots.text = "Shots Taken: " + shotsTaken;
        uitBest.text = "Best: " + GetBestScore();
    }
    int GetBestScore()
    {
        // Implement logic to retrieve the best score
        // For now, returning the initialized bestScore
        return bestScore;
    }


    void Update()
    {
        UpdateGUI();

        // Check for level end
        if ((mode == GameMode.playing) && Goal.goalMet)
        {
            // Change mode to stop checking for level end
            mode = GameMode.levelEnd;
            // Zoom out to show both
            FollowCam.SWITCH_VIEW(FollowCam.eView.both);
            // Start the next level in 2 seconds
            Invoke("NextLevel", 2f);                                                                             // e
        }
    }

    void NextLevel()                                                                                            // e
    {

        if (shotsTaken < bestScore)
        {
            bestScore = shotsTaken;
            PlayerPrefs.SetInt("BestScore", bestScore);
            PlayerPrefs.Save();
        }
        level++;
        if (level == levelMax)
        {
            level = 0;
            shotsTaken = 0;
        }
        StartLevel();
    }
    
    // Static method that allows code anywhere to increment shotsTaken
    static public void SHOT_FIRED()                                                                             // f
    {
        S.shotsTaken++;
    }

    // Static method that allows code anywhere to get a reference to S.castle
    static public GameObject GET_CASTLE()                                                                       // g
    {
        return S.castle;
    }
    // New method to reset the score
   
}