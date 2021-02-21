Game Engine Concepts \
Assignment 1 - FPS Microgame <br/><br/>
Task Breakdown\
_Task 1_ \
Completed the FPS Microgame tutorial. There’s not much to show for that in the project,
but I did like how the new Unity tutorials have the UI built into Unity \
_Task 2_ \
a) Three levels completed. Can be found in the “Scenes” folder\
b) Each level has at least 5 rooms and 20 enemies. Some of these enemies only appear in
hard mode\
c) KSU logo displayed near the beginning of each level. This sign is a texture edit from the
Sky City Lite asset\
d) Floor and wall textures replaced with textures from 3dtextures.me. I decided to go with
more realistic textures that are still sci-fi, because I wanted to take a closer look at all the
kinds of maps that the standard shader uses. Each of these uses about 7 different maps:
normal map, height map, ambient occlusion, etc. I actually ended up doing my own
texture packing on this because the ones here were for UE4.\
e) The scene receives lighting from the skybox, as well as lamps with point lights
throughout the scene.\
_Task 3_\
Implemented a system for difficulty where less enemies are there for the normal
difficulty. It works by all of the enemies for hard mode being in the scene. Each one of the
enemies that is only supposed to be in hard mode has a script on it called DifficultyDestroy that
checks the difficulty on Start and destroys itself if its normal mode.\
_Task 4_\
I created this document\
_Task 5_\
Created an Instant Cooldown pickup. When you pic this up, for a short period of time, the
cooldown on your weapon fills up almost instantaneously. Stop shooting and the cooldown
shoots back to normal. I edited the WeaponController Script from the FPS Microgame pack to
make this work. I added a couple modifying variable to the UpdateAmmo function. Also created
a Status Effect class for hte player, to track this kind of effect. Created a prefab with similar
effects to health pickup and a script on it that interfaces with the existing FPS Microgame pick
up system. <br/><br/>
_File Locations_\
A working build can be found in “Builds/Pc Build 1/”. Run GECAssignemnt1FPS.exe\
The Unity Folder is named “GECAssignment1FPS”\
The files I made from scratch are in the normal root folders (e.i. Scripts, Scenes, Prefabs)\
Any files from external assets are in the “External” folder, including ones I edited\
The textures I added are in the “3dtexture.me” folder. I created the materials here myself and
did texture packing for them.\
The Lamp posts and signs are from the “SKY city Lite” folder in External. Inside the props folder
here is the file “ads.psd” which I created insert eh KSU logo, overwriting the similarly named file. <br/><br/>
_Assets Used_\
Asset Store Assets\
FPS Microgame\
Starfield Skybox\
Sky City Lite\
Meshtint Free Santa Claus\
Internet Asset\
3dtextures.me - one artists repository of free use textures\
