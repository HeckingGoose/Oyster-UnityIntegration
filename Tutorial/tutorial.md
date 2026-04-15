# Setting up the Unity integration with a new project

## Making a new project

![An image of a new project being created](Img/sec1_img1.png)

The Unity integration is designed to work with any Unity project without requiring a specific version of Unity, but for this tutorial, the Universal 3D template will be used, along with Unity 6000.2.10f1. Regardless, the majority of this tutorial should remain relevant for differing Unity versions and project templates.

## Preparing the project for the Unity integration

Once the project is open, ensure the Addressables and TextMeshPro packages are added to the project.

### Adding Addressables

In the title bar of the Unity editor, select 'Window &rarr; Package Management &rarr; Package Manager'.

In the furthest left section of the window that opens, select 'Unity Registry'. Then in the search bar, search for 'Addressables'.

![An image showing addressables in the package manager](Img/sec2_img1.png)

Select the package titled 'Addressables' and press 'Install'. After a small moment, Addressables will be ready for use within the project.

### Adding TextMeshPro

To add TextMeshPro to a project, right click within the scene hierarchy and select either '3D Object &rarr; Text - TextMeshPro' or 'UI &rarr; Text - TextMeshPro'.

Pressing either of these options will cause the window shown below to appear:

![An image showing the TextMeshPro importer](Img/sec2_img2.png)

Select 'Import TMP Essentials' and after a few moments, TextMeshPro will be ready for use with your project.

## Importing the Unity integration

Download the most recent release of the Unity integration from [here](https://github.com/HeckingGoose/Oyster-UnityIntegration/releases/latest).

Drag and drop the downloaded `.unitypackage` file into the root of your project's 'Assets' folder.

![An image of the UnityPackage importer](Img/sec3_img1.png)

In the window that appears, leave all items ticked and select 'Import' in the bottom right of the window.

For a quick explanation on the two main folders:

- **Lib**: Contains the Unity implementation for Oyster, with scripts intended for direct use in a scene being prefaced with 'U_',
- **Editor**: Contains an editor script that Addressables uses to know how to handle the `.osf` file extension that Oyster uses for its scripts.

![An image of a lot of compile errors](Img/sec3_img2.png)

And..... Congratulations!

Now your blank project has one hundred and eight compile errors. This is due to the project not containing the engine-agnostic DLL. Please download the latest release of the DLL from [here](https://github.com/HeckingGoose/Oyster/releases/latest) and drag it into the assets folder of the project.

![An image of the compiler errors now gone](Img/sec3_img3.png)

As can be seen, once the DLL has been added, all compile errors should be gone. If this is not the case, then please let Jesus take the wheel as you write out an issue on this repository.

## Setting the scene

To start with, let's remove all objects from the scene and then create a new GameObject for the player and place a `U_PlayerTalker` script on it.

![An image showing the start of a player object](Img/sec4_img1.png)

This script acts as a central way for Oyster to access functionality relating to the player. Let's now add a camera to the player by creating a new GameObject that will be a child of the player object, and giving it a `Camera` component, then a `U_Camera` component so that Oyster can access the camera's functionality.

![An image showing the camera object](Img/sec4_img2.png)

Now we can start work on a speech display for the player, to start with let's create a new canvas to place the components on, and then on that canvas create the following structure:

![An image showing the current state of the scene](Img/sec4_img3.png)

Here is a quick discussion of each of these components:

- **SpeechDisplay**: The root GameObject for the speech display, does not need to contain any extra scripts,
- **MainTextBack**: An image that will be behind the main text that Oyster uses to show dialogue on screen, add a `U_ShowAndHide` to this GameObject,
- **MainText**: The aforementioned main text that Oyster uses to show dialogue on screen, add a `U_TextField` to this GameObject,
- **NameTextBack**: An image that will be behind the text that Oyster uses to show a character's name, add a `U_ShowAndHide` to this GameObject,
- **NameText**: The aforementioned text that Oyster uses to show a character's name, add a `U_TextField` to this GameObject,
- **ContinuePrompt**: This component is not absolutely required for the speech display, but when Oyster is waiting for input from the user (as in to click to continue text), this GameObject will be toggled between shown and hidden, add a `U_ShowAndHide` to this GameObject.

These components may be laid out anywhere on the canvas, with most of them actually being optional (for example you may not want to have a NameText), for the sake of this tutorial, they will be laid out as shown below (where the top text field and box are the NameText and the bottom box and text field are the MainText, with the black square being the continue prompt):

![An image showing a speech display](Img/sec4_img5.png)

Now that we have our speech display set-up properly, we can start dragging these components onto their respective places on the player talker, creating this:

![An image showing the completed player talker](Img/sec4_img4.png)

Congratulations! You have set up a player for use with Oyster. Next on the agenda is to set-up a scene script, which is as simple as creating a blank GameObject anywhere in the scene and adding a `U_SceneScript` component to it:

![An image showing a blank scene script](Img/sec4_img6.png)

For this script, nothing needs to be changed for it to work, however an explanation of each component of it will be given:

- **Hide in Conversation**: This is an array of `U_ShowAndHide` that will be hidden when a conversation is started, and shown when a conversation ends. The purpose being to hide any unwanted UI elements when a conversation is started,
- **Look Targets**: This is an array of look targets that Oyster will reference when running the [Set_Looker](https://oyster.abulman.com/writing/supportedcommands/base/set_looker) command.

```csharp
...

private void Update()
{
    // Give Oyster a heartbeat
    OysterMain.Update(Time.deltaTime);
}

...
```

Taking a look inside of the scene script, it can be seen that it calls the `Update` function of Oyster. This acts as the heartbeat of Oyster and is what allows Oyster to frequently run its `Tick` function. Effectively, having more than one scene script in a scene would end up with this function being called too frequently, so please don't do that. Or do. It's your choice.

(I aint got past this point in makin it yet m8. sozzo)

## Writing your first script