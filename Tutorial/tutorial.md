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

- **Lib**: Contains the Unity implementation or Oyster, with scripts intended for direct use in a scene being prefaced with 'U_',
- **Editor**: Contains an editor script that Addressables uses to know how to handle the `.osf` file extension that Oyster uses for its scripts.

![An image of a lot of compile errors](Img/sec3_img2.png)

And..... Congratulations!

Now your blank project has one hundred and eight compile errors. This is due to the project not containing the engine-agnostic DLL. Please download the latest release of the DLL from [here](https://github.com/HeckingGoose/Oyster/releases/latest) and drag it into the assets folder of the project.

![An image of the compiler errors now gone](Img/sec3_img3.png)

As can be seen, once the DLL has been added, all compile errors should be gone. If this is not the case, then please let Jesus take the wheel as you write out an issue on this repository.

## Components to familiarize yourself with

This section will show screenshots of some GameObjects filled out with Oyster components.

### Player

#### Main Player

![An image showing the player talker](Img/sec4_img5.png)

The main player talker is relatively simple, with it simply acting as a container for all of the components which will be discussed below.

#### Camera

![An image showing an Oyster camera](Img/sec4_img1.png)

For Oyster, a camera only requires the `U_Camera` script. The purpose of this script is for 'Lookers' to work within Oyster. If Looker functionality is not wanted (take for example a 2D game where the camera cannot turn to face the character being spoken to), this component can be ignored, and on the player talker can be left as null.

#### Speech Display

A speech display is a set of objects (A name text, main text, name text backing, main text backing and a continue prompt) that when combined, create a display that Oyster can use to display the contents of the scripts it processes.

The speech display for the context of this tutorial will be made from a set of UI elements as seen below:

![An image of the recommended object structure](Img/sec4_img2.png)

Shown above is a recommended object structure for a speech display.

![An image of the speech display in the scene](Img/sec4_img3.png)

Shown above is a recommended layout for the speech display in the scene (name text is at top, main text is at bottom, continue prompt is black square).

![An image of the Oyster components for the speech display](Img/sec4_img4.png)

Shown above is an image of the 'SpeechDisplay' object, which has the related Oyster scripts that are passed into the player talker.

### Character



### Scene

## Writing your first script