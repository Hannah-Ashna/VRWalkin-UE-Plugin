# VRWalkin' Unreal Engine Plugin
VRWalkin' is a compilation of blueprint locomotion paradigms for Virtual Reality. This plugin was initially designed to be utilised within a VR Travel Training tool as part of my undergraduate dissertation. At the end of that project, I decided to package and release the locomotion paradigms on GitHub so that others looking to explore the different facets of locomotion within VR were able to do so with ease. In case you're interested in learning more about the research that went with this plugin, you can find it *[here]() [COMING SOON]*. 

### Installing the Plugin
I've written up a handy little guide on the whole process that you can find via this [link](https://hannah-ashna.github.io/VRWalkin-UE-Plugin/). 

### How to use it
The different VR characters work similarly to how you'd use the engine's VR Pawn. Simply set the level gamemode to use any of the provided ones and hit play. In case you run into errors where the trigger or grip buttons aren't working, you may need to first setup these input options via your project settings. Make sure you use the same names as the ones in the blueprints (or just update the BPs to use your version!).

For a lot of these different paradigms, you'll also need to ensure you've got a NavMeshBounds volume setup for the space that you'd like to navigate. Without this, you may experience some challenges with getting the paradigms to work. 

### Demonstration
In case you'd just like to see how it in action along with a brief explanation on the research that accompanies it, you can watch the demo video [here]().
