using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Photon.Realtime;

namespace FG.Online
{
    public class DemoPhoton : MonoBehaviourPunCallbacks
    {
        public TextMeshProUGUI textState;
        public TMP_InputField IpInputField;
        public Button buttonCreateRoom;
        public Button joinRoom;
        private void Start()
        {
            PhotonNetwork.ConnectUsingSettings();
            buttonCreateRoom.onClick.AddListener(CreateRoom);
        }
        public override void OnConnectedToMaster()
        {
            base.OnConnectedToMaster();
            PhotonNetwork.JoinLobby();

            textState.text = "Loading";
        }
        public override void OnJoinedLobby()
        {
            base.OnJoinedLobby();
            textState.text = "Connected";
        }
        public void CreateRoom()
        {
            RoomOptions roomOptions = new RoomOptions();
            roomOptions.MaxPlayers = 4;

            PhotonNetwork.CreateRoom(IpInputField.text,roomOptions);
        }
        public override void OnCreatedRoom()
        {
            base.OnCreatedRoom();

            PhotonNetwork.LoadLevel("Learn");
        }
        public override void OnCreateRoomFailed(short returnCode, string message)
        {
            base.OnCreateRoomFailed(returnCode, message);
        }
    }

}