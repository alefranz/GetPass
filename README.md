# GetPass

[![Build Status](https://alefranz.visualstudio.com/GetPass/_apis/build/status/GetPass?branchName=master)](https://alefranz.visualstudio.com/GetPass/_build/latest?definitionId=1?branchName=master) [![](https://img.shields.io/nuget/v/GetPass.svg)](https://www.nuget.org/packages/GetPass/)

## About GetPass

GetPass is a free, open source, cross-platform library to read passwords in console applications masking the input.
It simply focus on getting the job done, with zero-dependencies and few lines of code.

It is licensed under [MIT License](LICENSE.txt).

If you like this project please don't forget to *star* it on [GitHub](https//github.com/alefranz/GetPass) or let me know with a [tweet](https://twitter.com/AleFranz).

## Quick Start

Install the [GetPass Nuget package](https://www.nuget.org/packages/GetPass/).

```csharp
using GetPass;
```

```csharp
var password = ConsolePasswordReader.Read();
```

or if you want to customize the prompt message:

```csharp
var password = ConsolePasswordReader.Read("Key: ");
```

## Example

```csharp
using System;
using GetPass;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = ConsolePasswordReader.Read();
            Console.Write(password);
            Console.WriteLine();
        }
    }
}
```

You can find the full example [here](samples/Sample).
