# NewBonusAkRepo
# INFR 3110 Make Up Assignment
---
### Name : Ashley Klahm
### Student Number : 100963908
---
# Object Oriented Programming
---
### Description
-Manager scripts inherit from singleton
-Things i need to access like prefabs are public to edit in unity other things are private so they arent in the inspector 

## UML Diagram
<!-- Attach your UML diagram here -->
---
# Singleton Pattern
---
### Purpose
Audio Manager, we only want one dont want multiple of the same audios playing at the same time
Factory Manager don't want same fruits spawning in same location, doubling points etc. would get confusing 
-->
### Implementation
singleton base class that check and destorys if more then 1. Audio and factory manager inherit
---
# Factory Pattern
---
### Purpose
Spawn different fruits in a clean way, makes it able to be used in future easily to add more fruits or have them give bonuses
### Implementation
Apple factory inherits from the abstract factory, apple factory creates apple which apple inherits form the fruit interface and changes it so it spawns apple in place of just fruit prefab 
---
# References
---
CODE FROM https://www.youtube.com/watch?v=0vFucqblH-g for movement
Singleton base is from class
