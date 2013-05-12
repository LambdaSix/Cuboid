Cuboid
======

Cuboid API.

All of the interfaces for CuboidEngine live here, there are one or two concrete classes that will eventually
migrate to the engine itself, maybe.

This will eventually (hopefully?) be the glue for building mods onto Cuboid.

Mods
======

The general idea is that CuboidEngine provides everything needed to run and render a Cuboid world, a 'mod'
is a front end on the engine, front ends can define their own additional behaviour on top of the default game rules.
Or just override chunks of the engine by replacing the appropriate bits with new API.

Server API coming Real Soon (As soon as I sit down and think about it)
