# GitHub Copilot Instructions for RimWorld Modding Project - "Royal Thrumbos"

## Mod Overview and Purpose

The "Royal Thrumbos" mod aims to introduce a new game experience by adding Royal Thrumbos, a majestic and rare creature, to the RimWorld universe. These creatures add a layer of strategic depth to the game by offering unique interactions, challenges, and rewards for players who encounter them.

## Key Features and Systems

- **Royal Thrumbo Incident**: A new world event where rare Royal Thrumbos may pass through the player's map. This event is handled by the `IncidentWorker_RoyalThrumboPass` class.
- **Custom Thrumbo Definition**: The Royal Thrumbo is defined with specific characteristics through `PawnKindDef_RoyalThrumbo` and `ThingDef_RoyalThrumbo` classes, ensuring they have unique behaviors and stats compared to regular thrumbos.
- **Butchering Products**: Custom logic for butcher products is implemented in `Pawn_ButcherProducts` to ensure players receive advantageous rewards from Royal Thrumbos.

## Coding Patterns and Conventions

- **Static Classes Usage**: Several components, such as `Main`, `Pawn_ButcherProducts`, `PawnKindDef_RoyalThrumbo`, and `ThingDef_RoyalThrumbo`, are implemented using static classes to streamline data access and manipulation, minimizing instantiation overhead.
- **Naming Conventions**: Classes and methods follow PascalCase naming, ensuring readability and consistency throughout the codebase.
- **Embedded Documentation**: It's encouraged to include XML documentation comments for methods explaining their purpose and usage.

## XML Integration

XML files in RimWorld mods are commonly used for defining game objects, events, and attributes. This project should leverage XML for defining the basic blueprint of the Royal Thrumbo, detailing parameters such as health, speed, and other attributes directly within the `Defs` folder.

### Suggestions for XML Integration:
- Define Royal Thrumbo properties, behaviors, and event triggers in XML.
- Link XML-defined Thrumbos with C# logic for dynamic behavior implementation.

## Harmony Patching

Harmony is used to patch existing game functions, allowing the mod to alter or extend functionality without directly modifying game code.

- **Incident Initialization**: Use Harmony to patch base incident functions to include Royal Thrumbos.
- **Custom Logic Injection**: Implement unique game logic where Royal Thrumbos interact with standard game events or objects.

### Example:
csharp
var harmony = new Harmony("com.example.RoyalThrumbos");
harmony.Patch(
    original: AccessTools.Method(typeof(SomeExistingClass), "SomeMethod"),
    postfix: new HarmonyMethod(typeof(MyPatchClass), nameof(MyPatchMethod))
);


## Suggestions for Copilot

- **General Suggestions**: Implement method stubs for new feature ideas or utility functions that could enhance the Royal Thrumbo experience.
- **Debugging Enhancements**: Generate additional logging code to help identify and resolve unexpected behaviors.
- **Unit Test Scaffolding**: Automatically create basic testing structure for critical logic, especially concerning event handling and Royal Thrumbo behavior.
- **Efficiency Improvement**: Suggest code optimizations or alternative approaches for performance-critical sections, particularly in large-scale maps or with numerous Royal Thrumbos.

This instruction file aims to ensure a coherent development process, guiding the integration of advanced features and maintaining clean, well-documented code. Happy modding!

--- 

This detailed file should help anyone new to the project understand its structure and how to effectively contribute to its development.
