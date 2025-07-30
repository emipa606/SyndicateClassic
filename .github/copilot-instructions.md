# GitHub Copilot Instructions for RimWorld Modding Project

## Mod Overview and Purpose

This RimWorld mod introduces a series of innovative and thematic changes to the game, focusing on expanding the interaction between colonists and enhancing gameplay with new items and systems. The key purpose of this mod is to integrate a "syndicate" theme into the game, offering players unique enhancements through implants and novel projectiles, amongst other features.

## Key Features and Systems

- **Syndicate Implants and Hediffs**: The mod introduces special implants that provide colonists with unique abilities and effects. The `Syndicate_Implant_Hediff` class manages these implants using RimWorld's health and hediff systems.
  
- **Novel Projectile Weaponry**: It features custom projectile weapons such as `Projectile_Banana`, which inherits behaviors from the base class `Projectile_Explosive`.

- **Special Recipe Integration**: Recipes for creating and installing syndicate themed items, such as the `Recipe_LoyaltyImplant`, are integrated into the mod, allowing players to craft and install unique items.

## Coding Patterns and Conventions

- **Internal Modifiers**: All classes are marked as `internal`, suggesting that the design intends for use exclusively within the assembly scope. This keeps encapsulation tight and only exposes what's necessary.

- **Inheritance**: Custom functionalities are achieved through inheritance, as seen where `Projectile_Banana` extends `Projectile_Explosive` and `Recipe_LoyaltyImplant` extends `Recipe_InstallImplant`.

- **Consistent Naming Conventions**: Class and method names follow PascalCase convention typical for C#, and commonly used RimWorld names are extended to maintain familiarity (`Hediff`, `Recipe`, `Projectile`).

## XML Integration

Though not explicitly shown in the file summaries, XML definitions in RimWorld mods are crucial for item and recipe implementations:
- Ensure all new items, recipes, and hediffs are correctly defined in XML files. 
- XML files should include defName, label, description, and relevant properties that match the logic defined in C# classes.
- Utilize XML to link in-game objects with classes, especially for defining how recipes should produce or handle specific items.

## Harmony Patching

Consider leveraging Harmony to patch original RimWorld methods without directly modifying the game source code. This is crucial for maintaining compatibility:
- Identify methods in the game's assembly that require alteration or extension.
- Use Harmony to prefix, postfix, or transpile those methods appropriately.
- Ensure patches are clean and maintainable by providing clear documentation on what each patch changes and why.

## Suggestions for Copilot

To get the most out of GitHub Copilot while working on your RimWorld mod:
- **Contextual Helpers**: Start by typing comments that describe what a method should do. This helps Copilot provide accurate code suggestions.
  
- **Pattern Recognition**: Use Copilot's strengths in pattern recognition to identify common patterns in your codebase, especially useful for repetitive XML integration tasks.
  
- **Boilerplate Code**: Leverage Copilot to quickly write boilerplate code needed for new features based on existing patterns seen in the project.

- **Testing Integration**: Encouraging Copilot to suggest test modes or scenarios can be beneficial for testing new features. It is essential for ensuring that mod changes work correctly with RimWorld updates.

By using these guidelines and suggestions, Copilot can effectively assist in developing and refining your RimWorld mod.
