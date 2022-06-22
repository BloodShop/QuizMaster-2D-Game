# QuizMaster-2D-Game

# Concept
1. Quiz game
2. Answer a set number of multiple choice questions
3. Limited time to answer each question
4. UI focused gameplay

# Game Mechanics
1. Mechanism to store and retrieve questions
2. Buttons to select an answers
3. Timer to put some pressure on the player
4. Progress bar to show how many questions remain
5. Scoring to show the player how well they did
6. A way to restart the game when the quiz ends

<img width="754" alt="img1" src="https://user-images.githubusercontent.com/23366804/175075438-fb6783ec-6a9d-463f-b5fe-1653018efdcc.png">

# Game Design
1. Player Experience: Knowledgeable / Intelligent
2. Core Mechanic: Test your knowledge
3. Game Loop: Answer a set number questions on a topic within the given time

# UI Canvas
1. UI = User Interface
2. Text, buttons, sliders, menus, etc.
3. UI elements live on the “Canvas”
4. The canvas generally exists in “Screen Space” and is mostly separate from the game world
5. You can have multiple canvases

# What is a Scriptable Object?
1. It’s just a data container!
2. Keeps the data out of our scripts
3. Help us save memory by storing data in one place
4. They don’t need to be attached to game objects
5. They’re lightweight and convenient
6. Act as a template for consistency
*Examples*
  - Weapon stats in an RPG
  - Card data in a CCG

  - using them to store question data
    1. Question text
    2. Possible answers
    3. Correct answer

<img width="754" alt="img2" src="https://user-images.githubusercontent.com/23366804/175075443-085803c0-7689-4558-a1ff-56701d249e72.png">

# Getter Methods
1. Gives a script read-only access to a private variable
2. Protects the contents of a private variable

# What is a Loop?
1. Repeat an event until some condition is met
2. Very powerful for counting or iterating
3. One type of loop is called a ‘For Loop’
4. Loop a set number of times
  *inside the for loop*
  1. int i = 0 
      1. Runs once before the code block is executed
      2. Sets up the iterator
  2. i < n 
      1. Defines the loop condition
      2. Tells the loop when to stop
      3. Be careful of infinite loops!
  3. i++ 
      1. Executes at the end of every loop
      2. Used to increment or decrement the iterator

# Game Flow
  1. Display New Question
  2. Turn buttons on
  3. Answer Question
  4. Turn buttons off
*and repeat*

# Timer
What state is the game in?
  - answering question or showing answer

Has the timer run down?

Change the fill amount of the timer image
When time runs out, change the state of the game

<img width="754" alt="img3" src="https://user-images.githubusercontent.com/23366804/175075446-f54aff97-d3ef-4bed-a009-22bf31b8473b.png">

# What is a List?
- They’re kind of like arrays!
*definition*
  A grouping of multiple variables of the same type
  Each item stored in an List is called an ‘element’
  Each element can be accessed by its index number
  Counting starts at zero!

- They’re mutable - meaning we can change their size!

Syntax --> List<int> oddNumbers = new List<int>()

Useful Methods & Properties
    1. Check item count: 			  List.Count
    2. Check if item exists:		List.Contains(3)
    3. Add an item:							List.Add(3)
    4. Remove an item:					List.Remove(3)
    5. Remove item at index:	  List.RemoveAt(0)
    6. Clear the list:				  List.Clear()
