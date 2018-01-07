using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class LadderboardController : MonoBehaviour {
    
    // Use this for initialization
    void Start (){
        //Previus coude
        //PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        //PlayGamesPlatform.InitializeInstance(config);
        //PlayGamesPlatform.Activate();
        //---------------------



        // ADD THIS CODE BETWEEN THESE COMMENTS

        // Create client configuration
        PlayGamesClientConfiguration config = new
           PlayGamesClientConfiguration.Builder()
           .Build();

        // Enable debugging output (recommended)
        PlayGamesPlatform.DebugLogEnabled = true;

        // Initialize and activate the platform
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();
        // END THE CODE TO PASTE INTO START

        //try silent sign in
        //PlayGamesPlatform.Instance.Authenticate(SignInCallback, true);
        
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Connect()
    {
        //Social.localUser.Authenticate(success => { });
        //Debug.Log("Loged In");

        if (!PlayGamesPlatform.Instance.localUser.authenticated)
        {
            // Sign in with Play Game Services, showing the consent dialog
            // by setting the second parameter to isSilent=false.
            PlayGamesPlatform.Instance.Authenticate(SignInCallback, false);
        }
    }
    
    public void SignInCallback(bool success)
    {
        //stuffs
    }

    public void OnLeaderboardClick()
    {
        Connect();
        Social.ShowLeaderboardUI();
        Debug.Log("Show leaderboard");
    }

    

    public void ReportScore(int score)
    {
        Social.ReportScore(score, Constants.leaderboard_highscore, (bool success) => {
            Debug.Log("Reported Score to Leaderboard " + success.ToString());
        });
    }
}
