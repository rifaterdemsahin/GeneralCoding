# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a self-learning project template focused on General Coding (C#, C++, Hack, PHP) that follows a structured 7-folder methodology based on Lacan's triad concepts. The project is designed to help developers fill skill gaps through systematic self-learning while leveraging AI tools like Claude Code and GitHub Copilot.

## Architecture & Folder Structure

The repository follows a 7-folder structure representing different phases of learning and development:

- **1_🌍_Real**: Objectives and Key Results - Contains goal-setting and measurable objectives
- **2_✈️_Journey**: Visual learning progression - Step-by-step guides and documentation of the learning process
- **3_🌳_Environments**: Roadmaps and use cases - Environment configurations and deployment scenarios  
- **4_🌌_Imaginary**: Knowledge capture - Screenshots, concepts, and theoretical learning materials
- **5_📐_Formulas**: Reference guides - Essential formulas and methodologies
- **6_🔣_Symbols**: Code implementation - Executable code, scripts, and practical examples
- **7_🌀_Semblance**: Error tracking - Documentation of issues, debugging, and solutions

## Common Commands

### Setup and Initialization
```bash
# Create the complete folder structure
chmod +x ./6_🔣_Symbols/1_Init/create_folders.sh
./6_🔣_Symbols/1_Init/create_folders.sh

# Create specific objective files
chmod +x ./6_🔣_Symbols/1_Init/create_real_files.sh
./6_🔣_Symbols/1_Init/create_real_files.sh

# Create journey documentation files
chmod +x ./6_🔣_Symbols/1_Init/create_journey_files.sh
./6_🔣_Symbols/1_Init/create_journey_files.sh

# Create environment configuration files
chmod +x ./6_🔣_Symbols/1_Init/create_environment_files.sh
./6_🔣_Symbols/1_Init/create_environment_files.sh
```

## Development Workflow

1. **Start with Objectives (1_🌍_Real)**: Define clear, measurable goals using OKR methodology
2. **Document Journey (2_✈️_Journey)**: Track learning steps, commands, todos, and prompts
3. **Set Up Environments (3_🌳_Environments)**: Configure development and runtime environments
4. **Capture Learning (4_🌌_Imaginary)**: Document concepts, screenshots, and theoretical knowledge
5. **Reference Guides (5_📐_Formulas)**: Maintain essential formulas and methodologies
6. **Implement Code (6_🔣_Symbols)**: Write executable code and practical examples
7. **Track Errors (7_🌀_Semblance)**: Document issues, debugging processes, and solutions

## Key Files and Their Purposes

- `README.md`: Main project documentation with folder structure explanation
- `2_✈️_Journey/2.2.1_commands.md`: Command documentation for the project
- `2_✈️_Journey/2.4.1_todos.md`: Project todo tracking
- `2_✈️_Journey/2.6.1_prompts.md`: AI prompt examples and templates
- `2_✈️_Journey/2.7.1_files.md`: File management documentation
- `6_🔣_Symbols/1_Init/*.sh`: Initialization scripts for project setup

## Documentation Standards

- Use emojis for visual organization and section identification
- Follow markdown formatting with clear headings and structure
- Track completion status using [+] for completed and [-] for pending items
- Maintain concise single-line comments for clarity
- Eliminate redundant information across files

## AI Tool Integration

This project is specifically designed to work with:
- **Claude Code**: For code generation, debugging, and documentation
- **GitHub Copilot**: For code completion and suggestions

When working on this project, leverage the structured folder approach to maintain organization and track progress systematically through each learning phase.