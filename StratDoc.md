# StakeBuddy

StakeBuddy is a bot for stake.us that supports custom strategies in C#. This repository contains the codebase for the bot and its functionalities.

## Table of Contents

- [Strategy Overview](#Strategy-overview)
- [Functions](#functions)
  - [DesignedForStakeOriginal](#DesignedForStakeOriginal)
  - [Name](#Name)
  - [Init](#Init)
  - [Tick](#Tick)
  - [GetMainBetAmount](#GetMainBetAmount)

## Strategy Overview

### Strategy

`Strategy` provides several functions that allow for the manipulation and analysis of data related to stake.us strategies.

## Functions

### DesignedForStakeOriginal

#### `public virtual StakeOriginalGame DesignedForStakeOriginal`

Set the game type for the strategy. 

```csharp
public virtual StakeOriginalGame DesignedForStakeOriginal
{
    get;
    set;
}
```
### Name

#### `public virtual string Name`

Set the name for the strategy. 

```csharp
public virtual string Name
{
    get;
    set;
}
```

### Init

#### `public virtual void Init()`

This function performs the initial setup for the strategy. 

```csharp
public virtual void Init()
{
    // Implementation code
}
```
### Tick

#### `public virtual void Tick()`

This function ticks every update of thread.

```csharp
public virtual void Tick()
{
    // Implementation code
}
```
### GetMainBetAmount

#### `public virtual double GetMainBetAmount()`

This function returns the current amount in the main bet box. 

```csharp
public virtual double GetMainBetAmount()
{
    // Implementation code
}
```
