# FoxRunner


### Chapter0 Unity Essentials and Junior Programmer.

When I did everything in CS50x and had to start working on the Project, I came up with the idea to make a game that people could play for free. I know that there are a lot of people who can't pay or don't want to invest the money required into a new game but still wanted to enjoy a game even if only for a few minutes.

To do this, the current knowledge I had of programming wasn't enough. I had to learn how to use a Game engine and its language. I was searching for what are the best engines for beginner game designers that were relatively easy to get into but powerful enough to make anything I could want to make.

I knew that Unreal Engine is very powerful and that many AAA games are made using it, but also it is hard to get into and is recommended for people already familiar with coding in C++ and game engines in general. I started looking and found a few uninteresting and pay-to-use game engines. My brother was over at my house for the weekend and he told me about the Unity Game Engine, how strong of a community it has, and that they do free courses to make it accessible for anyone to start learning. I was amazed by this and instantly started looking up their courses and decided to use Unity as my Game Engine.

I found out that they have multiple free courses. The one I wanted to start with was Unity Essentials, it's a short 2-week course to get a taste of what Unity can do, which I did in under a week. The next course was called Junior Programmer, which was 12 weeks long. It showed in depth how to use the Engine and how to write code using C#. I had to hand in 4 projects along the way and also start on a main one that we came back to at the end of every chapter. It was my baby, which I abandoned. By the time I finished the course there was just so much I learned and saw as an issue in my game and as something that needed to be changed that I scrapped it and started on a fresh game that I would hand in as a Final Project for Harvard.


### Chapter1 Deciding what Kind of Game I want to make.

Deciding was easy, I wanted to make a Platformer game. Something like Mario that I played as a child, but a game that had my touch on it. I wanted to have platforms to jump to, things to collect, and a couple of things to interact with as a Player. I started by looking at the free Asset packs on the Unity Store and found one called SunnyLand, it had a Fox as the main character, a lot of enemies to choose from for my Game, props as in chests doors, and also a beautiful Tile Palette to design my level in. I was set on making my game using it.


### Chapter2 Importing SunnyLand from Unity Asset Store and setting up the Player.

Importing Assets is as simple as finding what you want on the Unity Website and then clicking Import to Unity, if you have the Game Engine Open it brings up the package manager and you can click download and import. There is more setup to do to be able to fully use the Asset pack, but the first steps were done.

To set up the Player I had to add a Sprite Renderer component, which I would add the sprites to from the SunnyLand Asset Package. I also needed to add 2 elements to the Player, 1 to check for ceiling contact for the crouching ability, and another one for a ground check to know if the Character is airborne. I also needed 2 Colliders, a box collider for the head which would switch off when crouching, and a capsule collider for the body which would be always on.

I needed a way to be able to move my Character. I wanted my Character to be able to Run, Jump, and Crouch. Even though in the end I did not make my map to make a need for my Character to crouch. I had to write 2 scripts. One is called CharacterController2D and the other is PlayerMovement. In CharacterController2D I took care of the Physics, to see if he is on the Ground so he can jump or if he is touching a ceiling to know if he can get up from crouching. Also added the speed of jumping and crouching here. In PlayerMovement I added the controls for jump and crouch and the speed that the character moves according to the conditions set up in CharacterController2d.

I needed an Animator component and I had to make all the Animations my Player would need. Starting with the Idle Animation to play whenever the character was not moving. Then onto the Run Animation, the Jump Animation, and the Crouch Animation. Once the Animations were done, I needed the Animator and set up which Animation can lead to what other Animation. The way I have it set up is that when the game loads up the character straight away goes into Idle, if the character's speed is higher than 0.1 then he goes into the Run Animation.


### Chapter3 Setting up Tile maps and making a basic world for my Character to move around in.

As SunnyLand asset was already imported I just had to turn the sliced tile set in as a Tile Palette, set up the Layer for it to be the "Ground" level, add a Tilemap collider 2D component and I could already lay down a basic map for my Character to move around in. At 1st it was very basic, a few platforms to jump up and down on and level ground. I also added 2 Box colliders on each end of the map so the Character doesn't fall off when he reaches the ends.


### Chapter4 Creating my 1st Item, a cherry. Item Interactions and Inventory System.

I created an empty object where I have added a Sprite Renderer, Animator, and Box collider which has the Trigger parameter enabled. I made a UI element for the Inventory System, a place to see the Items the Character has picked up and an examine window for examining Items and interaction.

I started working on 3 scripts.  The InteractionSystem which needed a detection point on the Character was added to the Player object. Would check for what Items the Interaction point is in contact with. It would Handle the Input needed for the Interaction and brings up the examine window.

The InventorySystem would handle opening and closing the Inventory. Show the description of the Item that has been hovered over with the mouse. and would allow the user to consume items in case their Inventory is full and wanted another item instead of it being held.

The Item Script would handle the different types of Interactions with Items, so players could either examine or pick up the different Items in the world.


### Chapter5 Getting Sounds and music from the Unity Store and adding them to the Game.

I looked for sounds and music in the Unity Asset store. I found a pack of 50 sounds that I have imported and 4 soundtracks to choose from. I added sound effects to my jump, item Interactions, and jumping on enemy heads. I also added the soundtrack to the game to be on a constant loop.


### Chapter6 Adding enemies to the Game.

To add an enemy to the game I needed another empty game object with a sprite rendered and an animator. I needed to have 3 colliders, a capsule for the body, a box for the body that would be trigger enabled to handle damaging the player, and another box collider for the head that would handle the player damaging the enemy.

I wrote 2 scripts.  EnemyAI Handles the enemy moving from point to point in the world on a loop and damaging the player. It also adds different elements to enemy objects to streamline the creation of new enemies in the future.

HeadDetect would allow the Player to damage the Enemy, play a sound when attacked, and started the Killed animation which would just show an explosion when played.


### Chapter7 Player Health and Level Restart and Finishing Touches.

For Player health, I needed a UI element on the Canvas that would be constantly shown for the Player to see their Health. Right now the player Health is represented with hearts. When the player is damaged he loses one heart. If the hearts are reduced to Zero the game restarts on its own.

At this stage, all the systems have been worked out that I want to use in the game, and could start working on my map. I made a medium-sized map with 2 separate Biomes and a huge tree in the middle to separate them. I made it big enough to be able to fit different types of enemies on the map and for the player to be able to pick up different types of objects and have a few items to Interact with.

Next, I added the enemies, I added 5 different types of enemies. 2 rabbits, a zombie dog, 2 eagles, 2 slimes, and a huge bear Boss at the very end. You can kill all of them by jumping on their heads and they also all damage the player.

There is a frog at the start which tells you to find the 2 Gems and 4 Cherries on the map. Another frog at the end Thanks to the Player for playing the game.

There is also a chest that if the player interacts with unlocks a hidden gem somewhere in the world and a rock crate that does the same in the other biome.
