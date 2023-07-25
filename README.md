# Gurux Bug Reproduce for reading association view

This project is a simple console application,
that reproduces a bug in https://github.com/Gurux/Gurux.DLMS.Net.
(Reading access3 has incorrect index)

See [Program.cs](Program.cs) for the reproducing.

## Runing this project

Clone this project, than open the solution with Visual Studio.

## The candidate root causes

At [GXDLMSObjectCollection](https://github.com/Gurux/Gurux.DLMS.Net/blob/master/Development/Objects/GXDLMSObjectCollection.cs#L455),
when reading "Access", there are `++pos;` before calling `SetAccess` so the first attribute has index = 1
(following the DLMS specification), but when reading "Access3", following to the current source code,
the first attribute will has index = 0 instead of 1.