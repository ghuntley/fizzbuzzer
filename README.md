![](http://i.imgur.com/K6g50oI.png)
# FizzBuzzer [![Build status](https://ci.appveyor.com/api/projects/status/mon5gf244d32abg6?svg=true)](https://ci.appveyor.com/project/ghuntley/fizzbuzzer)


    After a fair bit of trial and error I've discovered that people who struggle
    to code don't just struggle on big problems, or even smallish problems (i.e.
    write a implementation of a linked list). They struggle with tiny problems.

    So I set out to develop questions that can identify this kind of developer and
    came up with a class of questions I call "FizzBuzz Questions" named after a
    game children often play (or are made to play) in schools in the UK. An
    example of a Fizz-Buzz question is the following:

    Write a program that prints the numbers from 1 to 100. But for multiples of
    three print "Fizz" instead of the number and for the multiples of five print
    "Buzz". For numbers which are multiples of both three and five print
    "FizzBuzz".

    Most good programmers should be able to write out on paper a program which
    does this in a under a couple of minutes. Want to know something scary? The
    majority of comp sci graduates can't. I've also seen self-proclaimed senior
    programmers take more than 10-15 minutes to write a solution.

http://blog.codinghorror.com/why-cant-programmers-program/

# Supported Platforms

* .NET 4.5 (We are a Profile78 Portable Class Library)
* Mono
* Xamarin.iOS
* Xamarin.Android
* Xamarin.Mac

# Installation
Installation is done via NuGet:

	Install-Package FizzBuzzer

# Usage

	var bottle = new FizzBuzzer() { MinValue = 1, MaxValue = 100 };       // [Min|Max]Value is optional, defaults to 1 and 100.
    IEnumerable<string> bubbles = bottle.ShakeIt();
    [ommitted ;-)]

## With thanks to
* The icon "<a href="http://thenounproject.com/term/can/52115/" target="_blank">Can</a>" designed by <a href="http://thenounproject.com/ArtZ91/" target="_blank">Arthur Shlain</a> from The Noun Project.
