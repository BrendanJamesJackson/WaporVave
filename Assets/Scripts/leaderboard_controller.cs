using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using LootLocker.Requests;
using UnityEngine;
using TMPro;

public class leaderboard_controller : MonoBehaviour
{
    public TMP_InputField player_name, player_score;
    public int ID;

    //public TextMeshPro player_names, player_scores;

    private void Start()
    {
        StartCoroutine(LoginRoutine());

    }

    IEnumerator LoginRoutine()
    {
        bool done = false;
        LootLockerSDKManager.StartGuestSession((response) =>
        {
            if (response.success)
            {
                Debug.Log("Player logged in");
                PlayerPrefs.SetString("PlayerID", response.player_id.ToString());
                done = true;
            }
            else
            {
                Debug.Log("Could not start session");
                done = true;
            }
        });
        yield return new WaitWhile(() => done == false);
    }

    public void SubmitScore(int score)
    {
        LootLockerSDKManager.SubmitScore(PlayerPrefs.GetString("PlayerID"), score, ID, (response) =>
        {
            if (response.success)
            {
                Debug.Log("Success");
                SetPlayerName();
            }
            else
            {
                Debug.Log("Failed");
            }
        });
        //FetchHighScores();
    }

    public void SetPlayerName()
    {
        LootLockerSDKManager.SetPlayerName(PlayerPrefs.GetString("PlayerName"), (response) => 
        {
            Debug.Log("Set player name");
        });
        
    }

    public void FetchHighScores()
    {
        LootLockerSDKManager.GetScoreList(ID, 10, 0, (response) =>
        {
            if (response.success)
            {
                string TempPlayerNames = "Names\n";
                string TempScores = "Scores\n";

                LootLockerLeaderboardMember[] members = response.items;

                for (int i = 0; i < members.Length; i++)
                {
                    TempPlayerNames += members[i].rank + ". ";
                    if (members[i].player.name != "")
                    {
                        TempPlayerNames += members[i].player.name;
                    }
                    else
                    {
                        TempPlayerNames += members[i].player.id;
                    }
                    TempScores += members[i].score + "\n";
                    TempPlayerNames += "\n";
                }

            }
            else
            {
                Debug.Log("Failed" + response.Error);
            }

        });
    }
}
