# Journal Program

**Generated on 2025-05-14**

This C# console application helps users keep a simple daily journal by giving a random prompt, saving entries with a date, displaying all entries, and loading/saving to text files.

## Core Features
- Write a new entry with a random prompt
- Display all journal entries
- Save the current journal to a chosen file (pipe‐delimited)
- Load a journal from a chosen file, replacing the in-memory list
- Simple console menu loop

## Classes
| Class | Responsibility |
|-------|----------------|
| `Program` | UI/menu director |
| `Journal` | Holds a list of `Entry` objects |
| `Entry` | Stores date, prompt, and response + (de)serialization helpers |
| `PromptGenerator` | Supplies random prompts |
| `FileManager` | Handles all file I/O |

## Exceeding Requirements
Add your extra-credit work below and mention it in your I‑Learn submission comments.

---
