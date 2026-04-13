# Game Time — Design Document

> Package: `com.eughc.gametime`
> Plane project: PACKS — module: eughcgametime
> Namespace: `Eughc.GameTime`

## Overview

A tick-based game time abstraction. Systems that operate on game-world time (plant growth, day/night cycles, buff durations, cooldowns) subscribe to `TickSystem.OnTick` rather than Unity's `Update`.

## Contents

- **TickSystem** — singleton MonoBehaviour; configurable tick interval; `CurrentTickNum` for age/duration calculations

## Design Notes

- DayNight dependency on ticks is optional — it subscribes if a TickSystem is present
- Tick rate is serialized on the component for per-scene tuning
