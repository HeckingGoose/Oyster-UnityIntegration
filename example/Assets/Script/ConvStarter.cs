using Assets.Lib.OysterInterop;
using UnityEngine;

public class ConvStarter : MonoBehaviour
{
    // Editor Variables
    [Header("Thuh Conversation objects")]
    [SerializeField]
    private U_PlayerTalker _player;
    [SerializeField]
    private U_CharacterTalker _character;
    [SerializeField]
    private U_SceneScript _scene;

    // Unity Methods
    private void Start()
    {
        // Start a chat!
        _scene.StartChat(_player.Talker, _character.Talker);
    }
}
