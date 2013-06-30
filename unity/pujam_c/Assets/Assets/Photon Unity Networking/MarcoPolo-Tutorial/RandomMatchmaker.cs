using UnityEngine;

public class RandomMatchmaker : Photon.MonoBehaviour
{
	public GUISkin guiSkin;
	
	[HideInInspector] public int droidPoint = 0;
	[HideInInspector] public int meraiPoint = 0;
	[HideInInspector] public bool gameStart = false;
	[HideInInspector] public bool gameEnd   = false;
	
	public  float gameLength;
	private float elapsed;
	
    private PhotonView myPhotonView;
	private int shoutMarco;
	
    // Use this for initialization
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("0.1");
    }

    void OnJoinedLobby()
    {
        Debug.Log("JoinRandom");
        PhotonNetwork.JoinRandomRoom();
    }

    void OnPhotonRandomJoinFailed()
    {
        PhotonNetwork.CreateRoom(null);
    }

    void OnJoinedRoom()
    {
		shoutMarco = PhotonNetwork.player.ID;
		GameObject monster;
		//monster = PhotonNetwork.Instantiate("3Dmodel/Doroid/DoroidPrefab", new Vector3(0,10,0), Quaternion.identity, 0);
		if (shoutMarco%2==0){
	        monster = PhotonNetwork.Instantiate("3Dmodel/Doroid/DoroidPrefab", new Vector3(0,10,0), Quaternion.identity, 0);
		}else{
				monster = PhotonNetwork.Instantiate("3Dmodel/doroimeraiSD/doroimerai", new Vector3(0,10,0), Quaternion.identity, 0);
		}
		//monster.GetComponent<myThirdPersonController>().isControllable = true;
        myPhotonView = monster.GetComponent<PhotonView>();
		
		//Camera.main.gameObject.GetComponent<TraceCharactor>().prefab = monster;
    }
	
	void Update(){
		int memberCount;
		
		memberCount = PhotonNetwork.playerList.Length;
		
		if( memberCount >= 2 && !gameStart ){
			Debug.LogError("Game Start!");
			gameStart = true;
		}
		
		if( gameStart ){
			elapsed += Time.deltaTime;
		
			if( elapsed >= gameLength ){
				//Debug.LogError("Time is over.");
				//gameEnd = true;
				//enabled = false;
			}	
		}
	}
	
	void addPoint(int pliayerId){
        if( pliayerId % 2 == 0 ){
			meraiPoint += 1;
        }
		
        if ( pliayerId % 2 == 1 ){
			droidPoint += 1;
		}
	}
	
    void OnGUI()
    {
		int sw = Screen.width;
		int sh = Screen.height;
		
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());

        if (PhotonNetwork.connectionStateDetailed == PeerState.Joined)
        {
            //bool shoutMarco = GameLogic.playerWhoIsIt == PhotonNetwork.player.ID;
			shoutMarco = PhotonNetwork.player.ID;
			Debug.Log (shoutMarco);
            if (shoutMarco%2==0 && GUILayout.Button("Marco!"))
            {
                myPhotonView.RPC("Marco", PhotonTargets.All);
            }
            if (shoutMarco%2==1 && GUILayout.Button("Polo!"))
            {
                myPhotonView.RPC("Polo", PhotonTargets.All);
            }
			
			if( gameStart && !gameEnd ){
				//GUI.enabled = false;
				//GUI.Label(new Rect(0, 100, sw / 2, sh / 4), "GAME START!!");
				
				string droid_score = "DROID : " + droidPoint;
				string merai_score = "MERAI : " + meraiPoint;
				
				//GUI.enabled = true;
				GUI.Label(new Rect(0, 50, sw / 2, sh / 4), droid_score);
				GUI.Label(new Rect(0, 70, sw / 2, sh / 4), merai_score);
			}
			
			if( gameStart && gameEnd ){
				//GUI.enabled = false;
				//GUI.Label(new Rect(0, 100, sw / 2, sh / 4), "GAME END!!");
			}
        }
    }
}
