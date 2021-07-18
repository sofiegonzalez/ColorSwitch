# ColorSwitch
Final Project for Game Development-CMSC425 at UMD

### Concept: 
The concept of our game is a first person puzzle game where the player needs to use a gun to change the color of objects and how the player interacts with the scene to find the exit. It fits into the escape room genre. The changing of an object’s color affects the way that the physics of the player will interact with the object.  Each room contains a puzzle that progresses into the next. Puzzles will include different types of mechanics, such as changing the color of objects, being able to stand on platforms based on the color setting the user’s gun is on, and solving puzzles to complete each room. 

### Artistic Elements: 
Our game uses a strict color palette because color is a main component to solving each puzzle. There are three main colors (red, blue, and green), but the environment is always the same white, grey or black material. This is done to accentuate the objects with color. We designed all 3D objects ourselves by using Blender, except for the player’s gun. We made sure the models work well together and the user is able to tell which objects can be altered by the gun and which cannot. We made sure to include player movement sounds, shooting sounds, and clicking sounds while the player is swapping colors to ensure there was feedback for each action.

### Algorithmic complexity:
The main algorithms we wrote were to 
Change the color of a crate if the player shoots at it
Mark a puzzle is solved if a crate on a platform is the same color
Allow the player to stand on a colored surface if their gun is set to that color, or fall through otherwise
Ability to pick up and move blocks
We also used a series of continuous rolling spheres to create obstacles and coroutines to smoothly open doors.
  
### Visual complexity: 
We used coroutines to create continuous, smooth movement in many of our objects. There are not a large amount of animations but care was taken to ensure that they are all consistent with each other and fit the style of the game. For example, opening doors and rolling spheres. Each room has its own lighting to light the scene and consistent color design so each level looks like they are in the same world. 

### Completeness:
The game has four levels and feels complete. The game starts with an introductory level, introducing the movement mechanics, how to use the player gun, and how to solve a simple level. After this point there is no more help from the game, and the user must experiment with the given information to solve the puzzles which get increasingly more difficult with the given mechanics/rules. Once the user finishes the fourth and final level they are informed they have escaped and have an option to start over or exit. The user controls are very typical, instructing the user to use their mouse to aim/shoot and WASD to move around the space. 

### Intangibles: 
Each level in our game includes a new rule the user must follow so they can properly interact with the objects and solve each puzzle. We made sure each rule can only be understood by the player’s experimentation within each level. Once the rule is discovered, they need to use the new information and all other rules previously found to solve the level. We did this to ensure the user would be engaged with each level while making the game challenging to solve because the rules are not readily apparent. 
The first level shows the player how to change the color of a crate with their gun. It also demonstrates that a crate must be the same color as a specific platform it rests on to solve the puzzle.
The next level teaches the player that their gun must be set to the same color of a block if they wish to stand on it. If this is not so, they fall through. This mechanic is taught through trial and error as the player must jump from multiple blocks while changing their gun color to reach a static color platform.
The third level demonstrates that objects follow the same rule as the player. If a crate is the same color of a platform, it will rest on it, else it will fall through. This is demonstrated through a sphere that must be color changed to reach a platform at the end of multiple ramps.
Finally the last level teaches how to pick up blocks and use them to trigger specific platforms at another area of the level. Each level combines all the rules of the previous levels while adding a new rule or mechanic, keeping the player engaged.

