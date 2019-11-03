## 10-8-2019 - Making the first records of this project
- - - - 
This is where I'll be keeping a record of all the conceptual and technical work for my tentatively titled Toast Game, and where it will remain for posterity as reference for future generations to marvel at the genius of some rando's senior year Game Engine Scripting midterm project.  
So, the requirements for this project atm are a little sparse. All that's due on the 14th is a filled-out version of a basic design document and a prototype Unity project that isn't empty. And I've got both those things! For the first chunk of this entry, I'm going to copy in some of my text from the design doc. It is of course subject to change, and in the case that I make any life-altering edits I'll record them in the subsequent journal entry.

> **Mantra or Tagline:** A single-sentence description of the game that you will use to guide design decisions
>
> "A point-and-shoot game where you launch toast out of a toaster."
>
> **Design Pillars:** Up to three words or phrases that convey the feeling or emotion that you want the player to experience
>
> "Cute, silly, fun."
>
> **Story or Gameplay Summary:** List what the game is from a gameplay and/or story perspective
>
> "This game has the player aim a toaster on a rotating axis and launch toast onto targets."
>
> **Storyboard:** What's the arc of the gameplay? Your storyboard should have three-six frames.
>
>> ![alt text](https://66.media.tumblr.com/7cc6d9a7560f1d37204d5d4590da4856/tumblr_pzfgztz0Hs1s5zyrgo2_540.jpg "Storyboard")
>
> **Feature List:** List all of the features that you want to include in your game
>
> * Spinning toaster player
> * Launcing toast from toaster
> * Targets to aim toast at
> * 3D environment
> * Sound effects for all actions
> * Ambient soundtrack
> * Timer that counts down
> * UI that tracks points 
>
> **References:** Link to at least three other pieces of media that have something similar to whar you are trying to accomplish and explain which element you are interested in
>
> * [I am Bread](http://www.iambreadgame.com/): Kitchen shenanigans, bread theming
> * [Catlateral Damage](http://www.catlateraldamage.com/): Silliness, tone, art style
> * [Little Inferno](https://tomorrowcorporation.com/littleinferno): Deeply simplistic single mechanic hiding real depth 
>
> **Target Audience and Platform:** Who is the target audience for the game? How do they play it?
>
> The game will be a simple PC mouse-and-keyboard game, and the audience is other developers who enjoy mechanically simple cute, free games on itch.io.
>
> **Asset Research:** Look through free resources to find assets you are considering for your project.
?
> * [Kenney's Furniture Kit](https://www.kenney.nl/assets/furniture-kit)
> * [Youtube Audio Library](https://www.youtube.com/audiolibrary/music?nv=1)
> * [Zapsplat](https://www.zapsplat.com/music/modern-toaster-pop-up-3/)

In addition to filling out and turning in this document, I also did an amount of work in-engine. I downloaded and installed the furniture asset pack, I created a toast prefab and wrote a couple of scripts to instantiate toast when you hit the spacebar and to move the camera with mouse movement. That was the basic prototype that I turned in. The only functionality was:

1. Mouse-tracking camera movement
2. Instantiate toast prefab on spacebar down
3. Rigidbody on toast lets physics interact with it
4. Collider on ground keeps toast from falling indefinitely

## 10-14-2019 - Making the toast fly in the direction the camera is facing & adding the environment
- - - -
When I arrived in class Monday morning and opened my Unity project, the first thing that struck me was that while the toast launched perfectly, it only did so on the z-axis and was indifferent to the direction the camera was facing. 

![alt text](https://66.media.tumblr.com/38680b5590e1b9daea2a4a3436d66106/tumblr_pzfgztz0Hs1s5zyrgo1_540.jpg "Toast Pile Screenshot")

Referencing the basketball-throwing script from the earlier Space Jam class project, I wrote a handful of lines and then spent time debugging, only for nothing I wrote to be working. It took me and my professor half an hour to realize I was referencing the toast prefab instead of the instantiated game object. After I fixed that, it worked great. Funny how that works.

After I got that squared away, I started adding the environment assets. I started with the floor, which I made out of four 4x-sized tiles arranged in a square. I added box colliders and the "floor" physic material. After that, I added the walls. Since right now the room is just a cube with solid walls, I'm going to replace some of the wall tiles with window and door tiles. I'm planning on adding basic furniture like counters and tables next to fill out the environment and maybe add additional fun interactions with the flying/falling toast.

## 10-21-2019 - Filling in the environment
- - - -
I spent a period of time filling in the environment with assets. I started by replacing chunks of the walls with pieces that include windows and doorways, and then edited them slightly (opening the windows, adding the doors). Then I added a handful of kitchen counters in one corner, and added a refrigerator and a stove. I populated the counter with a coffee maker and a radio, and a trash can next to the fridge. I then added a round kitchen table and some chairs, and moved the camera to sit on top of the table. I noticed that the table blended into the floor, so I added a red rug under the table and resized it until it could be seen all around the table regardless of where the camera was pointed. 

![alt text](https://66.media.tumblr.com/3f5673d6cabc555b9f3bc503e138cccf/be347ab0aed27097-dc/s540x810/d02a04cc583a9df31b22c34f2abdaceba7d25483.jpg "Environment Screenshot")

## 10-28-2019 - Menu screens and spawning plates
- - - -
Using the UI tutorial project that we did in class, I created the menu scene and UI. It has two panels: a start menu and a credits screen. The start menu has three buttons: "start," "credits," and "exit." The credits screen has a "back" button that returns to the start menu. Referencing the UI tutorial, I wrote two scripts, one for managing the menu, buttons, and activating and deactivating panels, and the other for loading in the game scene when the "play" button is pressed. It took me probably too long to realize that it wasn't working because I didn't have an EventSystem gameObject in place, but I figured it out.

![alt text](https://66.media.tumblr.com/24a4a06b5bed2ad56ac86342e9a89e64/e0c957975c98bcc5-40/s540x810/f6e39558df5646d7ada61ad0f8d4864da870ce73.jpg "Start Menu Screenshot")

![alt text](https://66.media.tumblr.com/6d6ef7974bcfde87b4b75a56c6a4087e/e0c957975c98bcc5-58/s540x810/2835d010ea23fcc2049357abc6d6b48e37d446c8.jpg "Credits Screenshot")


