# HW4
## Devlog
Write your Devlog here!

1. In this project, I applied the Model-View-Controller (MVC) to keep the gameplay logic separated from UI and Audio systems. The player.cs scripts functions as a controller. It handles input, physics, flapping, collisions, and determines when the player earns a point. Instead of directly updating the UI or triggering sounds, the player raises events such as OnScore, allowing it to focus solely on controlling the game state. This prevents the Player of becoming tightly coupled to other game systems and the its responisibilities clear and contained.

2. The ScoreManager.cs and AudioManager.cs scripts represent the view center, reacting to the players event rather than controlling gameplay. Both classes subscribe to player.Onscore in their OnEnable() methods, with ScoreManager updating the on‑screen score and AudioManager playing the scoring sound. ScoreManager also uses a Singleton (public static ScoreManager Instance) to ensure a single, globally accessible UI manager without requiring direct references from the player. By combing these events with the singleton pattern, the view and controller remain fully decoupled. The player never calls UI or audio methods directly, and the view layers update itself automatically in response to gameplay events. 

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
