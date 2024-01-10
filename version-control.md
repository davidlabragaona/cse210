# Version Control System

## Description

A Version Control System (VCS) is a peace of software designed to provide change-tracking and audit capabilities for projects. Individuals and teams can coordinate their work in a more organized way. When used properly, version control systems will increase productivity and minimize downtime. At the same time, if errors are introduced, it is possible to go back in time to a working version.


## Benefits

Let's imagine that we have a team of 3 working on a Math library for a software project. The project needs to have three new functions: Sine, Cosine and Tangent. The implementation of the library is found in math.c. If no VCS is used, developer A will start editing the file. Developers B and C will not be able to edit the file until developer A has finished. Moreover, Developer B and C could start working on a local version of the file, but this will include manual control and edition of the file to preserve the changes. What if experimental versions were tested? Files like *math1.c*, *math-exp.c*, *math-cosine.c* and *math-tg.c* could exist on the same directory causing some confusion. Luckily, VCS offer some benefits.

### Branching

It is possible to work on different versions by branching off the main version. By doing so, we preserve the latest working version, while we safely introduce changes. And this is encouraged. Branching does not have a performance cost (specially on git). Developers A, B and C can work on the same file: *math.c* but on different branches. They can work in parallel as well. Developer C could work on the definition of the Tangent function by placing references to Sine and Cosine without even having those functions defined yet.

### Merging

Once their work is done, they can **merge** the changes. Merging means that branches are combined preserving the changes that each developer added. Generally, merging is done automatically (based on some rules). In some situations the VCS will warn that there might be a conflict when automatically merging. A developer or team leader will resolve the conflict by manually selecting what would be the resulting change.
