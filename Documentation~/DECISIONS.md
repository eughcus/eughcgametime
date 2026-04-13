# Game Time — Decision Log

## Extracted from LemonadeStand as a standalone package

TickSystem was duplicated across projects with minor divergence. The LemonadeStand version was kept as it exposes `CurrentTickNum`, required by systems that calculate durations (e.g. plant age).
