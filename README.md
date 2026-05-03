# AR Tower Game

AR Tower Game is an AR tutorial project for the course "3D Technologies & Virtual Reality" in TU-Sofia.

## Disclaimer

The project is done after following [this tutorial](https://www.youtube.com/watch?v=XZPNRxMvelc) with some added functionalities.

## Functionalities

### Plane Detection

Using AR Foundation, the plane (floor, table, etc.) is detected and objects can be placed.

### AR Magic Bar

At the bottom of the screen there is a bar which allows the player to put 4 different types of 3D objects - cube, plank, plane and roof.
Each object has its own wooden (simulated with color) material assigned to it.

### Gameplay Buttons

At the top of the screen there are 4 buttons (2 during setup & 2 during gameplay).

During set up the buttons are "Start" and "Clear":
- "Start" button starts the game by activating physics for all 3D objects and allowing the player to shoot and the placed objects.
- "Clear" button deletes all placed 3D objects using tags.

During gameplay the buttons are "Shoot" and "Reset":
- "Shoot" button shoots balls and the 3D objects with the aim to push them over.
- "Reset" button resets all placed 3D objects to their original positions.

## Implementation

### Materials

4 wooden materials, differentiated only by their color

### 3D Objects

Wooden cube, wooden plank, wooden plane, wooden roof, sphere.

### Scripts

1. `UIButtonHandler.cs` - Assigned to an empty `GameLogic` object in the scene.
Creates a `[SerializeField]` for each of the 4 buttons and 4 actions for when the buttons are pressed.
Handles which buttons are visible / hidden during game setup and gameplay.
2. `EnablePhysicsOnEvent.cs` - Assigned to each 3D object. Subscribes to the "Start" button and enables gravity once the game is started using `Rigidbody`.
3. `HideBarOnStart.cs` - Assigned to an empty `GameLogic` object in the scene.
Subscribes to the "Start" & "Reset" buttons and hides / shows the bar for placing 3D objects.
4. `ResetRbPositionOfObject.cs` - Assigned to each 3D object.
Once a 3D object is created, this script saves the initial position and rotation of the object.
Subscribes to the "Reset" button and once it is pressed it does the following things - disables gravity, resets object's position and rotation, sets object's velocity to 0.
5. `ShootBallLogic.cs` - Assigned to an empty `GameLogic` object in the scene.
Subscribes to the "Shoot" button. Once it is pressed, it creates a new sphere, using the position of the camera.
The ball is placed a bit in front of the camera like it is shooting it. The sphere receives a forward force, which creates the shooting animation.
A 5-second timer is added, which destroys the ball, so that the balls don't clutter the game.
6. `ClearObjects.cs` - Assigned to an empty `GameLogic` object in the scene.
Subscribes to the "Clear" button. Once it is pressed, it finds all objects of type "Destroyable" and deletes them.
This tag is set to all wooden objects and is given to all clones when they are initially placed.

### Demo

[<video src="demo.mp4" width="320" height="640" controls></video>](https://github.com/ogi02/AR-Game/blob/c7e23660f30bc83594adc3aa8cbcb49d2ad83532/demo.mp4)

### Author

Ognian Baruh | 471221021\
Informatics and Software Sciences | Technical University - Sofia
