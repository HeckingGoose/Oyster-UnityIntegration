# Oyster - Unity Integration

This repository contains an example integration for Oyster with Unity.

# Requirements

This integrations requires a few other Unity packages:

- Addressables,
- TextMeshPro.

Please ensure these are in your project before adding the Unity integration.

# Integrating into a project

To add this integration into a project, download the `.unitypackage` file from the [releases](https://github.com/HeckingGoose/Oyster-UnityIntegration/releases/latest) section and import it into a project. This can either be done by double clicking the Unity package and selecting your Unity version, or dragging the Unity package into the assets folder of your project via the editor.

This integration does not ship with the core Oyster DLL, please download the latest release of the core Oyster library from [here](https://github.com/HeckingGoose/Oyster/releases/latest) and ensure it is placed within your project's 'Assets' folder.

## Tutorial

For a more in-depth tutorial for setting up this integration with a blank Unity project, please see the [tutorial](Tutorial/tutorial.md).

# Testing it out

To test out the integration, clone this repository and open the 'Example' unity project in Unity 6000.2.10f1.

The project contains the minimum required functionality to integrate this integration in with a Unity project, along with a few extra scripts that are used to control the demo conversation.
