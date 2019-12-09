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

It won't win any awards, but it'll get the job done for now. My biggest issue with it is that one line of the credits is difficult to read. I logged an issue and I'd love to illustrate a credits screen for it, but that can't be my priority right now. I'd also like to include an instructions screen, ideally also illustrated, that I can put in its own panel with an accompanying button. Again, I have to focus on actual integral game functions before I get carried away with quality-of-life things.

Speaking of quality-of-life, I added background music to both the menu and the game scenes. Both songs are free use from the YouTube Audio Library. The menu song is "The Curious Kitten" by Aaron Kenny, and the game song is "Brain Trust" by Wayne Jones. I like them a lot, and they add a lot of charm to the game.

## 11-4-2019 - Final build due and playtesting
- - - -
After implementing sound effects and some final quality-of-life changes, it was time for me to build. The night before the final submit was due, I sat down to build at around 8pm and... couldn't. I was faced with a wall of errors with long strings of characters that was difficult to parse. I spent the next three hours frantically Googling and sifting through StackOverflow pages for answers. I was able to solve a couple of them fairly simply, but one stayed firmly at the top of my console. Everybody I found with the same error found easy fixes, none of which worked for me. With half an hour left to submit and nothing left to try, I zipped an older, less complete build and submitted it with a note about the trouble I was having. 

The next morning I arrived at class early and sat down with my teacher to try to figure out what was going on. I rebooted Unity and made sure everything looked alright before going into my build settings again, and hit build to bring up the error. To my surprise, it didn't pop up and a build progress bar started filling up! I was dumbstruck, and stared at it for a couple seconds before I could form a thought. My error fixed itself, and I had a build after all. I submitted it to the assignment online, and I was ready for playtesting with my classmates by the time class started.

Playtesting time was split in half; half of the class speed-dated through the other half's games, and then we switched. I watched people play my game first. It was difficult sticking to the rule of not commenting or giving advice as they played, seeing as my game didn't have a complete arc. Most players did initially aim for the plates that spawned around the table, but once they realized the game wasn't responding, they branched out in their behavior and started aiming for different things in the environment.

## 11-11-2019 - Deciding to continue working on the project
- - - - 


## 11-18-2019 - Amending my design doc, and not much else
- - - - 


## 11-25-2019 - Adding colliders and physics to environment objects
- - - -
This week I spent my time adding colliders and rigibodies to the environment objects I want players to interact with. Most of them are acting the way I want, but I'm probably going to be tweaking the values of their physic materials to make them more fun to knock over. I'm also going to need to add my collision detector script to everything I want to generate points, which will probably take a while and be a pain to get working the way I want.

I still need to decide about certain objects. Do I want the fridge and oven doors to open when they're hit? How hard would it be to animate that? I don't have much experience animating in Unity, but I've done it a couple of times and moving a 3D object on a hinge shouldn't be prohibitively difficult. I think it'll be one of those things I'll move to the backburner, and we'll see how burned out I am when I finish what's at the top of my list.

## 12-2-2019 - Singletons and more environments
- - - - 
My teacher recommended a video tutorial by a nice Polish man on singletons, and I watched it eagerly. It really helped me wrap my mind around the concept, anad explained to me clearly how to implement it. I created two singletons: a scene loader and a points manager. After a little tweaking they both work perfectly, and I'm immensely happy to have learned a new concept so quickly and easily. 

Next up, constructing the tutorial level. I already built the floor and walls, so I quickly populated the space with decor and gave the objects colliders and rigidbodies. I transferred the player singleton and reordered my build settings, and then wrote a script attached to the door to load the kitchen scene when it collides with toast. 

I also added a new panel to the game UI as an end state. It activates when the timer runs out. After a game-breaking error that refused to let me return to the menu scene, I decided to just give it an "end" button as a placeholder until I can figure it out. Now, the game has a complete loop and is playable from start to finish. 

## 12-9-2019 - Final build and next steps
