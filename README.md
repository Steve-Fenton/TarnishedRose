# TarnishedRose

Gilded rose exercise based on a scenario defined by @NotMyself.

There are branches for different starting points, each one provides a different area of practise.

1. master - this is the version with no tests. In the words of Allister, we _start from scratch_.
2. characterised - there are characterising tests, but no other improvements.

## Exercises

Using the master branch, treat the whole application as a legacy code base that needs a new feature added.

You can follow this process if you like:

1. Add characterising tests
2. Refactor the legacy code
3. Add the new feature using test-first development

You can use BDD, TDD, or whatever other flavour of testing you like. You can even try it without tests (once you think you're done, head to the characterised branch and grab the tests to see if your code passes!)

### The Short Version

Start with the characterised branch to get straight into the refactoring part of the exercise. Maybe try out some of the ideas from 99 Bottles of OOP!

https://www.sandimetz.com/99bottles/

## Requirements

Written by @TerryHughes and @NotMyself

Hi and welcome to team Gilded Rose. As you know, we are a small inn with a prime location in a prominent city ran by a friendly innkeeper named Allison. We also buy and sell only the finest goods. Unfortunately, our goods are constantly degrading in quality as they approach their sell by date. We have a system in place that updates our inventory for us. It was developed by a no-nonsense type named Leeroy, who has moved on to new adventures. Your task is to add the new feature to our system so that we can begin selling a new category of items. First an introduction to our system:

 - All items have a SellIn value which denotes the number of days we have to sell the item
 - All items have a Quality value which denotes how valuable the item is
 - At the end of each day our system lowers both values for every item

Pretty simple, right? Well this is where it gets interesting:

 - Once the sell by date has passed, Quality degrades twice as fast
 - The Quality of an item is never negative
 - "Aged Brie" actually increases in Quality the older it gets
 - The Quality of an item is never more than 50
 - "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
 - "Backstage passes", like aged brie, increases in Quality as it's SellIn value approaches; Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but Quality drops to 0 after the concert

We have recently signed a supplier of conjured items. This requires an update to our system:

 - "Conjured" items degrade in Quality twice as fast as normal items

Feel free to make any changes to the UpdateQuality method and add any new code as long as everything still works correctly. However, do not alter the Item class or Items property as those belong to the goblin in the corner who will insta-rage and one-shot you as he doesn't believe in shared code ownership (you can make the UpdateQuality method and Items property static if you like, we'll cover for you).

Just for clarification, an item can never have its Quality increase above 50, however "Sulfuras" is a legendary item and as such its Quality is 80 and it never alters.