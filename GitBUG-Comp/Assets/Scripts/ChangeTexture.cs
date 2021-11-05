using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class (as per name) changes the texture of a sprite, it creates a new component and you set the initial and the one you want to change it too
//I have not tested this with a Player, only with theh backgrounds and stuff (tiles)
//When I entered play mode, the texture of the sprite changed. It did not change in the initial design
//this will allow us to change the textures to the art when we get it (hopefully) so we don't have to redo the whole thing with the custom sprites
public class ChangeTexture : MonoBehaviour
{
    //variables
    SpriteRenderer _SpriteRenderer; //Sprite Renderer object (initial texture)
    public Sprite [] textures;      //Array of textures, can set how many you want in the component, though right now it is only set to have 2


    // Start is called before the first frame update
    private void Start()
    {
        _SpriteRenderer = GetComponent<SpriteRenderer>();   //gets sprite renderer component
        _SpriteRenderer.sprite = textures[0];               //initializes sprite texture to be the original texture of the component
    }

    // Update is called once per frame
    private void Update()
    {
        //if the sprite has the initial texture, change it to the desired one
        if(_SpriteRenderer.sprite = textures[0])
        {
            _SpriteRenderer.sprite = textures[1];
        }
    }

}
