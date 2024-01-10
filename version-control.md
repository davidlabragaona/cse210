# Version Control System

## Description

A Version Control System (VCS) is a piece of software designed to provide change-tracking and audit capabilities for projects. Individuals and teams can coordinate their work in a more organized way. When used properly, version control systems will increase productivity and minimize downtime. At the same time, if errors are introduced, it is possible to go back in time to a working version.


## Benefits

Let's imagine that we have a team of 3 working on a Math library for a software project. The project needs to have three new functions: Sine, Cosine and Tangent. The implementation of the library is found in math.c. If no VCS is used, developer A will start editing the file. Developers B and C will not be able to edit the file until developer A has finished. Moreover, Developer B and C could start working on a local version of the file, but this will include manual control and edition of the file to preserve the changes. What if experimental versions were tested? Files like *math1.c*, *math-exp.c*, *math-cosine.c* and *math-tg.c* could exist on the same directory causing some confusion. Luckily, VCS offer some benefits.

### Branching

It is possible to work on different versions by branching off the main version. By doing so, we preserve the latest working version, while we safely introduce changes. And this is encouraged. Branching does not have a performance cost (specially on git). Developers A, B and C can work on the same file: *math.c* but on different branches. They can work in parallel as well. Developer C could work on the definition of the Tangent function by placing references to Sine and Cosine without even having those functions defined yet.

### Merging

Once their work is done, they can **merge** the changes. Merging means that branches are combined preserving the changes that each developer added. Generally, merging is done automatically (based on some rules). In some situations the VCS will warn that there might be a conflict when automatically merging. A developer or team leader will resolve the conflict by manually selecting what would be the resulting change.


## Command usage

For this example we are working with the *version-control.md* file.

We created the file, and after the first paragraph was typed, we executed the `git status` command. This command is useful if you don't know or forgot if you have pending changes to be commited. The result is this:

> Untracked files:
>  (use "git add <file>..." to include in what will be committed)
>        version-control.md
> 
> nothing added to commit but untracked files present (use "git add" to track)

We now add the file (start tracking) by using the `git add version-control.md` command. We execute the `git status` command:

> On branch main
> Your branch is up to date with 'origin/main'.
> 
> Changes to be committed:
>   (use "git restore --staged <file>..." to unstage)
>         new file:   version-control.md
> 

We then commit our changes by using the `git commit -m "Version control meaning"` command. We get this:

> [main 159f633] Version control meaning
>  1 file changed, 6 insertions(+)
>  create mode 100644 version-control.md

We can now push (upload our changes) to the remote repository. By using the `git log` we can see the changes:

> commit 7372db595d761f0cf4b63a03f38f05bf20ca7c7a (HEAD -> main)
> Author: David Labra Gaona 
> Date:   Wed Jan 10 12:19:04 2024 -0300
> 
>     highlights and application
> 
> commit 159f633ce8b4c787ce2774c191b12b62d02e767c
> Author: David Labra Gaona 
> Date:   Wed Jan 10 11:26:41 2024 -0300
> 
>     Version control meaning
> 
