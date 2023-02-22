# UnityToJavascript_DinoGame_Example
Example on how to use javascript to act as a brdige between an OpenBCI Ganglion Device and the Unity game engine in a WebGL build

## Note: In order to get Webgl to build in Unity you have to disable compression in the build settings, otherwise the engine will not load.  
* build settings -> player settings -> player -> publishing settings -> compression format -> disabled (default is brotli change this to disabled)
* Currently only working with microsoft edge browser.
* This demo is currently a work in progress and the data from the BCI device needs to be filtered before the game is playable.

## Demo Description
This program establishes a connection between javascipt, an OpenBCI ganglion datastream, and Unity 2021.3.13 utilizing the WEBGL framework.  This example has the dino jump whenever a threshold value is crossed by the input from the bci device.

## Setup
1. Create a new unity project. (Unity 2021.3.13 perfered, may or may not work with future versions.)
2. Import the Ganglion_To_Unity_Example_DinoGame.unitypackage into your new unity project.
3. Build the project in Unity.
    * Note: make sure to disable compression in the build settings as mentioned in the beginning of this readme
4. Once built go to {_YourProjectName_} -> build -> index.html in the file structure of your unity project.
    * Take the index.html file from this example and compare it to the one generated in your project
    * All changes made to the index.html file have been denoted inside a "comment block".  I've used 4 * (****) to differentiate my comments from the comments generated by Unity in the index.html file.
    * Example:\
                // **** Initialize myGameInstance\
                var myGameInstance = null;\
                // **** END of addition

## Troubleshooting
* If your project builds but the game doesn't load. (Stuck on black screen with unity logo in browser)  This is likely a problem with the build settings.  Double check compression is off.
* When clicking the connect button in the webpage, if nothing happens use a different browser.

## Credit
The base game of this demo was created following the tutorial below.  This "game" is a clone of google's offline dino game.
https://www.youtube.com/watch?v=UPvW8kYqxZk